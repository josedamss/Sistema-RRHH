using AntdUI;
using MySql.Data.MySqlClient;
using SistemaRRHH.DatosSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaRRHH.Formularios
{
    public partial class FrmEmpleados : Form
    {
        private readonly ConexionSQL conexionSQL = new ConexionSQL();
        private readonly Timer temporizadorBusqueda = new Timer();

        // Constantes SVG en una sola línea para no ensuciar visualmente el código
        private const string IconoEditar = "<svg viewBox=\"0 0 24 24\"><path fill=\"#1677ff\" d=\"M3 17.25V21h3.75L17.81 9.94l-3.75-3.75L3 17.25zm17.71-10.04a1.003 1.003 0 0 0 0-1.42l-2.5-2.5a1.003 1.003 0 0 0-1.42 0l-1.96 1.96 3.75 3.75 2.13-1.79z\"/></svg>";
        private const string IconoDesactivar = "<svg viewBox=\"0 0 24 24\"><path fill=\"#ff4d4f\" d=\"M6 19c0 1.1.9 2 2 2h8c1.1 0 2-.9 2-2V7H6v12zM8 9h8v10H8V9zm7.5-5-1-1h-5l-1 1H5v2h14V4z\"/></svg>";
        private const string IconoInformacion = "<svg viewBox=\"0 0 24 24\"><path fill=\"#722ed1\" d=\"M11 18h2v-2h-2v2zm1-16C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm0 18c-4.41 0-8-3.59-8-8s3.59-8 8-8 8 3.59 8 8-3.59 8-8 8zm0-14c-2.21 0-4 1.79-4 4h2c0-1.1.9-2 2-2s2 .9 2 2c0 2-3 1.75-3 5h2c0-2.25 3-2.5 3-5 0-2.21-1.79-4-4-4z\"/></svg>";

        private class EmpleadoFila
        {
            public int ID { get; set; }
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string DNI { get; set; }
            public string RTN { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string Direccion { get; set; }
            public DateTime FechaContratacion { get; set; }
            public decimal Salario { get; set; }
            public string Departamento { get; set; }
            public bool EstaActivo { get; set; }
            public CellTag Estado { get; set; }
            public ICell[] Acciones { get; set; }
        }

        public FrmEmpleados()
        {
            InitializeComponent();
            ConfigurarEventos();
            ConfigurarBusqueda();
        }

        private void ConfigurarEventos()
        {
            Load += FrmEmpleados_Load;
            button1.Click += button1_Click;
            tableempleados.CellButtonClick += Tableempleados_CellButtonClick;
        }

        private void ConfigurarBusqueda()
        {
            temporizadorBusqueda.Interval = 300;
            temporizadorBusqueda.Tick += TemporizadorBusqueda_Tick;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            ActualizarPantalla();
        }

        private void ConfigurarTabla()
        {
            tableempleados.Columns = new ColumnCollection()
            {
                new Column("ID", "ID", ColumnAlign.Center) { Width = "55" },
                new Column("Codigo", "Código") { Width = "110" },
                new Column("Nombre", "Nombre completo"),
                new Column("Departamento", "Departamento"),
                new Column("Estado", "Estado", ColumnAlign.Center) { Width = "110" },
                new Column("Acciones", "Acciones", ColumnAlign.Center) { Width = "170" }
            };
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            temporizadorBusqueda.Stop();
            temporizadorBusqueda.Start();
        }

        private void TemporizadorBusqueda_Tick(object sender, EventArgs e)
        {
            temporizadorBusqueda.Stop();
            CargarEmpleados(txtbuscar.Text.Trim());
        }

        private void CargarEmpleados(string busqueda = "")
        {
            List<EmpleadoFila> empleados = new List<EmpleadoFila>();

            string consulta = @"
                SELECT e.id_empleado, e.codigo_empleado, e.nombre, e.dni, e.rtn, e.telefono, e.correo, 
                       e.direccion, e.fecha_contratacion, e.salario_base, e.estado, 
                       COALESCE(d.nombre, 'Sin departamento') AS departamento
                FROM empleados e
                LEFT JOIN departamentos d ON e.id_depto = d.id_depto
                WHERE @busqueda = '' 
                   OR e.nombre LIKE CONCAT('%', @busqueda, '%')
                   OR e.codigo_empleado LIKE CONCAT('%', @busqueda, '%')
                   OR e.dni LIKE CONCAT('%', @busqueda, '%')
                ORDER BY e.nombre;";

            try
            {
                using (MySqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion.State != ConnectionState.Open) return;

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@busqueda", MySqlDbType.VarChar).Value = busqueda;

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                bool estaActivo = Convert.ToBoolean(lector["estado"]);

                                CellTag etiquetaEstado = estaActivo
                                    ? new CellTag("Activo", TTypeMini.Success)
                                    : new CellTag("Inactivo", TTypeMini.Error);

                                CellButton btnInfo = new CellButton("informacion") { IconSvg = IconoInformacion, Tooltip = "Ver información", Shape = TShape.Circle, IconRatio = 0.75F };
                                CellButton btnEdit = new CellButton("editar") { IconSvg = IconoEditar, Tooltip = "Editar empleado", Shape = TShape.Circle, IconRatio = 0.75F };
                                CellButton btnDesactivar = new CellButton("desactivar") { IconSvg = IconoDesactivar, Tooltip = "Desactivar empleado", Shape = TShape.Circle, IconRatio = 0.75F };

                                empleados.Add(new EmpleadoFila
                                {
                                    ID = Convert.ToInt32(lector["id_empleado"]),
                                    Codigo = lector["codigo_empleado"].ToString(),
                                    Nombre = lector["nombre"].ToString(),
                                    DNI = lector["dni"].ToString(),
                                    RTN = lector["rtn"].ToString(),
                                    Telefono = lector["telefono"].ToString(),
                                    Correo = lector["correo"].ToString(),
                                    Direccion = lector["direccion"].ToString(),
                                    FechaContratacion = Convert.ToDateTime(lector["fecha_contratacion"]),
                                    Salario = Convert.ToDecimal(lector["salario_base"]),
                                    Departamento = lector["departamento"].ToString(),
                                    EstaActivo = estaActivo,
                                    Estado = etiquetaEstado,
                                    Acciones = new ICell[] { btnInfo, btnEdit, btnDesactivar }
                                });
                            }
                        }
                    }
                }
                tableempleados.DataSource = empleados;
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "Error al cargar empleados: " + ex.Message, autoClose: 4);
            }
        }

        private void CargarEstadisticas()
        {
            string consulta = @"
                SELECT COUNT(*) AS total, 
                       COALESCE(SUM(estado = 1), 0) AS activos, 
                       COALESCE(SUM(estado = 0), 0) AS inactivos 
                FROM empleados;";

            try
            {
                using (MySqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion.State != ConnectionState.Open) return;

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            lbtotal.Text = Convert.ToInt32(lector["total"]).ToString();
                            lbactivos.Text = Convert.ToInt32(lector["activos"]).ToString();
                            lbinactivos.Text = Convert.ToInt32(lector["inactivos"]).ToString();
                        }
                    }
                }

                lbtotal.BringToFront();
                lbactivos.BringToFront();
                lbinactivos.BringToFront();
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "Error al cargar contadores: " + ex.Message, autoClose: 4);
            }
        }

        private void Tableempleados_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            EmpleadoFila empleado = e.Record as EmpleadoFila;
            if (empleado == null) return;

            if (e.Btn.Id == "informacion") MostrarInformacionEmpleado(empleado);
            else if (e.Btn.Id == "editar") EditarEmpleado(empleado.ID);
            else if (e.Btn.Id == "desactivar") DesactivarEmpleado(empleado);
        }

        private void MostrarInformacionEmpleado(EmpleadoFila empleado)
        {
            string rtn = string.IsNullOrWhiteSpace(empleado.RTN) ? "No registrado" : empleado.RTN;
            string telefono = string.IsNullOrWhiteSpace(empleado.Telefono) ? "No registrado" : empleado.Telefono;
            string correo = string.IsNullOrWhiteSpace(empleado.Correo) ? "No registrado" : empleado.Correo;
            string direccion = string.IsNullOrWhiteSpace(empleado.Direccion) ? "No registrada" : empleado.Direccion;
            string estado = empleado.EstaActivo ? "Activo" : "Inactivo";
            string fecha = empleado.FechaContratacion.ToString("dd/MM/yyyy");
            string salario = empleado.Salario.ToString("C2", CultureInfo.GetCultureInfo("es-HN"));

            // Interpolación de strings limpia y elegante
            string informacion = $"Código: {empleado.Codigo}\n\n" +
                                 $"Nombre: {empleado.Nombre}\n\n" +
                                 $"DNI: {empleado.DNI}\n\n" +
                                 $"RTN: {rtn}\n\n" +
                                 $"Teléfono: {telefono}\n\n" +
                                 $"Correo: {correo}\n\n" +
                                 $"Dirección: {direccion}\n\n" +
                                 $"Departamento: {empleado.Departamento}\n\n" +
                                 $"Fecha de contratación: {fecha}\n\n" +
                                 $"Salario base: {salario}\n\n" +
                                 $"Estado: {estado}";

            // Para mostrar un bloque grande de texto, el MessageBox clásico sigue siendo la mejor opción
            MessageBox.Show(informacion, "Información del empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditarEmpleado(int idEmpleado)
        {
            using (FrmNuevoEmpleado formulario = new FrmNuevoEmpleado(idEmpleado))
            {
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    ActualizarPantalla();
                }
            }
        }

        private void DesactivarEmpleado(EmpleadoFila empleado)
        {
            if (!empleado.EstaActivo)
            {
                AntdUI.Message.warn(this, "Este empleado ya se encuentra inactivo.", autoClose: 3);
                return;
            }

            DialogResult respuesta = MessageBox.Show($"¿Deseas desactivar a {empleado.Nombre}?", "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes) return;

            string consulta = "UPDATE empleados SET estado = 0 WHERE id_empleado = @idEmpleado;";

            try
            {
                using (MySqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion.State != ConnectionState.Open) return;

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@idEmpleado", MySqlDbType.Int32).Value = empleado.ID;

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            AntdUI.Message.success(this, "Empleado desactivado correctamente.", autoClose: 3);
                            ActualizarPantalla();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "No se pudo desactivar: " + ex.Message, autoClose: 4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FrmNuevoEmpleado formulario = new FrmNuevoEmpleado())
            {
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    ActualizarPantalla();
                }
            }
        }

        private void ActualizarPantalla()
        {
            CargarEmpleados(txtbuscar.Text.Trim());
            CargarEstadisticas();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            temporizadorBusqueda.Stop();
            temporizadorBusqueda.Dispose();
            base.OnFormClosed(e);
        }

        private void tableempleados_CellClick(object sender, TableClickEventArgs e)
        {
            // Método vacío por si lo necesitas a futuro
        }
    }
}
using MySql.Data.MySqlClient;
using SistemaRRHH.DatosSQL;
using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaRRHH.Formularios
{
    public partial class FrmNuevoEmpleado : Form
    {
        private readonly ConexionSQL conexionSQL = new ConexionSQL();
        private int? idEmpleadoEditar;

        private class DepartamentoItem
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public override string ToString() { return Nombre; }
        }

        private class EstadoItem
        {
            public int Valor { get; set; }
            public string Nombre { get; set; }
            public override string ToString() { return Nombre; }
        }

        public FrmNuevoEmpleado()
        {
            InitializeComponent();
            idEmpleadoEditar = null;
            ConfigurarFormulario();
        }

        public FrmNuevoEmpleado(int idEmpleado)
        {
            InitializeComponent();
            idEmpleadoEditar = idEmpleado;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            txtcodigo.MaxLength = 20;
            txtnombre.MaxLength = 100;
            txtdni.MaxLength = 20;
            txttele.MaxLength = 15;
            txtcorreo.MaxLength = 50;
            txtdireccion.MaxLength = 150;
            txtsalario.MaxLength = 12;

            Load -= FrmNuevoEmpleado_Load;
            Load += FrmNuevoEmpleado_Load;

            btningresar.Click -= btningresar_Click;
            btningresar.Click += btningresar_Click;

            btnsalir.Click -= btnsalir_Click;
            btnsalir.Click += btnsalir_Click;
        }

        private void FrmNuevoEmpleado_Load(object sender, EventArgs e)
        {
            CargarDepartamentos();
            CargarEstados();

            if (idEmpleadoEditar.HasValue)
            {
                this.Text = "Editar empleado";
                btningresar.Text = "Actualizar";
                CargarEmpleado(idEmpleadoEditar.Value);
            }
            else
            {
                this.Text = "Nuevo empleado";
                btningresar.Text = "Guardar";
                dtfecha.Text = DateTime.Today.ToShortDateString();

                if (cbestado.Items.Count > 0) cbestado.SelectedIndex = 0;
            }
        }

        private void CargarDepartamentos()
        {
            cbdepar.Items.Clear();
            string consulta = "SELECT id_depto, nombre FROM departamentos ORDER BY nombre;";

            try
            {
                using (MySqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion.State != ConnectionState.Open) return;

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            DepartamentoItem departamento = new DepartamentoItem();
                            departamento.Id = Convert.ToInt32(lector["id_depto"]);
                            departamento.Nombre = lector["nombre"].ToString();
                            cbdepar.Items.Add(departamento);
                        }
                    }
                }

                if (cbdepar.Items.Count == 0)
                {
                    AntdUI.Message.warn(this, "No existen departamentos registrados.", autoClose: 4);
                }
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "Error al cargar departamentos: " + ex.Message, autoClose: 4);
            }
        }

        private void CargarEstados()
        {
            cbestado.Items.Clear();

            EstadoItem estadoActivo = new EstadoItem();
            estadoActivo.Valor = 1;
            estadoActivo.Nombre = "Activo";
            cbestado.Items.Add(estadoActivo);

            EstadoItem estadoInactivo = new EstadoItem();
            estadoInactivo.Valor = 0;
            estadoInactivo.Nombre = "Inactivo";
            cbestado.Items.Add(estadoInactivo);
        }

        private void CargarEmpleado(int idEmpleado)
        {
            string consulta = "SELECT * FROM empleados WHERE id_empleado = @idEmpleado;";

            try
            {
                using (MySqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion.State != ConnectionState.Open) return;

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@idEmpleado", MySqlDbType.Int32).Value = idEmpleado;

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (!lector.Read())
                            {
                                AntdUI.Message.warn(this, "El empleado no fue encontrado.", autoClose: 3);
                                this.Close();
                                return;
                            }

                            txtcodigo.Text = lector["codigo_empleado"].ToString();
                            txtnombre.Text = lector["nombre"].ToString();
                            txtdni.Text = lector["dni"].ToString();
                            txttele.Text = lector["telefono"].ToString();
                            txtcorreo.Text = lector["correo"].ToString();
                            txtdireccion.Text = lector["direccion"].ToString();
                            dtfecha.Text = Convert.ToDateTime(lector["fecha_contratacion"]).ToShortDateString();
                            txtsalario.Text = Convert.ToDecimal(lector["salario_base"]).ToString("0.00");

                            if (lector["id_depto"] != DBNull.Value)
                            {
                                SeleccionarDepartamento(Convert.ToInt32(lector["id_depto"]));
                            }

                            SeleccionarEstado(Convert.ToInt32(lector["estado"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "Error al cargar el empleado: " + ex.Message, autoClose: 4);
            }
        }

        private void SeleccionarDepartamento(int idDepartamento)
        {
            foreach (object elemento in cbdepar.Items)
            {
                DepartamentoItem departamento = elemento as DepartamentoItem;
                if (departamento != null && departamento.Id == idDepartamento)
                {
                    cbdepar.SelectedValue = departamento;
                    return;
                }
            }
        }

        private void SeleccionarEstado(int valorEstado)
        {
            foreach (object elemento in cbestado.Items)
            {
                EstadoItem estado = elemento as EstadoItem;
                if (estado != null && estado.Valor == valorEstado)
                {
                    cbestado.SelectedValue = estado;
                    return;
                }
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            if (idEmpleadoEditar.HasValue)
            {
                ActualizarEmpleado();
            }
            else
            {
                GuardarEmpleado();
            }
        }

        private bool ValidarFormulario()
        {
            string codigo = txtcodigo.Text.Trim();
            string nombre = txtnombre.Text.Trim();
            string dni = txtdni.Text.Trim();
            string telefono = txttele.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string direccion = txtdireccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo)) { MostrarAdvertencia("Ingrese el código del empleado.", txtcodigo); return false; }
            
            if (!Regex.IsMatch(codigo, @"^[A-Za-z0-9-]{3,20}$")) { MostrarAdvertencia("El código debe tener entre 3 y 20 caracteres (letras, números o guiones).", txtcodigo); return false; }

            if (string.IsNullOrWhiteSpace(nombre)) { MostrarAdvertencia("Ingrese el nombre del empleado.", txtnombre); return false; }
            
            if (nombre.Length < 3) { MostrarAdvertencia("El nombre debe tener al menos 3 caracteres.", txtnombre); return false; }
            
            if (!Regex.IsMatch(nombre, @"^[A-Za-zÁÉÍÓÚáéíóúÑñÜü' -]+$")) { MostrarAdvertencia("El nombre solamente puede contener letras y espacios.", txtnombre); return false; }

            if (string.IsNullOrWhiteSpace(dni)) { MostrarAdvertencia("Ingrese el DNI del empleado.", txtdni); return false; }
            if (!Regex.IsMatch(dni, @"^\d{4}-?\d{4}-?\d{5}$")) { MostrarAdvertencia("Ingrese un DNI válido. Ejemplo: 0801-2000-12345.", txtdni); return false; }

            if (string.IsNullOrWhiteSpace(telefono)) { MostrarAdvertencia("Ingrese el teléfono del empleado.", txttele); return false; }
            if (!Regex.IsMatch(telefono, @"^\d{8}$")) { MostrarAdvertencia("El teléfono debe contener exactamente 8 números.", txttele); return false; }

            if (string.IsNullOrWhiteSpace(correo)) { MostrarAdvertencia("Ingrese el correo del empleado.", txtcorreo); return false; }
            if (!Regex.IsMatch(correo, @"^[^\s@]+@[^\s@]+\.[^\s@]+$")) { MostrarAdvertencia("Ingrese un correo electrónico válido.", txtcorreo); return false; }

            if (string.IsNullOrWhiteSpace(direccion)) { MostrarAdvertencia("Ingrese la dirección del empleado.", txtdireccion); return false; }
            if (direccion.Length < 5) { MostrarAdvertencia("La dirección debe tener al menos 5 caracteres.", txtdireccion); return false; }

            DepartamentoItem departamento = cbdepar.SelectedValue as DepartamentoItem;
            if (departamento == null) { MostrarAdvertencia("Seleccione un departamento.", cbdepar); return false; }

            EstadoItem estado = cbestado.SelectedValue as EstadoItem;
            if (estado == null) { MostrarAdvertencia("Seleccione el estado del empleado.", cbestado); return false; }

            DateTime fechaContratacion;
            if (!DateTime.TryParse(dtfecha.Text, out fechaContratacion)) { MostrarAdvertencia("Seleccione una fecha válida.", dtfecha); return false; }
            if (fechaContratacion.Date > DateTime.Today) { MostrarAdvertencia("La fecha de contratación no puede ser futura.", dtfecha); return false; }

            decimal salario;
            if (!ObtenerSalario(out salario)) { MostrarAdvertencia("Ingrese un salario numérico válido.", txtsalario); return false; }
            if (salario <= 0) { MostrarAdvertencia("El salario debe ser mayor que cero.", txtsalario); return false; }
            if (salario > 99999999.99m) { MostrarAdvertencia("El salario supera el máximo permitido.", txtsalario); return false; }

            return true;
        }

        private bool ObtenerSalario(out decimal salario)
        {
            bool resultado = decimal.TryParse(txtsalario.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out salario);
            if (!resultado)
            {
                resultado = decimal.TryParse(txtsalario.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out salario);
            }
            return resultado;
        }

        private void GuardarEmpleado()
        {
            string consulta = @"INSERT INTO empleados (codigo_empleado, nombre, dni, telefono, correo, direccion, fecha_contratacion, salario_base, id_depto, estado) 
                                VALUES (@codigo, @nombre, @dni, @telefono, @correo, @direccion, @fecha, @salario, @departamento, @estado);";
            EjecutarGuardado(consulta, false);
        }

        private void ActualizarEmpleado()
        {
            string consulta = @"UPDATE empleados SET codigo_empleado = @codigo, nombre = @nombre, dni = @dni, telefono = @telefono, 
                                correo = @correo, direccion = @direccion, fecha_contratacion = @fecha, salario_base = @salario, 
                                id_depto = @departamento, estado = @estado WHERE id_empleado = @idEmpleado;";
            EjecutarGuardado(consulta, true);
        }

        private void EjecutarGuardado(string consulta, bool esEdicion)
        {
            DepartamentoItem departamento = cbdepar.SelectedValue as DepartamentoItem;
            EstadoItem estado = cbestado.SelectedValue as EstadoItem;

            if (departamento == null || estado == null)
            {
                AntdUI.Message.warn(this, "Seleccione el departamento y el estado.", autoClose: 3);
                return;
            }

            decimal salario;
            if (!ObtenerSalario(out salario))
            {
                AntdUI.Message.warn(this, "El salario no es válido.", autoClose: 3);
                return;
            }

            DateTime fechaContratacion;
            if (!DateTime.TryParse(dtfecha.Text, out fechaContratacion))
            {
                AntdUI.Message.warn(this, "La fecha no es válida.", autoClose: 3);
                return;
            }

            try
            {
                using (MySqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion.State != ConnectionState.Open) return;

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        // Parámetros colapsados para mayor limpieza visual
                        comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = txtcodigo.Text.Trim();
                        comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = txtnombre.Text.Trim();
                        comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = txtdni.Text.Trim();
                        comando.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = txttele.Text.Trim();
                        comando.Parameters.Add("@correo", MySqlDbType.VarChar).Value = txtcorreo.Text.Trim();
                        comando.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = txtdireccion.Text.Trim();
                        comando.Parameters.Add("@fecha", MySqlDbType.Date).Value = fechaContratacion.Date;
                        comando.Parameters.Add("@salario", MySqlDbType.Decimal).Value = salario;
                        comando.Parameters.Add("@departamento", MySqlDbType.Int32).Value = departamento.Id;
                        comando.Parameters.Add("@estado", MySqlDbType.Byte).Value = estado.Valor;

                        if (esEdicion)
                        {
                            comando.Parameters.Add("@idEmpleado", MySqlDbType.Int32).Value = idEmpleadoEditar.Value;
                        }

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            string mensaje = esEdicion ? "Empleado actualizado correctamente." : "Empleado guardado correctamente.";
                            AntdUI.Message.success(this, mensaje, autoClose: 2);

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            AntdUI.Message.warn(this, "No se realizaron cambios.", autoClose: 3);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    AntdUI.Message.warn(this, "El código o el DNI ya están registrados.", autoClose: 4);
                }
                else
                {
                    AntdUI.Message.error(this, "Error de MySQL: " + ex.Message, autoClose: 4);
                }
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "Ocurrió un error al guardar: " + ex.Message, autoClose: 4);
            }
        }

        private void MostrarAdvertencia(string mensaje, Control control)
        {
            AntdUI.Message.warn(this, mensaje, autoClose: 3);
            control.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
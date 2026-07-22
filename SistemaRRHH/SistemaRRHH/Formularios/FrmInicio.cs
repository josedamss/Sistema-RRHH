using AntdUI;
using MySql.Data.MySqlClient;
using SistemaRRHH.DatosSQL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaRRHH.Formularios
{
    public partial class FrmInicio : Form
    {
        private readonly ConexionSQL conexionSQL = new ConexionSQL();

        public FrmInicio()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            Load -= FrmInicio_Load;
            Load += FrmInicio_Load;
            btnemple.Click -= btnNuevoEmpleado_Click;
            btnemple.Click += btnNuevoEmpleado_Click;
            btndepa.Click -= btnNuevoDepartamento_Click;
            btndepa.Click += btnNuevoDepartamento_Click;
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            ConfigurarGraficos();
            ActualizarDashboard();
        }

        private void ConfigurarGraficos()
        {
            graficoDepartamentos.ChartType = TChartType.Bar;
            graficoDepartamentos.Title = "Empleados por departamento";
            graficoDepartamentos.ShowLegend = false;
            graficoDepartamentos.ShowGrid = true;
            graficoDepartamentos.ShowAxes = true;
            graficoDepartamentos.ShowTooltip = true;
            graficoDepartamentos.EnableAnimation = true;
            graficoDepartamentos.AnimationDuration = 600;
            graficoDepartamentos.BackColor = Color.White;

            graficoEstados.ChartType = TChartType.Doughnut;
            graficoEstados.Title = "Estado del personal";
            graficoEstados.ShowLegend = true;
            graficoEstados.ShowGrid = false;
            graficoEstados.ShowAxes = false;
            graficoEstados.ShowTooltip = true;
            graficoEstados.EnablePieHoverValue = true;
            graficoEstados.EnableAnimation = true;
            graficoEstados.AnimationDuration = 600;
            graficoEstados.BackColor = Color.White;
        }

        private void ActualizarDashboard()
        {
            CargarTotales();
            CargarGraficoDepartamentos();
            CargarGraficoEstados();
        }

        private void CargarTotales()
        {
            string consulta = @"
                SELECT
                    (SELECT COUNT(*) FROM empleados) AS total_empleados,
                    (SELECT COUNT(*) FROM empleados WHERE estado = 1) AS empleados_activos,
                    (SELECT COUNT(*) FROM departamentos) AS total_departamentos,
                    (SELECT COUNT(DISTINCT id_empleado) FROM asistencias WHERE fecha = CURDATE()) AS asistencias_hoy;";

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
                            lblTotalEmpleados.Text = lector["total_empleados"].ToString();
                            lblEmpleadosActivos.Text = lector["empleados_activos"].ToString();
                            lblDepartamentos.Text = lector["total_departamentos"].ToString();
                            lblAsistenciasHoy.Text = lector["asistencias_hoy"].ToString();
                        }
                    }
                }

                lblTotalEmpleados.BringToFront();
                lblEmpleadosActivos.BringToFront();
                lblDepartamentos.BringToFront();
                lblAsistenciasHoy.BringToFront();
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "Error al cargar los totales: " + ex.Message, autoClose: 4);
            }
        }

        private void CargarGraficoDepartamentos()
        {
            string consulta = @"
                SELECT COALESCE(d.nombre, 'Sin departamento') AS departamento, COUNT(e.id_empleado) AS cantidad
                FROM empleados e
                LEFT JOIN departamentos d ON e.id_depto = d.id_depto
                GROUP BY e.id_depto, d.nombre
                ORDER BY cantidad DESC;";

            try
            {
                graficoDepartamentos.ClearDatasets();
                ChartDataset datos = new ChartDataset("Empleados", Color.FromArgb(22, 119, 255));
                int posicion = 1;

                using (MySqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion.State != ConnectionState.Open) return;

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string departamento = lector["departamento"].ToString();
                            double cantidad = Convert.ToDouble(lector["cantidad"]);
                            datos.AddPoint(departamento, posicion, cantidad);
                            posicion++;
                        }
                    }
                }

                graficoDepartamentos.AddDataset(datos);
                graficoDepartamentos.RefreshChart();
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "Error al cargar empleados por departamento: " + ex.Message, autoClose: 4);
            }
        }

        private void CargarGraficoEstados()
        {
            string consulta = @"
                SELECT
                    COALESCE(SUM(CASE WHEN estado = 1 THEN 1 ELSE 0 END), 0) AS activos,
                    COALESCE(SUM(CASE WHEN estado = 0 THEN 1 ELSE 0 END), 0) AS inactivos
                FROM empleados;";

            try
            {
                int activos = 0;
                int inactivos = 0;

                using (MySqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion.State != ConnectionState.Open) return;

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            activos = Convert.ToInt32(lector["activos"]);
                            inactivos = Convert.ToInt32(lector["inactivos"]);
                        }
                    }
                }

                graficoEstados.ClearDatasets();
                ChartDataset datos = new ChartDataset("Estado del personal");
                int total = activos + inactivos;

                if (total == 0)
                {
                    datos.DataPoints.Add(new ChartDataPoint("Sin empleados", 1, 1, Color.LightGray));
                }
                else
                {
                    double porcentajeActivos = activos * 100.0 / total;
                    double porcentajeInactivos = inactivos * 100.0 / total;
                    string textoActivos = "Activos " + porcentajeActivos.ToString("0.0") + "%";
                    string textoInactivos = "Inactivos " + porcentajeInactivos.ToString("0.0") + "%";
                    datos.DataPoints.Add(new ChartDataPoint(textoActivos, 1, activos, Color.FromArgb(82, 196, 26)));
                    datos.DataPoints.Add(new ChartDataPoint(textoInactivos, 2, inactivos, Color.FromArgb(255, 77, 79)));
                }

                graficoEstados.AddDataset(datos);
                graficoEstados.RefreshChart();
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "Error al cargar los estados: " + ex.Message, autoClose: 4);
            }
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            using (FrmNuevoEmpleado formulario = new FrmNuevoEmpleado())
            {
                if (formulario.ShowDialog() == DialogResult.OK) ActualizarDashboard();
            }
        }

        private void btnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            AntdUI.Message.info(this, "Primero debemos crear el formulario FrmNuevoDepartamento.", autoClose: 4);
        }
    }
}
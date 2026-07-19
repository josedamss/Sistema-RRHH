using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRRHH.Formularios
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

            tableempleados.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("ID", "ID", AntdUI.ColumnAlign.Center) { Width = "50" },
                new AntdUI.Column("Nombre", "Nombre Completo"),
                new AntdUI.Column("Departamento", "Departamento"),
                new AntdUI.Column("Cargo", "Cargo"),
                new AntdUI.Column("Estado", "Estado", AntdUI.ColumnAlign.Center)

            };




            tableempleados.DataSource = new object[]
            {
                new { ID = 1, Nombre = "Ana Banegas", Departamento = "Ventas", Cargo = "Administradora", Estado = "Activo" },
                new { ID = 2, Nombre = "Mario Salinas", Departamento = "Soporte", Cargo = "Empleado", Estado = "Inactivo" }
            };



        }
            
    }
}

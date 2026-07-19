using SistemaRRHH.Modelos;
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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private Form formularioActivo = null;

        private void AbrirFormularioHijo(Form formHijo)
        {
            
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formHijo;

            // Configuramos el formulario para que se comporte como un control interno
            formHijo.TopLevel = false; // Le decimos que ya no es una ventana independiente
            formHijo.FormBorderStyle = FormBorderStyle.None; // Le quitamos los bordes y botones de cerrar/maximizar
            formHijo.Dock = DockStyle.Fill; // Hacemos que se estire para llenar todo el panel blanco

            // Lo agregamos a nuestro panelCentral y lo mostramos
            panelcentral.Controls.Add(formHijo);
            panelcentral.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            
            string rol = VariablesGlobal.RolActual;

            if (rol == "Empleado")
            {
                
                btnempleados.Visible = false;
                btndepartamentos.Visible = false;
                btnnominas.Visible = false;
            }
            else if (rol == "Jefe Departamento")
            {
                
                btnnominas.Visible = false;
            }
            else if (rol == "Asistente")
            {
                
                btnnominas.Visible = false;
            }
            else if (rol == "Admin General")
            {
                
            }
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmEmpleados());
        }
    }
}

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

            // Leemos quién entró al sistema
            string rol = VariablesGlobal.RolActual;

            // POR DEFECTO: Ocultamos el botón de usuarios a TODOS para evitar riesgos
            btnusuario.Visible = false;

            // Aplicamos la seguridad según el rol
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
                // Si el que entró es el Admin General, ENTONCES le mostramos el botón secreto
                btnusuario.Visible = true;
            }

            // 1. Mostrar el rol del usuario desde la variable global
            lbrol.Text = "Has iniciado sesión como: " + VariablesGlobal.RolActual;

            // 2. Encender el reloj para que empiece a avanzar
            timer1.Start();
        }

        

        private void btnempleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmEmpleados());
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmUsuarios());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 3. Este código se ejecuta cada 1 segundo automáticamente
            // Formato "hh:mm:ss tt" muestra la hora con AM/PM (Ej: 10:46:57 PM)
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss tt");

            // ToLongDateString() escribe la fecha elegante (Ej: domingo, 19 de julio de 2026)
            lbfecha.Text = DateTime.Now.ToLongDateString();

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
           /*brirFormularioHijo(new FrmDashboard());*/
        }

        private void panelcentral_Click(object sender, EventArgs e)
        {

        }
    }
}

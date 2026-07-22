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

namespace SistemaRRHH
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            string error = "";

            var validaciones = new[]
            {
                new { Condicion = txtcontraseña.Text == "", Mensaje = "\nLa contraseña no puede estar vacía." },
                new { Condicion = txtusuario.Text == "", Mensaje = "\nEl usuario no puede estar vacío." },
                
            };

            for (int i = 0; i < validaciones.Length; i++)
            {
                if (validaciones[i].Condicion)
                {
                    error += validaciones[i].Mensaje;
                }
            }

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {


                string usuario = txtusuario.Text.Trim();
                string contrasena = txtcontraseña.Text.Trim();

                // Validamos que no dejen campos vacíos
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
                {
                    AntdUI.Message.error(this, "Por favor, ingresa tu usuario y contraseña", autoClose: 2);
                    return;
                }

                // --- SIMULACIÓN DE LOS 4 ROLES ---

                if (usuario == "admin" && contrasena == "1234")
                {
                    VariablesGlobal.RolActual = "Admin General";
                    AntdUI.Message.success(this, "Bienvenido Administrador General", autoClose: 2);

                    Formularios.FrmDashboard menu = new Formularios.FrmDashboard();
                    menu.Show();
                    this.Hide();
                }
                else if (usuario == "asistente" && contrasena == "1234")
                {
                    VariablesGlobal.RolActual = "Asistente";
                    AntdUI.Message.success(this, "Bienvenido Asistente de RRHH", autoClose: 2);

                    Formularios.FrmDashboard menu = new Formularios.FrmDashboard();
                    menu.Show();
                    this.Hide();
                }
                else if (usuario == "jefe" && contrasena == "1234")
                {
                    VariablesGlobal.RolActual = "Jefe Departamento";
                    AntdUI.Message.success(this, "Bienvenido Jefe de Departamento", autoClose: 2);

                    Formularios.FrmDashboard menu = new Formularios.FrmDashboard();
                    menu.Show();
                    this.Hide();
                }
                else if (usuario == "empleado" && contrasena == "1234")
                {
                    VariablesGlobal.RolActual = "Empleado";
                    AntdUI.Message.success(this, "Bienvenido Empleado", autoClose: 2);

                    Formularios.FrmDashboard menu = new Formularios.FrmDashboard();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    // Si escriben otra cosa, da error
                    AntdUI.Message.error(this, "Credenciales incorrectas. Intenta de nuevo.", autoClose: 2);
                }
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            string texto = txtusuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                lbusuario.Text = "El nombre no puede estar vacío.";
                lbusuario.Visible = true;
            }

            else if (texto.Length < 3)
            {
                lbusuario.Text = "Debe tener al menos 3 caracteres.";
                lbusuario.Visible = true;
            }

            else
            {
                lbusuario.Visible = false;
            }
        }

        private void lbcontra_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            string texto = txtcontraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                lbcontraseña.Text = "La contraseña no puede estar vacía.";
                lbcontraseña.Visible = true;
            }

            else if (texto.Length < 3)
            {
                lbcontraseña.Text = "Debe tener al menos 3 caracteres.";
                lbcontraseña.Visible = true;
            }

            else
            {
                lbcontraseña.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificamos si la contraseña está oculta actualmente
            if (txtcontraseña.UseSystemPasswordChar == true)
            {
                // 1. Mostrar la contraseña
                txtcontraseña.UseSystemPasswordChar = false;

                // 2. Cambiar el icono al de "ocultar" (ojito cerrado)
                btnojo.Text = "";
            }
            else
            {
                // 1. Volver a ocultar la contraseña con puntitos
                txtcontraseña.UseSystemPasswordChar = true;

                // 2. Cambiar el icono al de "ver" (ojito abierto)
                btnojo.Text = "";
            }
        }
    }

}


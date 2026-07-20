using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaRRHH.Formularios
{
    public partial class FrmNuevoEmpleado : Form
    {
        private readonly ErrorProvider errores = new ErrorProvider();
        private readonly Color colorError = Color.FromArgb(255, 77, 79);
        private readonly Color colorCorrecto = Color.FromArgb(82, 196, 26);

        public FrmNuevoEmpleado()
        {
            InitializeComponent();
            ConfigurarValidaciones();
        }

        private void ConfigurarValidaciones()
        {
            errores.ContainerControl = this;
            errores.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            txtcodigo.MaxLength = 20;
            txtnombre.MaxLength = 100;
            txttele.MaxLength = 8;
            txtcorreo.MaxLength = 50;
            txtdireccion.MaxLength = 150;
            txtsalario.MaxLength = 11;
            txtpuesto.MaxLength = 50;

            txtcodigo.TextChanged += (s, e) => ValidarCodigo();
            txtnombre.TextChanged += (s, e) => ValidarNombre();
            txttele.TextChanged += (s, e) => ValidarTelefono();
            txtcorreo.TextChanged += (s, e) => ValidarCorreo();
            txtdireccion.TextChanged += (s, e) => ValidarDireccion();
            txtsalario.TextChanged += (s, e) => ValidarSalario();
            txtpuesto.TextChanged += (s, e) => ValidarPuesto();
            dtfecha.TextChanged += (s, e) => ValidarFechaContratacion();
            cbdepar.SelectedValueChanged += (s, e) => ValidarDepartamento();
            cbestado.SelectedValueChanged += (s, e) => ValidarEstado();
            btningresar.Click += btningresar_Click;
            FormClosed += (s, e) => errores.Dispose();
        }

        private bool ValidarCodigo()
        {
            string codigo = txtcodigo.Text.Trim();
            string mensaje = null;

            if (string.IsNullOrWhiteSpace(codigo))
                mensaje = "El código del empleado es obligatorio.";
            else if (codigo.Length < 3 || codigo.Length > 20)
                mensaje = "El código debe contener entre 3 y 20 caracteres.";
            else if (!Regex.IsMatch(codigo, @"^[A-Za-z0-9-]+$"))
                mensaje = "Utilice únicamente letras, números y guiones.";

            return MostrarResultado(txtcodigo, mensaje);
        }

        private bool ValidarNombre()
        {
            string nombre = txtnombre.Text.Trim();
            string mensaje = null;

            if (string.IsNullOrWhiteSpace(nombre))
                mensaje = "El nombre completo es obligatorio.";
            else if (nombre.Length < 3 || nombre.Length > 100)
                mensaje = "El nombre debe contener entre 3 y 100 caracteres.";
            else if (!Regex.IsMatch(nombre, @"^[A-Za-zÁÉÍÓÚáéíóúÑñÜü' -]+$"))
                mensaje = "El nombre solo puede contener letras y espacios.";

            return MostrarResultado(txtnombre, mensaje);
        }

        private bool ValidarTelefono()
        {
            string telefono = txttele.Text.Trim();
            string mensaje = null;

            if (string.IsNullOrWhiteSpace(telefono))
                mensaje = "El teléfono es obligatorio.";
            else if (!Regex.IsMatch(telefono, @"^\d{8}$"))
                mensaje = "Ingrese un número de teléfono de 8 dígitos.";

            return MostrarResultado(txttele, mensaje);
        }

        private bool ValidarCorreo()
        {
            string correo = txtcorreo.Text.Trim();
            string mensaje = null;

            if (string.IsNullOrWhiteSpace(correo))
                mensaje = "El correo electrónico es obligatorio.";
            else if (correo.Length > 50)
                mensaje = "El correo no puede exceder los 50 caracteres.";
            else if (!Regex.IsMatch(correo, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
                mensaje = "Ingrese un correo electrónico válido.";

            return MostrarResultado(txtcorreo, mensaje);
        }

        private bool ValidarDireccion()
        {
            string direccion = txtdireccion.Text.Trim();
            string mensaje = null;

            if (string.IsNullOrWhiteSpace(direccion))
                mensaje = "La dirección es obligatoria.";
            else if (direccion.Length < 5 || direccion.Length > 150)
                mensaje = "La dirección debe contener entre 5 y 150 caracteres.";

            return MostrarResultado(txtdireccion, mensaje);
        }

        private bool ValidarSalario()
        {
            string salarioTexto = txtsalario.Text.Trim();
            decimal salario;
            string mensaje = null;

            bool salarioValido = decimal.TryParse(
                salarioTexto,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out salario)
                || decimal.TryParse(
                    salarioTexto,
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out salario);

            if (string.IsNullOrWhiteSpace(salarioTexto))
                mensaje = "El salario es obligatorio.";
            else if (!salarioValido)
                mensaje = "Ingrese un salario numérico válido.";
            else if (salario <= 0)
                mensaje = "El salario debe ser mayor que cero.";
            else if (salario > 99999999.99m)
                mensaje = "El salario excede el máximo permitido.";

            return MostrarResultado(txtsalario, mensaje);
        }

        private bool ValidarFechaContratacion()
        {
            DateTime fecha;
            string mensaje = null;

            if (string.IsNullOrWhiteSpace(dtfecha.Text))
                mensaje = "Seleccione la fecha de contratación.";
            else if (!DateTime.TryParse(dtfecha.Text, out fecha))
                mensaje = "La fecha de contratación no es válida.";
            else if (fecha.Date > DateTime.Today)
                mensaje = "La fecha de contratación no puede ser futura.";

            return MostrarResultado(dtfecha, mensaje);
        }

        private bool ValidarDepartamento()
        {
            string mensaje = cbdepar.SelectedValue == null
                ? "Seleccione un departamento."
                : null;

            return MostrarResultado(cbdepar, mensaje);
        }

        private bool ValidarEstado()
        {
            string mensaje = cbestado.SelectedValue == null
                ? "Seleccione el estado del empleado."
                : null;

            return MostrarResultado(cbestado, mensaje);
        }

        private bool ValidarPuesto()
        {
            string puesto = txtpuesto.Text.Trim();
            string mensaje = null;

            if (string.IsNullOrWhiteSpace(puesto))
                mensaje = "El puesto es obligatorio.";
            else if (puesto.Length < 2 || puesto.Length > 50)
                mensaje = "El puesto debe contener entre 2 y 50 caracteres.";

            return MostrarResultado(txtpuesto, mensaje);
        }

        private bool MostrarResultado(AntdUI.Input control, string mensaje)
        {
            bool esValido = string.IsNullOrEmpty(mensaje);
            errores.SetError(control, mensaje ?? string.Empty);
            control.BorderColor = esValido ? colorCorrecto : colorError;
            return esValido;
        }

        private bool ValidarFormulario(out Control primerCampoInvalido)
        {
            var validaciones = new List<KeyValuePair<Control, Func<bool>>>
            {
                new KeyValuePair<Control, Func<bool>>(txtcodigo, ValidarCodigo),
                new KeyValuePair<Control, Func<bool>>(txtnombre, ValidarNombre),
                new KeyValuePair<Control, Func<bool>>(txttele, ValidarTelefono),
                new KeyValuePair<Control, Func<bool>>(txtcorreo, ValidarCorreo),
                new KeyValuePair<Control, Func<bool>>(txtdireccion, ValidarDireccion),
                new KeyValuePair<Control, Func<bool>>(cbdepar, ValidarDepartamento),
                new KeyValuePair<Control, Func<bool>>(dtfecha, ValidarFechaContratacion),
                new KeyValuePair<Control, Func<bool>>(cbestado, ValidarEstado),
                new KeyValuePair<Control, Func<bool>>(txtsalario, ValidarSalario),
                new KeyValuePair<Control, Func<bool>>(txtpuesto, ValidarPuesto)
            };

            primerCampoInvalido = null;

            foreach (KeyValuePair<Control, Func<bool>> validacion in validaciones)
            {
                if (!validacion.Value() && primerCampoInvalido == null)
                    primerCampoInvalido = validacion.Key;
            }

            return primerCampoInvalido == null;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Control primerCampoInvalido;

            if (!ValidarFormulario(out primerCampoInvalido))
            {
                primerCampoInvalido.Focus();
                AntdUI.Message.error(
                    this,
                    "Revise los campos marcados antes de guardar.",
                    autoClose: 3);
                return;
            }

            AntdUI.Message.success(
                this,
                "Todos los datos del empleado son válidos.",
                autoClose: 3);

            // La inserción en MySQL se agregará al conectar el formulario
            // con la tabla empleados.
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

namespace SistemaRRHH.Formularios
{
    partial class FrmNuevoEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new AntdUI.Label();
            this.txtnombre = new AntdUI.Input();
            this.lbnombre = new AntdUI.Label();
            this.lbcodigo = new AntdUI.Label();
            this.txtcodigo = new AntdUI.Input();
            this.lbtele = new AntdUI.Label();
            this.txttele = new AntdUI.Input();
            this.lbcorreo = new AntdUI.Label();
            this.txtcorreo = new AntdUI.Input();
            this.lbdire = new AntdUI.Label();
            this.txtdireccion = new AntdUI.Input();
            this.lbfecha = new AntdUI.Label();
            this.lbdinero = new AntdUI.Label();
            this.txtsalario = new AntdUI.Input();
            this.dtfecha = new AntdUI.DatePicker();
            this.label2 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.cbdepar = new AntdUI.Select();
            this.lbdepar = new AntdUI.Label();
            this.lbestado = new AntdUI.Label();
            this.cbestado = new AntdUI.Select();
            this.lbpuesto = new AntdUI.Label();
            this.txtpuesto = new AntdUI.Input();
            this.btningresar = new AntdUI.Button();
            this.btnsalir = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Empleado";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(37, 238);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PlaceholderText = "Ingrese el nombre...";
            this.txtnombre.Size = new System.Drawing.Size(223, 39);
            this.txtnombre.TabIndex = 1;
            // 
            // lbnombre
            // 
            this.lbnombre.Location = new System.Drawing.Point(37, 209);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(156, 23);
            this.lbnombre.TabIndex = 2;
            this.lbnombre.Text = "Nombre Completo: *";
            // 
            // lbcodigo
            // 
            this.lbcodigo.Location = new System.Drawing.Point(37, 126);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(156, 23);
            this.lbcodigo.TabIndex = 4;
            this.lbcodigo.Text = "Codigo del Empleado: *";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(37, 155);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PlaceholderText = "Ingrese el codigo...";
            this.txtcodigo.Size = new System.Drawing.Size(223, 39);
            this.txtcodigo.TabIndex = 3;
            // 
            // lbtele
            // 
            this.lbtele.Location = new System.Drawing.Point(279, 126);
            this.lbtele.Name = "lbtele";
            this.lbtele.Size = new System.Drawing.Size(156, 23);
            this.lbtele.TabIndex = 10;
            this.lbtele.Text = "Telefono del Empleado: *";
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(279, 155);
            this.txttele.Name = "txttele";
            this.txttele.PlaceholderText = "Ingrese el numero...";
            this.txttele.Size = new System.Drawing.Size(223, 39);
            this.txttele.TabIndex = 9;
            // 
            // lbcorreo
            // 
            this.lbcorreo.Location = new System.Drawing.Point(279, 209);
            this.lbcorreo.Name = "lbcorreo";
            this.lbcorreo.Size = new System.Drawing.Size(156, 23);
            this.lbcorreo.TabIndex = 12;
            this.lbcorreo.Text = "Correo del Empleado: *";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(279, 238);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PlaceholderText = "Ingrese el correo...";
            this.txtcorreo.Size = new System.Drawing.Size(223, 39);
            this.txtcorreo.TabIndex = 11;
            // 
            // lbdire
            // 
            this.lbdire.Location = new System.Drawing.Point(37, 293);
            this.lbdire.Name = "lbdire";
            this.lbdire.Size = new System.Drawing.Size(156, 23);
            this.lbdire.TabIndex = 14;
            this.lbdire.Text = "Direccion del Empleado: *";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(37, 322);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PlaceholderText = "Ingrese la direccion...";
            this.txtdireccion.Size = new System.Drawing.Size(223, 39);
            this.txtdireccion.TabIndex = 13;
            // 
            // lbfecha
            // 
            this.lbfecha.Location = new System.Drawing.Point(279, 431);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(156, 23);
            this.lbfecha.TabIndex = 16;
            this.lbfecha.Text = "Fecha de Contratacion: *";
            // 
            // lbdinero
            // 
            this.lbdinero.Location = new System.Drawing.Point(279, 517);
            this.lbdinero.Name = "lbdinero";
            this.lbdinero.Size = new System.Drawing.Size(156, 23);
            this.lbdinero.TabIndex = 18;
            this.lbdinero.Text = "Salario del Empleado: *";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(279, 546);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.PlaceholderText = "Ingrese el salario...";
            this.txtsalario.Size = new System.Drawing.Size(223, 39);
            this.txtsalario.TabIndex = 17;
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(279, 460);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.PlaceholderText = "Fecha...";
            this.dtfecha.Size = new System.Drawing.Size(223, 39);
            this.dtfecha.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Inter ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Informacion Personal";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Informacion Laboral";
            // 
            // cbdepar
            // 
            this.cbdepar.Location = new System.Drawing.Point(37, 460);
            this.cbdepar.Name = "cbdepar";
            this.cbdepar.PlaceholderText = "Elegir Departamento...";
            this.cbdepar.Size = new System.Drawing.Size(223, 40);
            this.cbdepar.TabIndex = 22;
            // 
            // lbdepar
            // 
            this.lbdepar.Location = new System.Drawing.Point(37, 431);
            this.lbdepar.Name = "lbdepar";
            this.lbdepar.Size = new System.Drawing.Size(187, 23);
            this.lbdepar.TabIndex = 23;
            this.lbdepar.Text = "Departamento del Empleado: *";
            // 
            // lbestado
            // 
            this.lbestado.Location = new System.Drawing.Point(37, 517);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(187, 23);
            this.lbestado.TabIndex = 25;
            this.lbestado.Text = "Estado del Empleado: *";
            // 
            // cbestado
            // 
            this.cbestado.Location = new System.Drawing.Point(37, 546);
            this.cbestado.Name = "cbestado";
            this.cbestado.PlaceholderText = "Activo / Inactivo";
            this.cbestado.Size = new System.Drawing.Size(223, 40);
            this.cbestado.TabIndex = 24;
            // 
            // lbpuesto
            // 
            this.lbpuesto.Location = new System.Drawing.Point(37, 603);
            this.lbpuesto.Name = "lbpuesto";
            this.lbpuesto.Size = new System.Drawing.Size(156, 23);
            this.lbpuesto.TabIndex = 27;
            this.lbpuesto.Text = "Puesto del Empleado: *";
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(37, 632);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.PlaceholderText = "Puesto Empleado";
            this.txtpuesto.Size = new System.Drawing.Size(223, 39);
            this.txtpuesto.TabIndex = 26;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(279, 632);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 39);
            this.btningresar.TabIndex = 28;
            this.btningresar.Text = "Guardar";
            this.btningresar.Type = AntdUI.TTypeMini.Primary;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(399, 632);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(103, 39);
            this.btnsalir.TabIndex = 29;
            this.btnsalir.Text = "Salir";
            this.btnsalir.Type = AntdUI.TTypeMini.Error;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 749);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.lbpuesto);
            this.Controls.Add(this.txtpuesto);
            this.Controls.Add(this.lbestado);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.lbdepar);
            this.Controls.Add(this.cbdepar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.lbdinero);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbdire);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.lbcorreo);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lbtele);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNuevoEmpleado";
            this.Text = "Nuevo Empleado";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Input txtnombre;
        private AntdUI.Label lbnombre;
        private AntdUI.Label lbcodigo;
        private AntdUI.Input txtcodigo;
        private AntdUI.Label lbtele;
        private AntdUI.Input txttele;
        private AntdUI.Label lbcorreo;
        private AntdUI.Input txtcorreo;
        private AntdUI.Label lbdire;
        private AntdUI.Input txtdireccion;
        private AntdUI.Label lbfecha;
        private AntdUI.Label lbdinero;
        private AntdUI.Input txtsalario;
        private AntdUI.DatePicker dtfecha;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Select cbdepar;
        private AntdUI.Label lbdepar;
        private AntdUI.Label lbestado;
        private AntdUI.Select cbestado;
        private AntdUI.Label lbpuesto;
        private AntdUI.Input txtpuesto;
        private AntdUI.Button btningresar;
        private AntdUI.Button btnsalir;
    }
}
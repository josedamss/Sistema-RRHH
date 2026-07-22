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
            this.btnsalir = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.txtdni = new AntdUI.Input();
            this.panel1 = new AntdUI.Panel();
            this.btningresar = new AntdUI.Button();
            this.label6 = new AntdUI.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo empleado";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(27, 178);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PlaceholderText = "Ingrese el nombre completo";
            this.txtnombre.Radius = 14;
            this.txtnombre.Size = new System.Drawing.Size(251, 39);
            this.txtnombre.TabIndex = 2;
            // 
            // lbnombre
            // 
            this.lbnombre.BackColor = System.Drawing.Color.White;
            this.lbnombre.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnombre.Location = new System.Drawing.Point(27, 149);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(176, 23);
            this.lbnombre.TabIndex = 2;
            this.lbnombre.Text = "Nombre Completo: *";
            // 
            // lbcodigo
            // 
            this.lbcodigo.BackColor = System.Drawing.Color.White;
            this.lbcodigo.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbcodigo.Location = new System.Drawing.Point(27, 66);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(187, 23);
            this.lbcodigo.TabIndex = 4;
            this.lbcodigo.Text = "Codigo del Empleado: *";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(27, 95);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PlaceholderText = "Ej: EM001";
            this.txtcodigo.Radius = 14;
            this.txtcodigo.Size = new System.Drawing.Size(251, 39);
            this.txtcodigo.TabIndex = 1;
            // 
            // lbtele
            // 
            this.lbtele.BackColor = System.Drawing.Color.White;
            this.lbtele.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbtele.Location = new System.Drawing.Point(27, 307);
            this.lbtele.Name = "lbtele";
            this.lbtele.Size = new System.Drawing.Size(176, 23);
            this.lbtele.TabIndex = 10;
            this.lbtele.Text = "Telefono del Empleado: *";
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(27, 336);
            this.txttele.Name = "txttele";
            this.txttele.PlaceholderText = "Ej: 9999-8888";
            this.txttele.Radius = 14;
            this.txttele.Size = new System.Drawing.Size(251, 39);
            this.txttele.TabIndex = 4;
            // 
            // lbcorreo
            // 
            this.lbcorreo.BackColor = System.Drawing.Color.White;
            this.lbcorreo.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbcorreo.Location = new System.Drawing.Point(27, 390);
            this.lbcorreo.Name = "lbcorreo";
            this.lbcorreo.Size = new System.Drawing.Size(176, 23);
            this.lbcorreo.TabIndex = 12;
            this.lbcorreo.Text = "Correo del Empleado: *";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(27, 419);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PlaceholderText = "Ej: bbc@gmail.com";
            this.txtcorreo.Radius = 14;
            this.txtcorreo.Size = new System.Drawing.Size(251, 39);
            this.txtcorreo.TabIndex = 5;
            // 
            // lbdire
            // 
            this.lbdire.BackColor = System.Drawing.Color.White;
            this.lbdire.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbdire.Location = new System.Drawing.Point(27, 233);
            this.lbdire.Name = "lbdire";
            this.lbdire.Size = new System.Drawing.Size(176, 23);
            this.lbdire.TabIndex = 14;
            this.lbdire.Text = "Direccion del Empleado: *";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(27, 262);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PlaceholderText = "Ingrese la direccion completa";
            this.txtdireccion.Radius = 14;
            this.txtdireccion.Size = new System.Drawing.Size(251, 39);
            this.txtdireccion.TabIndex = 3;
            // 
            // lbfecha
            // 
            this.lbfecha.BackColor = System.Drawing.Color.White;
            this.lbfecha.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbfecha.Location = new System.Drawing.Point(328, 307);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(176, 23);
            this.lbfecha.TabIndex = 16;
            this.lbfecha.Text = "Fecha de Contratacion: *";
            // 
            // lbdinero
            // 
            this.lbdinero.BackColor = System.Drawing.Color.White;
            this.lbdinero.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdinero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbdinero.Location = new System.Drawing.Point(328, 393);
            this.lbdinero.Name = "lbdinero";
            this.lbdinero.Size = new System.Drawing.Size(176, 23);
            this.lbdinero.TabIndex = 18;
            this.lbdinero.Text = "Salario del Empleado: *";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(328, 422);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.PlaceholderText = "Ej: 25,000 Lps";
            this.txtsalario.Radius = 14;
            this.txtsalario.Size = new System.Drawing.Size(251, 39);
            this.txtsalario.TabIndex = 11;
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(328, 336);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.PlaceholderText = "Seleccione la fecha";
            this.dtfecha.Radius = 14;
            this.dtfecha.Size = new System.Drawing.Size(251, 39);
            this.dtfecha.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Informacion Personal";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(328, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Informacion Laboral";
            // 
            // cbdepar
            // 
            this.cbdepar.Location = new System.Drawing.Point(328, 95);
            this.cbdepar.Name = "cbdepar";
            this.cbdepar.PlaceholderText = "Elegir Departamento...";
            this.cbdepar.Radius = 14;
            this.cbdepar.Size = new System.Drawing.Size(251, 40);
            this.cbdepar.TabIndex = 7;
            // 
            // lbdepar
            // 
            this.lbdepar.BackColor = System.Drawing.Color.White;
            this.lbdepar.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdepar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbdepar.Location = new System.Drawing.Point(328, 66);
            this.lbdepar.Name = "lbdepar";
            this.lbdepar.Size = new System.Drawing.Size(222, 23);
            this.lbdepar.TabIndex = 23;
            this.lbdepar.Text = "Departamento del Empleado: *";
            // 
            // lbestado
            // 
            this.lbestado.BackColor = System.Drawing.Color.White;
            this.lbestado.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbestado.Location = new System.Drawing.Point(328, 152);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(210, 23);
            this.lbestado.TabIndex = 25;
            this.lbestado.Text = "Estado del Empleado: *";
            // 
            // cbestado
            // 
            this.cbestado.Location = new System.Drawing.Point(328, 181);
            this.cbestado.Name = "cbestado";
            this.cbestado.PlaceholderText = "Activo / Inactivo";
            this.cbestado.Radius = 14;
            this.cbestado.Size = new System.Drawing.Size(251, 40);
            this.cbestado.TabIndex = 8;
            // 
            // lbpuesto
            // 
            this.lbpuesto.BackColor = System.Drawing.Color.White;
            this.lbpuesto.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbpuesto.Location = new System.Drawing.Point(328, 233);
            this.lbpuesto.Name = "lbpuesto";
            this.lbpuesto.Size = new System.Drawing.Size(176, 23);
            this.lbpuesto.TabIndex = 27;
            this.lbpuesto.Text = "Puesto del Empleado: *";
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(328, 262);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.PlaceholderText = "Seleccione puesto";
            this.txtpuesto.Radius = 14;
            this.txtpuesto.Size = new System.Drawing.Size(251, 39);
            this.txtpuesto.TabIndex = 9;
            // 
            // btnsalir
            // 
            this.btnsalir.BorderWidth = 1F;
            this.btnsalir.Location = new System.Drawing.Point(328, 503);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Radius = 14;
            this.btnsalir.Size = new System.Drawing.Size(114, 39);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Complete la informacion del empleado";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(27, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "DNI del Empleado: *";
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtdni.Location = new System.Drawing.Point(27, 503);
            this.txtdni.Name = "txtdni";
            this.txtdni.PlaceholderText = "Ej: 0101200603821";
            this.txtdni.Radius = 14;
            this.txtdni.Size = new System.Drawing.Size(251, 39);
            this.txtdni.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderWidth = 1F;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtdni);
            this.panel1.Controls.Add(this.lbnombre);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.lbcodigo);
            this.panel1.Controls.Add(this.btningresar);
            this.panel1.Controls.Add(this.txttele);
            this.panel1.Controls.Add(this.lbpuesto);
            this.panel1.Controls.Add(this.lbtele);
            this.panel1.Controls.Add(this.txtpuesto);
            this.panel1.Controls.Add(this.txtcorreo);
            this.panel1.Controls.Add(this.lbestado);
            this.panel1.Controls.Add(this.lbcorreo);
            this.panel1.Controls.Add(this.cbestado);
            this.panel1.Controls.Add(this.txtdireccion);
            this.panel1.Controls.Add(this.lbdepar);
            this.panel1.Controls.Add(this.lbdire);
            this.panel1.Controls.Add(this.cbdepar);
            this.panel1.Controls.Add(this.lbfecha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtsalario);
            this.panel1.Controls.Add(this.lbdinero);
            this.panel1.Controls.Add(this.dtfecha);
            this.panel1.Location = new System.Drawing.Point(42, 113);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 14;
            this.panel1.Size = new System.Drawing.Size(605, 568);
            this.panel1.TabIndex = 33;
            this.panel1.Text = "panel1";
            // 
            // btningresar
            // 
            this.btningresar.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btningresar.BorderWidth = 1F;
            this.btningresar.Icon = global::SistemaRRHH.Properties.Resources.icon6;
            this.btningresar.IconGap = 0.8F;
            this.btningresar.Location = new System.Drawing.Point(444, 503);
            this.btningresar.Name = "btningresar";
            this.btningresar.Radius = 14;
            this.btningresar.Size = new System.Drawing.Size(135, 39);
            this.btningresar.TabIndex = 12;
            this.btningresar.Text = "Guardar";
            this.btningresar.Type = AntdUI.TTypeMini.Primary;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(528, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Administrador";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SistemaRRHH.Properties.Resources.usuario1;
            this.pictureBox3.Location = new System.Drawing.Point(484, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // FrmNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(693, 693);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNuevoEmpleado";
            this.Text = "Nuevo Empleado";
            this.Load += new System.EventHandler(this.FrmNuevoEmpleado_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Input txtdni;
        private AntdUI.Panel panel1;
        private AntdUI.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
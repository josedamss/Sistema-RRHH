namespace SistemaRRHH.Formularios
{
    partial class FrmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new AntdUI.In.Panel();
            this.btnusuario = new AntdUI.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnnominas = new AntdUI.Button();
            this.btnasistencias = new AntdUI.Button();
            this.btndepartamentos = new AntdUI.Button();
            this.btnempleados = new AntdUI.Button();
            this.btninicio = new AntdUI.Button();
            this.panelcentral = new AntdUI.In.Panel();
            this.lbfecha = new AntdUI.Label();
            this.lbhora = new AntdUI.Label();
            this.lbrol = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.btnusuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnnominas);
            this.panel1.Controls.Add(this.btnasistencias);
            this.panel1.Controls.Add(this.btndepartamentos);
            this.panel1.Controls.Add(this.btnempleados);
            this.panel1.Controls.Add(this.btninicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 652);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // btnusuario
            // 
            this.btnusuario.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnusuario.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.Location = new System.Drawing.Point(0, 250);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnusuario.Size = new System.Drawing.Size(240, 50);
            this.btnusuario.TabIndex = 6;
            this.btnusuario.Text = "Usuarios";
            this.btnusuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuario.Type = AntdUI.TTypeMini.Primary;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaRRHH.Properties.Resources.logo_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnnominas
            // 
            this.btnnominas.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnnominas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnnominas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnominas.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnominas.Location = new System.Drawing.Point(0, 200);
            this.btnnominas.Name = "btnnominas";
            this.btnnominas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnnominas.Size = new System.Drawing.Size(240, 50);
            this.btnnominas.TabIndex = 4;
            this.btnnominas.Text = "Nominas";
            this.btnnominas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnominas.Type = AntdUI.TTypeMini.Primary;
            // 
            // btnasistencias
            // 
            this.btnasistencias.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnasistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnasistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnasistencias.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnasistencias.Location = new System.Drawing.Point(0, 150);
            this.btnasistencias.Name = "btnasistencias";
            this.btnasistencias.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnasistencias.Size = new System.Drawing.Size(240, 50);
            this.btnasistencias.TabIndex = 3;
            this.btnasistencias.Text = "Asistencias";
            this.btnasistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnasistencias.Type = AntdUI.TTypeMini.Primary;
            // 
            // btndepartamentos
            // 
            this.btndepartamentos.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btndepartamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btndepartamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndepartamentos.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepartamentos.Location = new System.Drawing.Point(0, 100);
            this.btndepartamentos.Name = "btndepartamentos";
            this.btndepartamentos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btndepartamentos.Size = new System.Drawing.Size(240, 50);
            this.btndepartamentos.TabIndex = 2;
            this.btndepartamentos.Text = "Departamentos";
            this.btndepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndepartamentos.Type = AntdUI.TTypeMini.Primary;
            // 
            // btnempleados
            // 
            this.btnempleados.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnempleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnempleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnempleados.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.Location = new System.Drawing.Point(0, 50);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnempleados.Size = new System.Drawing.Size(240, 50);
            this.btnempleados.TabIndex = 1;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Type = AntdUI.TTypeMini.Primary;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // btninicio
            // 
            this.btninicio.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btninicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btninicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninicio.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.Location = new System.Drawing.Point(0, 0);
            this.btninicio.Name = "btninicio";
            this.btninicio.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btninicio.Size = new System.Drawing.Size(240, 50);
            this.btninicio.TabIndex = 0;
            this.btninicio.Text = "Inicio";
            this.btninicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninicio.Type = AntdUI.TTypeMini.Primary;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panelcentral
            // 
            this.panelcentral.BackColor = System.Drawing.Color.White;
            this.panelcentral.Controls.Add(this.lbfecha);
            this.panelcentral.Controls.Add(this.lbhora);
            this.panelcentral.Controls.Add(this.lbrol);
            this.panelcentral.Controls.Add(this.label2);
            this.panelcentral.Controls.Add(this.label1);
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.Location = new System.Drawing.Point(240, 0);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(1036, 652);
            this.panelcentral.TabIndex = 1;
            this.panelcentral.Text = "panel2";
            this.panelcentral.Click += new System.EventHandler(this.panelcentral_Click);
            // 
            // lbfecha
            // 
            this.lbfecha.Font = new System.Drawing.Font("Inter Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.Location = new System.Drawing.Point(38, 336);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(134, 23);
            this.lbfecha.TabIndex = 4;
            this.lbfecha.Text = "";
            // 
            // lbhora
            // 
            this.lbhora.Font = new System.Drawing.Font("Inter Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.lbhora.Location = new System.Drawing.Point(38, 224);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(271, 106);
            this.lbhora.TabIndex = 3;
            this.lbhora.Text = "00:00:00";
            // 
            // lbrol
            // 
            this.lbrol.Location = new System.Drawing.Point(38, 177);
            this.lbrol.Name = "lbrol";
            this.lbrol.Size = new System.Drawing.Size(134, 23);
            this.lbrol.TabIndex = 2;
            this.lbrol.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(666, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "¡Bienvenido al Sistema de Recursos Humanos!";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de Control";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 652);
            this.Controls.Add(this.panelcentral);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panel1;
        private AntdUI.In.Panel panelcentral;
        private AntdUI.Button btninicio;
        private AntdUI.Button btnnominas;
        private AntdUI.Button btnasistencias;
        private AntdUI.Button btndepartamentos;
        private AntdUI.Button btnempleados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AntdUI.Button btnusuario;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private System.Windows.Forms.Timer timer1;
        private AntdUI.Label lbhora;
        private AntdUI.Label lbrol;
        private AntdUI.Label lbfecha;
    }
}
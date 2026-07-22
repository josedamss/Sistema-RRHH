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
            this.panel1 = new AntdUI.In.Panel();
            this.panelcentral = new AntdUI.In.Panel();
            this.btnsalir = new AntdUI.Button();
            this.btnusuario = new AntdUI.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnnominas = new AntdUI.Button();
            this.btnasistencias = new AntdUI.Button();
            this.btndepartamentos = new AntdUI.Button();
            this.btnempleados = new AntdUI.Button();
            this.btninicio = new AntdUI.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btnsalir);
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
            // panelcentral
            // 
            this.panelcentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.Location = new System.Drawing.Point(240, 0);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(1036, 652);
            this.panelcentral.TabIndex = 1;
            this.panelcentral.Text = "panel2";
            this.panelcentral.Click += new System.EventHandler(this.panelcentral_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsalir.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Icon = global::SistemaRRHH.Properties.Resources.icono7;
            this.btnsalir.IconGap = 1F;
            this.btnsalir.IconRatio = 1.5F;
            this.btnsalir.Location = new System.Drawing.Point(0, 602);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(240, 50);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir del Sistema";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Type = AntdUI.TTypeMini.Primary;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnusuario.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.Icon = global::SistemaRRHH.Properties.Resources.icono11;
            this.btnusuario.IconGap = 1F;
            this.btnusuario.IconRatio = 2F;
            this.btnusuario.Location = new System.Drawing.Point(0, 250);
            this.btnusuario.Name = "btnusuario";
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnnominas
            // 
            this.btnnominas.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnnominas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnnominas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnominas.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnominas.Icon = global::SistemaRRHH.Properties.Resources.icon_icons1;
            this.btnnominas.IconGap = 1F;
            this.btnnominas.IconRatio = 1.6F;
            this.btnnominas.Location = new System.Drawing.Point(0, 200);
            this.btnnominas.Name = "btnnominas";
            this.btnnominas.Size = new System.Drawing.Size(240, 50);
            this.btnnominas.TabIndex = 4;
            this.btnnominas.Text = "Nominas";
            this.btnnominas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnominas.Type = AntdUI.TTypeMini.Primary;
            // 
            // btnasistencias
            // 
            this.btnasistencias.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnasistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnasistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnasistencias.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnasistencias.Icon = global::SistemaRRHH.Properties.Resources.icno3;
            this.btnasistencias.IconGap = 1F;
            this.btnasistencias.IconRatio = 1.5F;
            this.btnasistencias.Location = new System.Drawing.Point(0, 150);
            this.btnasistencias.Name = "btnasistencias";
            this.btnasistencias.Size = new System.Drawing.Size(240, 50);
            this.btnasistencias.TabIndex = 3;
            this.btnasistencias.Text = "Asistencias";
            this.btnasistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnasistencias.Type = AntdUI.TTypeMini.Primary;
            // 
            // btndepartamentos
            // 
            this.btndepartamentos.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btndepartamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btndepartamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndepartamentos.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepartamentos.Icon = global::SistemaRRHH.Properties.Resources.icono2;
            this.btndepartamentos.IconGap = 1F;
            this.btndepartamentos.IconRatio = 1.5F;
            this.btndepartamentos.Location = new System.Drawing.Point(0, 100);
            this.btndepartamentos.Name = "btndepartamentos";
            this.btndepartamentos.Size = new System.Drawing.Size(240, 50);
            this.btndepartamentos.TabIndex = 2;
            this.btndepartamentos.Text = "Departamentos";
            this.btndepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndepartamentos.Type = AntdUI.TTypeMini.Primary;
            this.btndepartamentos.Click += new System.EventHandler(this.btndepartamentos_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnempleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btnempleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnempleados.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.Icon = global::SistemaRRHH.Properties.Resources.icono1;
            this.btnempleados.IconGap = 1F;
            this.btnempleados.IconRatio = 2F;
            this.btnempleados.Location = new System.Drawing.Point(0, 50);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(240, 50);
            this.btnempleados.TabIndex = 1;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Type = AntdUI.TTypeMini.Primary;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // btninicio
            // 
            this.btninicio.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btninicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btninicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninicio.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.Icon = global::SistemaRRHH.Properties.Resources.ico5;
            this.btninicio.IconGap = 1F;
            this.btninicio.IconRatio = 1.5F;
            this.btninicio.Location = new System.Drawing.Point(0, 0);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(240, 50);
            this.btninicio.TabIndex = 0;
            this.btninicio.Text = "Inicio";
            this.btninicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninicio.Type = AntdUI.TTypeMini.Primary;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
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
        private AntdUI.Button btnsalir;
    }
}
namespace SistemaRRHH
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtusuario = new AntdUI.Input();
            this.txtcontraseña = new AntdUI.Input();
            this.btningresar = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.panel1 = new AntdUI.In.Panel();
            this.panel2 = new AntdUI.In.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(52, 176);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.OriginalBackColor = System.Drawing.Color.White;
            this.txtusuario.PlaceholderText = "Escribe tu usuario";
            this.txtusuario.Size = new System.Drawing.Size(225, 42);
            this.txtusuario.TabIndex = 0;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(52, 304);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PlaceholderText = "Introduzca su contraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(225, 42);
            this.txtcontraseña.TabIndex = 1;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // btningresar
            // 
            this.btningresar.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btningresar.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(190)))));
            this.btningresar.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btningresar.Location = new System.Drawing.Point(52, 398);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btningresar.Name = "btningresar";
            this.btningresar.OriginalBackColor = System.Drawing.SystemColors.Window;
            this.btningresar.Size = new System.Drawing.Size(225, 39);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Iniciar Sesion";
            this.btningresar.Type = AntdUI.TTypeMini.Primary;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema RR.HH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Inter ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(52, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "¡Bienvenido!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Inter ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(52, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Inter ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(52, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcontraseña);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btningresar);
            this.panel1.Location = new System.Drawing.Point(412, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 495);
            this.panel1.TabIndex = 9;
            this.panel1.Text = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SistemaRRHH.Properties.Resources._1;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 521);
            this.panel2.TabIndex = 10;
            this.panel2.Text = "panel2";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(756, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmLogin";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Input txtusuario;
        private AntdUI.Input txtcontraseña;
        private AntdUI.Button btningresar;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.In.Panel panel1;
        private AntdUI.In.Panel panel2;
    }
}


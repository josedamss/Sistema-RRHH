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
            this.btningresar = new AntdUI.Button();
            this.label3 = new AntdUI.Label();
            this.txtcontraseña = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.txtusuario = new AntdUI.Input();
            this.label4 = new AntdUI.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new AntdUI.Panel();
            this.lbcontraseña = new AntdUI.Label();
            this.lbusuario = new AntdUI.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnojo = new AntdUI.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.btningresar.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(120)))));
            this.btningresar.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btningresar.Location = new System.Drawing.Point(36, 338);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btningresar.Name = "btningresar";
            this.btningresar.OriginalBackColor = System.Drawing.SystemColors.Window;
            this.btningresar.Radius = 14;
            this.btningresar.Size = new System.Drawing.Size(284, 49);
            this.btningresar.TabIndex = 3;
            this.btningresar.Text = "Iniciar Sesion";
            this.btningresar.Type = AntdUI.TTypeMini.Primary;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Inter Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(36, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome Back!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtcontraseña.Location = new System.Drawing.Point(36, 254);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PaddGap = 3F;
            this.txtcontraseña.PlaceholderText = "Introduzca su contraseña";
            this.txtcontraseña.Radius = 14;
            this.txtcontraseña.Size = new System.Drawing.Size(284, 57);
            this.txtcontraseña.TabIndex = 1;
            this.txtcontraseña.UseSystemPasswordChar = true;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Inter ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.txtusuario.Location = new System.Drawing.Point(36, 126);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.OriginalBackColor = System.Drawing.Color.White;
            this.txtusuario.PaddGap = 3F;
            this.txtusuario.PlaceholderText = "Escribe tu usuario";
            this.txtusuario.Radius = 14;
            this.txtusuario.Size = new System.Drawing.Size(284, 56);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Inter ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(36, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Corporacion Empresarial S.A";
            // 
            // panel3
            // 
            this.panel3.BorderWidth = 1F;
            this.panel3.Controls.Add(this.lbcontraseña);
            this.panel3.Controls.Add(this.lbusuario);
            this.panel3.Controls.Add(this.btnojo);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btningresar);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtcontraseña);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtusuario);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(426, 12);
            this.panel3.Name = "panel3";
            this.panel3.Radius = 14;
            this.panel3.Size = new System.Drawing.Size(364, 495);
            this.panel3.TabIndex = 11;
            this.panel3.Text = "panel3";
            // 
            // lbcontraseña
            // 
            this.lbcontraseña.BackColor = System.Drawing.Color.White;
            this.lbcontraseña.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.lbcontraseña.Location = new System.Drawing.Point(128, 225);
            this.lbcontraseña.Name = "lbcontraseña";
            this.lbcontraseña.Size = new System.Drawing.Size(204, 23);
            this.lbcontraseña.TabIndex = 16;
            this.lbcontraseña.Text = "";
            this.lbcontraseña.Visible = false;
            // 
            // lbusuario
            // 
            this.lbusuario.BackColor = System.Drawing.Color.White;
            this.lbusuario.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.lbusuario.Location = new System.Drawing.Point(93, 97);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(218, 23);
            this.lbusuario.TabIndex = 12;
            this.lbusuario.Text = "";
            this.lbusuario.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaRRHH.Properties.Resources.ChatGPT_Image_21_jul_2026__23_36_46;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(410, 519);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // btnojo
            // 
            this.btnojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnojo.Icon = global::SistemaRRHH.Properties.Resources.eye_visible_hide_hidden_show_icon_145988;
            this.btnojo.IconRatio = 1.5F;
            this.btnojo.Location = new System.Drawing.Point(265, 274);
            this.btnojo.Name = "btnojo";
            this.btnojo.Size = new System.Drawing.Size(36, 18);
            this.btnojo.TabIndex = 2;
            this.btnojo.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(9)))), ((int)(((byte)(38)))));
            this.pictureBox3.Image = global::SistemaRRHH.Properties.Resources.logo_sin_fondo;
            this.pictureBox3.Location = new System.Drawing.Point(53, 414);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::SistemaRRHH.Properties.Resources.candado;
            this.pictureBox2.Location = new System.Drawing.Point(53, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SistemaRRHH.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(53, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(812, 521);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmLogin";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Button btningresar;
        private AntdUI.Label label3;
        private AntdUI.Input txtcontraseña;
        private AntdUI.Label label2;
        private AntdUI.Input txtusuario;
        private AntdUI.Label label4;
        private AntdUI.Button btnojo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private AntdUI.Panel panel3;
        private AntdUI.Label lbusuario;
        private AntdUI.Label lbcontraseña;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}


namespace SistemaRRHH.Formularios
{
    partial class FrmDepartamentos
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
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.panel1 = new AntdUI.In.Panel();
            this.btnnuevo = new AntdUI.Button();
            this.tabledepartamentos = new AntdUI.Table();
            this.txtbuscar = new AntdUI.Input();
            this.button4 = new AntdUI.Button();
            this.button3 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Administra la información, cargos y estado de tus departamentos";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestion de Departamentos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnnuevo);
            this.panel1.Controls.Add(this.tabledepartamentos);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Location = new System.Drawing.Point(33, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 452);
            this.panel1.TabIndex = 8;
            this.panel1.Text = "panel1";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(845, 24);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.OriginalBackColor = System.Drawing.Color.White;
            this.btnnuevo.Size = new System.Drawing.Size(166, 43);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "+ Nuevo Departamento";
            this.btnnuevo.Type = AntdUI.TTypeMini.Primary;
            // 
            // tabledepartamentos
            // 
            this.tabledepartamentos.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            this.tabledepartamentos.Bordered = true;
            this.tabledepartamentos.Gap = 12;
            this.tabledepartamentos.Location = new System.Drawing.Point(24, 83);
            this.tabledepartamentos.Name = "tabledepartamentos";
            this.tabledepartamentos.Size = new System.Drawing.Size(987, 350);
            this.tabledepartamentos.TabIndex = 4;
            this.tabledepartamentos.Text = "table1";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(24, 24);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.OriginalBackColor = System.Drawing.Color.White;
            this.txtbuscar.PlaceholderText = "Buscar por nombre o id...";
            this.txtbuscar.Size = new System.Drawing.Size(783, 43);
            this.txtbuscar.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Icon = global::SistemaRRHH.Properties.Resources.file_excel_icon_207242;
            this.button4.IconGap = 0.3F;
            this.button4.IconRatio = 1.5F;
            this.button4.Location = new System.Drawing.Point(949, 135);
            this.button4.Name = "button4";
            this.button4.OriginalBackColor = System.Drawing.Color.White;
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Icon = global::SistemaRRHH.Properties.Resources._3844460_can_trash_110351;
            this.button3.IconGap = 0.3F;
            this.button3.IconRatio = 1.5F;
            this.button3.Location = new System.Drawing.Point(911, 135);
            this.button3.Name = "button3";
            this.button3.OriginalBackColor = System.Drawing.Color.White;
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Icon = global::SistemaRRHH.Properties.Resources._3643749_edit_pen_pencil_write_writing_113397;
            this.button2.IconGap = 0.3F;
            this.button2.IconRatio = 1.5F;
            this.button2.Location = new System.Drawing.Point(873, 135);
            this.button2.Name = "button2";
            this.button2.OriginalBackColor = System.Drawing.Color.White;
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 5;
            // 
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1281, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDepartamentos";
            this.Text = "FrmDepartamentos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.In.Panel panel1;
        private AntdUI.Button button4;
        private AntdUI.Button button3;
        private AntdUI.Button button2;
        private AntdUI.Button btnnuevo;
        private AntdUI.Table tabledepartamentos;
        private AntdUI.Input txtbuscar;
    }
}
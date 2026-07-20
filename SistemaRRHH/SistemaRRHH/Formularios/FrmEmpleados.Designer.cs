namespace SistemaRRHH.Formularios
{
    partial class FrmEmpleados
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
            this.label2 = new AntdUI.Label();
            this.txtbuscar = new AntdUI.Input();
            this.button1 = new AntdUI.Button();
            this.tableempleados = new AntdUI.Table();
            this.panel1 = new AntdUI.In.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Empleados";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administra la información, cargos y estado de tu personal";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(24, 24);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.OriginalBackColor = System.Drawing.Color.White;
            this.txtbuscar.PlaceholderText = "Buscar por nombre o DNI...";
            this.txtbuscar.Size = new System.Drawing.Size(783, 43);
            this.txtbuscar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(845, 24);
            this.button1.Name = "button1";
            this.button1.OriginalBackColor = System.Drawing.Color.White;
            this.button1.Size = new System.Drawing.Size(166, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "+ Nuevo Empleado";
            this.button1.Type = AntdUI.TTypeMini.Primary;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableempleados
            // 
            this.tableempleados.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            this.tableempleados.Bordered = true;
            this.tableempleados.Gap = 12;
            this.tableempleados.Location = new System.Drawing.Point(24, 83);
            this.tableempleados.Name = "tableempleados";
            this.tableempleados.Size = new System.Drawing.Size(755, 350);
            this.tableempleados.TabIndex = 4;
            this.tableempleados.Text = "table1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tableempleados);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Location = new System.Drawing.Point(33, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 452);
            this.panel1.TabIndex = 5;
            this.panel1.Text = "panel1";
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::SistemaRRHH.Properties.Resources.pngtree_dotted_grid_paper_for_school_and_print_geometric_vector_png_image_11291854;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1124, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input txtbuscar;
        private AntdUI.Button button1;
        private AntdUI.Table tableempleados;
        private AntdUI.In.Panel panel1;
    }
}
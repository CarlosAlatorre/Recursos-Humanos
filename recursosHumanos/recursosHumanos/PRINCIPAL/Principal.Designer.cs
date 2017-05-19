namespace recursosHumanos.PRINCIPAL
{
    partial class Principal
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
            this.listView_nomina = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_asistencia = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.date_dia = new System.Windows.Forms.DateTimePicker();
            this.date_mes = new System.Windows.Forms.DateTimePicker();
            this.date_año = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_nomina
            // 
            this.listView_nomina.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_nomina.Location = new System.Drawing.Point(61, 121);
            this.listView_nomina.Name = "listView_nomina";
            this.listView_nomina.Size = new System.Drawing.Size(513, 253);
            this.listView_nomina.TabIndex = 2;
            this.listView_nomina.UseCompatibleStateImageBehavior = false;
            this.listView_nomina.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Nombre";
            this.columnHeader2.Width = 224;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora Entrada";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hora Salida";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha";
            this.columnHeader5.Width = 84;
            // 
            // label_asistencia
            // 
            this.label_asistencia.AutoSize = true;
            this.label_asistencia.BackColor = System.Drawing.Color.Transparent;
            this.label_asistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asistencia.ForeColor = System.Drawing.Color.Orange;
            this.label_asistencia.Location = new System.Drawing.Point(56, 80);
            this.label_asistencia.Name = "label_asistencia";
            this.label_asistencia.Size = new System.Drawing.Size(132, 29);
            this.label_asistencia.TabIndex = 12;
            this.label_asistencia.Text = "Asistencia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puestosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.asistenciaToolStripMenuItem,
            this.nominaToolStripMenuItem,
            this.gastosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.puestosToolStripMenuItem.Text = "Puestos";
            this.puestosToolStripMenuItem.Click += new System.EventHandler(this.puestosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horaEntradaToolStripMenuItem,
            this.horaSalidaToolStripMenuItem});
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            this.asistenciaToolStripMenuItem.Click += new System.EventHandler(this.asistenciaToolStripMenuItem_Click);
            // 
            // horaEntradaToolStripMenuItem
            // 
            this.horaEntradaToolStripMenuItem.Name = "horaEntradaToolStripMenuItem";
            this.horaEntradaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.horaEntradaToolStripMenuItem.Text = "Hora Entrada";
            this.horaEntradaToolStripMenuItem.Click += new System.EventHandler(this.horaEntradaToolStripMenuItem_Click);
            // 
            // horaSalidaToolStripMenuItem
            // 
            this.horaSalidaToolStripMenuItem.Name = "horaSalidaToolStripMenuItem";
            this.horaSalidaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.horaSalidaToolStripMenuItem.Text = "Hora Salida";
            this.horaSalidaToolStripMenuItem.Click += new System.EventHandler(this.horaSalidaToolStripMenuItem_Click);
            // 
            // nominaToolStripMenuItem
            // 
            this.nominaToolStripMenuItem.Name = "nominaToolStripMenuItem";
            this.nominaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.nominaToolStripMenuItem.Text = "Nomina";
            this.nominaToolStripMenuItem.Click += new System.EventHandler(this.nominaToolStripMenuItem_Click);
            // 
            // date_dia
            // 
            this.date_dia.CustomFormat = "dd";
            this.date_dia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_dia.Location = new System.Drawing.Point(928, 634);
            this.date_dia.Name = "date_dia";
            this.date_dia.Size = new System.Drawing.Size(52, 20);
            this.date_dia.TabIndex = 14;
            // 
            // date_mes
            // 
            this.date_mes.CustomFormat = "MM";
            this.date_mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_mes.Location = new System.Drawing.Point(986, 634);
            this.date_mes.Name = "date_mes";
            this.date_mes.Size = new System.Drawing.Size(52, 20);
            this.date_mes.TabIndex = 15;
            // 
            // date_año
            // 
            this.date_año.CustomFormat = "yyyy";
            this.date_año.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_año.Location = new System.Drawing.Point(1044, 634);
            this.date_año.Name = "date_año";
            this.date_año.Size = new System.Drawing.Size(52, 20);
            this.date_año.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::recursosHumanos.Properties.Resources.logotipo_don_juan;
            this.pictureBox1.Location = new System.Drawing.Point(324, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.gastosToolStripMenuItem.Text = "Gastos";
            this.gastosToolStripMenuItem.Click += new System.EventHandler(this.gastosToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.date_año);
            this.Controls.Add(this.date_mes);
            this.Controls.Add(this.date_dia);
            this.Controls.Add(this.label_asistencia);
            this.Controls.Add(this.listView_nomina);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_nomina;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label_asistencia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaSalidaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker date_dia;
        private System.Windows.Forms.DateTimePicker date_mes;
        private System.Windows.Forms.DateTimePicker date_año;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
    }
}
namespace recursosHumanos.NOMINA
{
    partial class Nomina
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
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.radio_quincena1 = new System.Windows.Forms.RadioButton();
            this.radio_quincena2 = new System.Windows.Forms.RadioButton();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_nomina
            // 
            this.listView_nomina.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_nomina.Location = new System.Drawing.Point(159, 160);
            this.listView_nomina.Name = "listView_nomina";
            this.listView_nomina.Size = new System.Drawing.Size(526, 253);
            this.listView_nomina.TabIndex = 1;
            this.listView_nomina.UseCompatibleStateImageBehavior = false;
            this.listView_nomina.View = System.Windows.Forms.View.Details;
            this.listView_nomina.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Asistencias";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sueldo Base";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bono";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sueldo Total";
            this.columnHeader5.Width = 78;
            // 
            // date_fecha
            // 
            this.date_fecha.CustomFormat = "yyyy-MM";
            this.date_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_fecha.Location = new System.Drawing.Point(159, 106);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(95, 22);
            this.date_fecha.TabIndex = 2;
            this.date_fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radio_quincena1
            // 
            this.radio_quincena1.AutoSize = true;
            this.radio_quincena1.Checked = true;
            this.radio_quincena1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_quincena1.Location = new System.Drawing.Point(275, 106);
            this.radio_quincena1.Name = "radio_quincena1";
            this.radio_quincena1.Size = new System.Drawing.Size(93, 20);
            this.radio_quincena1.TabIndex = 3;
            this.radio_quincena1.TabStop = true;
            this.radio_quincena1.Text = "Quincena 1";
            this.radio_quincena1.UseVisualStyleBackColor = true;
            // 
            // radio_quincena2
            // 
            this.radio_quincena2.AutoSize = true;
            this.radio_quincena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_quincena2.Location = new System.Drawing.Point(374, 106);
            this.radio_quincena2.Name = "radio_quincena2";
            this.radio_quincena2.Size = new System.Drawing.Size(93, 20);
            this.radio_quincena2.TabIndex = 4;
            this.radio_quincena2.Text = "Quincena 2";
            this.radio_quincena2.UseVisualStyleBackColor = true;
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(502, 100);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 33);
            this.btn_generar.TabIndex = 5;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.Location = new System.Drawing.Point(594, 100);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(75, 33);
            this.btn_exportar.TabIndex = 6;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(153, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prenomina";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(423, 432);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(154, 22);
            this.txt_buscar.TabIndex = 8;
            this.txt_buscar.Visible = false;
            this.txt_buscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(610, 432);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 30);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::recursosHumanos.Properties.Resources.logotipo_don_juan;
            this.pictureBox1.Location = new System.Drawing.Point(432, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.radio_quincena2);
            this.Controls.Add(this.radio_quincena1);
            this.Controls.Add(this.date_fecha);
            this.Controls.Add(this.listView_nomina);
            this.Name = "Nomina";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load);
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
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.RadioButton radio_quincena1;
        private System.Windows.Forms.RadioButton radio_quincena2;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
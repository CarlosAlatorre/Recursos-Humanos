namespace recursosHumanos.ASISTENCIA
{
    partial class Asistencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_empleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.dateHora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_clave
            // 
            this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.Location = new System.Drawing.Point(71, 174);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(199, 22);
            this.txt_clave.TabIndex = 5;
            this.txt_clave.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clave";
            this.label2.Visible = false;
            // 
            // combo_empleado
            // 
            this.combo_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_empleado.FormattingEnabled = true;
            this.combo_empleado.Location = new System.Drawing.Point(71, 106);
            this.combo_empleado.Name = "combo_empleado";
            this.combo_empleado.Size = new System.Drawing.Size(199, 24);
            this.combo_empleado.TabIndex = 10;
            this.combo_empleado.SelectedIndexChanged += new System.EventHandler(this.combo_empleado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "24 de Abril del 2017";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "13:06";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(92, 234);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(83, 30);
            this.btn_registrar.TabIndex = 14;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(189, 234);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(83, 30);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "yyyy-MM-dd";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(834, 464);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(200, 20);
            this.dateFecha.TabIndex = 15;
            // 
            // dateHora
            // 
            this.dateHora.CustomFormat = "hh:mm";
            this.dateHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHora.Location = new System.Drawing.Point(834, 492);
            this.dateHora.Name = "dateHora";
            this.dateHora.Size = new System.Drawing.Size(200, 20);
            this.dateHora.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(24, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hora de entrada / Salida";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::recursosHumanos.Properties.Resources.logotipo_don_juan;
            this.pictureBox1.Location = new System.Drawing.Point(360, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 317);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateHora);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_empleado);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Asistencia";
            this.Text = "Hora de entrada / salida";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_empleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.DateTimePicker dateHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
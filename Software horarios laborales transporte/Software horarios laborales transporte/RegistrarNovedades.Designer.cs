namespace Software_horarios_laborales_transporte
{
    partial class RegistrarNovedades
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbincapacidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnatrasnovedad = new System.Windows.Forms.Button();
            this.btnguardarnovedad = new System.Windows.Forms.Button();
            this.btnsalirnovedad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "MODULO REGISTRAR NOVEDADES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "SELECCIONAR EMPLEADO";
            // 
            // cmbincapacidad
            // 
            this.cmbincapacidad.FormattingEnabled = true;
            this.cmbincapacidad.Items.AddRange(new object[] {
            "ID 1 JUAN PEREZ",
            "ID 2 PABLO DIAZ",
            "ID 3 MARIA CORTEZ",
            "ID 4 PEDRO RAMIREZ",
            "ID 5 CARLOS GONZALEZ"});
            this.cmbincapacidad.Location = new System.Drawing.Point(386, 97);
            this.cmbincapacidad.Name = "cmbincapacidad";
            this.cmbincapacidad.Size = new System.Drawing.Size(256, 21);
            this.cmbincapacidad.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "TIPO DE NOVEDAD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 20);
            this.textBox2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "ADJUNTAR ARCHIVO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "FECHA INICIAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Salmon;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "FECHA FINAL";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(386, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(386, 298);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // btnatrasnovedad
            // 
            this.btnatrasnovedad.BackColor = System.Drawing.Color.Lime;
            this.btnatrasnovedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatrasnovedad.Location = new System.Drawing.Point(83, 385);
            this.btnatrasnovedad.Name = "btnatrasnovedad";
            this.btnatrasnovedad.Size = new System.Drawing.Size(96, 40);
            this.btnatrasnovedad.TabIndex = 26;
            this.btnatrasnovedad.Text = "ATRAS";
            this.btnatrasnovedad.UseVisualStyleBackColor = false;
            this.btnatrasnovedad.Click += new System.EventHandler(this.btnatrasnovedad_Click);
            // 
            // btnguardarnovedad
            // 
            this.btnguardarnovedad.BackColor = System.Drawing.Color.Yellow;
            this.btnguardarnovedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarnovedad.Location = new System.Drawing.Point(326, 366);
            this.btnguardarnovedad.Name = "btnguardarnovedad";
            this.btnguardarnovedad.Size = new System.Drawing.Size(124, 48);
            this.btnguardarnovedad.TabIndex = 27;
            this.btnguardarnovedad.Text = "GUARDAR";
            this.btnguardarnovedad.UseVisualStyleBackColor = false;
            // 
            // btnsalirnovedad
            // 
            this.btnsalirnovedad.BackColor = System.Drawing.Color.Red;
            this.btnsalirnovedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirnovedad.Location = new System.Drawing.Point(556, 374);
            this.btnsalirnovedad.Name = "btnsalirnovedad";
            this.btnsalirnovedad.Size = new System.Drawing.Size(86, 40);
            this.btnsalirnovedad.TabIndex = 28;
            this.btnsalirnovedad.Text = "SALIR";
            this.btnsalirnovedad.UseVisualStyleBackColor = false;
            this.btnsalirnovedad.Click += new System.EventHandler(this.btnsalirnovedad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_horarios_laborales_transporte.Properties.Resources.sitp_24;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrarNovedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalirnovedad);
            this.Controls.Add(this.btnguardarnovedad);
            this.Controls.Add(this.btnatrasnovedad);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbincapacidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrarNovedades";
            this.Text = "RegistrarNovedades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbincapacidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnatrasnovedad;
        private System.Windows.Forms.Button btnguardarnovedad;
        private System.Windows.Forms.Button btnsalirnovedad;
    }
}
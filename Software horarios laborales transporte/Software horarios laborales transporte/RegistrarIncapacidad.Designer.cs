namespace Software_horarios_laborales_transporte
{
    partial class RegistrarIncapacidad
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
            this.btnatrasincapa = new System.Windows.Forms.Button();
            this.btnsalirincapa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbincapacidad = new System.Windows.Forms.ComboBox();
            this.btnguardarincapacidad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnatrasincapa
            // 
            this.btnatrasincapa.BackColor = System.Drawing.Color.Lime;
            this.btnatrasincapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatrasincapa.Location = new System.Drawing.Point(114, 345);
            this.btnatrasincapa.Name = "btnatrasincapa";
            this.btnatrasincapa.Size = new System.Drawing.Size(96, 40);
            this.btnatrasincapa.TabIndex = 2;
            this.btnatrasincapa.Text = "ATRAS";
            this.btnatrasincapa.UseVisualStyleBackColor = false;
            this.btnatrasincapa.Click += new System.EventHandler(this.btnatrasincapa_Click);
            // 
            // btnsalirincapa
            // 
            this.btnsalirincapa.BackColor = System.Drawing.Color.Red;
            this.btnsalirincapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirincapa.Location = new System.Drawing.Point(595, 345);
            this.btnsalirincapa.Name = "btnsalirincapa";
            this.btnsalirincapa.Size = new System.Drawing.Size(86, 40);
            this.btnsalirincapa.TabIndex = 3;
            this.btnsalirincapa.Text = "SALIR";
            this.btnsalirincapa.UseVisualStyleBackColor = false;
            this.btnsalirincapa.Click += new System.EventHandler(this.btnsalirincapa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 5;
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
            this.cmbincapacidad.Location = new System.Drawing.Point(382, 72);
            this.cmbincapacidad.Name = "cmbincapacidad";
            this.cmbincapacidad.Size = new System.Drawing.Size(256, 21);
            this.cmbincapacidad.TabIndex = 6;
            // 
            // btnguardarincapacidad
            // 
            this.btnguardarincapacidad.BackColor = System.Drawing.Color.Yellow;
            this.btnguardarincapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarincapacidad.Location = new System.Drawing.Point(355, 337);
            this.btnguardarincapacidad.Name = "btnguardarincapacidad";
            this.btnguardarincapacidad.Size = new System.Drawing.Size(124, 48);
            this.btnguardarincapacidad.TabIndex = 7;
            this.btnguardarincapacidad.Text = "GUARDAR";
            this.btnguardarincapacidad.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "FECHA INICIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "FECHA FINAL";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(382, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(382, 238);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "ADJUNTAR ARCHIVO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "MODULO REGISTRAR INCAPACIDAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_horarios_laborales_transporte.Properties.Resources.sitp_24;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrarIncapacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguardarincapacidad);
            this.Controls.Add(this.cmbincapacidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalirincapa);
            this.Controls.Add(this.btnatrasincapa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrarIncapacidad";
            this.Text = "RegistrarIncapacidad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnatrasincapa;
        private System.Windows.Forms.Button btnsalirincapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbincapacidad;
        private System.Windows.Forms.Button btnguardarincapacidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}
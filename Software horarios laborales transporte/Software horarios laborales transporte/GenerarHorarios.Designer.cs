namespace Software_horarios_laborales_transporte
{
    partial class GenerarHorarios
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnautomatico = new System.Windows.Forms.Button();
            this.btnatrashorarios = new System.Windows.Forms.Button();
            this.btnsalirhorarios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(550, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "DESDE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "RUTA";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FONTIBON CENTRO",
            "SAN PABLO",
            "LA ESTANCIA",
            "ZONA FRANCA",
            "VILLEMAR",
            "MODELIA",
            "K 300",
            "BELEN"});
            this.comboBox1.Location = new System.Drawing.Point(173, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // btnautomatico
            // 
            this.btnautomatico.BackColor = System.Drawing.Color.Salmon;
            this.btnautomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnautomatico.Location = new System.Drawing.Point(332, 301);
            this.btnautomatico.Name = "btnautomatico";
            this.btnautomatico.Size = new System.Drawing.Size(159, 67);
            this.btnautomatico.TabIndex = 9;
            this.btnautomatico.Text = "GENERAR AUTOMATICO";
            this.btnautomatico.UseVisualStyleBackColor = false;
            this.btnautomatico.Click += new System.EventHandler(this.btnautomatico_Click);
            // 
            // btnatrashorarios
            // 
            this.btnatrashorarios.BackColor = System.Drawing.Color.Lime;
            this.btnatrashorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatrashorarios.Location = new System.Drawing.Point(122, 325);
            this.btnatrashorarios.Name = "btnatrashorarios";
            this.btnatrashorarios.Size = new System.Drawing.Size(95, 43);
            this.btnatrashorarios.TabIndex = 11;
            this.btnatrashorarios.Text = "ATRAS";
            this.btnatrashorarios.UseVisualStyleBackColor = false;
            this.btnatrashorarios.Click += new System.EventHandler(this.btnatrashorarios_Click);
            // 
            // btnsalirhorarios
            // 
            this.btnsalirhorarios.BackColor = System.Drawing.Color.Red;
            this.btnsalirhorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirhorarios.Location = new System.Drawing.Point(574, 325);
            this.btnsalirhorarios.Name = "btnsalirhorarios";
            this.btnsalirhorarios.Size = new System.Drawing.Size(85, 43);
            this.btnsalirhorarios.TabIndex = 12;
            this.btnsalirhorarios.Text = "SALIR";
            this.btnsalirhorarios.UseVisualStyleBackColor = false;
            this.btnsalirhorarios.Click += new System.EventHandler(this.btnsalirhorarios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_horarios_laborales_transporte.Properties.Resources.sitp_24;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GenerarHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalirhorarios);
            this.Controls.Add(this.btnatrashorarios);
            this.Controls.Add(this.btnautomatico);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GenerarHorarios";
            this.Text = "GenerarHorarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnautomatico;
        private System.Windows.Forms.Button btnatrashorarios;
        private System.Windows.Forms.Button btnsalirhorarios;
    }
}
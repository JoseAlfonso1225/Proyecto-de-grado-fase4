namespace Software_horarios_laborales_transporte
{
    partial class HorarioAutomatico
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
            this.btnatrasauto = new System.Windows.Forms.Button();
            this.btnsalirautoma = new System.Windows.Forms.Button();
            this.btnguardarauto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbautomatico = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnatrasauto
            // 
            this.btnatrasauto.BackColor = System.Drawing.Color.Lime;
            this.btnatrasauto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatrasauto.Location = new System.Drawing.Point(46, 398);
            this.btnatrasauto.Name = "btnatrasauto";
            this.btnatrasauto.Size = new System.Drawing.Size(96, 40);
            this.btnatrasauto.TabIndex = 1;
            this.btnatrasauto.Text = "ATRAS";
            this.btnatrasauto.UseVisualStyleBackColor = false;
            this.btnatrasauto.Click += new System.EventHandler(this.btnatrasauto_Click);
            // 
            // btnsalirautoma
            // 
            this.btnsalirautoma.BackColor = System.Drawing.Color.Red;
            this.btnsalirautoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirautoma.Location = new System.Drawing.Point(714, 398);
            this.btnsalirautoma.Name = "btnsalirautoma";
            this.btnsalirautoma.Size = new System.Drawing.Size(86, 40);
            this.btnsalirautoma.TabIndex = 2;
            this.btnsalirautoma.Text = "SALIR";
            this.btnsalirautoma.UseVisualStyleBackColor = false;
            this.btnsalirautoma.Click += new System.EventHandler(this.btnsalirautoma_Click);
            // 
            // btnguardarauto
            // 
            this.btnguardarauto.BackColor = System.Drawing.Color.Yellow;
            this.btnguardarauto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarauto.Location = new System.Drawing.Point(370, 361);
            this.btnguardarauto.Name = "btnguardarauto";
            this.btnguardarauto.Size = new System.Drawing.Size(124, 48);
            this.btnguardarauto.TabIndex = 3;
            this.btnguardarauto.Text = "GENERAR";
            this.btnguardarauto.UseVisualStyleBackColor = false;
            this.btnguardarauto.Click += new System.EventHandler(this.btnguardarauto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECCIONAR EMPLEADO";
            // 
            // cmbautomatico
            // 
            this.cmbautomatico.FormattingEnabled = true;
            this.cmbautomatico.Items.AddRange(new object[] {
            "SELECCIONAR TODOS",
            "ID 1 JUAN PEREZ",
            "ID 2 PABLO DIAZ",
            "ID 3 MARIA CORTEZ",
            "ID 4 PEDRO RAMIREZ",
            "ID 5 CARLOS GONZALEZ"});
            this.cmbautomatico.Location = new System.Drawing.Point(399, 84);
            this.cmbautomatico.Name = "cmbautomatico";
            this.cmbautomatico.Size = new System.Drawing.Size(256, 21);
            this.cmbautomatico.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(91, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(614, 221);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_horarios_laborales_transporte.Properties.Resources.sitp_24;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HorarioAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbautomatico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardarauto);
            this.Controls.Add(this.btnsalirautoma);
            this.Controls.Add(this.btnatrasauto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HorarioAutomatico";
            this.Text = "HorarioAutomatico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnatrasauto;
        private System.Windows.Forms.Button btnsalirautoma;
        private System.Windows.Forms.Button btnguardarauto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbautomatico;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
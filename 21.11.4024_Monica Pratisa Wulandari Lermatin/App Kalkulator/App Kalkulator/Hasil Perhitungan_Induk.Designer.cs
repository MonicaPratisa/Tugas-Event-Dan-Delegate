namespace App_Kalkulator
{
    partial class Induk_Kalkulator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_Hasil = new System.Windows.Forms.ListBox();
            this.lst_Hitung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_Hasil);
            this.groupBox1.Location = new System.Drawing.Point(18, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Hasil]";
            // 
            // lst_Hasil
            // 
            this.lst_Hasil.FormattingEnabled = true;
            this.lst_Hasil.Location = new System.Drawing.Point(6, 19);
            this.lst_Hasil.Name = "lst_Hasil";
            this.lst_Hasil.Size = new System.Drawing.Size(324, 212);
            this.lst_Hasil.TabIndex = 0;
            // 
            // lst_Hitung
            // 
            this.lst_Hitung.Location = new System.Drawing.Point(18, 272);
            this.lst_Hitung.Name = "lst_Hitung";
            this.lst_Hitung.Size = new System.Drawing.Size(331, 25);
            this.lst_Hitung.TabIndex = 1;
            this.lst_Hitung.Text = "Hitung";
            this.lst_Hitung.UseVisualStyleBackColor = true;
            this.lst_Hitung.Click += new System.EventHandler(this.lst_Hitung_Click);
            // 
            // Induk_Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 309);
            this.Controls.Add(this.lst_Hitung);
            this.Controls.Add(this.groupBox1);
            this.Name = "Induk_Kalkulator";
            this.Text = "Hasil Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_Hasil;
        private System.Windows.Forms.Button lst_Hitung;
    }
}


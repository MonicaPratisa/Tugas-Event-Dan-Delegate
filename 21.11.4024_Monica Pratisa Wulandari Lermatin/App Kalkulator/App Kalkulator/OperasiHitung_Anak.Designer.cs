namespace App_Kalkulator
{
    partial class OperasiHitung_Anak
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pengoperasian = new System.Windows.Forms.ComboBox();
            this.txt_Nilai_A = new System.Windows.Forms.TextBox();
            this.txt_Nilai_B = new System.Windows.Forms.TextBox();
            this.btn_Hitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // txt_Pengoperasian
            // 
            this.txt_Pengoperasian.FormattingEnabled = true;
            this.txt_Pengoperasian.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.txt_Pengoperasian.Location = new System.Drawing.Point(66, 6);
            this.txt_Pengoperasian.Name = "txt_Pengoperasian";
            this.txt_Pengoperasian.Size = new System.Drawing.Size(121, 21);
            this.txt_Pengoperasian.TabIndex = 3;
            // 
            // txt_Nilai_A
            // 
            this.txt_Nilai_A.Location = new System.Drawing.Point(66, 38);
            this.txt_Nilai_A.Name = "txt_Nilai_A";
            this.txt_Nilai_A.Size = new System.Drawing.Size(121, 20);
            this.txt_Nilai_A.TabIndex = 4;
            // 
            // txt_Nilai_B
            // 
            this.txt_Nilai_B.Location = new System.Drawing.Point(66, 72);
            this.txt_Nilai_B.Name = "txt_Nilai_B";
            this.txt_Nilai_B.Size = new System.Drawing.Size(121, 20);
            this.txt_Nilai_B.TabIndex = 5;
            // 
            // btn_Hitung
            // 
            this.btn_Hitung.Location = new System.Drawing.Point(102, 109);
            this.btn_Hitung.Name = "btn_Hitung";
            this.btn_Hitung.Size = new System.Drawing.Size(85, 23);
            this.btn_Hitung.TabIndex = 6;
            this.btn_Hitung.Text = "Proses";
            this.btn_Hitung.UseVisualStyleBackColor = true;
            this.btn_Hitung.Click += new System.EventHandler(this.btn_Hitung_Click);
            // 
            // OperasiHitung_Anak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 144);
            this.Controls.Add(this.btn_Hitung);
            this.Controls.Add(this.txt_Nilai_B);
            this.Controls.Add(this.txt_Nilai_A);
            this.Controls.Add(this.txt_Pengoperasian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OperasiHitung_Anak";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_Pengoperasian;
        private System.Windows.Forms.TextBox txt_Nilai_A;
        private System.Windows.Forms.TextBox txt_Nilai_B;
        private System.Windows.Forms.Button btn_Hitung;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Kalkulator
{
    public partial class OperasiHitung_Anak : Form
    {
        public delegate void PenghubungProses(int operasi, int a, int b, int hasil);
        public event PenghubungProses OnRunning;
        public OperasiHitung_Anak()
        {
            InitializeComponent();
            txt_Pengoperasian.SelectedIndex = 0;
        }
        
        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            string operasi = txt_Pengoperasian.SelectedItem.ToString();
            int a = Convert.ToInt32(txt_Nilai_A.Text);   //casting
            int b = Convert.ToInt32(txt_Nilai_B.Text);   //casting
            int hasil;


            switch (txt_Pengoperasian.SelectedIndex)
            {
                case 0: // penjumlahan
                    hasil = a + b;
                    break;
                case 1: // pengurangan
                    hasil = a - b;
                    break;
                case 2: // perkalian
                    hasil = a * b;
                    break;
                case 3: // pembagian
                    hasil = a / b;
                    break;
                default: // default
                    hasil = 0;
                    break;
            }
            this.OnRunning(txt_Pengoperasian.SelectedIndex, a, b, hasil);
        }
    }
}

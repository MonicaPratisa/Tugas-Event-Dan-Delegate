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
    public partial class Induk_Kalkulator : Form
    {
        private IList<Kalkulator> listofCalc = new List<Kalkulator>();

        private void AnakCalc_OnCreate(Kalkulator kalkulator)
        {
            listofCalc.Add(kalkulator);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(kalkulator.Operasi);
            item.SubItems.Add(kalkulator.NilaiA);
            item.SubItems.Add(kalkulator.NilaiB);
            lst_Hasil.Items.Add(item);
        }

        public Induk_Kalkulator()
        {
            InitializeComponent();
        }
        private void Display(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', 'x', '/' };
            string[] operasi_str = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            lst_Hasil.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}");
        }

        private void lst_Hitung_Click(object sender, EventArgs e)
        {
            OperasiHitung_Anak Menghitung = new OperasiHitung_Anak();
            Menghitung. OnRunning += Display;
            Menghitung.ShowDialog();
        }
    }
}
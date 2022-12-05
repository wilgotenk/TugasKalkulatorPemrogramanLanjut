using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasDelegateDanEvent
{
    public partial class Hitung : Form
    {
        public delegate void Proses(int a, int b, string operasi, string simbol, float hasil);
        public event Proses Perhitungan;
        public Hitung()
        {
            InitializeComponent();
        }
        public Hitung(string title)
           : this()
        {
            this.Text = title; // Ubah title
        }
        private void Hitung_Load(object sender, EventArgs e)
        {
            Operasi.Items.Clear();
            Operasi.Items.Add("Penjumlahan");
            Operasi.Items.Add("Pengurangan");
            Operasi.Items.Add("Perkalian");
            Operasi.Items.Add("Pembagain");
            
            // Atur indeks ke-0 sebagai default item
            Operasi.SelectedIndex = 0; 
        }
        private void btnProses_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            int a = int.Parse(NilaiA.Text);
            var b = int.Parse(NilaiB.Text);

            string operasi = "";
            string simbol = "";
            float hasil = 0;

            switch (Operasi.SelectedIndex)
            {
                case 0:
                    hasil = cal.Penjumlahan(a, b);
                    operasi = "Penjumlahan";
                    simbol = "+";
                    break;
                case 1:
                    hasil = cal.Pengurangan(a, b);
                    operasi = "Pengurangan";
                    simbol = "-";
                    break;
                case 2:
                    hasil = cal.Perkalian(a, b);
                    operasi = "Perkalian";
                    simbol = "x";
                    break;
                case 3:
                    hasil = (float)Calculator.Pembagian(a, b); 
                    operasi = "Pembagian";
                    simbol = "/";
                    break;

            }
            Perhitungan(a, b, operasi, simbol, hasil);
        }
    }
}

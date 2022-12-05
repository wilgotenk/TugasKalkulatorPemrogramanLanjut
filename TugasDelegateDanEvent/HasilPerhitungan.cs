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
    public partial class HasilPerhitungan : Form
    {
        public HasilPerhitungan()
        {
            InitializeComponent();
        }
        private void proses(int a, int b, string operasi, string label, float hasil)
        {
            listHasil.Items.Add(
                String.Format($"Hasil {label} dari {a} {operasi} {b} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil) // Atur untuk 2 angka di belakang koma
            );
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            Hitung hit = new Hitung("Calculator"); 
            hit.Perhitungan += proses;
            hit.ShowDialog();
        }
    }
}

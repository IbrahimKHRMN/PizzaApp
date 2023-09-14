using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void btn_KayitliMusteriler_Click(object sender, EventArgs e)
        {
            KayitliMusteriler kayitliMusteriler = new KayitliMusteriler();
            this.Hide();
            kayitliMusteriler.Show();
        }

        private void btn_Urunler_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            this.Hide();
            urunler.Show();
        }
    }
}

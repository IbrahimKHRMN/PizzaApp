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
    public partial class frm_AdminPaneli : Form
    {
        public frm_AdminPaneli()
        {
            InitializeComponent();
        }

        private void btn_KayitliMusteriler_Click(object sender, EventArgs e)
        {
            frm_KayitliMusteriler kayitliMusteriler = new frm_KayitliMusteriler();
            this.Hide();
            kayitliMusteriler.Show();
        }

        private void btn_Urunler_Click(object sender, EventArgs e)
        {
            frm_Urunler urunler = new frm_Urunler();
            this.Hide();
            urunler.Show();
        }
    }
}

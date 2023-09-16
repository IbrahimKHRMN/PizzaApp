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
    public partial class frm_Urunler : Form
    {
        public frm_Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pizzaAppDataSet1.Pizzalars' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pizzalarsTableAdapter.Fill(this.pizzaAppDataSet1.Pizzalars);

        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            frm_PizzaEkle pizzaEkle = new frm_PizzaEkle();
            this.Hide();
            pizzaEkle.Show();
        }

        private void btn_AdminPanelineDon_Click(object sender, EventArgs e)
        {
            frm_AdminPaneli adminPaneli = new frm_AdminPaneli();
            this.Hide();
            adminPaneli.Show();
        }
    }
}

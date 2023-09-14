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
    public partial class Urunler : Form
    {
        public Urunler()
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
            PizzaEkle pizzaEkle = new PizzaEkle();
            this.Hide();
            pizzaEkle.Show();
        }

        private void btn_AdminPanelineDon_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli = new AdminPaneli();
            this.Hide();
            adminPaneli.Show();
        }
    }
}

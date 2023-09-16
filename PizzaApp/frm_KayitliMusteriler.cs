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
    public partial class frm_KayitliMusteriler : Form
    {
        public frm_KayitliMusteriler()
        {
            InitializeComponent();
        }

        private void KayitliMusteriler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pizzaAppDataSet.Kullanicilars' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicilarsTableAdapter.Fill(this.pizzaAppDataSet.Kullanicilars);

        }

        private void btn_AdminPanelineDon_Click(object sender, EventArgs e)
        {
            frm_AdminPaneli adminPaneli = new frm_AdminPaneli();
            this.Hide();
            adminPaneli.Show();
        }
    }
}

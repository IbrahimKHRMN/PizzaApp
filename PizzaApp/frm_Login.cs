using PizzaApp.ORM.Context;
using PizzaApp.ORM.Entity;
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
    public partial class frm_Login : Form
    {
        ProjectContext db = new ProjectContext();
        string email = "";
        string parola = "";
        int id;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void linklbl_uyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_KayitOl frm_KayitOl = new frm_KayitOl();
            frm_KayitOl.Show();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            List<Kullanicilar> mst = new List<Kullanicilar>();
            
        }
    }
}

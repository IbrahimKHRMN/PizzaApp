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
    public partial class frm_UyeOl : Form
    {
        ProjectContext db = new ProjectContext();
        public frm_UyeOl()
        {
            InitializeComponent();
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            List<Kullanicilar> mst = new List<Kullanicilar>();
            mst = db.Kullanicilars.ToList();
            bool emailvar =false;
            cmb_Cinsiyet.Items.Add("Ankara");
            foreach (var email in mst)
            {
                if (email.Email == txt_Email.Text) 
                {
                    emailvar = true;
                }
            }
            if (emailvar==true)
            {
                MessageBox.Show("E-mail zaten sistemde kayıtlı. Lütfen başka bir E-mail ile deneyiniz.");
            }
            else
            {
                Kullanicilar kullanicilar = new Kullanicilar()
                {
                    Ad = txt_Ad.Text,
                    Soyad = txt_Soyad.Text,
                    Email = txt_Email.Text,
                    Parola = txt_Parola.Text,
                    Cinsiyet=cmb_Cinsiyet.Text,
                    KullaniciTipiId=cmb_KullaniciTipi.SelectedIndex
                    
                };

                db.Kullanicilars.Add(kullanicilar);//ORM
                db.SaveChanges();
                MessageBox.Show("Kaydınız başarıyla oluşturuldu.");
                this.Hide();
                frm_Giris frm_Login = new frm_Giris();
                frm_Login.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Giris frm_Login = new frm_Giris();
            frm_Login.Show();

        }
    }
}

﻿using PizzaApp.ORM.Context;
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
    public partial class frm_Giris : Form
    {
        ProjectContext db = new ProjectContext();
        string email = "";
        string parola = "";
        int id;
        frm_UyeOl frm_KayitOl = new frm_UyeOl();
        int kullaniciTipi;
        
        public frm_Giris()
        {
            InitializeComponent();

        }

        private void linklbl_uyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_UyeOl frm_KayitOl = new frm_UyeOl();
            frm_KayitOl.Show();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            List<Kullanicilar> mst = new List<Kullanicilar>();
            mst = db.Kullanicilars.Where(x => x.Email == txt_eposta.Text).ToList();
            //mst = db.Kullanicilars.Where(x=>x.KullaniciTipiId == kullaniciTipi).ToList();
            

            foreach (Kullanicilar kullanici in mst)
            {
                email = kullanici.Email.ToString();
                parola =kullanici.Parola.ToString();
                id = kullanici.ID;
                kullaniciTipi = kullanici.KullaniciTipiId;
            }

            if (email == txt_eposta.Text & kullaniciTipi == 1)
            {
                if (parola==txt_parola.Text)
                {
                    this.Hide();
                    //Kullanıcı tipi id 1 e eşit ise müşteri paneli açılacak. Form hazırlanınca yönlendirme yapılacak.
                    MessageBox.Show("Giriş Başarılı Müşteri Paneline Yönlendiriliyorsunuz.");
                    frm_MusteriPaneli musteriPaneli = new frm_MusteriPaneli();
                    musteriPaneli.Show();
                }
                else
                {
                    MessageBox.Show("Şifreniz yanlış.");
                }

            }
            else if (email == txt_eposta.Text & kullaniciTipi == 2)
            {
                if (parola==txt_parola.Text)
                {
                    this.Hide();
                    //Kullanıcı tipi id 2 ye eşit ise admin paneli açılacak. Form hazırlanınca yönlendirme yapılacak.
                    MessageBox.Show("Giriş Başarılı Admin Paneline Yönlendiriliyorsunuz.");
                    frm_AdminPaneli adminPaneli = new frm_AdminPaneli();
                    adminPaneli.Show();
                }
                else
                {
                    MessageBox.Show("Şifreniz yanlış.");

                }

            }
            else
            {
                MessageBox.Show("E-mail sistemde mevcut değil.");
            }
        }
    }
}

using PizzaApp.ORM.Context;
using PizzaApp.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PizzaApp
{
    public partial class PizzaEkle : Form
    {
        ProjectContext db = new ProjectContext();
        string base64 = "";
        public PizzaEkle()
        {
            InitializeComponent();
        }

        private void btn_PizzaKaydet_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) 
            {
                using (Image image = pictureBox1.Image.Clone() as Image)
                {
                    base64 = ConvertImageToBase64(image);
                }
            }
            else
            {
                MessageBox.Show("Lütfen pizza resmi yükleyin.");
                return;
            }

            Pizzalar pizzalar = new Pizzalar()
            {
                PizzaAdi = txt_PizzaAdi.Text,
                PizzaFiyati=Convert.ToDouble(txt_PizzaFiyati.Text),
                ImageUrl = base64,
                Icindekiler=cList_Icindekiler.Text,
            };
            db.pizzalars.Add(pizzalar);
            db.SaveChanges();
            MessageBox.Show("Pizza Başarıyla Eklendi");



        }
        public string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        private void btn_ResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp) | *.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp";
            if (open.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                txt_ImageUrl.Text = open.FileName;
            }
        }
    }
}

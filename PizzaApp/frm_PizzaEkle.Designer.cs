namespace PizzaApp
{
    partial class frm_PizzaEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PizzaEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PizzaAdi = new System.Windows.Forms.TextBox();
            this.txt_PizzaFiyati = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ResimEkle = new System.Windows.Forms.Button();
            this.txt_ImageUrl = new System.Windows.Forms.TextBox();
            this.btn_PizzaKaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Icindekiler = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(226, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Adı";
            // 
            // txt_PizzaAdi
            // 
            this.txt_PizzaAdi.Location = new System.Drawing.Point(291, 62);
            this.txt_PizzaAdi.Name = "txt_PizzaAdi";
            this.txt_PizzaAdi.Size = new System.Drawing.Size(119, 20);
            this.txt_PizzaAdi.TabIndex = 1;
            // 
            // txt_PizzaFiyati
            // 
            this.txt_PizzaFiyati.Location = new System.Drawing.Point(103, 324);
            this.txt_PizzaFiyati.Name = "txt_PizzaFiyati";
            this.txt_PizzaFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_PizzaFiyati.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(26, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizza Fiyatı";
            // 
            // btn_ResimEkle
            // 
            this.btn_ResimEkle.Location = new System.Drawing.Point(78, 254);
            this.btn_ResimEkle.Name = "btn_ResimEkle";
            this.btn_ResimEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_ResimEkle.TabIndex = 7;
            this.btn_ResimEkle.Text = "Dosya Seç";
            this.btn_ResimEkle.UseVisualStyleBackColor = true;
            this.btn_ResimEkle.Click += new System.EventHandler(this.btn_ResimEkle_Click);
            // 
            // txt_ImageUrl
            // 
            this.txt_ImageUrl.Location = new System.Drawing.Point(37, 226);
            this.txt_ImageUrl.Name = "txt_ImageUrl";
            this.txt_ImageUrl.Size = new System.Drawing.Size(154, 20);
            this.txt_ImageUrl.TabIndex = 8;
            // 
            // btn_PizzaKaydet
            // 
            this.btn_PizzaKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btn_PizzaKaydet.Location = new System.Drawing.Point(254, 315);
            this.btn_PizzaKaydet.Name = "btn_PizzaKaydet";
            this.btn_PizzaKaydet.Size = new System.Drawing.Size(138, 36);
            this.btn_PizzaKaydet.TabIndex = 9;
            this.btn_PizzaKaydet.Text = "Pizzayı Kaydet";
            this.btn_PizzaKaydet.UseVisualStyleBackColor = false;
            this.btn_PizzaKaydet.Click += new System.EventHandler(this.btn_PizzaKaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 153);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(251, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "İçindekiler";
            // 
            // txt_Icindekiler
            // 
            this.txt_Icindekiler.Location = new System.Drawing.Point(254, 126);
            this.txt_Icindekiler.Multiline = true;
            this.txt_Icindekiler.Name = "txt_Icindekiler";
            this.txt_Icindekiler.Size = new System.Drawing.Size(138, 151);
            this.txt_Icindekiler.TabIndex = 12;
            // 
            // frm_PizzaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 423);
            this.Controls.Add(this.txt_Icindekiler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_PizzaKaydet);
            this.Controls.Add(this.txt_ImageUrl);
            this.Controls.Add(this.btn_ResimEkle);
            this.Controls.Add(this.txt_PizzaFiyati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PizzaAdi);
            this.Controls.Add(this.label1);
            this.Name = "frm_PizzaEkle";
            this.Text = "PizzaEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PizzaAdi;
        private System.Windows.Forms.TextBox txt_PizzaFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ResimEkle;
        private System.Windows.Forms.TextBox txt_ImageUrl;
        private System.Windows.Forms.Button btn_PizzaKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Icindekiler;
    }
}
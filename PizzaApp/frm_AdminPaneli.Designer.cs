namespace PizzaApp
{
    partial class frm_AdminPaneli
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
            this.components = new System.ComponentModel.Container();
            this.btn_KayitliMusteriler = new System.Windows.Forms.Button();
            this.btn_Urunler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_KayitliMusteriler
            // 
            this.btn_KayitliMusteriler.Location = new System.Drawing.Point(356, 35);
            this.btn_KayitliMusteriler.Name = "btn_KayitliMusteriler";
            this.btn_KayitliMusteriler.Size = new System.Drawing.Size(190, 52);
            this.btn_KayitliMusteriler.TabIndex = 0;
            this.btn_KayitliMusteriler.Text = "Kayıtlı Müşteriler";
            this.btn_KayitliMusteriler.UseVisualStyleBackColor = true;
            this.btn_KayitliMusteriler.Click += new System.EventHandler(this.btn_KayitliMusteriler_Click);
            // 
            // btn_Urunler
            // 
            this.btn_Urunler.Location = new System.Drawing.Point(570, 35);
            this.btn_Urunler.Name = "btn_Urunler";
            this.btn_Urunler.Size = new System.Drawing.Size(190, 52);
            this.btn_Urunler.TabIndex = 2;
            this.btn_Urunler.Text = "Ürünler";
            this.btn_Urunler.UseVisualStyleBackColor = true;
            this.btn_Urunler.Click += new System.EventHandler(this.btn_Urunler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 276);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mevcut Siparişler";
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Urunler);
            this.Controls.Add(this.btn_KayitliMusteriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminPaneli";
            this.Text = "Admin Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_KayitliMusteriler;
        private System.Windows.Forms.Button btn_Urunler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Label label1;
    }
}
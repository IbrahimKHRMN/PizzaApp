namespace PizzaApp
{
    partial class frm_Urunler
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
            this.btn_UrunEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıcindekilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ımageUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzalarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaAppDataSet1 = new PizzaApp.PizzaAppDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AdminPanelineDon = new System.Windows.Forms.Button();
            this.pizzalarsTableAdapter = new PizzaApp.PizzaAppDataSet1TableAdapters.PizzalarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzalarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaAppDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.Location = new System.Drawing.Point(583, 97);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(190, 68);
            this.btn_UrunEkle.TabIndex = 0;
            this.btn_UrunEkle.Text = "Yeni Ürün Ekle";
            this.btn_UrunEkle.UseVisualStyleBackColor = true;
            this.btn_UrunEkle.Click += new System.EventHandler(this.btn_UrunEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.pizzaAdiDataGridViewTextBoxColumn,
            this.pizzaFiyatiDataGridViewTextBoxColumn,
            this.ıcindekilerDataGridViewTextBoxColumn,
            this.ımageUrlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pizzalarsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 241);
            this.dataGridView1.TabIndex = 1;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pizzaAdiDataGridViewTextBoxColumn
            // 
            this.pizzaAdiDataGridViewTextBoxColumn.DataPropertyName = "PizzaAdi";
            this.pizzaAdiDataGridViewTextBoxColumn.HeaderText = "PizzaAdi";
            this.pizzaAdiDataGridViewTextBoxColumn.Name = "pizzaAdiDataGridViewTextBoxColumn";
            // 
            // pizzaFiyatiDataGridViewTextBoxColumn
            // 
            this.pizzaFiyatiDataGridViewTextBoxColumn.DataPropertyName = "PizzaFiyati";
            this.pizzaFiyatiDataGridViewTextBoxColumn.HeaderText = "PizzaFiyati";
            this.pizzaFiyatiDataGridViewTextBoxColumn.Name = "pizzaFiyatiDataGridViewTextBoxColumn";
            // 
            // ıcindekilerDataGridViewTextBoxColumn
            // 
            this.ıcindekilerDataGridViewTextBoxColumn.DataPropertyName = "Icindekiler";
            this.ıcindekilerDataGridViewTextBoxColumn.HeaderText = "Icindekiler";
            this.ıcindekilerDataGridViewTextBoxColumn.Name = "ıcindekilerDataGridViewTextBoxColumn";
            // 
            // ımageUrlDataGridViewTextBoxColumn
            // 
            this.ımageUrlDataGridViewTextBoxColumn.DataPropertyName = "ImageUrl";
            this.ımageUrlDataGridViewTextBoxColumn.HeaderText = "ImageUrl";
            this.ımageUrlDataGridViewTextBoxColumn.Name = "ımageUrlDataGridViewTextBoxColumn";
            // 
            // pizzalarsBindingSource
            // 
            this.pizzalarsBindingSource.DataMember = "Pizzalars";
            this.pizzalarsBindingSource.DataSource = this.pizzaAppDataSet1;
            // 
            // pizzaAppDataSet1
            // 
            this.pizzaAppDataSet1.DataSetName = "PizzaAppDataSet1";
            this.pizzaAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürünler";
            // 
            // btn_AdminPanelineDon
            // 
            this.btn_AdminPanelineDon.Location = new System.Drawing.Point(306, 374);
            this.btn_AdminPanelineDon.Name = "btn_AdminPanelineDon";
            this.btn_AdminPanelineDon.Size = new System.Drawing.Size(190, 64);
            this.btn_AdminPanelineDon.TabIndex = 3;
            this.btn_AdminPanelineDon.Text = "Admin Paneline Dön";
            this.btn_AdminPanelineDon.UseVisualStyleBackColor = true;
            this.btn_AdminPanelineDon.Click += new System.EventHandler(this.btn_AdminPanelineDon_Click);
            // 
            // pizzalarsTableAdapter
            // 
            this.pizzalarsTableAdapter.ClearBeforeFill = true;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AdminPanelineDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_UrunEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Urunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzalarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaAppDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UrunEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AdminPanelineDon;
        private PizzaAppDataSet1 pizzaAppDataSet1;
        private System.Windows.Forms.BindingSource pizzalarsBindingSource;
        private PizzaAppDataSet1TableAdapters.PizzalarsTableAdapter pizzalarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıcindekilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ımageUrlDataGridViewTextBoxColumn;
    }
}
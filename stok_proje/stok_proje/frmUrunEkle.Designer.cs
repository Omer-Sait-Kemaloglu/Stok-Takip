namespace stok_proje
{
    partial class frmUrunEkle
    {
        private const string V = "Ürün Ekleme Sayfası";
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnYeniÜrünEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.txtSatışFiyati = new System.Windows.Forms.TextBox();
            this.txtAlışFiyati = new System.Windows.Forms.TextBox();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.btnVarOlanaEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SatışFiyatitxt = new System.Windows.Forms.TextBox();
            this.AlışFiyatitxt = new System.Windows.Forms.TextBox();
            this.Miktaritxt = new System.Windows.Forms.TextBox();
            this.UrunAditxt = new System.Windows.Forms.TextBox();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.BarkodNotxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnYeniÜrünEkle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboMarka);
            this.groupBox1.Controls.Add(this.comboKategori);
            this.groupBox1.Controls.Add(this.txtSatışFiyati);
            this.groupBox1.Controls.Add(this.txtAlışFiyati);
            this.groupBox1.Controls.Add(this.txtMiktari);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.txtBarkodNo);
            this.groupBox1.Location = new System.Drawing.Point(51, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Satış Fiyatı";
            // 
            // btnYeniÜrünEkle
            // 
            this.btnYeniÜrünEkle.Location = new System.Drawing.Point(121, 396);
            this.btnYeniÜrünEkle.Name = "btnYeniÜrünEkle";
            this.btnYeniÜrünEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniÜrünEkle.TabIndex = 2;
            this.btnYeniÜrünEkle.Text = "Ekle";
            this.btnYeniÜrünEkle.UseVisualStyleBackColor = true;
            this.btnYeniÜrünEkle.Click += new System.EventHandler(this.btnYeniÜrünEkle_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kateegori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "BarkodNo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(165, 135);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(100, 24);
            this.comboMarka.TabIndex = 6;
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(165, 86);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(100, 24);
            this.comboKategori.TabIndex = 5;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged_1);
            // 
            // txtSatışFiyati
            // 
            this.txtSatışFiyati.Location = new System.Drawing.Point(165, 325);
            this.txtSatışFiyati.Name = "txtSatışFiyati";
            this.txtSatışFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtSatışFiyati.TabIndex = 4;
            this.txtSatışFiyati.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtAlışFiyati
            // 
            this.txtAlışFiyati.Location = new System.Drawing.Point(165, 278);
            this.txtAlışFiyati.Name = "txtAlışFiyati";
            this.txtAlışFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtAlışFiyati.TabIndex = 3;
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(165, 231);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(100, 22);
            this.txtMiktari.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(165, 184);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 1;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(165, 39);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 22);
            this.txtBarkodNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMiktari);
            this.groupBox2.Controls.Add(this.btnVarOlanaEkle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.SatışFiyatitxt);
            this.groupBox2.Controls.Add(this.AlışFiyatitxt);
            this.groupBox2.Controls.Add(this.Miktaritxt);
            this.groupBox2.Controls.Add(this.UrunAditxt);
            this.groupBox2.Controls.Add(this.Markatxt);
            this.groupBox2.Controls.Add(this.Kategoritxt);
            this.groupBox2.Controls.Add(this.BarkodNotxt);
            this.groupBox2.Location = new System.Drawing.Point(407, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 449);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Var Olan Ürün";
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(60, 386);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 16);
            this.lblMiktari.TabIndex = 21;
            // 
            // btnVarOlanaEkle
            // 
            this.btnVarOlanaEkle.Location = new System.Drawing.Point(184, 383);
            this.btnVarOlanaEkle.Name = "btnVarOlanaEkle";
            this.btnVarOlanaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnVarOlanaEkle.TabIndex = 3;
            this.btnVarOlanaEkle.Text = "Ekle";
            this.btnVarOlanaEkle.UseVisualStyleBackColor = true;
            this.btnVarOlanaEkle.Click += new System.EventHandler(this.btnVarOlanaEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Kateegori";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "BarkodNo";
            // 
            // SatışFiyatitxt
            // 
            this.SatışFiyatitxt.Location = new System.Drawing.Point(172, 306);
            this.SatışFiyatitxt.Name = "SatışFiyatitxt";
            this.SatışFiyatitxt.Size = new System.Drawing.Size(100, 22);
            this.SatışFiyatitxt.TabIndex = 6;
            // 
            // AlışFiyatitxt
            // 
            this.AlışFiyatitxt.Location = new System.Drawing.Point(172, 261);
            this.AlışFiyatitxt.Name = "AlışFiyatitxt";
            this.AlışFiyatitxt.Size = new System.Drawing.Size(100, 22);
            this.AlışFiyatitxt.TabIndex = 5;
            // 
            // Miktaritxt
            // 
            this.Miktaritxt.Location = new System.Drawing.Point(172, 216);
            this.Miktaritxt.Name = "Miktaritxt";
            this.Miktaritxt.Size = new System.Drawing.Size(100, 22);
            this.Miktaritxt.TabIndex = 4;
            // 
            // UrunAditxt
            // 
            this.UrunAditxt.Location = new System.Drawing.Point(172, 171);
            this.UrunAditxt.Name = "UrunAditxt";
            this.UrunAditxt.Size = new System.Drawing.Size(100, 22);
            this.UrunAditxt.TabIndex = 3;
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(172, 126);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.Size = new System.Drawing.Size(100, 22);
            this.Markatxt.TabIndex = 2;
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(172, 81);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.Size = new System.Drawing.Size(100, 22);
            this.Kategoritxt.TabIndex = 1;
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(172, 36);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(100, 22);
            this.BarkodNotxt.TabIndex = 0;
            this.BarkodNotxt.TextChanged += new System.EventHandler(this.BarkodNotxt_TextChanged);
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Ekleme Sayfasi";
            this.Load += new System.EventHandler(this.frmÜrünEkle_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSatışFiyati;
        private System.Windows.Forms.TextBox txtAlışFiyati;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SatışFiyatitxt;
        private System.Windows.Forms.TextBox AlışFiyatitxt;
        private System.Windows.Forms.TextBox Miktaritxt;
        private System.Windows.Forms.TextBox UrunAditxt;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.Button btnYeniÜrünEkle;
        private System.Windows.Forms.Button btnVarOlanaEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMiktari;
    }
}
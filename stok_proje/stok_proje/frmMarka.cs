﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace stok_proje
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Stok1_Takip;Integrated Security=True");

        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from marka", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["kategori"].ToString() && textBox1.Text == read["marka"].ToString() || comboBox1.Text == "" || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into marka(kategori,marka) values( '" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori ve marka var","Uyarı");
            }

           
            textBox1.Text = "";
            comboBox1.Text = "";
           
        }
        private void kategorigetir()
        {
        baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
    baglanti.Close();
        }
        private void frmMarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
    }
}

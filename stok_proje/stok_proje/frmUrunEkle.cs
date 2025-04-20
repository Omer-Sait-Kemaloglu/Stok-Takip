using System;
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
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace stok_proje
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Stok1_Takip;Integrated Security=True");

        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("select *from ürün", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString() || txtBarkodNo.Text == ""   )
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniÜrünEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into ürün(barkodno, kategori, marka, urunadi, miktari, alisfiyati, satisfiyati, tarih) values(@barkodno, @kategori, @marka, @urunadi, @miktari, @alisfiyati, @satisfiyati, @tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlışFiyati.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyati.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(Text);
            }
            else
            {
                MessageBox.Show("Böyle bir barkod var","Uyarı");
            }

           

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select  *from marka where kategori='"+comboKategori.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void frmÜrünEkle_Load_1(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void btnYeniÜrünEkle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open() ;
            SqlCommand komut = new SqlCommand("insert into ürün(barkodno, kategori, marka, urunadi, miktarı, alisfiyati, satisfiyati, tarih ) values(@barkodno, @kategori, @marka, @urunadi, @miktarı, @alisfiyati, @satisfiyati, @tarih) ", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
            komut.Parameters.AddWithValue("@marka", comboMarka.Text);
            komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@miktarı", txtMiktari.Text);
            komut.Parameters.AddWithValue("@alisfiyati", txtAlışFiyati.Text);
            komut.Parameters.AddWithValue("@satisfiyati", txtSatışFiyati.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün eklendi");
            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls )
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text== "")
            {
                lblMiktari.Text = "";
                foreach (Control item in groupBox2.Controls )
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from ürün where barkodno like '"+BarkodNotxt.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            { 
                Kategoritxt.Text = read["kategori"].ToString();
                Markatxt.Text = read["marka"].ToString();
                UrunAditxt.Text = read["urunadi"].ToString();
                lblMiktari.Text = read["miktarı"].ToString();
                AlışFiyatitxt.Text = read["alisfiyati"].ToString();
                SatışFiyatitxt.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();

        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update ürün set miktarı=miktarı+ '" + int.Parse(Miktaritxt.Text) + "' where barkodno='" + BarkodNotxt.Text + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı");
        }
    }
}

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

namespace stok_proje
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Stok1_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet",baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from sepet", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("urun sepetten çikarildi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            var Listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUrunEkle ekle = new frmUrunEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmUrunListele listele = new frmUrunListele();
            listele.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                lblGenelToplam.Text = cmd.ExecuteScalar() + "TL";
                baglanti.Close();


            }
            catch (Exception)
            {

                ;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text=="")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from müsteri1 where tc like '"+txtTc.Text+"'",baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from ürün where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtUrunAdi.Text = read["urunadi"].ToString();
                txtSatisFiyati.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktari)
                        {
                            item.Text = "";
                        }
                    }


                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;   
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from sepet",baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close() ;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into sepet(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyati, tarih) values(@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyati, @tarih)", baglanti);
                cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                cmd.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
                cmd.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd2 = new SqlCommand("update sepet miktari=miktari+'"+int.Parse(txtMiktari.Text)+ "'where barkodno'"+txtBarkodNo.Text+"'", baglanti);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("update sepet toplamfiyat=miktari * satisfiyati where barkodno'"+txtBarkodNo.Text+"'", baglanti);
                cmd3.ExecuteNonQuery();

                baglanti.Close();
            }

           
            txtMiktari.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktari)
                    {
                        item.Text = "";
                    }
                }
                baglanti.Close();

            }
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from sepet where barkodno= '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() +"'",baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("urun sepetten çikarildi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatisListele listele = new frmSatisListele();
            listele.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into satis(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyati, tarih) values(@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyati, @tarih)", baglanti);
                cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                cmd.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                cmd.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                cmd.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
               
                SqlCommand cmd2 = new SqlCommand("update ürün set miktarı=miktarı- '" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "' ", baglanti);
                cmd2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("delete from sepet", baglanti);
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            MessageBox.Show("Urun satildi");
        }
    }
}

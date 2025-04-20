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
    public partial class frmUrunListele : Form
    {
        public frmUrunListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Stok1_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            UrunListele();
            kategorigetir();

        }

        private void UrunListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ürün", baglanti);
            adtr.Fill(daset,"urunadi");
            dataGridView1.DataSource = daset.Tables["urunadi"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            UrunAditxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktaritxt.Text = dataGridView1.CurrentRow.Cells["miktarı"].Value.ToString();
            AlisFiyatitxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatisFiyatitxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update ürün set urunadi=@urunadi, miktarı=@miktarı, alisfiyati=@alisfiyati, satisfiyati=@satisfiyati where barkodno=@barkodno",baglanti);
            cmd.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
            cmd.Parameters.AddWithValue("@urunadi", UrunAditxt.Text);
            cmd.Parameters.AddWithValue("@miktarı", int.Parse(Miktaritxt.Text));
            cmd.Parameters.AddWithValue("@alisfiyati", double.Parse (AlisFiyatitxt.Text));
            cmd.Parameters.AddWithValue("@satisfiyati", double.Parse( SatisFiyatitxt.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urunadi"].Clear();
            UrunListele();
            MessageBox.Show("Guncelleme yapildi");
            foreach  (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text!="")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update urun set kategori=@kategori, marka=@marka where barkodno=@barkodno", baglanti);
                cmd.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                cmd.Parameters.AddWithValue("@kategori", comboKategori.Text);
                cmd.Parameters.AddWithValue("@marka", comboMarka.Text);

                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Guncelleme yapildi");
                daset.Tables["urun"].Clear();
                UrunListele();
            }
            else
            {
                MessageBox.Show("Barkodno yazılı degil");
            }

           
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select  *from marka where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from ürün where barkodno ='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urunadi"].Clear();
            UrunListele();
            MessageBox.Show("Kayıt silindi");
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from ürün where barkodno like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}

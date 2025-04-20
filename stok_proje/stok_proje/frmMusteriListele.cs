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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Stok1_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        

        private void Kayit_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from müsteri1", baglanti);
            adtr.Fill(daset, "müsteri1");
            dataGridView1.DataSource = daset.Tables["müsteri1"];
            baglanti.Close();
        }
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            Kayit_Göster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müsteri1 set adsoyad=@adsoyad, telefon=@telefon, adres=@adres, email=@email where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTcc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            komut.Parameters.AddWithValue("@telefon", textBox3.Text);
            komut.Parameters.AddWithValue("@adres", textBox4.Text);
            komut.Parameters.AddWithValue("@email", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müsteri1"].Clear();
            Kayit_Göster();
            MessageBox.Show("musteri kaydı güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from müsteri1 where tc='"+ dataGridView1.CurrentRow.Cells["tc"].Value.ToString() +"'",baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müsteri1"].Clear();
            Kayit_Göster();
            MessageBox.Show("Kayıt silindi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable(); 
            baglanti.Open();
            SqlDataAdapter adtr  = new SqlDataAdapter("select *from müsteri1 where tc like '%"+txtTcAra.Text+"%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtTcc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_SERVER_DEVAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kütüphane;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Id", 100);
            listView1.Columns.Add("KitapAdı", 200);
            listView1.Columns.Add("Yazar", 200);
            listView1.Columns.Add("Yayınevi", 200);
            listView1.Columns.Add("Sayfa No", 200);
        }
        private void VerileriListele()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from kitaplar", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["kitapad"].ToString());
                ekle.SubItems.Add(oku["yazar"].ToString());
                ekle.SubItems.Add(oku["yayınevi"].ToString());
                ekle.SubItems.Add(oku["sayfa"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void Btn_listele_Click(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into kitaplar (id,kitapad,yazar,yayınevi,sayfa) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("Yeni Kayıt Eklendi...");
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "")
            {
                MessageBox.Show("Alanlar boş iken yeni kayıt oluşturulamaz!");
            }
            baglan.Close();
            VerileriListele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sil = listView1.SelectedItems[0].Text;
            SqlCommand komut = new SqlCommand("Delete from kitaplar where id='" + sil + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            VerileriListele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            //Verilerimizi güncellemek için textbox' daki değerlerimizi değiştirip güncelle tuşunu basıyoruz(id haric çünkü id'ye göre arama yapıyoruz)
            baglan.Open();
            SqlCommand komut = new SqlCommand("update kitaplar set id='" + textBox1.Text + "',kitapad='" + textBox2.Text + "',yazar='" + textBox3.Text + "',yayınevi='" + textBox4.Text + "',sayfa='" + textBox5.Text + "' where id='" + textBox1.Text + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            VerileriListele();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            //Veri tabanımızı güncellemek için listview'de seçtiğimiz itemlere tıkladığımızda textbox içerisine atıyoruz.
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[0].Text;
                textBox2.Text = item.SubItems[1].Text;
                textBox3.Text = item.SubItems[2].Text;
                textBox4.Text = item.SubItems[3].Text;
                textBox5.Text = item.SubItems[4].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            int srg = int.Parse(textBox6.Text);
            SqlCommand komut = new SqlCommand("Select * From kitaplar where id like '%" + srg + "%'", baglan);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Araması Tamamlandı.");
            baglan.Close();
            VerileriListele();
        }
    }
}

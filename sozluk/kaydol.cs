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

namespace sozluk
{
    public partial class kaydol : Form
    {


        SqlConnection baglanti = new SqlConnection("Data Source=camelia;Initial Catalog=sozluk;Integrated Security=true");
        public kaydol()
        {
            InitializeComponent();
        }

        private void kaydol_Load(object sender, EventArgs e)
        {
           



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != textBox3.Text)
            {

                MessageBox.Show("Şifreniz eşleşmiyor");


            }
            
            else
            {


                SqlCommand emir = new SqlCommand("insert into Kullanici_Tablo values (@ad,@sifre)", baglanti);

                emir.Parameters.AddWithValue("@ad", textBox1.Text);

                emir.Parameters.AddWithValue("@sifre", textBox2.Text);
                baglanti.Open();

                emir.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Kayıdınız Yapılmıştır");




            }
            
            
            
            
           
        }
    }
}

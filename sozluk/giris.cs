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
    public partial class giris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=camelia;Initial Catalog=sozluk;Integrated Security=true");
        public giris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            kaydol a = new kaydol();

            this.Hide();

            a.ShowDialog();

        }

        private void giris_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlCommand getir = new SqlCommand("select Kullanici_id from Kullanici_Tablo where Kullanici_Ad = @ad and Kullanici_sifre = @sifre", baglanti);
             
            getir.Parameters.AddWithValue("@ad",textBox1.Text);

            getir.Parameters.AddWithValue("@sifre",textBox2.Text);

          
            baglanti.Open();

            int id = Convert.ToInt32(getir.ExecuteScalar()); // getir.executuscalarle id alınır ve int degere cevrilir




            if (id != 0)

            {

              
               
                sozluk a = new sozluk();

                this.Hide();

                a.ShowDialog();


            }




           
            else
            {
                MessageBox.Show("Yalnış Kullanıcı adı veya Şifre");
               
            }



           
           

           
                
            
            
          

           

          
               

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sozluk a = new sozluk();

            this.Hide();

            a.ShowDialog();
        }
    }
}

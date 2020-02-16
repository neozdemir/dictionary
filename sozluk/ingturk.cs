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
    public partial class sozluk2 : Form
    {


        SqlConnection baglanti = new SqlConnection("Data Source=camelia;Initial Catalog=sozluk;Integrated Security=true;");
        public sozluk2()
        {
            InitializeComponent();
        }

        private void ingilizceTürkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozluk2 a = new sozluk2();

            this.Hide();

            a.ShowDialog();
        }

        private void türkçeİngiliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozluk a = new sozluk();

            this.Hide();

            a.ShowDialog();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekle a = new ekle();

            this.Hide();

            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            SqlDataAdapter adaptor = new SqlDataAdapter("select anlam from ingturk_tablo where ingilizce = '" + textBox1.Text + "' ", baglanti);
            DataTable tablo = new DataTable();

            adaptor.Fill(tablo);


            dataGridView1.DataSource = tablo;


          

        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ekle2 a = new ekle2();
            this.Hide();

            a.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {


           

            SqlDataAdapter adaptor = new SqlDataAdapter("select cumle from ingturk_tablo where ingilizce = '" + textBox1.Text + "' ", baglanti);
            DataTable tablo = new DataTable();

            adaptor.Fill(tablo);


            dataGridView2.DataSource = tablo;
            dataGridView2.Visible = true;


        }

       
       

        private void mediaPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muzik a = new muzik();

            this.Hide();

            a.ShowDialog();
        }

        private void zarAtmacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zar m = new zar();

            this.Hide();

            m.ShowDialog();
        }

        private void sayıTahminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayitahmin s = new sayitahmin();

            this.Hide();

            s.ShowDialog();
       }
        
        private void playSound(string path)
              {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                
                player.SoundLocation = path;
                player.Load();
                player.Play();
              }

        private void sozluk2_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand emir = new SqlCommand("select  top(1) ses_yol from ingturk_tablo where ingilizce= '" + textBox1.Text + "' ", baglanti);
                baglanti.Open();

                SqlDataReader oku = emir.ExecuteReader();

                while (oku.Read())
                {


                    playSound(oku.GetString(0));

                }


                baglanti.Close();


            }
           
            catch(Exception)
            {

                


            }

           
            
           
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web w = new web();

            this.Hide();

            w.ShowDialog();
        }

        private void atYarışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atyarisi a = new atyarisi();
            this.Hide();

            a.ShowDialog();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozluk a = new sozluk();

            this.Close();

           
        }
    
       
    }
}

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
    public partial class sozluk : Form
    {
       
        SqlConnection baglanti = new SqlConnection("Data Source=camelia;Initial Catalog=sozluk;Integrated Security=true;");
        public sozluk()
        {
            InitializeComponent();
           
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void türkçeİngilizceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sozluk a = new sozluk();
            this.Hide();

            a.ShowDialog();
        }

        private void ingilizceTürkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozluk2 b = new sozluk2();

            this.Hide();

            b.ShowDialog();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ekle a = new ekle();

            this.Hide();


            a.ShowDialog();

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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adaptor = new SqlDataAdapter("select meaning from turking_tablo where turkce = '" + textBox1.Text + "' ", baglanti);
            DataTable tablo = new DataTable();

            adaptor.Fill(tablo);


            dataGridView1.DataSource = tablo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adaptor = new SqlDataAdapter("select cumle from turking_tablo where turkce = '" + textBox1.Text + "' ", baglanti);
            DataTable tablo = new DataTable();

            adaptor.Fill(tablo);


            dataGridView2.DataSource = tablo;
            dataGridView2.Visible = true;

           
        }

        private void sozluk_Load(object sender, EventArgs e)
        {
            
        }

        private void müzikToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

       

        private void mediaPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muzik a = new muzik();

            this.Hide();

            a.ShowDialog();


        }

        private void zarAtmacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zar z = new zar();

            this.Hide();

            z.ShowDialog();
        }

        private void sayıTahminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayitahmin s = new sayitahmin();

            this.Hide();

            s.ShowDialog();
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
            sozluk2 a = new sozluk2();
            this.Close();
        }


       
    }
}

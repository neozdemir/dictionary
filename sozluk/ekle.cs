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
    public partial class ekle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data source= camelia;Initial Catalog=sozluk;Integrated Security=true;");

        public ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand emir = new SqlCommand("insert into ingturk_tablo (ingilizce,anlam) values(@ing,@anlam)",baglanti);
            emir.Parameters.AddWithValue("@ing", textBox1.Text);

            emir.Parameters.AddWithValue("@anlam", textBox2.Text);

            baglanti.Open();

            emir.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("ekleme gerçekleşti");



        }

        private void sözlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozluk a = new sozluk();

            this.Hide();

            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

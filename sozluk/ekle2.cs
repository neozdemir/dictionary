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
    public partial class ekle2 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data source= camelia;Initial Catalog=sozluk;Integrated Security=true;");
        public ekle2()
        {
            InitializeComponent();
        }

        private void sözlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozluk2 a = new sozluk2();
            this.Hide();

            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand emir = new SqlCommand("insert into turking_tablo (turkce,meaning) values(@tur,@mean)", baglanti);
            emir.Parameters.AddWithValue("@tur", textBox1.Text);

            emir.Parameters.AddWithValue("@mean", textBox2.Text);

            baglanti.Open();

            emir.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("ekleme gerçekleşti");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozluk
{
    public partial class zar : Form
    {
        public zar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int zar1, zar2;

            Random r = new Random();

            zar1 = r.Next(1, 7);
            pictureBox1.ImageLocation = "C:\\zar\\zar" + zar1.ToString() + ".png";

            zar2 = r.Next(1, 7);

            pictureBox2.ImageLocation = "C:\\zar\\zar" + zar2.ToString() + ".png";

           


        }

        private void sözlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozluk a = new sozluk();

            this.Hide();

            a.ShowDialog();
        }
    }
}

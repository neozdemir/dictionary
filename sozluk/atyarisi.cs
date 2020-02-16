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
    public partial class atyarisi : Form
    {
        public atyarisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           

            Random r = new Random();

            int at1 = r.Next(10, 100);

            pictureBox1.Location = new Point(pictureBox1.Location.X + at1, pictureBox1.Location.Y);


            int at2 = r.Next(10, 100);

            pictureBox2.Location = new Point(pictureBox2.Location.X + at2, pictureBox2.Location.Y);


            int at3 = r.Next(10, 100);

            pictureBox3.Location = new Point(pictureBox3.Location.X + at3, pictureBox3.Location.Y);

            int at4 = r.Next(10, 100);

            pictureBox4.Location = new Point(pictureBox4.Location.X + at4, pictureBox4.Location.Y);

            int at5 = r.Next(10, 100);

            pictureBox5.Location = new Point(pictureBox5.Location.X + at5, pictureBox5.Location.Y);


           if(pictureBox1.Location.X>590)
           {
               
               timer1.Stop();
               MessageBox.Show("1 ci At kazandı");


           }



           else if (pictureBox2.Location.X > 590)
           {
              
               timer1.Stop();

               MessageBox.Show("2 ci At kazandı");

           }


           else  if (pictureBox3.Location.X > 590)
           {
              
               timer1.Stop();
               MessageBox.Show("3 cü At kazandı");


           }

          else if (pictureBox4.Location.X > 590)
           {
               
               timer1.Stop();

               MessageBox.Show("4 ci At kazandı");

           }


         else  if (pictureBox5.Location.X > 590)
           {
               
               timer1.Stop();

               MessageBox.Show("5 ci At kazandı");

           }






        }

        private void yenidenBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atyarisi a = new atyarisi();
            this.Hide();
            a.ShowDialog();
        }

        private void sözlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozluk s = new sozluk();

            this.Hide();

            s.ShowDialog();
        }
    }
}

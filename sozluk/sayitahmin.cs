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
    public partial class sayitahmin : Form
    {
        int tutturmasayisi = 0;
        public sayitahmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool aynimi = false;



            if(Convert.ToInt32(maskedTextBox1.Text)<30)
            {


                foreach(object gez in listBox1.Items)
                {

                    if(gez.ToString()==maskedTextBox1.Text)
                    {

                        aynimi = true;



                    }

                  

                }
               
                if (aynimi == false)
                {

                    listBox1.Items.Add(maskedTextBox1.Text);

                    maskedTextBox1.Text = "";




                }





                if(listBox1.Items.Count==6)
                {

                    button1.Enabled = false;

                    button2.Enabled = true;




                }



            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)  
            {
                listView2.Items.Add(listBox1.Items[i].ToString());
            }
            
            Random yeni = new Random();

            int RastgeleSayi = yeni.Next(1, 29);
            int[] FarkliSayilariTut = new int[6];
            FarkliSayilariTut[0] = RastgeleSayi;


            for (int i = 1; i < FarkliSayilariTut.Length; i++)
            {
                RastgeleSayi = yeni.Next(1, 29);
                for (int j = 0; j < i; j++)
                {
                    if (FarkliSayilariTut[j] == RastgeleSayi)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        FarkliSayilariTut[i] = RastgeleSayi;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                Array.Sort(FarkliSayilariTut);
                listView1.Items.Add(FarkliSayilariTut[i].ToString());


            }

            


            for (int i = 0; i < 6; i++)  
            {

                for (int j = 0; j < 6; j++)
                {

                    if (listView1.Items[j].Text == listView2.Items[i].Text)
                    {

                        tutturmasayisi++;


                    }

                }

                label3.Visible = true;
                label3.Text =  tutturmasayisi + " sayı tutturdunuz";
                pictureBox1.Visible = true;

            }

        }

        private void sözlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozluk a = new sozluk();

            this.Hide();

            a.ShowDialog();
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listView1.Clear();

            listView2.Clear();

            button1.Enabled = true;
            button2.Enabled = false;

            label3.Text = "";
            pictureBox1.Visible = false;
        }
    }
}

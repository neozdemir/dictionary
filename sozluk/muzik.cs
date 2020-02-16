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
    public partial class muzik : Form
    {
        public muzik()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Open";

            open.Filter = "All Files|*.*";

            try
            {

                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {


                    axWindowsMediaPlayer1.URL = (open.FileName);

                }
                   



            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());



            }


        }
    }
}

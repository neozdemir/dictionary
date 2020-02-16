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
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url;

            url = textBox1.Text.Replace("http://www.", "");

            webBrowser1.Url = new Uri("http://www." + url);

            webBrowser1.ScriptErrorsSuppressed = false;
        }
    }
}

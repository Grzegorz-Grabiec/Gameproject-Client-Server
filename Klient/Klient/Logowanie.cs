using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klient.Serwer;
namespace Klient
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }
        public string Nick { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Nick = textBox1.Text;
            Close();
          
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarkovOverlay
{
    public partial class dev : Form
    {
        public dev()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.TopMost = !f1.TopMost;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void outputConsole(string Type, string Message)
        {
            textBox1.AppendText(Environment.NewLine + Type + ": " + Message);
        }
    }
}

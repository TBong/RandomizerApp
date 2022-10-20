using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomizerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtGen_Click(object sender, EventArgs e)
        {
            int from = Int32.Parse(textBox1.Text);
            int to = Int32.Parse(textBox2.Text);

            Random rnd = new Random();

            int res = rnd.Next(from, to+1);

            result.Text  = res.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

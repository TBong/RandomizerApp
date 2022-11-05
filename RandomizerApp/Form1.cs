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
            iscl.Visible = false;

        }
        private void ButtGen_Click(object sender, EventArgs e)
        {
            int from = Int32.Parse(textBox1.Text);
            int to = Int32.Parse(textBox2.Text);
            Random rnd = new Random();
            int ch = -1;
            int res = rnd.Next(from, to + 1);
            if (ch != 0)
            {
                int isclNum = Int32.Parse(iscl.Text);
                ch = isclNum;
                if (res == isclNum)
                {

                }
                else
                {
                    result.Text = res.ToString();
                }
            }

            else
            {
                result.Text = res.ToString();
            }
            return;

                
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (iscl.Visible == false)
            {
                iscl.Visible = true;
            }

            else
            {
                iscl.Visible = false;
            }
        }
    }
}

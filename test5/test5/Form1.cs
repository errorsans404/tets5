using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 20 || textBox1.Text.Length > 75)
            {
                button1.Text = "автор";
                return;
            }

            if (textBox2.Text.Length < 10 || textBox2.Text.Length > 100)
            {
                button1.Text = "название";
                return;
            }

            try
            {
                int x = Int32.Parse(textBox3.Text);
                if (x < 0)
                {
                    button1.Text = "-";
                    return;
                }

                if (textBox3.Text.Length != 4)
                {
                    button1.Text = "-4";
                    return;
                }
            }

            catch(Exception ex)
            {
                button1.Text = ".";
                return;
            }
        }
    }
}

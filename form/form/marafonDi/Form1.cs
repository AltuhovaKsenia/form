using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox11.Text);
            double b = Convert.ToInt32(textBox12.Text);
            double c = a / 100;
            double bmi = b / (c * c);
            if (bmi < 10)
            { trackBar1.Value = 0;
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox7.Visible = false;

            }
            else if ((bmi > 11)&& (bmi < 19))
            { trackBar1.Value = 4;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox7.Visible = false;
            }
            else if ((bmi > 20) && (bmi < 25))
            { trackBar1.Value = 6;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox7.Visible = true;
            }
            else
            { trackBar1.Value = 9;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                pictureBox7.Visible = false;
            }

            textBox13.Text = Convert.ToString(bmi);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

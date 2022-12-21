using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace milk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox6.Clear();
            textBox8.Clear();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox11.Text);
            double b = Convert.ToInt32(textBox6.Text);
            double c = Convert.ToInt32(textBox8.Text);
            double bmr = 66 + (13.7 * a) + (5 * b) - (6.8 * c);
            double sit = bmr * 1.2;
            double small = bmr * 1.375;
            double medium = bmr * 1.55;
            double hard = bmr * 1.725;
            double max = bmr * 1.9;

            textBox12.Text = Convert.ToString(bmr);
            textBox19.Text = Convert.ToString(sit);
            textBox20.Text = Convert.ToString(small);
            textBox21.Text = Convert.ToString(medium);
            textBox22.Text = Convert.ToString(hard);
            textBox23.Text = Convert.ToString(max);


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox11.Text);
            double b = Convert.ToInt32(textBox6.Text);
            double c = Convert.ToInt32(textBox8.Text);
            double bmr = 655 + (9.6 * a) + (1.8 * b) - (4.7 * c);
            double sit = bmr * 1.2;
            double small = bmr * 1.375;
            double medium = bmr * 1.55;
            double hard = bmr * 1.725;
            double max = bmr * 1.9;

            textBox12.Text = Convert.ToString(bmr);
            textBox19.Text = Convert.ToString(sit);
            textBox20.Text = Convert.ToString(small);
            textBox21.Text = Convert.ToString(medium);
            textBox22.Text = Convert.ToString(hard);
            textBox23.Text = Convert.ToString(max);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

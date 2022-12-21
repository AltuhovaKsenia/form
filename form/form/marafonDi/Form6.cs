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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form form7 = new Form7();
                form7.Show();
                this.Close();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

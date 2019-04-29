using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 n = new Form10();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 n = new Form3();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 n = new Form4();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 n = new Form5();
            n.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 n = new Form6();
            n.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 n = new Form7();
            n.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 n = new Form8();
            n.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 n = new Form9();
            n.Show();
        }
    }
}

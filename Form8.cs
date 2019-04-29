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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1,", "Рафиков Джамсут Бахрузович", "Таджикистан", "799765");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }
            }
        }
    }
}


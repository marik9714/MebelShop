﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1, "Диван", "да", 1500, "Курьером");
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
    }
}
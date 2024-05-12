using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridVIWE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createbutton();
        }
        private void createbutton()
        {
            for (int i = 0; i < 10; i++)
            {
                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(column);
                dataGridView1.Columns[i].Width = 25;
            }
            for (int i = 0; i < 9; i++)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows[i].Cells[i].Style.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) 
                { if (i < j) { dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red; }}
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { if (i > j) { dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red; } }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows[10 - 1 - i].Cells[i].Style.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { if (i < j) { dataGridView1.Rows[10 - i - 1].Cells[j].Style.BackColor = Color.Red; } }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { if (i > j) { dataGridView1.Rows[10 - i - 1].Cells[j].Style.BackColor = Color.Red; } }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                { dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red; }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 5; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red; }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                { dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red; }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 5; j < 10; j++)
                { dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red; }
            }
        }
    }
}

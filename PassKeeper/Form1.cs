﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(3);
            FillGrid();
            FillToSort();
        }

        private void FillToSort()
        {
            for(int i = 0; i< dataGridView2.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView2.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
                else
                    dataGridView2.Rows[i].Cells[0].Value = (i - 1).ToString();
            }
        }

        private void FillGrid()
        {
            Random rnd = new Random();
            int a;
            for (int r = 0; r < dataGridView2.RowCount; r++)
            {
                for (int c = 0; c < dataGridView2.ColumnCount; c++)
                {
                    a = rnd.Next();
                    //dataGridView2.Rows[r].Cells[c].Value = a;
                    //dataGridView2.Rows[r].Cells[c].Value = a.ToString("X");
                    dataGridView2.Rows[r].Cells[c].Value = 
                        a.ToString() + "=" + a.ToString("X");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Clear();
            //dataGridView2.Rows[0].Cells[0].Value = dataGridView2.Rows.Count.ToString();


            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Cells[1].Value = (i).ToString();
            }
        }

        
    }
}

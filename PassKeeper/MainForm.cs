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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Adding new Row
        private void AddNewRow()
        {
            // show edit form
            EditForm ef = new EditForm();
            DialogResult result = ef.ShowDialog();
            if (result == DialogResult.OK)
            {
                // add new row
                int n = dataGridView2.Rows.Add();
                // fill this row
                dataGridView2.Rows[n].Cells[0].Value = ef.Caption;
                dataGridView2.Rows[n].Cells[1].Value = ef.Login;
                dataGridView2.Rows[n].Cells[2].Value = ef.Password;
                dataGridView2.Rows[n].Cells[3].Value = ef.Comment;

                // sort by 
                dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Ascending);
            }
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

        
    }
}

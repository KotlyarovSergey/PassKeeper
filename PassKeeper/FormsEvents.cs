using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper
{
    partial class MainForm
    {
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(3);
            FillGrid();
            FillToSort();
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

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }

        private void editRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRow();
        }


        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        

        private void toolStripShowPass_Click(object sender, EventArgs e)
        {

        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            EditRow();
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }


        //private void contextMenuStripGrid_Click(object sender, EventArgs e)
        //{
        //    AddNewRow();
        //}
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}

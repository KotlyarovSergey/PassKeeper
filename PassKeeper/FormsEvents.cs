using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper
{
    partial class MainForm
    {
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

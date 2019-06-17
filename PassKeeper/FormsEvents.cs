using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;


namespace PassKeeper
{
    partial class MainForm
    {
        private void contextMenuStripGrid_Opening(object sender, CancelEventArgs e)
        {
            if (showAllPass || dataGridView2.CurrentRow == null ||
                dataGridView2.CurrentRow.Cells[2].Value == dataGridView2.CurrentRow.Cells[4].Value)
            {
                toolStripShowPass.Enabled = false;
            }
            else
            {
                toolStripShowPass.Enabled = true;
            }

            if (dataGridView2.CurrentRow == null)
            {
                toolStripEdit.Enabled = false;
                toolStripDelete.Enabled = false;
                toolStripCopy.Enabled = false;
            }
            else
            {
                toolStripEdit.Enabled = true;
                toolStripDelete.Enabled = true;
                toolStripCopy.Enabled = true;
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

        private void showPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentRow.Cells[2].Value =
                        dataGridView2.CurrentRow.Cells[4].Value;
        }


        private void toolStripShowPass_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentRow.Cells[2].Value =
                        dataGridView2.CurrentRow.Cells[4].Value;
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

        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (showAllPass || dataGridView2.CurrentRow == null ||
                dataGridView2.CurrentRow.Cells[2].Value == dataGridView2.CurrentRow.Cells[4].Value)
            {
                showPassToolStripMenuItem.Enabled = false;
            }
            else
            {
                showPassToolStripMenuItem.Enabled = true;
            }

            if (dataGridView2.CurrentRow == null)
            {
                editRowToolStripMenuItem.Enabled = false;
                deleteRowToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }
            else
            {
                editRowToolStripMenuItem.Enabled = true;
                deleteRowToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
            }
        }

        private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            //MessageBox.Show("MenuItem_DropDownOpening");
            if (showAllPass)
            {
                displayPassToolStripMenuItem.Text = "Скрыть пароли";
            }
            else
            {
                displayPassToolStripMenuItem.Text = "Отображать пароли";
            }
        }

        private void displayPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAllPass = !showAllPass;

            if (showAllPass)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Cells[2].Value =
                        dataGridView2.Rows[i].Cells[4].Value;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Cells[2].Value = hidePasswordString;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // if run with file, necessary decrypt him with users key
            string[] comandArgs = System.Environment.GetCommandLineArgs();
            
            if (comandArgs.Length > 1)
            {
                // verify that this our file
                // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                InputForm inputForm = new InputForm();
                DialogResult dr = inputForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string key = inputForm.key;
                    //MessageBox.Show(key);
                }
                else
                {
                    // don't open file
                }
                //MessageBox.Show(string.Join("\r\n",comandArgs));
            }
        }
    }
}

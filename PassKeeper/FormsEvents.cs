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
            if (showAllPass || dataGridMain.CurrentRow == null )
            {
                toolStripShowPass.Enabled = false;
            }
            else
            {
                toolStripShowPass.Enabled = true;
                if (dataGridMain.CurrentRow.Cells[2].Value == dataGridMain.CurrentRow.Cells[4].Value)
                {
                    toolStripShowPass.Text = "Скрыть пароль";
                }
                else
                {
                    toolStripShowPass.Text = "Показать пароль";
                }
                
            }

            if (dataGridMain.CurrentRow == null)
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

        private void toolStripCopy_DropDownOpening(object sender, EventArgs e)
        {
            if (dataGridMain.CurrentRow != null)
            {
                toolStripCopyCaption.Text = dataGridMain.CurrentRow.Cells[0].Value.ToString();
                toolStripCopyLogin.Text = dataGridMain.CurrentRow.Cells[1].Value.ToString();
                toolStripCopyPass.Text = dataGridMain.CurrentRow.Cells[4].Value.ToString();
                toolStripCopyComment.Text = dataGridMain.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                toolStripCopyCaption.Text = "";
                toolStripCopyLogin.Text = "";
                toolStripCopyPass.Text = "";
                toolStripCopyComment.Text = "";
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

        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(sender.ToString());
            this.Text = sender.ToString();
        }

        private void showPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showPassToolStripMenuItem.Text == "Показать пароль")
            {
                // need show password
                dataGridMain.CurrentRow.Cells[2].Value =
                        dataGridMain.CurrentRow.Cells[4].Value;
                //toolStripShowPass.Text = "Скрыть пароль";
            }
            else
            {
                // need hide
                dataGridMain.CurrentRow.Cells[2].Value = HIDEPASSWORDSTRING;
                //toolStripShowPass.Text = "Показать пароль";
            }
        }


        private void toolStripShowPass_Click(object sender, EventArgs e)
        {
            if (toolStripShowPass.Text == "Показать пароль")
            {
                // need show password
                dataGridMain.CurrentRow.Cells[2].Value =
                        dataGridMain.CurrentRow.Cells[4].Value;
                //toolStripShowPass.Text = "Скрыть пароль";
            }
            else
            {
                // need hide
                dataGridMain.CurrentRow.Cells[2].Value = HIDEPASSWORDSTRING;
                //toolStripShowPass.Text = "Показать пароль";
            }
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
            if (showAllPass || dataGridMain.CurrentRow == null)
            {
                //toolStripShowPass.Enabled = false;
                showPassToolStripMenuItem.Enabled = false;
            }
            else
            {
                //toolStripShowPass.Enabled = true;
                showPassToolStripMenuItem.Enabled = true;
                if (dataGridMain.CurrentRow.Cells[2].Value == dataGridMain.CurrentRow.Cells[4].Value)
                {
                    //toolStripShowPass.Text = "Скрыть пароль";
                    showPassToolStripMenuItem.Text = "Скрыть пароль";
                }
                else
                {
                    //toolStripShowPass.Text = "Показать пароль";
                    showPassToolStripMenuItem.Text = "Показать пароль";
                }

            }
            
            if (dataGridMain.CurrentRow == null)
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

        private void copyToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (dataGridMain.CurrentRow != null)
            {
                copyCaptionToolStripMenuItem.Text = dataGridMain.CurrentRow.Cells[0].Value.ToString();
                copyLoginToolStripMenuItem.Text = dataGridMain.CurrentRow.Cells[1].Value.ToString();
                copyPassToolStripMenuItem.Text = dataGridMain.CurrentRow.Cells[4].Value.ToString();
                copyCommentToolStripMenuItem.Text = dataGridMain.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                copyCaptionToolStripMenuItem.Text = "";
                copyLoginToolStripMenuItem.Text = "";
                copyPassToolStripMenuItem.Text = "";
                copyCommentToolStripMenuItem.Text = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(sender.ToString());
            //this.Text = sender.ToString();
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
                for (int i = 0; i < dataGridMain.RowCount; i++)
                {
                    dataGridMain.Rows[i].Cells[2].Value =
                        dataGridMain.Rows[i].Cells[4].Value;
                }
                toolStripShowPass.Text = "Скрыть пароль";
                showPassToolStripMenuItem.Text = "Скрыть пароль";
            }
            else
            {
                for (int i = 0; i < dataGridMain.RowCount; i++)
                {
                    dataGridMain.Rows[i].Cells[2].Value = HIDEPASSWORDSTRING;
                }
                //toolStripShowPass.Text = "Показать пароль";
                //showPassToolStripMenuItem.Text = "Показать пароль";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // if run with file, necessary decrypt him with users key
            string[] comandArgs = System.Environment.GetCommandLineArgs();
            //MessageBox.Show(string.Join("\r\n", comandArgs));

            if (comandArgs.Length > 1)
            {
                // verify that this our file
                openedFile = comandArgs[1];
                OpenFile();


                //MessageBox.Show(string.Join("\r\n",comandArgs));
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needSave)
            {
                DialogResult dialog = MessageBox.Show("Файл \"" + shortFileName + "\" не сохранен. Сохранить?", "Сохранить", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)      // Save
                {
                    // if is new file
                    if (openedFile == string.Empty)
                    {
                        // needed SaveAs..
                        saveAsToolStripMenuItem_Click(sender, new EventArgs());
                    }
                    else
                    {
                        SaveFile();
                    }
                }
                else if (dialog == DialogResult.No)  // Not save
                {

                }
                else    // Cancel
                {
                    e.Cancel = true;
                }
            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // need Save?
            if (needSave)
            {
                DialogResult dialog = MessageBox.Show("Файл \"" + shortFileName + "\" не сохранен. Сохранить?", "Сохранить", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)      // Save
                {
                    // if is new file
                    if (openedFile == string.Empty)
                    {
                        // needed SaveAs..
                        saveAsToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        SaveFile();
                    }
                }
                else if (dialog == DialogResult.No)  // Not save
                {

                }
                else    // Cancel
                {
                    return;
                }
            }

            // create new file
            needSave = false;
            dataGridMain.Rows.Clear();
            openedFile = string.Empty;
            shortFileName = string.Empty;
            encriptionKey = string.Empty;
            this.Text = string.Empty;

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (needSave)
            {
                DialogResult dialog = MessageBox.Show("Файл \"" + shortFileName + "\" не сохранен. Сохранить?", "Сохранить", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)      // Save
                {
                    // if is new file
                    if (openedFile == string.Empty)
                    {
                        // needed SaveAs..
                        saveAsToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        SaveFile();
                    }
                }
                else if (dialog == DialogResult.No)  // Not save
                {

                }
                else    // Cancel
                {
                    return;
                }
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = FILEEXTENTION + " files (*." + FILEEXTENTION + ")|*." + FILEEXTENTION + "|All files (*.*)|*.*";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                dataGridMain.Rows.Clear();
                openedFile = openFileDialog.FileName;
                shortFileName = System.IO.Path.GetFileNameWithoutExtension(openedFile);
                OpenFile();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openedFile != string.Empty)
            {
                // does it exist Path
                string dir = System.IO.Path.GetDirectoryName(openedFile);
                if (System.IO.Directory.Exists(dir))
                {
                    // create/overwite file
                    SaveFile();
                }
                else
                {
                    MessageBox.Show("Путь: \"" + dir + "\" не найден!");
                }
            }
            else
            {
                // needed SaveAs..
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = FILEEXTENTION;
            saveFileDialog.Filter = FILEEXTENTION + " files (*." + FILEEXTENTION + ")|*." + FILEEXTENTION + "|All files (*.*)|*.*";
            saveFileDialog.SupportMultiDottedExtensions = false;
            DialogResult result = saveFileDialog.ShowDialog();
            {
                if (result == DialogResult.OK)
                {
                    openedFile = saveFileDialog.FileName;
                    shortFileName = System.IO.Path.GetFileNameWithoutExtension(openedFile);
                    SaveFile();

                }
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void changeCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyInputForm inputForm = new KeyInputForm();
            DialogResult dr = inputForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                encriptionKey = inputForm.key;
                needSave = true;
            }
            else
            {
                //encriptionKey = string.Empty;
            }
        }


    }
}

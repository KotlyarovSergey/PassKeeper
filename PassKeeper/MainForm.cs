using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PassKeeper
{
    public partial class MainForm : Form
    {
        private class RowOfTable
        {
            public byte siteLength;
            public byte nameLength;
            public byte passLength;
            public byte commentLength;
            public string Site;
            public string Name;
            public string Pass;
            public string Comment;
        }

        private bool needSave;
        private bool showAllPass;
        private string openedFile;
        private string shortFileName;
        private string encriptionKey;

        private const string HIDEPASSWORDSTRING = "**********";
        private const string FILEEXTENTION = "paskk";

        public MainForm()
        {
            InitializeComponent();
            needSave = false;
            showAllPass = false;
            openedFile = string.Empty;
            shortFileName = string.Empty;
            encriptionKey = string.Empty;
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
                int n = dataGridMain.Rows.Add();
                // fill this row
                dataGridMain.Rows[n].Cells[0].Value = ef.Caption;
                dataGridMain.Rows[n].Cells[1].Value = ef.Login;
                if (showAllPass)
                {
                    dataGridMain.Rows[n].Cells[2].Value = ef.Password;
                }
                else
                {
                    dataGridMain.Rows[n].Cells[2].Value = HIDEPASSWORDSTRING;
                }

                dataGridMain.Rows[n].Cells[3].Value = ef.Comment;
                dataGridMain.Rows[n].Cells[4].Value = ef.Password;

                // sort by 
                dataGridMain.Sort(dataGridMain.Columns[0], ListSortDirection.Ascending);

                // need save
                needSave = true;
            }
        }

        // edit row
        private void EditRow()
        {
            if (dataGridMain.CurrentRow == null)
                return;

            int n = dataGridMain.CurrentRow.Index;

            // show edit form
            EditForm ef = new EditForm((string)dataGridMain.Rows[n].Cells[0].Value,
                (string)dataGridMain.Rows[n].Cells[1].Value,
                (string)dataGridMain.Rows[n].Cells[4].Value,
                (string)dataGridMain.Rows[n].Cells[3].Value);
            DialogResult result = ef.ShowDialog();
            if (result == DialogResult.OK)
            {
                // fill this row
                dataGridMain.Rows[n].Cells[0].Value = ef.Caption;
                dataGridMain.Rows[n].Cells[1].Value = ef.Login;
                if (showAllPass)
                {
                    dataGridMain.Rows[n].Cells[2].Value = ef.Password;
                }
                else
                {
                    dataGridMain.Rows[n].Cells[2].Value = HIDEPASSWORDSTRING;
                }
                dataGridMain.Rows[n].Cells[3].Value = ef.Comment;
                dataGridMain.Rows[n].Cells[4].Value = ef.Password;

                // sort by 
                dataGridMain.Sort(dataGridMain.Columns[0], ListSortDirection.Ascending);

                // need save
                needSave = true;
            }
        }

        // delete row
        private void DeleteRow()
        {
            if (dataGridMain.CurrentRow == null)
                return;

            int n = dataGridMain.CurrentRow.Index;
            if (n < 0)
                return;

            string txt = "Уверены, что хотите удалить \"" + dataGridMain.Rows[n].Cells[0].Value + "\"?";
            DialogResult result = MessageBox.Show(txt,
                                                  "Удалить запись",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                dataGridMain.Rows.RemoveAt(n);

                // need save
                needSave = true;
            }

        }

        private void OpenFile()
        {
            // if file exist
            if (System.IO.File.Exists(openedFile))
            {
                InputForm inputForm = new InputForm();
                DialogResult dr = inputForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    encriptionKey = inputForm.key;
                    // decript file with key

                    //MessageBox.Show(key);
                    ReadPskFile();

                    //DecriptFile();

                    this.Text = shortFileName;
                }
                else
                {
                    encriptionKey = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Файл \"" + openedFile + "\" не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                openedFile = string.Empty;
                shortFileName = string.Empty;
            }
        }


        private void SaveFile()
        {
            WritePskFile();
        }


        // decript file
        private void DecriptFile()
        {
            MessageBox.Show("открываем " + openedFile + " и дешифруем с помощью " + encriptionKey);
        }


        private byte[] TableToArray()
        {

            // 0-4 bytes - int count of Rows
            // i - index current Row
            // (4+i
            byte[] buffer;
            int rows = dataGridMain.Rows.Count;
            MemoryStream memoryStream = new MemoryStream();
            buffer = BitConverter.GetBytes(rows);
            memoryStream.Write(buffer, 0, buffer.Length);
            byte b;
            RowOfTable row = new RowOfTable();
            for (int i = 0; i < rows; i++)
            {
                // fill RowOfTable
                row.Site = (string)dataGridMain.Rows[i].Cells[0].Value;
                row.Name = (string)dataGridMain.Rows[i].Cells[1].Value;
                row.Pass = (string)dataGridMain.Rows[i].Cells[4].Value;
                row.Comment = (string)dataGridMain.Rows[i].Cells[3].Value;

                // write length of the fields in the table
                //memoryStream.WriteByte((byte)row.Site.Length);
                //memoryStream.WriteByte((byte)row.Name.Length);
                //memoryStream.WriteByte((byte)row.Pass.Length);
                //memoryStream.WriteByte((byte)row.Comment.Length);
                b = (byte)(row.Site.Length * 2);
                memoryStream.WriteByte(b);
                b = (byte)(row.Name.Length * 2);
                memoryStream.WriteByte(b);
                b = (byte)(row.Pass.Length * 2);
                memoryStream.WriteByte(b);
                b = (byte)(row.Comment.Length * 2);
                memoryStream.WriteByte(b);


                // write fields of current row
                if (row.Site.Length > 0)
                {
                    buffer = Encoding.Unicode.GetBytes(row.Site);
                    memoryStream.Write(buffer, 0, buffer.Length);
                }

                if (row.Name.Length > 0)
                {
                    buffer = Encoding.Unicode.GetBytes(row.Name);
                    memoryStream.Write(buffer, 0, buffer.Length);
                }

                if (row.Pass.Length > 0)
                {
                    buffer = Encoding.Unicode.GetBytes(row.Pass);
                    memoryStream.Write(buffer, 0, buffer.Length);
                }

                if (row.Comment.Length > 0)
                {
                    buffer = Encoding.Unicode.GetBytes(row.Comment);
                    memoryStream.Write(buffer, 0, buffer.Length);
                }
            }

            buffer = memoryStream.ToArray();
            return buffer;
        }


        private void TableFromArray(byte[] array)
        {
            MemoryStream memoryStream = new MemoryStream(array);
            byte[] buffer = new byte[4];
            memoryStream.Read(buffer, 0, 4);
            int row = BitConverter.ToInt32(buffer, 0);
            int rowIndex;
            RowOfTable rowOfTable = new RowOfTable();
            for (int i = 0; i < row; i++)
            {
                rowOfTable.siteLength = (byte)memoryStream.ReadByte();
                rowOfTable.nameLength = (byte)memoryStream.ReadByte();
                rowOfTable.passLength = (byte)memoryStream.ReadByte();
                rowOfTable.commentLength = (byte)memoryStream.ReadByte();

                if (rowOfTable.siteLength > 0)
                {
                    buffer = new byte[rowOfTable.siteLength];
                    memoryStream.Read(buffer, 0, rowOfTable.siteLength);
                    rowOfTable.Site = Encoding.Unicode.GetString(buffer);
                }
                else
                {
                    rowOfTable.Site = string.Empty;
                }

                if (rowOfTable.nameLength > 0)
                {
                    buffer = new byte[rowOfTable.nameLength];
                    memoryStream.Read(buffer, 0, rowOfTable.nameLength);
                    rowOfTable.Name = Encoding.Unicode.GetString(buffer);
                }
                else
                {
                    rowOfTable.Name = string.Empty;
                }

                if (rowOfTable.passLength > 0)
                {
                    buffer = new byte[rowOfTable.passLength];
                    memoryStream.Read(buffer, 0, rowOfTable.passLength);
                    rowOfTable.Pass = Encoding.Unicode.GetString(buffer);
                }
                else
                {
                    rowOfTable.Pass = string.Empty;
                }

                if (rowOfTable.commentLength > 0)
                {
                    buffer = new byte[rowOfTable.commentLength];
                    memoryStream.Read(buffer, 0, rowOfTable.commentLength);
                    rowOfTable.Comment = Encoding.Unicode.GetString(buffer);
                }
                else
                {
                    rowOfTable.Comment = string.Empty;
                }

                rowIndex = dataGridMain.Rows.Add();
                dataGridMain.Rows[rowIndex].Cells[0].Value = rowOfTable.Site;
                dataGridMain.Rows[rowIndex].Cells[1].Value = rowOfTable.Name;
                dataGridMain.Rows[rowIndex].Cells[4].Value = rowOfTable.Pass;
                dataGridMain.Rows[rowIndex].Cells[3].Value = rowOfTable.Comment;
            }

        }


        private void WritePskFile()
        {
            byte[] table = TableToArray();

            // ========
            // ENCRIPT
            // ========
            Encription encription = new Encription();
            table = encription.Encript(table);

            try
            {
                FileStream stream = File.Create(openedFile);
                stream.Write(table, 0, table.Length);
                stream.Close();
                needSave = false;
            }
            catch
            {
                MessageBox.Show("Не удалось записать файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadPskFile()
        {
            byte[] buffer = new byte[1];
            try
            {
                FileStream stream = File.Open(openedFile,FileMode.Open);
                buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();

            }
            catch
            {
                MessageBox.Show("Не удалось прочитать файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // ==============
            // DECRIPT buffer
            // ==============
            Encription encription = new Encription();
            buffer = encription.Decript(buffer);

            TableFromArray(buffer);
        }

        
    }
}

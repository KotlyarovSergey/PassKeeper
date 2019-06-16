using System;
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
        private bool needSave;

        public MainForm()
        {
            InitializeComponent();
            needSave = false;
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

                // need save
                needSave = true;
            }
        }

        // edit row
        private void EditRow()
        {
            if (dataGridView2.CurrentRow == null)
                return;

            int n = dataGridView2.CurrentRow.Index;

            // show edit form
            EditForm ef = new EditForm((string)dataGridView2.Rows[n].Cells[0].Value,
                (string)dataGridView2.Rows[n].Cells[1].Value,
                (string)dataGridView2.Rows[n].Cells[2].Value,
                (string)dataGridView2.Rows[n].Cells[3].Value);
            DialogResult result = ef.ShowDialog();
            if (result == DialogResult.OK)
            {
                // fill this row
                dataGridView2.Rows[n].Cells[0].Value = ef.Caption;
                dataGridView2.Rows[n].Cells[1].Value = ef.Login;
                dataGridView2.Rows[n].Cells[2].Value = ef.Password;
                dataGridView2.Rows[n].Cells[3].Value = ef.Comment;

                // sort by 
                dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Ascending);

                // need save
                needSave = true;
            }
        }

        // delete row
        private void DeleteRow()
        {
            if (dataGridView2.CurrentRow == null)
                return;

            int n = dataGridView2.CurrentRow.Index;
            if (n < 0)
                return;

            string txt = "Уверены, что хотите удалить \"" + dataGridView2.Rows[n].Cells[0].Value + "\"?";
            DialogResult result = MessageBox.Show(txt,
                                                  "Удалить запись",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                dataGridView2.Rows.RemoveAt(n);
                
                // need save
                needSave = true;
            }
        }


        


    }
}

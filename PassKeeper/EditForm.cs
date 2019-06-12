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
    public partial class EditForm : Form
    {
        public string Caption { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
        public string Comment { set; get; }

        public EditForm()
        {
            InitializeComponent();
            Caption = "";
            Login = "";
            Password = "";
            Comment = "";
            this.Text = "Добавление новой записи";
        }

        public EditForm(string caption, string name, string pass, string comment)
        {
            InitializeComponent();
            Caption = caption;
            Login = name;
            Password = pass;
            Comment = comment;
            this.Text = "Редактирование";
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            textBoxCaption.Text = Caption;
            textBoxLogin.Text = Login;
            textBoxPass.Text = Password;
            textBoxComment.Text = Comment;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBoxCaption.TextLength > 0 ||
                textBoxLogin.TextLength > 0 ||
                textBoxPass.TextLength > 0 ||
                textBoxComment.TextLength > 0)
            {
                Caption = textBoxCaption.Text.Trim();
                Login = textBoxLogin.Text.Trim();
                Password = textBoxPass.Text.Trim();
                Comment = textBoxComment.Text.Trim();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

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
    public partial class KeyInputForm : Form
    {
        public string key = string.Empty;
        public KeyInputForm()
        {
            InitializeComponent();
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            key = textBox1.Text.Trim();
            if (key.Length == 0)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = (char)0;
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void InputForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            DetermineInputLang();
        }

        private void DetermineInputLang()
        {
            //InputLanguage il = InputLanguage.CurrentInputLanguage;
            string lg  = InputLanguage.CurrentInputLanguage.Culture.Name;
            //textBox1.Text += lg;
            if (lg.IndexOf("ru") == 0)
                lblLang.Text = "RU";
            else if (lg.IndexOf("en") == 0)
                lblLang.Text = "EN";
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            DetermineInputLang();
            GetCapsLockState();
        }

        private void InputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                GetCapsLockState();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.CapsLock)
            {
                GetCapsLockState();
            }
        }

        private void GetCapsLockState()
        {
            if(Control.IsKeyLocked(Keys.CapsLock))
            {
                lblCapsLock.Visible = true;
            }
            else
            {
                lblCapsLock.Visible = false;
            }
        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                GetCapsLockState();
            }
        }

        private void btnON_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                GetCapsLockState();
            }
        }
    }
}

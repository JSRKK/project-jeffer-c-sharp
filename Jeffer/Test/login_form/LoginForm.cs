using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeffer.login_manager_Form
{
    public partial class LoginForm : Form
    {
        string sql = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.sql = "SELECT `EMP_ID` FROM `employee` WHERE `EMP_ID` = '"+ username.Text +"' AND `EMP_PASSWORD` = '"+ password.Text + "' AND ( `RANK_ID` = '1' OR `RANK_ID` = '2') ";
            DataTable t = Program.SQLlist(this.sql);
            if (t.Rows.Count > 0)
            {
                 Program.user_id = username.Text;
                 this.Hide();
                 Program.mainmenuForm = new MenuForm.MainMenuForm();
                 Program.mainmenuForm.ShowDialog();
                 this.Close();           
            }
            else
            {
                MessageBox.Show("กรุณากรอก username และ password ให้ถูกต้อง !", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username.ResetText();
                password.ResetText();
            }                   
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.button_login_Click(sender, e);
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button_login_Click(sender, e);
            }
        }
    }
}

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
            string sql = "SELECT `EMP_ID`,`EMP_PASSWORD` FROM `employee` WHERE `EMP_ID` = '"+username.Text+"' AND `EMP_PASSWORD` = '"+password.Text+"' ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Program.connect.Close();

            if (ds.Tables[0].Rows.Count == 1)
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

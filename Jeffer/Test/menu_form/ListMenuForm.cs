using Jeffer;
using Jeffer.MenuForm;
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

namespace jeffer.menu_form
{
    public partial class ListMenuForm : Form
    {
        public static string menu_id;
        string name = null;
        public ListMenuForm()
        {
            InitializeComponent();
        }

        private void GenerateId_SelectedIndexChanged(object sender, EventArgs e)
        {
            search.Text = "";
            show("");
        }

        private void View_Load(object sender, EventArgs e)
        {
            show("");

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            show(search.Text);
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.addmenuForm = new AddMenuForm();
            Program.addmenuForm.ShowDialog();
            this.Close();
        }

        private void show(string search)
        {
            if (GenerateId.Text != null)
                name = Program.getMenuId(GenerateId.Text);
            if (search == "")
            {
                string sql = "SELECT MENU_ID,MENU_NAME,MENU_PRICE,MENU_TYPE,MENU_STATUS FROM `menu` WHERE MENU_ID LIKE '" + name + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                Program.connect.Open();
                DataTable t = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(t);
                Table_view.DataSource = t;
                Program.connect.Close();
            }
            else
            {
                string sql = "SELECT MENU_ID,MENU_NAME,MENU_PRICE,MENU_TYPE,MENU_STATUS FROM `menu` WHERE MENU_ID LIKE '" + name + "%'AND MENU_NAME LIKE '%" + search + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                Program.connect.Open();
                DataTable t = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(t);
                Table_view.DataSource = t;
                Program.connect.Close();
            }
        }

        private void Search_MouseClick(object sender, MouseEventArgs e)
        {
            search.Text = "";
            search.ForeColor = System.Drawing.Color.Black;
        }

        private void button_back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Program.mainmenuForm = new Jeffer.MenuForm.MainMenuForm();
            Program.mainmenuForm.ShowDialog();
            this.Close();
        }


        private void Table_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                menu_id = Table_view.Rows[e.RowIndex].Cells[0].Value.ToString();
            button_update_Click(sender, e);
        }


        private void Table_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                menu_id = Table_view.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (menu_id == null)
            {
                if(Table_view.Rows.Count==1)
                {
                  MessageBox.Show("Please insert a menu!",
                                    "ERROR!!!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button2);
                }
                else
                {
                    menu_id = Table_view.Rows[0].Cells[0].Value.ToString();
                    this.Hide();
                    Program.editmenuForm = new EditMenuForm();
                    Program.editmenuForm.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                this.Hide();
                Program.editmenuForm = new EditMenuForm();
                Program.editmenuForm.ShowDialog();
                this.Close();
            }
        }

        private void search_MouseClick_1(object sender, MouseEventArgs e)
        {
            search.Text = "";
            search.ForeColor = System.Drawing.Color.Black;
        }

        private void search_TextChanged_1(object sender, EventArgs e)
        {
            show(search.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}

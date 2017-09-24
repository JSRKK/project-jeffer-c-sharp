using Jeffer;
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
    public partial class AddMenuForm : Form
    {
        public object MySqlConnection { get; private set; }
        string name = null;
        string sql = "";
        string takeaway = "";
        int count = 0;
        int tmpCount = 0;

        public AddMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            show("");
            tb_menuType.Enabled = false;

        }
        private void show(string search)
        {
            if (search == "")
            {
                if (SearchGroup.Text == "Dinein")
                {
                    sql = "SELECT PRODUCT_ID,PRODUCT_NAME,PRODUCT_UNIT FROM `stock_product`";
                    MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                    Program.connect.Open();
                    DataTable t = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(t);
                    Table_view.DataSource = t;
                    Program.connect.Close();
                }
                else if (SearchGroup.Text == "TAKEAWAY")
                {
                    sql = "SELECT PRODUCT_ID,PRODUCT_NAME,PRODUCT_UNIT FROM `stock_product` ";
                    MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                    Program.connect.Open();
                    DataTable t = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(t);
                    Table_view.DataSource = t;
                    Program.connect.Close();
                }
            }
            else
            {
                if (SearchGroup.Text == "Dinein")
                {
                    sql = "SELECT PRODUCT_ID,PRODUCT_NAME,PRODUCT_UNIT FROM `stock_product` WHERE PRODUCT_NAME LIKE '%" + search + "%'";
                    MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                    Program.connect.Open();
                    DataTable t = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(t);
                    Table_view.DataSource = t;
                    Program.connect.Close();
                }
                else if (SearchGroup.Text == "TAKEAWAY")
                {
                    sql = "SELECT PRODUCT_ID,PRODUCT_NAME,PRODUCT_UNIT FROM `stock_product` WHERE PRODUCT_NAME LIKE '%" + search + "%'";
                    MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                    Program.connect.Open();
                    DataTable t = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(t);
                    Table_view.DataSource = t;
                    Program.connect.Close();
                }
            }
        }

        private void insert(string type)
        {

            if (type == "Dinein")
            {
                sql = "INSERT INTO `menu` (MENU_ID,MENU_NAME,MENU_PRICE,MENU_STATUS,MENU_TYPE) VALUES ('" + txtID.Text + "','" + tb_Name.Text + "','" + tb_Price.Text + "','" + 1 + "','" + "Dinein" + "')";
                //OLD_STYLE sql = "INSERT INTO `menu` (MENU_ID,MENU_NAME,MENU_PRICE,MENU_STATUS,MENU_TYPE) VALUES ('" + txtID.Text + "','" + txtName.Text + "','" + txtPrice.Text + "','" + 1 + "','" + "Dinein" + "')";
                MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                Program.sqlOther(sql);
                MessageBox.Show("INSERT SUSCESS", "COMPLETE!");
            }
            else if (type == "TAKEAWAY")
            {
                sql = "INSERT INTO `menu` (MENU_ID,MENU_NAME,MENU_PRICE,MENU_STATUS,MENU_TYPE) VALUES ('" + txtID.Text + "','" + tb_Name.Text + "','" + tb_Price.Text + "','" + 1 + "','" + "TAKEAWAY" + "')";
                MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                Program.sqlOther(sql);
                MessageBox.Show("INSERT SUSCESS", "COMPLETE!");
            }
            else if (type == "Dinein+Take-Away")
            {
                sql = "INSERT INTO `menu` (MENU_ID,MENU_NAME,MENU_PRICE,MENU_STATUS,MENU_TYPE) VALUES ('" + txtID.Text + "','" + tb_Name.Text + "','" + tb_Price.Text + "','" + 1 + "','" + "Dinein" + "')";
                MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                Program.sqlOther(sql);

                sql = "INSERT INTO `menu` (MENU_ID,MENU_NAME,MENU_PRICE,MENU_STATUS,MENU_TYPE) VALUES ('" + takeaway + "','" + tb_Name.Text + "','" + tb_Price.Text + "','" + 1 + "','" + "TAKEAWAY" + "')";
                cmd = new MySqlCommand(sql, Program.connect);
                Program.sqlOther(sql);
                MessageBox.Show("INSERT SUSCESS", "COMPLETE!");
            }

        }
        private void insert_product(string type)
        {
            if (type == "Dinein")
            {
                foreach (DataGridViewRow row in DINEGRID.Rows)
                {
                    sql = "INSERT INTO `ingredident` (MENU_ID,PRODUCT_ID,INGREDIDENT_QTY) VALUES ('" + txtID.Text + "','" + row.Cells[0].Value + "','" + row.Cells[2].Value + "')";
                    Program.sqlOther(sql);
                }
            }
            else if (type == "TAKEAWAY")
            {
                foreach (DataGridViewRow row in TAKEGRID.Rows)
                {
                    sql = "INSERT INTO `ingredident` (MENU_ID,PRODUCT_ID,INGREDIDENT_QTY) VALUES ('" + txtID.Text + "','" + row.Cells[0].Value + "','" + row.Cells[2].Value + "')";
                    Program.sqlOther(sql);
                }
            }
            else if (type == "Dinein+Take-Away")
            {
                foreach (DataGridViewRow row in DINEGRID.Rows)
                {
                    sql = "INSERT INTO `ingredident` (MENU_ID,PRODUCT_ID,INGREDIDENT_QTY) VALUES ('" + txtID.Text + "','" + row.Cells[0].Value + "','" + row.Cells[2].Value + "')";
                    Program.sqlOther(sql);

                }
                foreach (DataGridViewRow row in TAKEGRID.Rows)
                {
                    sql = "INSERT INTO `ingredident` (MENU_ID,PRODUCT_ID,INGREDIDENT_QTY) VALUES ('" + takeaway + "','" + row.Cells[0].Value + "','" + row.Cells[2].Value + "')";
                    Program.sqlOther(sql);
                }
            }

        }


        private void button_insert_Click(object sender, EventArgs e)
        {
            MessageBox.Show(takeaway);
            if (cb_groupId.Text == "" || tb_Name.Text == "" || tb_Price.Text == "" || tb_menuType.Text == "")
            {
                MessageBox.Show("PLEASE CHECK YOUR INFORMATIONS !!", "NULL INFORMATIONS!");
            }
            else if (tb_menuType.Text == "Dinein" && DINEGRID.Rows.Count > 0)
            {
                insert("Dinein");
                insert_product("Dinein");
                this.button_back_Click(sender,e);
            }
            else if (tb_menuType.Text == "TAKEAWAY" && TAKEGRID.Rows.Count > 0)
            {
                insert("TAKEAWAY");
                insert_product("TAKEAWAY");
                this.button_back_Click(sender, e);
            }
            else if (tb_menuType.Text == "Dinein+Take-Away" && TAKEGRID.Rows.Count > 0 && DINEGRID.Rows.Count > 0)
            {
                insert("Dinein+Take-Away");
                insert_product("Dinein+Take-Away");
                this.button_back_Click(sender, e);
            }
            else
            {
                MessageBox.Show("PLEASE CHECK YOUR INFORMATIONS !!", "NULL INFORMATIONS");
            }


        }


        private void cb_groupId_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_menuType.Enabled = true;
            name = Program.getMenuId(cb_groupId.Text);
            sql = "SELECT COUNT(MENU_ID) FROM `menu` WHERE MENU_ID LIKE '" + name + "%'";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            count = reader.GetInt16("COUNT(MENU_ID)") + 1;
            tmpCount = count;
            Program.connect.Close();
            int index = 3 - count.ToString().Length;
            for (int i = 0; i < index; i++)
                name += "0";

            tb_Name.Focus();

        }

        private void tb_menuType_SelectedIndexChanged(object sender, EventArgs e)
        {//********************

            if (tb_menuType.Text == "Dinein")
            {
                SearchGroup.Text = "Dinein";
                SearchGroup.Enabled = false;
                txtID.Text = name + count.ToString();
            }
            else if (tb_menuType.Text == "TAKEAWAY")
            {
                SearchGroup.Text = "TAKEAWAY";
                SearchGroup.Enabled = false;
                txtID.Text = name + count.ToString();
            }
            else if (tb_menuType.Text == "Dinein+Take-Away")
            {
                SearchGroup.Enabled = true;
                txtID.Text = name + count.ToString();
                count++;
                takeaway = name + count;

                count = tmpCount; // set to default
            }
            tb_Name.Focus();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            show(Search.Text);
        }

        private void SearchGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            show("");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_MouseClick(object sender, MouseEventArgs e)
        {

            Search.Text = "";
            Search.ForeColor = System.Drawing.Color.Black;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listmenuForm = new ListMenuForm();
            Program.listmenuForm.ShowDialog();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ListMenuForm vm = new ListMenuForm();
            vm.Show();
            this.Hide();
        }

        private void Table_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)//check click
            {
                string mat_id = Table_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                string mat_name = Table_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (SearchGroup.Text == "Dinein" && tb_menuType.Text == "Dinein+Take-Away")
                {
                    DINEGRID.Rows.Add(mat_id, mat_name, 0);
                    TAKEGRID.Rows.Add(mat_id, mat_name, 0);
                }
                else if (SearchGroup.Text == "Dinein")
                {
                    DINEGRID.Rows.Add(mat_id, mat_name, 0);
                }
                else if (SearchGroup.Text == "TAKEAWAY")
                    TAKEGRID.Rows.Add(mat_id, mat_name, 0);
            }
        }

        private void DINEGRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
                DINEGRID.Rows.RemoveAt(e.RowIndex);
        }

        private void TAKEGRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
                TAKEGRID.Rows.RemoveAt(e.RowIndex);
        }
    }
}

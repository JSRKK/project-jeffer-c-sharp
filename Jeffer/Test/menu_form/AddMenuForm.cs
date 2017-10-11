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
        private string sql = "";
        string name = null;
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
            radioButton1.Checked = true;
            tb_menuType.Enabled = false;

        }
        private void show(string search)
        {
            if (search == "")
            {
                if (cb_groupId.Text == "Set")
                {
                    Menu_view.Visible = true;
                    Table_view.Visible = false;
                    DINEGRID.Visible = false;
                    TAKEGRID.Visible = false;
                    Menu_dinein.Visible = true;
                    Menu_take.Visible = true;

                    if(SearchGroup.Text =="Dinein")
                    {
                        this.sql = "SELECT MENU_ID,MENU_NAME,MENU_PRICE FROM `menu` WHERE MENU_TYPE = 'Dinein'";                       
                    }
                    else if(SearchGroup.Text =="Take-Away")
                    {
                        this.sql = "SELECT MENU_ID,MENU_NAME,MENU_PRICE FROM `menu` WHERE MENU_TYPE = 'Take-Away'";                       
                    }

                    this.Menu_view.DataSource = Program.SQLlist(this.sql);
                }
                else
                {
                    Menu_view.Visible = false;
                    Table_view.Visible = true;
                    DINEGRID.Visible = true;
                    TAKEGRID.Visible = true;
                    Menu_dinein.Visible = false;
                    Menu_take.Visible = false;

                    this.sql = "SELECT PRODUCT_ID,PRODUCT_NAME,PRODUCT_UNIT FROM `stock_product`";
                    Table_view.DataSource = Program.SQLlist(this.sql);
                }
            }
            else
            {

                if (cb_groupId.Text == "Set")
                {

                    Menu_view.Visible = true;
                    Table_view.Visible = false;
                    DINEGRID.Visible = false;
                    TAKEGRID.Visible = false;
                    Menu_dinein.Visible = true;
                    Menu_take.Visible = true;

                    if(SearchGroup.Text=="Dinein")
                    {
                        this.sql = "SELECT MENU_ID,MENU_NAME,MENU_PRICE FROM `menu` WHERE MENU_TYPE = 'Dinein' AND MENU_NAME LIKE '%" + search + "%'";                        
                    }
                        
                    else if (SearchGroup.Text == "Take-Away")
                    {
                        this.sql = "SELECT MENU_ID,MENU_NAME,MENU_PRICE FROM `menu` WHERE MENU_TYPE = 'Take-Away' AND MENU_NAME LIKE '%" + search + "%'";                     
                    }

                    this.Menu_view.DataSource = Program.SQLlist(this.sql);
                }
                else
                {
                    Menu_view.Visible = false;
                    Table_view.Visible = true;
                    DINEGRID.Visible = true;
                    TAKEGRID.Visible = true;
                    Menu_dinein.Visible = false;
                    Menu_take.Visible = false;

                    this.sql = "SELECT PRODUCT_ID,PRODUCT_NAME,PRODUCT_UNIT FROM `stock_product` WHERE PRODUCT_NAME LIKE '%" + search + "%'";
                    this.Table_view.DataSource = Program.SQLlist(this.sql);
                }

            }
        }
        private int check_status()
        {
            if (radioButton1.Checked == true)
                return 1;
            return 0;
        }

        private void insertMenu(string type)
        {
            int status = check_status();

            if (type == "Dinein")
            {
                this.insertDineinAndTakeAway(txtID.Text, tb_Name.Text, tb_Price.Text, status, "Dinein");          
            }
            else if (type == "Take-Away")
            {
                this.insertDineinAndTakeAway(txtID.Text, tb_Name.Text, tb_Price.Text, status, "Take-Away");
            }
            else if (type == "Dinein+Take-Away")
            {
                this.insertDineinAndTakeAway(txtID.Text, tb_Name.Text, tb_Price.Text, status, "Dinein");
                this.insertDineinAndTakeAway(takeaway, tb_Name.Text, tb_Price.Text, status, "Take-Away");               
            }

        }

        private void insertDineinAndTakeAway(string menuId, string menuName, string menuPrice, int menuStatus, string menuType)
        {
            this.sql = "INSERT INTO `menu` (MENU_ID,MENU_NAME,MENU_PRICE,MENU_STATUS,MENU_TYPE) VALUES ('" + menuId + "','" + menuName + "','" + menuPrice + "','" + menuStatus + "','" + menuType + "')";
            Program.sqlOther(this.sql);
            MessageBox.Show("INSERT SUSCESS", "COMPLETE!");
        }       

        private void insertIngredident(string type)
        {
            if (type == "Dinein")
            {
                foreach (DataGridViewRow row in DINEGRID.Rows)
                {
                    this.insertSubIngredident(txtID.Text, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                }
            }
            else if (type == "Take-Away")
            {
                foreach (DataGridViewRow row in TAKEGRID.Rows)
                {
                    this.insertSubIngredident(txtID.Text, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                }
            }
            else if (type == "Dinein+Take-Away")
            {
                foreach (DataGridViewRow row in DINEGRID.Rows)
                {
                    this.insertSubIngredident(txtID.Text, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                }
                foreach (DataGridViewRow row in TAKEGRID.Rows)
                {
                    this.insertSubIngredident(takeaway, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                }
            }
        }

        private void insertSubIngredident(string menuId, string productId, string qty)
        {
            this.sql = "INSERT INTO `ingredident` (MENU_ID,PRODUCT_ID,INGREDIDENT_QTY) VALUES ('" + menuId + "','" + productId + "','" + qty + "')";
            Program.sqlOther(this.sql);
        }

        private void insertSetmenu(string type)
        {
            if (type == "Dinein")
            {
                foreach (DataGridViewRow row in Menu_dinein.Rows)
                {
                    this.insertSubSetmenu(txtID.Text, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                }
            }
            else if (type == "Take-Away")
            {
                foreach (DataGridViewRow row in Menu_take.Rows)
                {
                    this.insertSubSetmenu(txtID.Text, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                }
            }
            else if(type =="Dinein+Take-Away")
            {
                foreach (DataGridViewRow row in Menu_dinein.Rows)
                {
                    this.insertSubSetmenu(txtID.Text, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                }
                foreach (DataGridViewRow row in Menu_take.Rows)
                {
                    this.insertSubSetmenu(takeaway, row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());                  
                }
            }               
        }

        private void insertSubSetmenu(string setmenuId, string menuId, string qty)
        {
            this.sql = "INSERT INTO `setmenu` (SETMENU_ID, SETMENU_QTY, MENU_ID) VALUES ('" + setmenuId + "','" + qty + "','" + menuId + "')";
            Program.sqlOther(this.sql);
        }

        private void button_insert_Click(object sender, EventArgs e)
        {

            if (cb_groupId.Text == "" || tb_Name.Text == "" || tb_Price.Text == "" || tb_menuType.Text == "")
            {
                MessageBox.Show("PLEASE CHECK YOUR INFORMATIONS !!", "NULL INFORMATIONS!");
            }
            else if (tb_menuType.Text == "Dinein" && DINEGRID.Rows.Count > 0)
            {
                insertMenu("Dinein");
                insertIngredident("Dinein");
                this.button_back_Click(sender,e);
            }
            else if (tb_menuType.Text == "Take-Away" && TAKEGRID.Rows.Count > 0)
            {
                insertMenu("Take-Away");
                insertIngredident("Take-Away");
                this.button_back_Click(sender, e);
            }
            else if (tb_menuType.Text == "Dinein+Take-Away" && TAKEGRID.Rows.Count > 0 && DINEGRID.Rows.Count > 0)
            {
                insertMenu("Dinein+Take-Away");
                insertIngredident("Dinein+Take-Away");
                this.button_back_Click(sender, e);
            }
            else if(cb_groupId.Text =="Set" && (Menu_dinein.Rows.Count >0||Menu_take.Rows.Count >0) && (tb_menuType.Text =="Dinein" || tb_menuType.Text =="Take-Away") )
            {
                insertMenu(tb_menuType.Text);
                insertSetmenu(tb_menuType.Text);
                this.button_back_Click(sender, e);

            }
            else if(cb_groupId.Text == "Set" && tb_menuType.Text =="Dinein+Take-Away" && Menu_take.Rows.Count >0 && Menu_dinein.Rows.Count > 0)
            {
                insertMenu("Dinein+Take-Away");
                insertSetmenu(tb_menuType.Text);
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
            this.sql = "SELECT COUNT(MENU_ID) FROM `menu` WHERE MENU_ID LIKE '" + name + "%'";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
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

            show("");


        }

        private void tb_menuType_SelectedIndexChanged(object sender, EventArgs e)
        { 

            if (tb_menuType.Text == "Dinein")
            {
                SearchGroup.Text = "Dinein";
                SearchGroup.Enabled = false;
                txtID.Text = name + count.ToString();
            }
            else if (tb_menuType.Text == "Take-Away")
            {
                SearchGroup.Text = "Take-Away";
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
                string menu_id = Table_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                string menu_name = Table_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (SearchGroup.Text == "Dinein")
                {
                    DINEGRID = Program.check_duplicate(DINEGRID, menu_id, menu_name);
                }
                else if (SearchGroup.Text == "Take-Away")
                {
                    TAKEGRID = Program.check_duplicate(TAKEGRID, menu_id, menu_name);
                }
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

        private void Menu_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (e.ColumnIndex == 0 && e.RowIndex != -1)//check click
            {
                string menu_id = Menu_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                string menu_name = Menu_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (SearchGroup.Text == "Dinein")
                {
                    Menu_dinein = Program.check_duplicate(Menu_dinein, menu_id, menu_name);
                }
                else if (SearchGroup.Text == "Take-Away")
                {
                    Menu_take = Program.check_duplicate(Menu_take, menu_id, menu_name);
                }
            }
        }

        private void Menu_dinein_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
                Menu_dinein.Rows.RemoveAt(e.RowIndex);
        }

        private void Menu_take_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
                Menu_dinein.Rows.RemoveAt(e.RowIndex);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}

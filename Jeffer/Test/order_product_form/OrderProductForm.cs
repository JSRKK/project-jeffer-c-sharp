using Jeffer;
using Jeffer.login_manager_Form;
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

namespace jeffer
{
    public partial class OrderProductForm : Form
    {
        public static int count = 0;
        public static string idGroup = null;
        private string sql;
        public OrderProductForm()
        {
            InitializeComponent();
            this.dateOrder.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.countOrder.Text = count.ToString();
            this.ShowlistGroup();
        }

        //แสดงรายการกลุ่มสินค้า
        private void ShowlistGroup()
        {
            this.sql = "SELECT `GROUP_ID`, `GROUP_NAME` FROM `group`";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);

            Program.connect.Open();

            DataTable t = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //MySqlDataReader reder = cmd.ExecuteReader();
            da.Fill(t);
            this.showGroup.Rows.Clear();

            foreach (DataRow item in t.Rows)
            {
                int n = showGroup.Rows.Add();
                this.showGroup.Rows[n].Cells[0].Value = item[0].ToString();
                this.showGroup.Rows[n].Cells[1].Value = item[1].ToString();
            }
            Program.connect.Close();
        }

        private void tb_searchProduct_TextChanged(object sender, EventArgs e)
        {
            this.listProduct(tb_searchProduct.Text);
        }

        //แสดงรายการสินค้า
        private void listProduct(string nameProduct)
        {
            if(nameProduct != "")
            {
                this.sql = "SELECT * FROM `stock_product` WHERE PRODUCT_NAME LIKE '%" + nameProduct + "%' ";
            }
            else
            {
                this.sql = "SELECT * FROM `stock_product` WHERE `GROUP_ID` = '" + idGroup + "' ";
            }     
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            DataTable t = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(t);
            dgv_product.Rows.Clear();
            
            foreach (DataRow item in t.Rows)
            {
                int n = dgv_product.Rows.Add();
                Boolean flag = true;
                this.dgv_product.Rows[n].Cells[0].Value = item[0].ToString();
                this.dgv_product.Rows[n].Cells[1].Value = item[1].ToString();
                this.dgv_product.Rows[n].Cells[2].Value = item[2].ToString();
                this.dgv_product.Rows[n].Cells[3].Value = Double.Parse(item[4].ToString()) / Double.Parse(item[3].ToString());
                
                foreach (DataGridViewRow row in dgv_checkProduct.Rows)
                {
                    if(row.Cells[0].Value.ToString() == this.dgv_product.Rows[n].Cells[0].Value.ToString())
                    {
                        this.dgv_product.Rows[n].Cells[4].Value = row.Cells[4].Value;
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    this.dgv_product.Rows[n].Cells[4].Value = 0;
                }  
            }
            Program.connect.Close();
        }

        
        private void dtg_product_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int index = -1;
            Boolean flag = true;

            foreach(DataGridViewRow row in dgv_checkProduct.Rows)
            {
                if(row.Cells[0].Value.ToString() == this.dgv_product.Rows[rowIndex].Cells[0].Value.ToString())
                {
                    if(this.dgv_product.Rows[rowIndex].Cells[4].Value.ToString() == "0")
                    {                       
                        foreach(DataGridViewRow row2 in dgv_checkProduct.Rows)
                        {
                            if (row2.Cells[0].Value.ToString() == this.dgv_product.Rows[rowIndex].Cells[0].Value.ToString())
                            {
                                index = row2.Index;
                                break;
                            }
                        }
                        this.dgv_checkProduct.Rows.RemoveAt(index);
                        flag = false;
                        break;
                    }
                    else
                    {
                        row.Cells[4].Value = Int16.Parse(dgv_product.Rows[rowIndex].Cells[4].Value.ToString());
                        flag = false;
                        break;
                    } 
                }                     
            }

            if (flag && dgv_product.Rows[rowIndex].Cells[4].Value.ToString() != "" && Int16.Parse(dgv_product.Rows[rowIndex].Cells[4].Value.ToString()) > 0)
            {
                string id = this.dgv_product.Rows[rowIndex].Cells[0].Value.ToString();
                string name = this.dgv_product.Rows[rowIndex].Cells[1].Value.ToString();
                string unit = this.dgv_product.Rows[rowIndex].Cells[2].Value.ToString();
                string remain = this.dgv_product.Rows[rowIndex].Cells[3].Value.ToString();
                string amount = this.dgv_product.Rows[rowIndex].Cells[4].Value.ToString();    
                         
                this.dgv_checkProduct.Rows.Add(id, name, unit, remain, amount);         
            }
            count = this.dgv_checkProduct.Rows.Count;
            this.countOrder.Text = count.ToString();
        }

        private void dgv_check_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                DialogResult dr = MessageBox.Show("คุณต้องการลบรายการสินค้าใช่ หรือ ไม่?", "เตือน!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    this.dgv_checkProduct.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void showGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int rowIndex = e.RowIndex;
                idGroup = this.showGroup.Rows[rowIndex].Cells[0].Value.ToString();
                this.listProduct("");
            }
        }

        //สร้างหมายเลขสั่งสินค้า
        private string getIdLot()
        {
            string temp = "";
            this.sql = "SELECT MAX(`LOT_ID`) FROM `lot_product`";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int check = reader.GetOrdinal("MAX(`LOT_ID`)");
            if (!reader.IsDBNull(check))
            {
                temp = reader.GetString("MAX(`LOT_ID`)").Substring(2, 4);
                int num = Int16.Parse(temp) + 1;
                temp = num.ToString();
            }
            Program.connect.Close();

            while (temp.Length < 4)
            {
                temp = "0" + temp;
            }
            temp = "SP" + temp;
            return temp;
        }

        //บันทึก
        private void button_save_Click(object sender, EventArgs e)
        {
            if (this.dgv_checkProduct.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่อสั่งสินค้า!", "เตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    string lot_id = getIdLot();
                    this.sql = "INSERT INTO `lot_product`(`LOT_ID`, `LOT_ORDER_DATE`, `EMP_ID`) VALUES ('" + lot_id + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + Program.user_id + "')";
                    Program.sqlOther(this.sql);
                    this.insertSubLotProduct(lot_id);

                    dr = MessageBox.Show("สั่งสินค้าเรียบร้อยแล้ว", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        this.dgv_product.Rows.Clear();
                        this.dgv_checkProduct.Rows.Clear();
                        this.button_back_Click(sender, e);
                    }
                }          
            }
            else
            {
                MessageBox.Show("ไม่มีรายการสินค้า", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.button_back_Click(sender, e);
            }
        }

        //เพื่มสินค้าเข้าสู่ lot
        private void insertSubLotProduct(string lot_id)
        {
            foreach (DataGridViewRow row in dgv_checkProduct.Rows)
            {
                this.sql = "INSERT INTO `sub_lot_product`(`LOT_ORDER_QTY`, `LOT_ID`, `PRODUCT_ID`) VALUES ('" + row.Cells[4].Value + "', '" + lot_id + "', '" + row.Cells[0].Value.ToString() + "')";
                Program.sqlOther(this.sql);
            }
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย! " + "หมายเลขสั่งสินค้า " + lot_id, "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtg_product_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(listProduct_KeyPress);
        }

        private void listProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;             
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        

        private void button_backmain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainmenuForm = new Jeffer.MenuForm.MainMenuForm();
            Program.mainmenuForm.ShowDialog();
            this.Close();
        }

        

        private void button_check_Click(object sender, EventArgs e)
        {
            this.button_back.Visible = true;
            this.button_save.Visible = true;
            this.button_check.Visible = false;
            this.button_backmain.Visible = false;
            this.dgv_checkProduct.Visible = true;

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.button_back.Visible = false;
            this.button_save.Visible = false;
            this.button_check.Visible = true;
            this.button_backmain.Visible = true;
            this.dgv_checkProduct.Visible = false;
            this.listProduct("");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}

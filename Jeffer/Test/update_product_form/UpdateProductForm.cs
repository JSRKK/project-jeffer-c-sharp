using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Jeffer
{
    public partial class UpdateProductForm : Form
    {
        public static bool check = false;
        private string sql = "";
        public UpdateProductForm()
        {
            InitializeComponent();
            this.listGroupProduct();   
            this.amount.Text = "0";
            this.dateUp.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

               
        private void listGroupProduct()
        {
            this.sql = "SELECT * FROM `group` WHERE 1";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);

            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.cb_groupMenu.Items.Add(reader.GetString("GROUP_NAME"));
                
            }
            Program.connect.Close();
        }

        private void listProduct(string nameProduct)
        {
            if (nameProduct != "")
            {
                this.sql = "SELECT `GROUP_ID`, `PRODUCT_ID`, `PRODUCT_NAME`, `PRODUCT_UNIT`, `PRODUCT_PER_UNIT`, `PRODUCT_TOTAL`  FROM `stock_product` WHERE PRODUCT_NAME LIKE '%" + nameProduct + "%' ";
            }
            else
            {
                this.sql = "SELECT sp.GROUP_ID, sp.PRODUCT_ID, sp.PRODUCT_NAME, sp.PRODUCT_UNIT, sp.PRODUCT_PER_UNIT, sp.PRODUCT_TOTAL FROM stock_product sp INNER JOIN `group` ON sp.GROUP_ID = group.GROUP_ID WHERE group.GROUP_NAME = '" + cb_groupMenu.Text + "'";
            }


            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
            Program.connect.Open();

            DataTable t = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(t);
            this.dgv_product.Rows.Clear();

            foreach (DataRow item in t.Rows)
            {
                int n = dgv_product.Rows.Add();
                bool flag = true;
                this.dgv_product.Rows[n].Cells[0].Value = item[0].ToString();
                this.dgv_product.Rows[n].Cells[1].Value = item[1].ToString();
                this.dgv_product.Rows[n].Cells[2].Value = item[2].ToString();
                this.dgv_product.Rows[n].Cells[3].Value = item[3].ToString();
                this.dgv_product.Rows[n].Cells[4].Value = item[4].ToString();
                this.dgv_product.Rows[n].Cells[5].Value = item[5].ToString();

                foreach (DataGridViewRow row2 in dgv_checkUpdateProduct.Rows)
                {
                    if (row2.Cells[1].Value.ToString() == this.dgv_product.Rows[n].Cells[1].Value.ToString())
                    {
                        this.dgv_product.Rows[n].Cells[6].Value = Int16.Parse(row2.Cells[6].Value.ToString());
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    this.dgv_product.Rows[n].Cells[6].Value = "";
                }

            }

            Program.connect.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (dgv_checkUpdateProduct.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่อบันทึกข้อมูล!", "เตือน!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                        double sum = 0;
                        foreach (DataGridViewRow row in dgv_checkUpdateProduct.Rows)
                        {
                            if (Double.Parse(row.Cells[5].Value.ToString()) > Double.Parse(row.Cells[6].Value.ToString()))
                            {
                                sum = Double.Parse(row.Cells[5].Value.ToString()) - Double.Parse(row.Cells[6].Value.ToString());

                                updateStock_1(row, sum);
                                while (sum > 0)
                                {
                                this.sql = "SELECT slp.LOT_REMAIN_QTY, lp.LOT_ID, slp.PRODUCT_ID FROM sub_lot_product slp NATURAL JOIN lot_product lp WHERE slp.PRODUCT_ID = '" + row.Cells[1].Value.ToString() + "' AND slp.LOT_REMAIN_QTY > 0";
                                MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);

                                    Program.connect.Open();
                                    MySqlDataReader reader = cmd.ExecuteReader();
                                    reader.Read();
                                    double tempNum1 = reader.GetDouble("LOT_REMAIN_QTY");
                                    string tempLot = reader.GetString("LOT_ID");
                                    string tempProduct = reader.GetString("PRODUCT_ID");
                                    Program.connect.Close();

                                    if ((tempNum1 - sum) >= 0)
                                    {
                                        tempNum1 -= sum;
                                        //call function 
                                        this.updateSubLotProduct(tempNum1, tempProduct, tempLot);
                                        sum = 0;
                                    }
                                    else
                                    {
                                        //call function
                                        this.updateSubLotProduct(0, tempProduct, tempLot);
                                        sum -= tempNum1;
                                    }
                                }
                            }
                            else
                            {
                                sum = Double.Parse(row.Cells[5].Value.ToString()) - Double.Parse(row.Cells[4].Value.ToString());

                                updateStock_2(row, sum);
                                while (sum > 0)

                                {
                                this.sql = "SELECT slp.LOT_RECEIVE_QTY, slp.LOT_REMAIN_QTY, lp.LOT_ID, slp.PRODUCT_ID, sp.PRODUCT_PER_UNIT FROM sub_lot_product slp NATURAL JOIN lot_product lp NATURAL JOIN stock_product sp WHERE slp.PRODUCT_ID = '" + row.Cells[1].Value.ToString() + "' AND (slp.LOT_REMAIN_QTY < (slp.LOT_RECEIVE_QTY * sp.PRODUCT_PER_UNIT))";
                                MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);

                                    Program.connect.Open();
                                    MySqlDataReader reader = cmd.ExecuteReader();
                                    reader.Read();
                                    double tempNum1 = reader.GetDouble("LOT_RECEIVE_QTY") * reader.GetDouble("PRODUCT_PER_UNIT"); ;
                                    double tempNum2 = reader.GetDouble("LOT_REMAIN_QTY");
                                    string tempLot = reader.GetString("LOT_ID");
                                    string tempProduct = reader.GetString("PRODUCT_ID");
                                    Program.connect.Close();

                                    if ((tempNum2 + sum) <= tempNum1)
                                    {
                                        tempNum2 += sum;
                                        //call function
                                        this.updateSubLotProduct(tempNum2, tempProduct, tempLot);
                                        sum = 0;
                                    }
                                    else
                                    {
                                        //call function
                                        this.updateSubLotProduct(tempNum1, tempProduct, tempLot);
                                        sum -= (tempNum1 - tempNum2);
                                    }
                                }
                            }
                        }

                        sum = 0;
                        this.tb_searchProduct.Text = "";
                        this.listProduct("");
                        dr = MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            this.dgv_checkUpdateProduct.Rows.Clear();
                            this.dgv_product.Rows.Clear();
                            this.button_back_Click(sender, e);
                        }
                }
            }
            else
            {
                MessageBox.Show("คุณยังไม่ได้อัพเดทรายการข้อมูลสินค้า!", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.button_back_Click(sender, e);
            }
        }

        //function update sublotproduct 
        private void updateSubLotProduct(double remian, string productId, string lotId)
        {
            this.sql = "UPDATE sub_lot_product SET LOT_REMAIN_QTY = '" + remian + "' WHERE PRODUCT_ID = '" + productId + "' AND LOT_ID = '" + lotId + "'";
            Program.sqlOther(this.sql);
        }

        private void updateStock_1(DataGridViewRow row, double sum)
        {
            this.sql = "SELECT `PRODUCT_TOTAL` FROM `stock_product` WHERE `PRODUCT_ID` = '" + row.Cells[1].Value.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            double total = reader.GetDouble("PRODUCT_TOTAL");
            Program.connect.Close();

            total -= sum;
            this.sql = "UPDATE `stock_product` SET `PRODUCT_TOTAL` = " + total + " WHERE `PRODUCT_ID` = '" + row.Cells[1].Value.ToString() + "'";
            Program.sqlOther(this.sql);
        }

        private void updateStock_2(DataGridViewRow row, double sum)
        {
            this.sql = "SELECT `PRODUCT_TOTAL` FROM `stock_product` WHERE `PRODUCT_ID` = '" + row.Cells[1].Value.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            double total = reader.GetDouble("PRODUCT_TOTAL");
            Program.connect.Close();

            total += sum;
            this.sql = "UPDATE `stock_product` SET `PRODUCT_TOTAL` =  " + total + " WHERE `PRODUCT_ID` = '" + row.Cells[1].Value.ToString() + "'";
            Program.sqlOther(this.sql);
        }

        private void dgv_product_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Boolean flag = true;
            int index = e.RowIndex;
            foreach (DataGridViewRow row2 in dgv_checkUpdateProduct.Rows)
            {
                if (row2.Cells[1].Value.ToString() == tb_searchProduct.Text)
                {
                    row2.Cells[5].Value = dgv_product.Rows[index].Cells[5].Value;
                    flag = false;
                    break;
                }
            }
            if (flag && dgv_product.Rows[index].Cells[5].Value.ToString() != "")
            {
                string group = dgv_product.Rows[index].Cells[0].Value.ToString();
                string id = dgv_product.Rows[index].Cells[1].Value.ToString();
                string name = dgv_product.Rows[index].Cells[2].Value.ToString();
                string unit = dgv_product.Rows[index].Cells[3].Value.ToString();
                double amount1 = Double.Parse(dgv_product.Rows[index].Cells[5].Value.ToString());
                double amount2 = Double.Parse(dgv_product.Rows[index].Cells[6].Value.ToString());

                this.dgv_checkUpdateProduct.Rows.Add(group, id, name, unit, amount1, amount2);
            }
            this.amount.Text = this.dgv_checkUpdateProduct.Rows.Count.ToString();
        }

        private void dgv_checkUpdateProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int rowIndex = e.RowIndex;
                DialogResult dr = MessageBox.Show("คุณต้องการลบรายการสินค้าใช่ หรือ ไม่?", "รายการสินค้า", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    this.dgv_checkUpdateProduct.Rows.RemoveAt(rowIndex);
                    int temp = Int32.Parse(amount.Text) - 1;
                    this.amount.Text = temp.ToString();
                }
            }
        }

        private void cb_groupMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
              this.listProduct("");
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            this.dgv_checkUpdateProduct.Visible = true;
            this.cb_groupMenu.Hide();
            this.tb_searchProduct.Hide();
            this.botton_save.Visible = true;
            this.button_back.Visible = true;
            this.button_check.Visible = false;
            this.button_backmain.Visible = false;
            this.text1.Hide();
            this.text2.Hide();
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            this.dgv_checkUpdateProduct.Visible = false;
            this.cb_groupMenu.Show();
            this.tb_searchProduct.Show();
            this.botton_save.Visible = false;
            this.button_back.Visible = false;
            this.button_check.Visible = true;
            this.button_backmain.Visible = true;
            this.text1.Show();
            this.text2.Show();

        }

        private void tb_searchProduct_TextChanged(object sender, EventArgs e)
        {
                this.listProduct(this.tb_searchProduct.Text);
        }


        private void dgv_product_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dgv_product_KeyPress);
        }

        private void dgv_product_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgv_checkUpdateProduct_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dgv_checkUpdateProduct_KeyPress);
        }

        private void dgv_checkUpdateProduct_KeyPress(object sender, KeyPressEventArgs e)
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
            Program.mainmenuForm = new MenuForm.MainMenuForm();
            Program.mainmenuForm.ShowDialog();
            this.Close();
        }
    }
}

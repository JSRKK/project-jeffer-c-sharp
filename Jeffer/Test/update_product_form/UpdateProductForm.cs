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
            this.tb_amount.Text = "0";
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
                this.sql = "SELECT `GROUP_ID`, `PRODUCT_ID`, `PRODUCT_NAME`, `PRODUCT_UNIT`, PRODUCT_PER_UNIT, `PRODUCT_TOTAL`  FROM `stock_product` WHERE PRODUCT_NAME LIKE '%" + nameProduct + "%' ";
            }
            else
            {
                this.sql = "SELECT sp.GROUP_ID, sp.PRODUCT_ID, sp.PRODUCT_NAME, sp.PRODUCT_UNIT, sp.PRODUCT_PER_UNIT, sp.PRODUCT_TOTAL FROM stock_product sp INNER JOIN `group` ON sp.GROUP_ID = group.GROUP_ID WHERE group.GROUP_NAME = '" + cb_groupMenu.Text + "'";
            }

            DataTable t = Program.SQLlist(this.sql);

            this.dgv_product.Rows.Clear();

            bool flagUnit = true;
            int remainUnit = 0;
            double remainPerunit = 0, totalUnit = 0;
            foreach (DataRow item in t.Rows)
            {
                int n = dgv_product.Rows.Add();
                totalUnit = Int32.Parse(item[5].ToString()) / Int32.Parse(item[4].ToString());
                remainUnit = Convert.ToInt32(totalUnit);
                remainPerunit = Int32.Parse(item[5].ToString()) - (remainUnit * Int32.Parse(item[4].ToString()));

                this.dgv_product.Rows[n].Cells[0].Value = item[0].ToString();
                this.dgv_product.Rows[n].Cells[1].Value = item[1].ToString();
                this.dgv_product.Rows[n].Cells[2].Value = item[2].ToString();
                this.dgv_product.Rows[n].Cells[3].Value = item[3].ToString();
                this.dgv_product.Rows[n].Cells[4].Value = remainUnit;
                this.dgv_product.Rows[n].Cells[5].Value = remainPerunit;
                this.dgv_product.Rows[n].Cells[8].Value = item[4].ToString();
                this.dgv_product.Rows[n].Cells[9].Value = item[5].ToString();

                foreach (DataGridViewRow row in dgv_checkUpdateProduct.Rows)
                {
                    if (row.Cells[1].Value.ToString() == this.dgv_product.Rows[n].Cells[1].Value.ToString())
                    {
                        this.dgv_product.Rows[n].Cells[6].Value = row.Cells[6].Value;
                        this.dgv_product.Rows[n].Cells[7].Value = row.Cells[7].Value;
                        flagUnit = false;
                        break;
                    }
                }
                if (flagUnit)
                {
                    this.dgv_product.Rows[n].Cells[6].Value = "";
                    this.dgv_product.Rows[n].Cells[7].Value = "";
                }

            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            bool checkError = false;

            if (dgv_checkUpdateProduct.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่อบันทึกข้อมูล!", "เตือน!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    int sum = 0;
                    int totalProduct = 0;
                    foreach (DataGridViewRow row in dgv_checkUpdateProduct.Rows)
                    {
                        totalProduct = (Int32.Parse(row.Cells[6].Value.ToString()) * Int32.Parse(row.Cells[9].Value.ToString())) + Int32.Parse(row.Cells[7].Value.ToString());
                        if (Int32.Parse(row.Cells[10].Value.ToString()) > totalProduct)
                        {
                            sum = Int32.Parse(row.Cells[10].Value.ToString()) - totalProduct;

                            this.updateStock_1(row, sum);
                            while (sum > 0)
                            {
                                this.sql = "SELECT slp.LOT_REMAIN_QTY, lp.LOT_ID, slp.PRODUCT_ID FROM sub_lot_product slp NATURAL JOIN lot_product lp WHERE slp.PRODUCT_ID = '" + row.Cells[1].Value.ToString() + "' AND slp.LOT_REMAIN_QTY > 0";
                                MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);

                                Program.connect.Open();
                                MySqlDataReader reader = cmd.ExecuteReader();
                                reader.Read();
                                int tempNum1 = reader.GetInt32("LOT_REMAIN_QTY");
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
                            int sumProduct = this.checkSumProduct(row.Cells[1].Value.ToString());
                            if (totalProduct <= sumProduct)
                            {
                                sum = totalProduct - Int32.Parse(row.Cells[10].Value.ToString());

                                this.updateStock_2(row, sum);
                                while (sum > 0)
                                {
                                    this.sql = "SELECT slp.LOT_RECEIVE_QTY, slp.LOT_REMAIN_QTY, lp.LOT_ID, slp.PRODUCT_ID, sp.PRODUCT_PER_UNIT FROM sub_lot_product slp NATURAL JOIN lot_product lp NATURAL JOIN stock_product sp WHERE slp.PRODUCT_ID = '" + row.Cells[1].Value.ToString() + "' AND (slp.LOT_REMAIN_QTY < (slp.LOT_RECEIVE_QTY * sp.PRODUCT_PER_UNIT))";
                                    MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);

                                    Program.connect.Open();
                                    MySqlDataReader reader = cmd.ExecuteReader();
                                    reader.Read();
                                    int tempNum1 = reader.GetInt32("LOT_RECEIVE_QTY") * reader.GetInt32("PRODUCT_PER_UNIT"); ;
                                    int tempNum2 = reader.GetInt32("LOT_REMAIN_QTY");
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
                            else
                            {
                                checkError = true;
                                MessageBox.Show("จำนวนสินค้า '" + row.Cells[2].Value.ToString() + "' ในสต๊อคมีจำนวนน้อยกว่าการอัพเดท!", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }

                    sum = 0;
                    this.tb_searchProduct.Text = "";
                    this.listProduct("");

                    if (dgv_checkUpdateProduct.Rows.Count > 1 && checkError == false)
                    {
                        dr = MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            this.dgv_checkUpdateProduct.Rows.Clear();
                            this.dgv_product.Rows.Clear();
                            this.button_back_Click(sender, e);
                        }
                    }
                    else
                    {
                        this.dgv_checkUpdateProduct.Rows.Clear();
                        this.dgv_product.Rows.Clear();
                        this.button_back_Click(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("คุณยังไม่ได้เลือกสินค้าที่ต้องการอัพเดท!", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.button_back_Click(sender, e);
            }
        }

        //เช็คจำนวนสินค้ารวมใน sub lot product
        private int checkSumProduct(string product_id)
        {
            int sumProduct = 0;

            this.sql = "SELECT IFNULL(SUM(LOT_RECEIVE_QTY) * sp.PRODUCT_PER_UNIT, 0) AS sumReceive FROM sub_lot_product slp NATURAL JOIN stock_product sp WHERE slp.PRODUCT_ID = '" + product_id + "' AND LOT_EXP_DATE > '" + DateTime.Now.ToString("dd/MM/yyyy") + "' ";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            sumProduct = reader.GetInt32("sumReceive");
            Program.connect.Close();
            return sumProduct;
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
            bool flag = true;
            int index = e.RowIndex;
            int column = e.ColumnIndex;
            foreach (DataGridViewRow row in dgv_checkUpdateProduct.Rows)
            {
                if (row.Cells[1].Value.ToString() == dgv_product.Rows[index].Cells[1].Value.ToString())
                {
                    row.Cells[6].Value = dgv_product.Rows[index].Cells[6].Value;
                    row.Cells[7].Value = dgv_product.Rows[index].Cells[7].Value;
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                this.addDataGridView(index, column); //เพิ่มข้อมูลจาก dgv_product ไปที่ dgv_checkUpdateProduct
            }

            this.tb_amount.Text = this.dgv_checkUpdateProduct.Rows.Count.ToString();
        }

        private void addDataGridView(int index, int column)
        {
            string temp_group = "";
            string temp_id = "";
            string temp_name = "";
            string temp_unit = "";
            string temp_remainUnit = "";
            string temp_remainPerunit = "";
            int temp_countUnit = 0;
            int temp_countPerunit = 0;
            string temp_perunit = "";
            string temp_totalProduct = "";

            temp_group = dgv_product.Rows[index].Cells[0].Value.ToString();
            temp_id = dgv_product.Rows[index].Cells[1].Value.ToString();
            temp_name = dgv_product.Rows[index].Cells[2].Value.ToString();
            temp_unit = dgv_product.Rows[index].Cells[3].Value.ToString();
            temp_remainUnit = dgv_product.Rows[index].Cells[4].Value.ToString();
            temp_remainPerunit = dgv_product.Rows[index].Cells[5].Value.ToString();
            temp_perunit = dgv_product.Rows[index].Cells[8].Value.ToString();
            temp_totalProduct = dgv_product.Rows[index].Cells[9].Value.ToString();

            if (dgv_product.Rows[index].Cells[6].Value.ToString() != "") // มีข้อมูลนับจริงหน่วยใหญ่
            {
                temp_countUnit = Int32.Parse(dgv_product.Rows[index].Cells[6].Value.ToString());
                temp_countPerunit = Int32.Parse(dgv_product.Rows[index].Cells[5].Value.ToString());
                this.dgv_checkUpdateProduct.Rows.Add(temp_group, temp_id, temp_name, temp_unit, temp_remainUnit, temp_remainPerunit, temp_countUnit, temp_countPerunit, 0, temp_perunit, temp_totalProduct);
            }
            else if (dgv_product.Rows[index].Cells[7].Value.ToString() != "") //มีข้อมูลนับจริงหน่วยย่อย
            {
                temp_countUnit = Int32.Parse(dgv_product.Rows[index].Cells[4].Value.ToString());
                temp_countPerunit = Int32.Parse(dgv_product.Rows[index].Cells[7].Value.ToString());
                this.dgv_checkUpdateProduct.Rows.Add(temp_group, temp_id, temp_name, temp_unit, temp_remainUnit, temp_remainPerunit, temp_countUnit, temp_countPerunit, 0, temp_perunit, temp_totalProduct);
            }

        }

        private void dgv_checkUpdateProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                int rowIndex = e.RowIndex;
                DialogResult dr = MessageBox.Show("คุณต้องการลบรายการสินค้าใช่ หรือ ไม่?", "รายการสินค้า", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    this.dgv_checkUpdateProduct.Rows.RemoveAt(rowIndex);
                    int temp = Int32.Parse(tb_amount.Text) - 1;
                    this.tb_amount.Text = temp.ToString();
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
            this.cb_groupMenu.Show();
            this.tb_searchProduct.Show();
            this.dgv_checkUpdateProduct.Visible = false;
            this.botton_save.Visible = false;
            this.button_back.Visible = false;
            this.button_check.Visible = true;
            this.button_backmain.Visible = true;
            this.text1.Show();
            this.text2.Show();
            this.listProduct("");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeffer
{
    public partial class ReceiveProductForm : Form
    {
        private string sql = "";
        private string lotId = "";
        public ReceiveProductForm()
        {
            InitializeComponent();
                    
        }

        private void ReceiveProductForm_Load(object sender, EventArgs e)
        {
            this.listLotProduct();           
        }

        
        //แสดงรายการหมายเลขสั่งสินค้า
        private void listLotProduct()
        {
            this.sql = "SELECT DISTINCT LOT_ID, LOT_ORDER_DATE, LOT_RECEIVE_DATE FROM `lot_product` NATURAL JOIN sub_lot_product WHERE LOT_EXP_DATE IS NOT NULL ORDER BY LOT_ID DESC";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            this.dgv_lotProduct.Rows.Clear();
                while (reader.Read())
                {
                    int n = dgv_lotProduct.Rows.Add();
                    this.dgv_lotProduct.Rows[n].Cells[0].Value = reader.GetString("LOT_ID");
                    this.dgv_lotProduct.Rows[n].Cells[1].Value = reader.GetDateTime("LOT_ORDER_DATE").ToString("dd/MM/yyyy");

                    int checknull = reader.GetOrdinal("LOT_RECEIVE_DATE");
                    if (!reader.IsDBNull(checknull))
                    {
                        this.dgv_lotProduct.Rows[n].Cells[2].Value = reader.GetDateTime("LOT_RECEIVE_DATE").ToString("dd/MM/yyyy");
                        this.dgv_lotProduct.Rows[n].Cells[3].Value = "รับสินค้าเรียบร้อย";
                        this.dgv_lotProduct.Rows[n].Cells[3].Style.ForeColor = Color.Green;
                    }
                else
                    {
                        this.dgv_lotProduct.Rows[n].Cells[2].Value = null;
                        this.dgv_lotProduct.Rows[n].Cells[3].Value = "ยังไม่ได้ทำการรับสินค้า";
                        this.dgv_lotProduct.Rows[n].Cells[3].Style.ForeColor = Color.Red;
                    }
                }
            Program.connect.Close();
        }

        //แสดงรายการสินค้า
        private void listProduct(string lotId)
        {
            this.sql = "SELECT sp.PRODUCT_ID, sp.PRODUCT_NAME, sp.PRODUCT_UNIT, slp.LOT_ORDER_QTY, slp.LOT_RECEIVE_QTY, slp.LOT_STATUS FROM ((stock_product sp NATURAL JOIN sub_lot_product slp)NATURAL JOIN lot_product lp) WHERE lp.LOT_ID = '" + lotId +"'";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
            Program.connect.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                this.checkReceived.Rows.Clear();

                while (reader.Read())
                {
                    int n = checkReceived.Rows.Add();
                    this.checkReceived.Rows[n].Cells[0].Value = n+1;
                    this.checkReceived.Rows[n].Cells[1].Value = reader.GetString("PRODUCT_ID");
                    this.checkReceived.Rows[n].Cells[2].Value = reader.GetString("PRODUCT_NAME");
                    this.checkReceived.Rows[n].Cells[3].Value = reader.GetString("PRODUCT_UNIT");
                    this.checkReceived.Rows[n].Cells[4].Value = reader.GetInt32("LOT_ORDER_QTY");
                    this.checkReceived.Rows[n].Cells[5].Value = reader.GetInt32("LOT_RECEIVE_QTY");

                    int checknull = reader.GetOrdinal("LOT_STATUS");
                    if (!reader.IsDBNull(checknull))
                    {
                        this.checkReceived.Rows[n].Cells[6].Value = reader.GetString("LOT_STATUS");

                        if(this.checkReceived.Rows[n].Cells[6].Value.ToString() == "Received")
                        {
                            this.checkReceived.Rows[n].Cells[6].Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            this.checkReceived.Rows[n].Cells[6].Style.ForeColor = Color.Red;
                        }
                            
                    }
                    else
                    {
                        this.checkReceived.Rows[n].Cells[6].Value = "Received";
                        this.checkReceived.Rows[n].Cells[6].Style.ForeColor = Color.Green;
                    }                                 
                }
            Program.connect.Close();
            this.total.Text = checkReceived.Rows.Count.ToString();
        }

        private void selectInfo()
        {
            this.sql = "SELECT * FROM lot_product WHERE LOT_ID = '"+ this.lotId + "' ";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);

            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.lotID.Text = reader.GetString("LOT_ID");
            this.dateOrder.Text = reader.GetDateTime("LOT_ORDER_DATE").ToString("dd/MM/yyyy HH:mm:ss");
           
            int checknull = reader.GetOrdinal("LOT_RECEIVE_DATE");
            if (!reader.IsDBNull(checknull))
            {
                this.dateReceived.Value = reader.GetDateTime("LOT_RECEIVE_DATE");
            }
            else
            {
                this.dateReceived.Value = DateTime.Now;
            }

            Program.connect.Close();
        }

        private void listLot_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.text1.Visible = true;
                this.text2.Visible = true;
                this.text3.Visible = true;
                this.text4.Visible = true;

                this.lotID.Visible = true;
                this.dateOrder.Visible = true;
                this.dateReceived.Visible = true;
                this.total.Visible = true;
                this.button_save.Visible = true;
                this.button_back.Visible = true;

                this.dgv_lotProduct.Visible = false;
                this.button_backmain.Visible = false;
                int rowIndex = e.RowIndex;

                this.lotId = this.dgv_lotProduct.Rows[rowIndex].Cells[0].Value.ToString();
                this.listProduct(this.lotId);
                this.selectInfo();
            }
        }

        //มีไว้ไม่ให้มัน error
        private void checkReceived_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.text1.Visible = false;
            this.text2.Visible = false;
            this.text3.Visible = false;
            this.text4.Visible = false;

            this.lotID.Visible = false;
            this.dateOrder.Visible = false;
            this.dateReceived.Visible = false;
            this.total.Visible = false;
            this.button_save.Visible = false;
            this.dgv_lotProduct.Visible = true;
            this.button_back.Visible = false;
            this.button_backmain.Visible = true;


        }

        private void checkReceived_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                if(checkReceived.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Received")
                {
                    checkReceived.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Received";
                    checkReceived.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Green;
                }
                else
                {
                    checkReceived.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Not Received";
                    checkReceived.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" กดยืนยันเพื่อบันทึกข้อมูล! ", "เตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                this.sql = "UPDATE `lot_product` SET `LOT_RECEIVE_DATE` = '" + dateReceived.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE `LOT_ID` = '" + lotID.Text + "'";
                Program.sqlOther(this.sql);
               
                this.updateSubLotProduct(); //อัพเดทใน sub lot product
                this.updateStock(); //อัพเดทใน stock product

                dr = MessageBox.Show(" บันทึกรายการรับสินค้าเรียบร้อย ", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(dr == DialogResult.OK)
                {
                    this.button_back_Click(sender, e);
                    this.listLotProduct();
                }
            }
        }

        //อัพเดทสินค้าใน sub lot product
        private void updateSubLotProduct()
        {
            foreach (DataGridViewRow row in checkReceived.Rows)
            {
                this.sql = "UPDATE `sub_lot_product` SET `LOT_RECEIVE_QTY` = '" + row.Cells[5].Value.ToString() + "', `LOT_REMAIN_QTY` = '" + row.Cells[5].Value.ToString() + "' * (SELECT PRODUCT_PER_UNIT FROM stock_product WHERE PRODUCT_ID = '"+ row.Cells[1].Value.ToString() + "'), `LOT_STATUS` = '" + row.Cells[6].Value.ToString() + "' WHERE `PRODUCT_ID` = '" + row.Cells[1].Value.ToString() + "' AND `LOT_ID` = '" + lotID.Text + "'";
                Program.sqlOther(this.sql);
            }
        }

        //อัพเดทสินค้าใน stock product
        private void updateStock()
        {
            this.sql = "SELECT `PRODUCT_ID`, SUM(`LOT_REMAIN_QTY`) FROM `sub_lot_product` WHERE `LOT_REMAIN_QTY` > 0 AND LOT_EXP_DATE > '"+ DateTime.Now.ToString("yyyy-MM-dd") + "' AND `LOT_STATUS` != 'Not received'  GROUP BY `PRODUCT_ID`";
            DataTable t = Program.SQLlist(this.sql);
            foreach (DataRow item in t.Rows)
            {
                this.sql = "UPDATE `stock_product` SET `PRODUCT_TOTAL` = '" + item[1].ToString() + "' WHERE `PRODUCT_ID` = '" + item[0].ToString() + "' ";
                Program.sqlOther(this.sql);
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

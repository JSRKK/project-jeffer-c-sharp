using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeffer.report_form
{
    public partial class ReportForm : Form
    {
        private string sql = "";
        private int countOrder = 0;
        private double sumFood = 0, sumPrice = 0, sumDiscount = 0, sumCash = 0, sumCradit = 0;

        public ReportForm()
        {
            InitializeComponent();
        }

        //รายงานการขายตามกลุ่มสินค้า
        private void GroupPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmpname = "";
            string tmp = "";
            tmp = GroupPD.Text;
            tmpname = Program.getMenuId(tmp);
            this.sql = "SELECT DIARY_MENU_DATE, MENU_ID, MENU_NAME, DIARY_MENU_QTY, DIARY_MENU_VOID FROM `menu` NATURAL JOIN `dairy_menu` WHERE MENU_ID LIKE '" + tmpname + "%' && DIARY_MENU_DATE <= '" + dateTimeStop.Value.ToString("yyyy-MM-dd") + "' && DIARY_MENU_DATE >= '" + dateTimeStart.Value.ToString("yyyy-MM-dd") + "' ";
            DataTable t = Program.SQLlist(this.sql);
            if (t.Rows.Count > 0)
            {
                this.dgv_ReportGroup.DataSource = t;
                this.BestSellButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูลในระบบ", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t.Rows.Clear();
                this.BestSellButton.Enabled = false;
            }
        }

        private void BestSellButton_Click(object sender, EventArgs e)
        {
            string tmpname = "";
            string tmp = "";
            tmp = GroupPD.Text;
            tmpname = Program.getMenuId(tmp);
            this.sql = "SELECT DIARY_MENU_DATE, MENU_ID, MENU_NAME, DIARY_MENU_QTY, DIARY_MENU_VOID FROM `menu` NATURAL JOIN `dairy_menu` WHERE MENU_ID LIKE '" + tmpname + "%' && DIARY_MENU_DATE <= '" + dateTimeStop.Value.ToString("yyyy-MM-dd") + "' && DIARY_MENU_DATE >= '" + dateTimeStart.Value.ToString("yyyy-MM-dd") + "' ORDER BY DIARY_MENU_QTY DESC";
            DataTable t = Program.SQLlist(this.sql);
            if (t.Rows.Count > 0)
            {
                this.dgv_ReportGroup.DataSource = t;
            }
        }


        //รายงานการขายตามช่วงเวลา
        private void button_search_Click(object sender, EventArgs e)
        {
            if (StartTime.Text != null && EndTime.Text != null)
            {
                if (Int16.Parse(StartTime.Text.Substring(0, 2)) <= Int16.Parse(EndTime.Text.Substring(0, 2)))
                {
                    this.sql = "SELECT MENU_ID, MENU_NAME, SUM(ORDER_QTY) FROM (`menu` NATURAL JOIN `order`) NATURAL JOIN `bill` WHERE BILL_DATE = '" + dateTimeCheck.Value.ToString("yyyy-MM-dd") + "' && ORDER_TIME >= '" + StartTime.SelectedItem + "' && ORDER_TIME <= '" + EndTime.SelectedItem + "' GROUP BY MENU_ID";
                    DataTable t = Program.SQLlist(this.sql);
                    if (t.Rows.Count > 0)
                    {
                        this.dgv_TimeReport.DataSource = t;
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลในระบบ", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        t.Rows.Clear();
                        this.dgv_TimeReport.DataSource = t;
                    }
                }
                else
                {
                    MessageBox.Show("คุณเลือกช่วงเวลาไม่ถูกต้อง", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkSelectTime();
        }

        private void EndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkSelectTime();
        }

        private void checkSelectTime()
        {
            if (StartTime.SelectedIndex != -1 && EndTime.SelectedIndex != -1)
            {
                button_search.Enabled = true;
            }
            else
            {
                button_search.Enabled = false;
            }
        }

        //รายงานการ void
        private void voidSearch_TextChanged(object sender, EventArgs e)
        {
            this.sql = "SELECT DISTINCT(MENU_ID), MENU_NAME, SUM(HISTORY_VOID_QTY), SUM(HISTORY_VOID_QTY) * ORDER_PRICE AS totalVoid FROM (`menu` NATURAL JOIN `order`) NATURAL JOIN `history_void` WHERE ORDER_STATUS = 1 && HISTORY_VOID_DATE >= '" + dtpVoid_startTime.Value.ToString("yyyy-MM-dd") + "' && HISTORY_VOID_DATE <= '" + dtpVoid_endTime.Value.ToString("yyyy-MM_dd") + "' && MENU_NAME LIKE '" + voidSearch.Text + "%' ";
            DataTable t = Program.SQLlist(this.sql);
            if (t.Rows[0].ItemArray[0].ToString() != "")
            {
                this.dgv_VoidReport.DataSource = t;
            }
            else
            {
                t.Rows.Clear();
                this.dgv_VoidReport.DataSource = t;
            }
        }

        //รายงานการ void
        private void dtpVoid_endTime_ValueChanged(object sender, EventArgs e)
        {
            this.sql = "SELECT MENU_ID, MENU_NAME, SUM(HISTORY_VOID_QTY), (SUM(HISTORY_VOID_QTY) * ORDER_PRICE) AS total FROM (`menu` NATURAL JOIN `order`) NATURAL JOIN `history_void` WHERE ORDER_STATUS = 1 && HISTORY_VOID_DATE >= '" + dtpVoid_startTime.Value.ToString("yyyy-MM-dd") + "' && HISTORY_VOID_DATE <= '" + dtpVoid_endTime.Value.ToString("yyyy-MM-dd") + "' GROUP BY MENU_ID";
            DataTable t = Program.SQLlist(this.sql);
            if (t.Rows.Count.ToString() != "0")
            {
                this.dgv_VoidReport.DataSource = t;
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูลในระบบ", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t.Rows.Clear();
                this.dgv_VoidReport.DataSource = t;
            }
        }

        //รายงานส่วนลดโปรโมชั่น
        private void buttonPro_search_Click(object sender, EventArgs e)
        {
            this.sql = "SELECT PM_DATE, PRO_NAME, COUNT(HP_DISCOUNT), PRO_DISCOUNT * COUNT(HP_DISCOUNT) FROM (`payment` NATURAL JOIN `history_promotion`) NATURAL JOIN `promotion` WHERE PM_DATE >= '" + dtpPro_startTime.Value.ToString("yyyy-MM-dd") + "' && PM_DATE <= '" + dtpPro_endTime.Value.ToString("yyyy-MM-dd") + " 23:59:59' ";
            DataTable t = Program.SQLlist(this.sql);
            if (t.Rows[0].ItemArray[0].ToString() != "")
            {
                this.dgv_Promotion.DataSource = t;
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูลในระบบ", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t.Rows.Clear();
                this.dgv_Promotion.DataSource = t;
            }
        }

        private void dtpPro_startTime_ValueChanged(object sender, EventArgs e)
        {
            this.checkSelectPromotion();
        }

        private void dtpPro_endTime_ValueChanged(object sender, EventArgs e)
        {
            this.checkSelectPromotion();
        }

        private void checkSelectPromotion()
        {
            if (dtpPro_startTime.Value <= dtpPro_endTime.Value)
            {
                buttonPro_search.Enabled = true;
            }
            else
            {
                buttonPro_search.Enabled = false;
            }
        }

        private void button_searchDiary_Click(object sender, EventArgs e)
        {
            bool checkNull = this.listDairy();
            if (checkNull)
            {
                this.selectSumDrink();
                this.selectSumFood();

                this.sum_food.Text = sumFood.ToString();
                this.sum_drink.Text = (sumPrice - sumFood).ToString();
                this.sum_bill.Text = dgv_listBill.Rows.Count.ToString();
                this.sum_order.Text = countOrder.ToString();
                this.sum_price.Text = sumPrice.ToString();
                this.sum_discount.Text = sumDiscount.ToString();
                this.sum_netprice.Text = (sumPrice - sumDiscount).ToString();
                this.sum_cash.Text = sumCash.ToString();
                this.sum_cradit.Text = sumCradit.ToString();

                this.button_save.Enabled = true;
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูลในระบบ", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.button_save.Enabled = false;
                this.clearValue();
            }
        }

        //select หมายเลขใบเสร็จ, วันที่, โต๊ะ, ราคารวม, ส่วนลด, ราคาสุทธิ, พนักงานผู้ทำรายการ, ประเภทจ่าย
        private bool listDairy()
        {
            this.sql = "SELECT pm.PM_DATE, pm.PM_ID, pm.PM_TOTAL, pm.PM_NETPRICE, pm.EMP_ID, pm.PM_TYPE, b.BILL_TABLE FROM `payment` pm INNER JOIN `bill` b ON pm.PM_ID = b.PM_ID WHERE pm.PM_DATE between '" + dtpDairy_date.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpDairy_date.Value.ToString("yyyy-MM-dd") + " 23:59:59' AND PM_STATUS = '1' GROUP BY pm.PM_ID";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            this.dgv_listBill.Rows.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int index = dgv_listBill.Rows.Add();
                    this.dgv_listBill.Rows[index].Cells[0].Value = reader.GetString("PM_ID");
                    this.dgv_listBill.Rows[index].Cells[1].Value = reader.GetDateTime("PM_DATE").ToString("dd-MM-yyyy HH:mm");
                    this.dgv_listBill.Rows[index].Cells[2].Value = reader.GetString("BILL_TABLE");
                    this.dgv_listBill.Rows[index].Cells[3].Value = reader.GetDouble("PM_TOTAL");
                    this.dgv_listBill.Rows[index].Cells[4].Value = reader.GetDouble("PM_TOTAL")- reader.GetDouble("PM_NETPRICE");
                    this.dgv_listBill.Rows[index].Cells[5].Value = reader.GetDouble("PM_NETPRICE");
                    this.dgv_listBill.Rows[index].Cells[6].Value = (reader.GetDouble("PM_NETPRICE") * 7) / 100;
                    this.dgv_listBill.Rows[index].Cells[7].Value = reader.GetString("EMP_ID");
                    this.dgv_listBill.Rows[index].Cells[8].Value = reader.GetString("PM_TYPE");

                    if (reader.GetString("PM_TYPE") == "Cash")
                    {
                        this.sumCash += reader.GetDouble("PM_NETPRICE");
                    }
                    else
                    {
                        this.sumCradit += reader.GetDouble("PM_NETPRICE");
                    }

                    this.sumPrice += reader.GetDouble("PM_TOTAL");
                    this.sumDiscount += reader.GetDouble("PM_NETPRICE") - reader.GetDouble("PM_TOTAL");
                }
            }
            else
            {
                Program.connect.Close();
                return false;
            }
            Program.connect.Close();
            return true;
        }

       

        //select ราคารวมของอาหาร
        private void selectSumFood()
        {
            this.sql = "SELECT IFNULL(SUM(order.ORDER_PRICE),0) AS sumFood FROM ((payment INNER JOIN bill ON payment.PM_ID = bill.PM_ID) NATURAL JOIN `order`) NATURAL JOIN `menu` WHERE payment.PM_DATE = '" + dtpDairy_date.Value.ToString("yyyy-MM-dd") + "' AND menu.MENU_ID NOT LIKE 'WDR%' ";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.sumFood = reader.GetDouble("sumFood");
                }
            }
            Program.connect.Close();
        }
       
        //select ราคารวมของเครื่องดื่ม
        private void selectSumDrink()
        {
            this.sql = "SELECT COUNT(order.MENU_ID) AS countOrder FROM ((payment INNER JOIN bill ON payment.PM_ID = bill.PM_ID) NATURAL JOIN `order`) WHERE payment.PM_DATE = '" + dtpDairy_date.Value.ToString("yyyy-MM-dd") + "' ";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.countOrder = reader.GetInt16("countOrder");
                }
            }
            Program.connect.Close();
        }

        

        //insert ข้อมูลลง dairymenu
        private void insertDairyMenu()
        {
            this.sql = "SELECT * FROM dairy_menu WHERE DIARY_MENU_DATE='" + dtpDairy_date.Value.ToString("yyyy-MM-dd") + "'";
            DataTable t = Program.SQLlist(this.sql);
            if (t.Rows.Count.ToString() == "0")
            {
                this.sql = "INSERT INTO dairy_menu`(MENU_ID`, DIARY_MENU_DATE, DIARY_MENU_QTY, DIARY_MENU_VOID, DIARY_MENU_TOTAL) (SELECT  MENU_ID, BILL_DATE, SUM(ORDER_QTY) - IFNULL(SUM(HISTORY_VOID_QTY),0), IFNULL(SUM(HISTORY_VOID_QTY),0) AS void, ((SUM(ORDER_QTY) - IFNULL(SUM(HISTORY_VOID_QTY),0)) * ORDER_PRICE) AS total  FROM payment AS p INNER JOIN bill AS b ON p.PM_ID = b.PM_ID INNER JOIN order AS o ON b.BILL_ID = o.BILL_ID LEFT JOIN history_void hv ON o.ORDER_ID = hv.ORDER_ID WHERE p.PM_DATE between '" + dtpDairy_date.Value.ToString("yyyy-MM-dd") + "' and '" + dtpDairy_date.Value.ToString("yyyy-MM-dd") + " 23:59:59' GROUP BY o.MENU_ID ) ";
                Program.sqlOther(this.sql);
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("คุณได้บันทึกข้อมูลนี้ไปแล้ว", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearValue()
        {
            this.sum_food.Text = "0";
            this.sum_drink.Text = "0";
            this.sum_bill.Text = "0";
            this.sum_order.Text = "0";
            this.sum_price.Text = "0";
            this.sum_discount.Text = "0";
            this.sum_netprice.Text = "0";
            this.sum_cash.Text = "0";
            this.sum_cradit.Text = "0";

            this.countOrder = 0;
            this.sumFood = 0;
            this.sumDiscount = 0;
            this.sumPrice = 0;
            this.sumCash = 0;
            this.sumCradit = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (dgv_listBill.Rows.Count > 0)
            {
                this.insertDairyMenu();
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

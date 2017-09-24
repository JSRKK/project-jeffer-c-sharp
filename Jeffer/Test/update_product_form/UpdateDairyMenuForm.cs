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

namespace Jeffer.update_product_form
{
    public partial class UpdateDairyMenuForm : Form
    {
        private string sql = "";
        private int  countOrder = 0;
        private double sumFood = 0, sumPrice = 0, sumDiscount = 0, sumCash = 0, sumCradit = 0;

        public UpdateDairyMenuForm()
        {
            InitializeComponent();
            this.text_date.Text = DateTime.Now.Date.ToString("dddd dd MMMM yyyy");
        }

        
        private void dtp_dateDairy_ValueChanged(object sender, EventArgs e)
        {
            bool checkNull = this.listDairy();
            if(checkNull)
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
            }
            else
            {              
                MessageBox.Show("ไม่พบข้อมูลในระบบ!", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearValue();
            }
            
        }

        //select หมายเลขใบเสร็จ, วันที่, โต๊ะ, ราคารวม, ส่วนลด, ราคาสุทธิ, พนักงานผู้ทำรายการ, ประเภทจ่าย
        private bool listDairy()
        {
            this.sql = "SELECT pm.PM_DATE, pm.PM_ID, pm.PM_TOTAL, pm.PM_NETPRICE, pm.EMP_ID, pm.PM_TYPE, b.BILL_TABLE FROM payment pm NATURAL JOIN bill b WHERE pm.PM_DATE = '" + dtp_dateDairy.Value.ToString("yyyy-MM-dd") + "' ";
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
                    this.dgv_listBill.Rows[index].Cells[4].Value = reader.GetDouble("PM_NETPRICE") - reader.GetDouble("PM_TOTAL");
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
            this.sql = "SELECT IFNULL(SUM(menu.MENU_PRICE),0) AS sumFood FROM ((payment NATURAL JOIN bill) NATURAL JOIN `order`) NATURAL JOIN `menu` WHERE payment.PM_DATE = '" + dtp_dateDairy.Value.ToString("yyyy-MM-dd") + "' AND menu.MENU_ID NOT LIKE 'WDR%' ";
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
            this.sql = "SELECT COUNT(order.MENU_ID) AS countOrder FROM ((payment NATURAL JOIN bill) NATURAL JOIN `order`) WHERE payment.PM_DATE = '" + dtp_dateDairy.Value.ToString("yyyy-MM-dd") + "' ";
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

        private void button_save_Click(object sender, EventArgs e)
        {
            this.insertDairyMenu(); 
        }

        //insert ข้อมูลลง dairymenu
        private void insertDairyMenu()
        {
            this.sql = "INSERT INTO `dairy_menu`(`MENU_ID`, `DIARY_MENU_DATE`, `DIARY_MENU_QTY`, `DIARY_MENU_VOID`, `DIARY_MENU_TOTAL`) (SELECT  MENU_ID, BILL_DATE, SUM(ORDER_QTY), IFNULL(SUM(HISTORY_VOID_QTY),0), (SUM(ORDER_QTY) - IFNULL(SUM(HISTORY_VOID_QTY),0)) AS total  FROM ((payment p NATURAL JOIN bill b) NATURAL JOIN `order` o) LEFT JOIN history_void hv ON o.ORDER_ID = hv.ORDER_ID WHERE p.PM_DATE = '" + dtp_dateDairy.Value.ToString("yyyy-MM-dd") + "' GROUP BY o.MENU_ID ) ";
            Program.sqlOther(this.sql);
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
        private void button_backmain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainmenuForm = new MenuForm.MainMenuForm();
            Program.mainmenuForm.ShowDialog();
            this.Close();
        }
    }
}

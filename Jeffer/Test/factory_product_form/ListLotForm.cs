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
    public partial class ListLotForm : Form
    {
        private string sql = "";
        public ListLotForm()
        {
            InitializeComponent();          
            showlistLot();
        }

        //แสดงรายการหมายเลขสั่งสินค้า
        private void showlistLot()
        {
            this.sql = "SELECT DISTINCT LOT_ID, LOT_ORDER_DATE, LOT_RECEIVE_DATE, LOT_EXP_DATE FROM `lot_product` NATURAL JOIN sub_lot_product ORDER BY LOT_ID DESC";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            listLot.Rows.Clear();

            while (reader.Read())
            {
                int n = listLot.Rows.Add();
                this.listLot.Rows[n].Cells[0].Value = reader.GetString("LOT_ID");
                this.listLot.Rows[n].Cells[1].Value = reader.GetDateTime("LOT_ORDER_DATE").ToString("dd/MM/yyyy");

                int checknull = reader.GetOrdinal("LOT_RECEIVE_DATE");
                if (!reader.IsDBNull(checknull))
                {
                    this.listLot.Rows[n].Cells[2].Value = reader.GetDateTime("LOT_RECEIVE_DATE").ToString("dd/MM/yyyy");
                }
                else
                {
                    this.listLot.Rows[n].Cells[2].Value = null;
                }

                int checknull2 = reader.GetOrdinal("LOT_EXP_DATE");
                if (!reader.IsDBNull(checknull2) && !reader.IsDBNull(checknull))
                {
                    this.listLot.Rows[n].Cells[3].Value = "จัดส่งสินค้าเรียบร้อย";
                    this.listLot.Rows[n].Cells[3].Style.ForeColor = Color.Green;
                }
                else if(!reader.IsDBNull(checknull2))
                {
                    this.listLot.Rows[n].Cells[3].Value = "กำลังดำเนินการ";
                    this.listLot.Rows[n].Cells[3].Style.ForeColor = Color.Blue;
                }
                else
                {
                    this.listLot.Rows[n].Cells[3].Value = "ยังไม่ได้จัดส่งสินค้า";
                    this.listLot.Rows[n].Cells[3].Style.ForeColor = Color.Red;
                }

            }
            Program.connect.Close();
        }

        
        private void listLot_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string idG = this.listLot.Rows[e.RowIndex].Cells[0].Value.ToString();
                ShippingForm.lotId = idG;

                this.Hide();
                Program.shippingForm = new ShippingForm();
                Program.shippingForm.ShowDialog();
                this.Close();
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

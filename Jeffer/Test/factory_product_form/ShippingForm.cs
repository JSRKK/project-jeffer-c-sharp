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
    public partial class ShippingForm : Form
    {
        public static DateTimePicker dtp;
        public static int row, col;
        public static string idG;
        public static bool checkDtp = false;
        private string sql = "";

        public ShippingForm()
        {
            InitializeComponent();
            showlistproduct(idG);
        }

        //แสดงรายการสินค้า
        private void showlistproduct(string idG)
        {
            this.sql = "SELECT sp.PRODUCT_ID, sp.PRODUCT_NAME, sp.PRODUCT_UNIT, slp.LOT_ORDER_QTY, slp.LOT_RECEIVE_QTY, lp.LOT_ID, lp.LOT_ORDER_DATE, lp.LOT_RECEIVE_DATE, slp.LOT_EXP_DATE, slp.LOT_STATUS, lp.EMP_ID FROM ((stock_product sp INNER JOIN sub_lot_product slp ON sp.PRODUCT_ID = slp.PRODUCT_ID)INNER JOIN lot_product lp ON lp.LOT_ID = slp.LOT_ID) WHERE lp.LOT_ID = '" + idG + "'";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            dgv_checkReceived.Rows.Clear();

            string lot = "", dateorder = "", datesent = "";
            while (reader.Read())
            {
                int n = dgv_checkReceived.Rows.Add();
                dgv_checkReceived.Rows[n].Cells[0].Value = n + 1;
                dgv_checkReceived.Rows[n].Cells[1].Value = reader.GetString("PRODUCT_ID");
                dgv_checkReceived.Rows[n].Cells[2].Value = reader.GetString("PRODUCT_NAME");
                dgv_checkReceived.Rows[n].Cells[3].Value = reader.GetString("PRODUCT_UNIT");
                dgv_checkReceived.Rows[n].Cells[4].Value = reader.GetInt32("LOT_ORDER_QTY");
                dgv_checkReceived.Rows[n].Cells[5].Value = reader.GetInt32("LOT_ORDER_QTY");

                int checknull = reader.GetOrdinal("LOT_EXP_DATE");

                if (!reader.IsDBNull(checknull))
                {
                    dgv_checkReceived.Rows[n].Cells[6].Value = reader.GetDateTime("LOT_EXP_DATE").ToString("dd/MM/yyyy");
                }
                else
                {
                    dgv_checkReceived.Rows[n].Cells[6].Value = null;
                }

                checknull = reader.GetOrdinal("LOT_STATUS");
                if (!reader.IsDBNull(checknull))
                {
                    dgv_checkReceived.Rows[n].Cells[7].Value = reader.GetString("LOT_STATUS");
                }
                else
                {
                    dgv_checkReceived.Rows[n].Cells[7].Value = null;
                }
                lot = reader.GetString("LOT_ID");

                dateorder = reader.GetDateTime("LOT_ORDER_DATE").ToString("dd/MM/yyyy");

                checknull = reader.GetOrdinal("LOT_RECEIVE_DATE");
                if (!reader.IsDBNull(checknull))
                {
                    datesent = reader.GetDateTime("LOT_RECEIVE_DATE").ToString("dd/MM/yyyy");
                }
                else
                {
                    datesent = DateTime.Now.ToString("dd/MM/yyyy");
                }

                
            }
            Program.connect.Close();
            numberProduct.Text = lot;
            total.Text = dgv_checkReceived.Rows.Count.ToString();
            dateOrder.Text = dateorder;
            dateSent.Text = datesent;
        }

        //บันทึกข้อมูล
        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("กดยืนยันเพื่อบันทึกรายการจัดส่งสินค้า", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgv_checkReceived.Rows)
                {
                    DateTime dt = DateTime.ParseExact(row.Cells[6].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    this.sql = "UPDATE `sub_lot_product` SET `LOT_RECEIVE_QTY` = '" + row.Cells[5].Value.ToString() + "', `LOT_EXP_DATE` = '" + dt.ToString("yyyy-MM-dd") + "' WHERE `PRODUCT_ID` = '" + row.Cells[1].Value.ToString() + "' AND `LOT_ID` = '" + numberProduct.Text + "'";
                    Program.sqlOther(this.sql);
                }
                dr = MessageBox.Show("คุณได้บันทึกรายการเสร็จเรียบร้อยแล้ว", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(dr == DialogResult.OK)
                {
                    this.button_back_Click(sender, e);
                }
            }
        }

        
        private void dgv_checkReceived_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 6 && e.RowIndex != -1 && dgv_checkReceived.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value == null)
            {
                dtp = new DateTimePicker();
                dgv_checkReceived.Controls.Add(dtp);
                dtp.CustomFormat = "dd/MM/yyyy";
                dtp.Format = DateTimePickerFormat.Custom;
                Rectangle Rectangle = dgv_checkReceived.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(Rectangle.Width, Rectangle.Height);
                dtp.Location = new Point(Rectangle.X, Rectangle.Y);

                dtp.Visible = true;
                checkDtp = true;
                row = e.RowIndex;
                col = e.ColumnIndex;
                dtp.TextChanged += new EventHandler(dtp_OnTextChange);
            }
        }

        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            dgv_checkReceived.Rows[row].Cells[col].Value = dtp.Text;
            dtp.Visible = false;
            checkDtp = false;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listlotForm = new ListLotForm();
            Program.listlotForm.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void Time_1_Click(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void dgv_checkReceived_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (checkDtp == true)
            {
                dtp.Visible = false;
            }
        }

    }
}

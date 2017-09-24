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

namespace Jeffer.schedule_employee_form
{
    public partial class HolidayForm : Form
    {
        private string sql = "";
        MonthCalendar MCalendar;
        public HolidayForm()
        {
            InitializeComponent();
        }

        //select วันหยุด
        private void HolidayForm_Load(object sender, EventArgs e)
        {
            this.sql = "SELECT `HOLIDAY_DATE`, `HOLIDAY_DETAIL` FROM `holiday_entitlememnt` WHERE 1";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            this.dgv_listHoliday.Rows.Clear();
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int index = this.dgv_listHoliday.Rows.Add();
                this.dgv_listHoliday.Rows[index].Cells[0].Value = reader.GetDateTime("HOLIDAY_DATE").ToString("dd/MM/yyyy");
                this.dgv_listHoliday.Rows[index].Cells[1].Value = reader.GetString("HOLIDAY_DETAIL");
            }
            Program.connect.Close();
        }

        private void button_addDate_Click(object sender, EventArgs e)
        {
            this.MCalendar = new MonthCalendar();
            Controls.Add(MCalendar);
            this.MCalendar.Size = new Size(241, 180);
            this.MCalendar.Location = new Point(270, 94);
            this.MCalendar.BringToFront();

            this.MCalendar.Visible = true;
            this.MCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MCalendar_DateSelected);
        }

        private void MCalendar_DateSelected(object sender, EventArgs e)
        {       
            this.MCalendar.Visible = false;
            if(tb_editDate.Visible == false)
            {
                this.textBox_date.Text = MCalendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            }
            else
            {
                this.tb_editDate.Text = MCalendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            }
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_date.Text) || String.IsNullOrEmpty(textBox_detail.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่อบันทึกข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.OK)
                {
                    DateTime dt = DateTime.ParseExact(textBox_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    this.sql = "INSERT INTO `holiday`(`HOLIDAY_DATE`, `HOLIDAY_DETAIL`) VALUES ('" + dt.ToString("yyyy-MM-dd") + "','" + textBox_detail.Text + "')";
                    Program.sqlOther(this.sql);

                    this.textBox_date.ResetText();
                    this.textBox_detail.ResetText();
                    this.HolidayForm_Load(sender, e);
                }
            }           
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.textBox_date.ResetText();
            this.textBox_detail.ResetText();
        }

        private void button_backmain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.showscheduleForm = new ShowScheduleForm();
            Program.showscheduleForm.ShowDialog();
            this.Close();
        }

        private void dgv_listHoliday_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 2)
                {
                    this.label_edit_date.Visible = true;
                    this.label_edit_detail.Visible = true;
                    this.tb_editDate.Visible = true;
                    this.tb_editDetail.Visible = true;
                    this.button_update2.Visible = true;
                    this.button_cancel2.Visible = true;

                    this.tb_editDate.Text = this.dgv_listHoliday.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.tb_editDetail.Text = this.dgv_listHoliday.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                else if (e.ColumnIndex == 3)
                {
                    DialogResult dr = MessageBox.Show("กดยืนยันเพื่อลบข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if(dr == DialogResult.OK)
                    {
                        DateTime dt = DateTime.ParseExact(dgv_listHoliday.Rows[e.RowIndex].Cells[0].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        this.sql = "DELETE FROM `holiday` WHERE `HOLIDAY_DATE` = '"+dt.ToString("yyyy-MM-dd")+"' ";
                        Program.sqlOther(this.sql);

                    }
                }
            }
        }

        private void button_update2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_date.Text) || String.IsNullOrEmpty(textBox_detail.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่ออัพเดทข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    DateTime dt = DateTime.ParseExact(tb_editDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    this.sql = "INSERT INTO `holiday`(`HOLIDAY_DATE`, `HOLIDAY_DETAIL`) VALUES ('" + dt.ToString("yyyy-MM-dd") + "','" + tb_editDetail.Text + "')";
                    Program.sqlOther(this.sql);

                    this.tb_editDate.ResetText();
                    this.tb_editDetail.ResetText();
                    this.label_edit_date.Visible = false;
                    this.label_edit_detail.Visible = false;
                    this.tb_editDate.Visible = false;
                    this.tb_editDetail.Visible = false;
                    this.button_update2.Visible = false;
                    this.button_cancel2.Visible = false;

                    this.HolidayForm_Load(sender, e);
                }
            }
        }

        private void button_cancel2_Click(object sender, EventArgs e)
        {
            this.tb_editDate.ResetText();
            this.tb_editDetail.ResetText();
            this.label_edit_date.Visible = false;
            this.label_edit_detail.Visible = false;
            this.tb_editDate.Visible = false;
            this.tb_editDetail.Visible = false;
            this.button_update2.Visible = false;
            this.button_cancel2.Visible = false;
        }
    }
}

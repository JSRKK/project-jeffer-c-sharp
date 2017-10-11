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
        private string temp_date = "";
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
                this.tb_date.Text = MCalendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            }
            else
            {
                this.tb_editDate.Text = MCalendar.SelectionRange.Start.ToString("dd/MM/yyyy");
            }
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tb_date.Text) || String.IsNullOrEmpty(tb_detail.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่อบันทึกข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    DateTime dt = DateTime.ParseExact(tb_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    this.sql = "INSERT INTO `holiday_entitlememnt`(`HOLIDAY_DATE`, `HOLIDAY_DETAIL`) VALUES ('" + dt.ToString("yyyy-MM-dd") + "','" + tb_detail.Text + "')";
                    Program.sqlOther(this.sql);
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tb_date.ResetText();
                    this.tb_detail.ResetText();
                    this.HolidayForm_Load(sender, e);
                }
            }           
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.tb_date.ResetText();
            this.tb_detail.ResetText();
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
                    this.temp_date = this.dgv_listHoliday.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                else if (e.ColumnIndex == 3)
                {
                    DialogResult dr = MessageBox.Show("กดยืนยันเพื่อลบข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if(dr == DialogResult.OK)
                    {
                        DateTime dt = DateTime.ParseExact(dgv_listHoliday.Rows[e.RowIndex].Cells[0].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        this.sql = "DELETE FROM `holiday_entitlememnt` WHERE `HOLIDAY_DATE` = '" + dt.ToString("yyyy-MM-dd")+"' ";
                        Program.sqlOther(this.sql);
                        this.HolidayForm_Load(sender, e);
                    }
                }
            }
        }

        private void button_update2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_editDate.Text) || String.IsNullOrEmpty(tb_editDetail.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่ออัพเดทข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    DateTime newDate = DateTime.ParseExact(tb_editDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    DateTime oldDate = DateTime.ParseExact(temp_date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    this.sql = "UPDATE `holiday_entitlememnt` SET `HOLIDAY_DATE`='" + newDate.ToString("yyyy-MM-dd") + "',`HOLIDAY_DETAIL`='" + tb_editDetail.Text + "' WHERE `HOLIDAY_DATE`='" + oldDate.ToString("yyyy-MM-dd") +"' ";
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
                    MessageBox.Show("อัพเดทข้อมูลเรียบร้อย", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}

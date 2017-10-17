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
    public partial class ShowScheduleForm : Form
    {
        private string sql = "";
        public ShowScheduleForm()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string tempdate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            this.list_shedule(tempdate);
        }

        //แสกงรายการตารางเวลา
        private void list_shedule(string tempdate)
        {
            this.sql = "SELECT SCHEDULE_DATE, SCHEDULE_START, SCHEDULE_END, SCHEDULE_HOURS, EMP_FNAME, EMP_LNAME, schedule.EMP_ID FROM `schedule` INNER JOIN `employee` ON schedule.EMP_ID = employee.EMP_ID WHERE schedule.SCHEDULE_DATE = '" + tempdate + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            dgv_listEmployee.Rows.Clear();
            Program.connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = dgv_listEmployee.Rows.Add();
                dgv_listEmployee.Rows[index].Cells[0].Value = index + 1;
                dgv_listEmployee.Rows[index].Cells[1].Value = reader.GetString("EMP_FNAME")+" "+ reader.GetString("EMP_LNAME");
                dgv_listEmployee.Rows[index].Cells[2].Value = reader.GetTimeSpan("SCHEDULE_START");
                dgv_listEmployee.Rows[index].Cells[3].Value = reader.GetTimeSpan("SCHEDULE_END");
                dgv_listEmployee.Rows[index].Cells[4].Value = Int16.Parse(reader.GetString("SCHEDULE_END").Substring(0,2)) - Int16.Parse(reader.GetString("SCHEDULE_START").Substring(0, 2));

                int checknull = reader.GetOrdinal("SCHEDULE_HOURS");
                if (!reader.IsDBNull(checknull))
                {
                    dgv_listEmployee.Rows[index].Cells[5].ReadOnly = true;
                }
                else
                {
                    dgv_listEmployee.Rows[index].Cells[5].ReadOnly = false;
                }
                           
                dgv_listEmployee.Rows[index].Cells[7].Value = reader.GetString("EMP_ID");
                dgv_listEmployee.Rows[index].Cells[8].Value = reader.GetDateTime("SCHEDULE_DATE").ToString("yyyy-MM-dd");
            }

            Program.connect.Close();

            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.addscheduleForm = new AddScheduleForm();
            Program.addscheduleForm.ShowDialog();
            this.Close();
        }

        private void dgv_listEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgv_listEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
            string time1 = dgv_listEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
            string time2 = dgv_listEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
            string date = dgv_listEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();

                if (e.RowIndex != -1 && e.ColumnIndex == 5 || e.ColumnIndex == 6)
                {
                    if (this.checkScedule(id, date))
                    {
                        if (e.ColumnIndex == 5)
                        {
                            this.showDialogEdit(id, date, time1, time2);
                        }
                        else if (e.ColumnIndex == 6)
                        {
                            DialogResult dr = MessageBox.Show("กดยืนยันเพื่อลบข้อมูล", "เตือน!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (dr == DialogResult.OK)
                            {
                                dgv_listEmployee.Rows.RemoveAt(e.RowIndex);
                                this.deleteTimeWork(id, date);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเปลี่ยนแปลงหรือลบข้อมูลได้ เนื่องจากมีการบันทึกข้อมูลการทำงานของวันที่นี้ในระบบแล้ว", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                    

        }

        private bool checkScedule(string empId, string date)
        {
            this.sql = "SELECT SCHEDULE_HOURS FROM schedule WHERE EMP_ID = '" + empId + "' AND SCHEDULE_DATE = '"+ date + "' AND SCHEDULE_HOURS IS NOT NULL";
            DataTable t = Program.SQLlist(this.sql);
            if(t.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

        private void showDialogEdit(string id, string date, string time1, string time2)
        {
            Form prompt = new Form();
            prompt.Width = 250;
            prompt.Height = 200;
            prompt.Text = "Edit";

            Label text1 = new Label() { Left = 75, Top = 10, Text = "เวลาเข้า:" };
            Label text2 = new Label() { Left = 75, Top = 60, Text = "เวลาออก:" };
            DateTimePicker timeIn = new DateTimePicker() { Left = 75, Width = 80, Top = 30 };
            DateTimePicker timeOut = new DateTimePicker() { Left = 75, Width = 80, Top = 80 };
            Button ok = new Button() { Text = "Ok", Left = 110, Width = 50, Top = 120 };
            Button cancel = new Button() { Text = "Cancel", Left = 165, Width = 50, Top = 120 };

            timeIn.Format = DateTimePickerFormat.Custom;
            timeIn.CustomFormat = "HH:mm";
            timeIn.ShowUpDown = true;
            timeIn.Text = time1;

            timeOut.Format = DateTimePickerFormat.Custom;
            timeOut.CustomFormat = "HH:mm";
            timeOut.ShowUpDown = true;
            timeOut.Text = time2;
            
            //functions
            ok.Click += (sender, e) => { this.updateTimeWork(id, date, timeIn.Text, timeOut.Text); prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };


            prompt.Controls.Add(ok);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(timeIn);
            prompt.Controls.Add(timeOut);
            prompt.Controls.Add(text1);
            prompt.Controls.Add(text2);

            prompt.StartPosition = FormStartPosition.CenterScreen;
            prompt.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            prompt.ShowDialog();

            

        }

        //Update เวลาทำงานของพนักงาน
        private void updateTimeWork(string id, string date, string time1, string time2)
        {
            int hours = Int16.Parse(time2.Substring(0, 2)) - Int16.Parse(time1.Substring(0, 2));
            this.sql = "UPDATE `schedule` SET `SCHEDULE_START`='"+time1+"',`SCHEDULE_END`='"+time2+"',`SCHEDULE_HOURS`='"+hours+"' WHERE SCHEDULE_DATE = '"+date+"' AND EMP_ID = '"+id+"' ";
            Program.sqlOther(this.sql);
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย!", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Delete เวลาทำงานของพนักงาน
        private void deleteTimeWork(string id, string date)
        {
            this.sql = "DELETE FROM `schedule` WHERE `SCHEDULE_DATE` = '" + date + "' AND `EMP_ID` = '" + id + "' ";
            Program.sqlOther(this.sql);

            MessageBox.Show("ลบข้อมูลเรียบร้อย!", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_backmain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainmenuForm = new MenuForm.MainMenuForm();
            Program.mainmenuForm.ShowDialog();
            this.Close();
        }

        private void button_holiday_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.holidayForm = new schedule_employee_form.HolidayForm();
            Program.holidayForm.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}

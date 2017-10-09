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
    public partial class AddScheduleForm : Form
    {
        private string sql = "";
        public static string empId;
        DateTime input = DateTime.Now;
        int temp;

        public AddScheduleForm()
        {
            InitializeComponent();
            setDate();
        }

        private void setDate()
        {
            if(input.DayOfWeek == 0)
            {
                temp = 7;
            }
            else
            {
                temp = (int)input.DayOfWeek;
            }
        }

        private void Mo_CheckStateChanged(object sender, EventArgs e)
        {
            int delta = (int)(DayOfWeek.Monday) - temp;
            DateTime monday = input.AddDays(7 + delta);
            date1.Text = monday.ToString("dd/MM/yyyy");         
        }

        private void Tu_CheckStateChanged(object sender, EventArgs e)
        {
            int delta = (int)(DayOfWeek.Tuesday) - temp;
            DateTime tuesday = input.AddDays(7 + delta);
            date2.Text = tuesday.ToString("dd/MM/yyyy");
        }

        private void We_CheckStateChanged(object sender, EventArgs e)
        {
            int delta = (int)(DayOfWeek.Wednesday) - temp;
            DateTime wednesday = input.AddDays(7 + delta);
            date3.Text = wednesday.ToString("dd/MM/yyyy");
        }

        private void Th_CheckStateChanged(object sender, EventArgs e)
        {
            int delta = (int)(DayOfWeek.Thursday) - temp;
            DateTime thursday = input.AddDays(7 + delta);
            date4.Text = thursday.ToString("dd/MM/yyyy");
        }

        private void Fr_CheckStateChanged(object sender, EventArgs e)
        {
            int delta = (int)(DayOfWeek.Friday) - temp;
            DateTime friday = input.AddDays(7 + delta);
            date5.Text = friday.ToString("dd/MM/yyyy");
        }

        private void Sa_CheckStateChanged(object sender, EventArgs e)
        {
            int delta = (int)(DayOfWeek.Saturday) - temp;
            DateTime saturday = input.AddDays(7 + delta);
            date6.Text = saturday.ToString("dd/MM/yyyy");
        }

        private void Su_CheckStateChanged(object sender, EventArgs e)
        {
            int delta = (int)(DayOfWeek.Sunday) - temp;
            DateTime sunday = input.AddDays(14 + delta);
            date7.Text = sunday.ToString("dd/MM/yyyy");
        }

        private void emp_Click(object sender, EventArgs e)
        {
            Program.schedulelistemployeeForm = new ScheduleListEmployeeForm();
            Program.schedulelistemployeeForm.ShowDialog();
            textEmp.Text = empId;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textEmp.Text))
            {
                bool statusbox = checkStatusAll();
                if (statusbox == true)
                {
                    DialogResult dr = MessageBox.Show("กดยืนยันเพื่อบันทึกข้อมูล", "เตือน!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        DateTime conversDT = new DateTime();                     
                        string tempdate;

                        if (Mo.CheckState == CheckState.Checked)
                        {
                            conversDT = DateTime.ParseExact(date1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            tempdate = conversDT.ToString("yyyy-MM-dd");
                            this.insertSchedule(tempdate, timeIn1.Text, timeOut1.Text);
                        }

                        if (Tu.CheckState == CheckState.Checked)
                        {
                            conversDT = DateTime.ParseExact(date2.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            tempdate = conversDT.ToString("yyyy-MM-dd");
                            this.insertSchedule(tempdate, timeIn2.Text, timeOut2.Text);
                        }

                        if (We.CheckState == CheckState.Checked)
                        {
                            conversDT = DateTime.ParseExact(date3.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            tempdate = conversDT.ToString("yyyy-MM-dd");
                            this.insertSchedule(tempdate, timeIn3.Text, timeOut3.Text);
                        }

                        if (Th.CheckState == CheckState.Checked)
                        {
                            conversDT = DateTime.ParseExact(date4.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            tempdate = conversDT.ToString("yyyy-MM-dd");
                            this.insertSchedule(tempdate, timeIn4.Text, timeOut4.Text);
                        }

                        if (Fr.CheckState == CheckState.Checked)
                        {
                            conversDT = DateTime.ParseExact(date5.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            tempdate = conversDT.ToString("yyyy-MM-dd");
                            this.insertSchedule(tempdate, timeIn5.Text, timeOut5.Text);
                        }

                        if (Sa.CheckState == CheckState.Checked)
                        {
                            conversDT = DateTime.ParseExact(date6.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            tempdate = conversDT.ToString("yyyy-MM-dd");
                            this.insertSchedule(tempdate, timeIn6.Text, timeOut6.Text);
                        }

                        if (Su.CheckState == CheckState.Checked)
                        {
                            conversDT = DateTime.ParseExact(date7.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            tempdate = conversDT.ToString("yyyy-MM-dd");
                            this.insertSchedule(tempdate, timeIn7.Text, timeOut7.Text);
                        }

                        this.Hide();
                        Program.showscheduleForm = new ShowScheduleForm();
                        Program.showscheduleForm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้! กรุณากดเลือกวันทำงาน", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้! กรุณากดเลือกพนักงาน", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        }

        private bool checkStatusAll()
        {
            bool statusbox = true;
            if(Mo.CheckState == CheckState.Unchecked && Tu.CheckState == CheckState.Unchecked && We.CheckState == CheckState.Unchecked && Th.CheckState == CheckState.Unchecked && Fr.CheckState == CheckState.Unchecked && Su.CheckState == CheckState.Unchecked && Sa.CheckState == CheckState.Unchecked)
            {
                statusbox = false;
            }
            return statusbox;
        }

        //เพิ่มข้อมูลการทำงานของพนักงาน
        private void insertSchedule(string tempdate, string timeIn, string timeOut)
        {
            this.sql = "INSERT INTO `schedule`(`SCHEDULE_DATE`, `SCHEDULE_START`, `SCHEDULE_END`, `EMP_ID`) VALUES ('" + tempdate + "', '" + timeIn + "', '" + timeOut + "', '"+empId+"')";
            Program.sqlOther(this.sql);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.showscheduleForm = new ShowScheduleForm();
            Program.showscheduleForm.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}

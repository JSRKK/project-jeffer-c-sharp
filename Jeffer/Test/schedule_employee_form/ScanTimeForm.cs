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
    public partial class ScantimeForm : Form
    {
        DateTimePicker tp;
        public static int row, col;
        public static bool checkTp = false;
        private string sql = "";
        private int original = 0;
        public ScantimeForm()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string tempdate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            this.list_shedule(tempdate);
            this.list_workedtime(tempdate);
        }

        private void list_workedtime(string tempdate)
        {
            this.sql = "SELECT `WORKING_DATE`, `WORKING_START`, `WORKING_END`, `EMP_ID` FROM `working` WHERE WORKING_DATE = '"+ tempdate + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            this.dgv_listEmployee2.Rows.Clear();

            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int index = dgv_listEmployee2.Rows.Add();
                this.dgv_listEmployee2.Rows[index].Cells[0].Value = reader.GetString("EMP_ID");
                this.dgv_listEmployee2.Rows[index].Cells[1].Value = reader.GetTimeSpan("WORKING_START");
                this.dgv_listEmployee2.Rows[index].Cells[2].Value = reader.GetTimeSpan("WORKING_END");
                this.dgv_listEmployee2.Rows[index].Cells[3].Value = "";
                this.dgv_listEmployee2.Rows[index].Cells[4].Value = "";
            }

            Program.connect.Close();

            this.original = this.dgv_listEmployee2.Rows.Count;
        }

        //แสดงรายการตารางเวลา
        private void list_shedule(string tempdate)
        {
            this.sql = "SELECT SCHEDULE_START, SCHEDULE_END, SCHEDULE_HOURS, EMP_FNAME, EMP_LNAME, EMP_TYPE, EMP_SALARY, emp.EMP_ID FROM `schedule` INNER JOIN `employee` emp ON schedule.EMP_ID = emp.EMP_ID WHERE schedule.SCHEDULE_DATE = '" + tempdate + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            this.dgv_listEmployee1.Rows.Clear();

            Program.connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = dgv_listEmployee1.Rows.Add();
                this.dgv_listEmployee1.Rows[index].Cells[0].Value = index+1;
                this.dgv_listEmployee1.Rows[index].Cells[1].Value = reader.GetString("EMP_ID");
                this.dgv_listEmployee1.Rows[index].Cells[2].Value = reader.GetTimeSpan("SCHEDULE_START");
                this.dgv_listEmployee1.Rows[index].Cells[3].Value = reader.GetTimeSpan("SCHEDULE_END");
                this.dgv_listEmployee1.Rows[index].Cells[5].Value = reader.GetString("EMP_TYPE");
                this.dgv_listEmployee1.Rows[index].Cells[6].Value = reader.GetString("EMP_SALARY");
            }

            Program.connect.Close();
        }       

        private bool checkWorked(string empId, string date, string start, string end)
        {
            this.sql = "SELECT * FROM working WHERE EMP_ID = '"+ empId + "' AND WORKING_DATE = '"+ date + "' AND WORKING_START = '"+ start + "' AND WORKING_END = '"+ end + "' ";
            DataTable t = Program.SQLlist(this.sql);
            if(t.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

        //บันทึกข้อมูล
        private void save_Click(object sender, EventArgs e)
        {
            if (this.dgv_listEmployee2.Rows.Count > this.original)
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่อบันทึกข้อมูล!", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.insertWorking();
                    this.updateSchedule();     
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย!", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgv_listEmployee1.Rows.Clear();
                    this.dgv_listEmployee2.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล!", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertWorking()
        {
            foreach (DataGridViewRow row in dgv_listEmployee2.Rows)
            {
                if (row.Cells[4].Value.ToString() != "")
                {
                    this.sql = "INSERT INTO `working`(`WORKING_START`, `WORKING_END`, `EMP_ID`, `WORKING_DATE`) VALUES ('" + row.Cells[1].Value + "', '" + row.Cells[2].Value + "', '" + row.Cells[0].Value + "', '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "')";
                    Program.sqlOther(this.sql);
                }
            }
        }

        private void updateSchedule()
        {
            double temp_hour = 0, temp_wage = 0, time_late = 0, time_work = 0;
            TimeSpan timeStart, timeEnd, timeStart2, timeEnd2, tempTimeStart = DateTime.Today.TimeOfDay;
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(monthCalendar1.SelectionRange.Start);
            string employee_id;

            foreach (DataGridViewRow row in dgv_listEmployee2.Rows)
            {
                timeStart = TimeSpan.Parse(row.Cells[1].Value.ToString());
                timeEnd = TimeSpan.Parse(row.Cells[2].Value.ToString());
                employee_id = row.Cells[0].Value.ToString();

                if (row.Cells[4].Value.ToString() == "F")
                {                  
                    this.sql = "SELECT `SCHEDULE_HOURS`, `SCHEDULE_START`, `SCHEDULE_END`, `SCHEDULE_LATE` FROM `schedule` WHERE `SCHEDULE_DATE` = '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' AND EMP_ID = '" + employee_id + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                    Program.connect.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    //select เวลาเริ่ม กับ เวลาสิ้นสุด ที่ลงตารางเวลาไว้ใน database
                    timeStart2 = reader.GetTimeSpan("SCHEDULE_START");
                    timeEnd2 = reader.GetTimeSpan("SCHEDULE_END");

                    int checknull = reader.GetOrdinal("SCHEDULE_HOURS");
                    if (!reader.IsDBNull(checknull))
                    {                           
                        temp_hour = timeEnd.Subtract(tempTimeStart).TotalHours;
                        temp_hour += reader.GetInt16("SCHEDULE_HOURS");
                           
                    }
                    else
                    {
                        if (timeEnd2.Subtract(timeStart2).TotalHours > 8)
                        {
                            tempTimeStart = timeEnd.Add(TimeSpan.FromHours(1));
                        }

                        temp_hour = timeEnd.Subtract(timeStart2).TotalHours;
                        
                    }

                    // check work time late
                    if (timeEnd.Subtract(timeStart).TotalMinutes % 30 > 0)
                    {
                        checknull = reader.GetOrdinal("SCHEDULE_LATE");
                        if (!reader.IsDBNull(checknull))
                        {
                            time_work = timeEnd.Subtract(tempTimeStart).TotalMinutes; // หาเวลาเต็มของเวลาที่ต้องทำงานเป็นนาที
                            MessageBox.Show("เวลาทำงานช่วงที่สอง = " + time_work.ToString());
                            time_late = time_work - timeEnd.Subtract(timeStart).TotalMinutes;
                            time_late += reader.GetInt16("SCHEDULE_LATE");
                            MessageBox.Show("รวมเวลาเลททั้ง2ช่วง = " + time_late.ToString());
                        }
                        else
                        {
                            time_work = timeEnd.Subtract(timeStart2).TotalMinutes; // หาเวลาเต็มของเวลาที่ต้องทำงานเป็นนาที
                            time_late = time_work - timeEnd.Subtract(timeStart).TotalMinutes;
                            MessageBox.Show("เวลาทำงานช่วงแรก = " + time_work.ToString() + " เวลาเลทช่วงแรก = " + time_late.ToString());
                        }

                    }
                    Program.connect.Close();

                    //update time late
                    this.updateLateTime(time_late, monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), employee_id);            

                    //check วันทำที่ทำงานตรงกับวันหยุดไหม
                    if (this.checkHoliday() == true)
                    {
                        //อัพเดทจำนวนชั่วโมงทำงาน
                        this.updateHours(Convert.ToInt16(temp_hour), monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), employee_id);                   
                        
                        //อัพเดท QUOTA 
                        this.sql = "UPDATE `employee` SET `EMP_QUOTA` = `EMP_QUOTA`+1 WHERE EMP_ID = '" + employee_id + "' ";
                        Program.sqlOther(this.sql);

                        //เพิ่มข้อมูลวันหยุดพิเศษ
                        this.addHistoryHoliday(employee_id);
                        
                    }
                    else
                    {
                        if (temp_hour > 8)
                        {
                            this.updateOT1(8, (Convert.ToInt16(temp_hour) - 8), monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), employee_id);                          
                        }
                        else
                        {
                            this.updateHours(Convert.ToInt16(temp_hour), monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), employee_id);                                       
                        }
                    }                        
                }
                else if(row.Cells[4].Value.ToString() == "P")
                {                
                    this.sql = "SELECT `SCHEDULE_START`, `SCHEDULE_END`, `SCHEDULE_HOURS`, `SCHEDULE_WAGE`, `SCHEDULE_LATE` FROM `schedule` WHERE `SCHEDULE_DATE` = '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' AND EMP_ID = '" + employee_id + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
                    Program.connect.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    //select เวลาเริ่ม กับ เวลาสิ้นสุด ที่ลงตารางเวลาไว้ใน database
                    timeStart2 = reader.GetTimeSpan("SCHEDULE_START");
                    timeEnd2 = reader.GetTimeSpan("SCHEDULE_END");

                    int checknull = reader.GetOrdinal("SCHEDULE_HOURS");
                    if (!reader.IsDBNull(checknull))
                    {
                            temp_hour = timeEnd.Subtract(tempTimeStart).TotalHours;
                            temp_wage = temp_hour * Double.Parse(row.Cells[5].Value.ToString());
                            temp_hour += reader.GetInt16("SCHEDULE_HOURS");                       
                            temp_wage += reader.GetDouble("SCHEDULE_WAGE");
                    }
                    else
                    {                   
                        if (timeEnd2.Subtract(timeStart2).TotalHours > 8)
                        {
                            tempTimeStart = timeEnd.Add(TimeSpan.FromHours(1));
                        }

                        temp_hour = timeEnd.Subtract(timeStart2).TotalHours;
                        temp_wage = temp_hour * Double.Parse(row.Cells[5].Value.ToString());
                    }

                    // check work time late
                    if (timeEnd.Subtract(timeStart).TotalMinutes % 30 > 0)
                    {
                        checknull = reader.GetOrdinal("SCHEDULE_LATE");
                        if (!reader.IsDBNull(checknull))
                        {
                            time_work = timeEnd.Subtract(tempTimeStart).TotalMinutes; // หาเวลาเต็มของเวลาที่ต้องทำงานเป็นนาที
                            MessageBox.Show("เวลาทำงานช่วงที่สอง = "+time_work.ToString());
                            time_late = time_work - timeEnd.Subtract(timeStart).TotalMinutes;
                            time_late += reader.GetInt16("SCHEDULE_LATE");
                            MessageBox.Show("รวมเวลาเลททั้ง2ช่วง = "+time_late.ToString());
                        }
                        else
                        {
                            time_work = timeEnd.Subtract(timeStart2).TotalMinutes; // หาเวลาเต็มของเวลาที่ต้องทำงานเป็นนาที
                            time_late = time_work - timeEnd.Subtract(timeStart).TotalMinutes;
                            MessageBox.Show("เวลาทำงานช่วงแรก = "+ time_work.ToString()+" เวลาเลทช่วงแรก = "+ time_late.ToString());
                        }

                    }
                    Program.connect.Close();

                    //update time late
                    this.updateLateTime(time_late, monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), employee_id);                 

                    if (this.checkHoliday() == true)
                    {
                        this.sql = "UPDATE `schedule` SET `SCHEDULE_OT2` = '" + Convert.ToInt16(temp_hour) + "' WHERE `SCHEDULE_DATE` = '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' AND EMP_ID = '" + employee_id + "' ";
                        Program.sqlOther(this.sql);

                        //เพิ่มข้อมูลวันหยุดพิเศษ
                        this.addHistoryHoliday(employee_id);
                    }
                    else if(day >= DayOfWeek.Friday || day == DayOfWeek.Sunday)
                    {
                        double sumhours = this.checkHoursOfWorking(employee_id);
                        double ot = (sumhours + temp_hour) - 48;
                        if ((sumhours + temp_hour) > 48)
                        {
                            if (day == DayOfWeek.Friday)
                            {
                                double hour = Math.Abs(Convert.ToInt16(temp_hour) - ot);
                                this.updateOT1(hour, ot, monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), employee_id);                                                           
                            }
                            else
                            {
                                this.sql = "UPDATE `schedule` SET `SCHEDULE_OT1` = '" + Convert.ToInt16(temp_hour) + "' WHERE `SCHEDULE_DATE` = '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' AND EMP_ID = '" + employee_id + "' ";
                                Program.sqlOther(this.sql);
                            }
                        }
                        else
                        {
                            this.updateWage(Convert.ToInt16(temp_hour), temp_wage, monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), employee_id);
                        }
                       
                    }
                    else
                    {
                        this.updateWage(Convert.ToInt16(temp_hour), temp_wage, monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), employee_id);                      
                    }              
                }               
            }
        }

        private void updateLateTime(double lateTime, string date, string empId)
        {
            this.sql = "UPDATE `schedule` SET SCHEDULE_LATE = '" + lateTime + "' WHERE `SCHEDULE_DATE` = '" + date + "' AND EMP_ID = '" + empId + "' ";
            Program.sqlOther(this.sql);
        }

        private void updateOT1(double hour, double ot, string date, string empId)
        {
            this.sql = "UPDATE `schedule` SET `SCHEDULE_HOURS` = '"+ hour +"', `SCHEDULE_OT1` = '" + ot + "' WHERE `SCHEDULE_DATE` = '" + date + "' AND EMP_ID = '" + empId + "' ";
            Program.sqlOther(this.sql);
        }

        private void updateWage(int hour, double wage, string date, string empId)
        {
            this.sql = "UPDATE `schedule` SET `SCHEDULE_HOURS` = '" + hour + "', `SCHEDULE_WAGE` = '" + wage + "' WHERE `SCHEDULE_DATE` = '" + date + "' AND EMP_ID = '" + empId + "' ";
            Program.sqlOther(this.sql);
        }

        private void updateHours(int hour, string date, string empId)
        {
            this.sql = "UPDATE `schedule` SET `SCHEDULE_HOURS` = '" + hour + "' WHERE `SCHEDULE_DATE` = '" + date + "' AND EMP_ID = '" + empId + "' ";
            Program.sqlOther(this.sql);
        }

        private void addHistoryHoliday(string employee_id)
        {
            this.sql = "INSERT INTO `history_holiday`(`EMP_ID`, `HOLIDAY_DATE`) VALUES ('" + employee_id + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "')";
            Program.sqlOther(this.sql);
        }

        private bool checkHoliday() //check วันหยุดพิเศษ เพื่อกำหนดค่า OT
        {
            bool check_holiday = false;
            this.sql = "SELECT `HOLIDAY_DATE` FROM `holiday_entitlememnt` WHERE `HOLIDAY_DATE` = '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    check_holiday = true;
                }
            Program.connect.Close();

            return check_holiday;
        }

        private double checkHoursOfWorking(string employee_id)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(monthCalendar1.SelectionRange.Start);
            int num_day;
            DateTime temp_date;
            double sum_hours = 0;
            if (day >= DayOfWeek.Friday)
            {
                if (day == DayOfWeek.Sunday)
                {
                    num_day = 7;
                }
                else
                {
                    num_day = (int)day;
                }

                temp_date = monthCalendar1.SelectionRange.Start.AddDays(-num_day);
                this.sql = "SELECT SUM(COALESCE(SCHEDULE_HOURS,0) + COALESCE(SCHEDULE_OT2, 0)) AS sum FROM schedule WHERE SCHEDULE_DATE >= '" + temp_date.ToString("yyyy-MM-dd") + "' AND SCHEDULE_DATE < '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' AND EMP_ID = '" + employee_id + "' ";
                MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
                Program.connect.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                sum_hours = reader.GetDouble("sum");
                MessageBox.Show(sum_hours.ToString());
                Program.connect.Close();
            }

            return sum_hours;
        }

        private void dgv_listEmployee1_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                string empId = dgv_listEmployee1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string start = dgv_listEmployee1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string end = dgv_listEmployee1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");

                if (this.checkWorked(empId, date, start, end))
                {
                    int index = dgv_listEmployee2.Rows.Add();
                    dgv_listEmployee2.Rows[index].Cells[0].Value = dgv_listEmployee1.Rows[e.RowIndex].Cells[1].Value;
                    dgv_listEmployee2.Rows[index].Cells[1].Value = dgv_listEmployee1.Rows[e.RowIndex].Cells[2].Value;
                    dgv_listEmployee2.Rows[index].Cells[2].Value = dgv_listEmployee1.Rows[e.RowIndex].Cells[3].Value;
                    dgv_listEmployee2.Rows[index].Cells[4].Value = dgv_listEmployee1.Rows[e.RowIndex].Cells[5].Value;
                    dgv_listEmployee2.Rows[index].Cells[5].Value = dgv_listEmployee1.Rows[e.RowIndex].Cells[6].Value;
                }
                else
                {
                    MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้ เนื่องจากมีการบันทึกข้อมูลนี้ในระบบแล้ว", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void dgv_listEmployee2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string empId = dgv_listEmployee2.Rows[e.RowIndex].Cells[0].Value.ToString();
                string start = dgv_listEmployee2.Rows[e.RowIndex].Cells[1].Value.ToString();
                string end = dgv_listEmployee2.Rows[e.RowIndex].Cells[2].Value.ToString();
                string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");

                if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
                {
                    if (this.checkWorked(empId, date, start, end))
                    {
                        tp = new DateTimePicker();
                        this.dgv_listEmployee2.Controls.Add(tp);
                        tp.Format = DateTimePickerFormat.Custom;
                        tp.CustomFormat = "HH:mm:ss";
                        tp.ShowUpDown = true;
                        tp.Text = this.dgv_listEmployee2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        Rectangle Rectangle = this.dgv_listEmployee2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        tp.Size = new Size(Rectangle.Width, Rectangle.Height);
                        tp.Location = new Point(Rectangle.X, Rectangle.Y);

                        tp.Visible = true;
                        checkTp = true;
                        row = e.RowIndex;
                        col = e.ColumnIndex;
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    if (this.checkWorked(empId, date, start, end))
                    {
                        this.dgv_listEmployee2.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเปลี่ยนแปลงหรือลบข้อมูลได้ เนื่องจากมีการบันทึกข้อมูลนี้ในระบบแล้ว", "เตือน!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void dgv_listEmployee2_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(checkTp == true)
            {
                this.tp.Visible = false;
                this.dgv_listEmployee2.Rows[row].Cells[col].Value = tp.Text;
                checkTp = false;
            }
        }
    }
}

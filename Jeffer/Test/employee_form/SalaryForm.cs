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

namespace Jeffer.employee_form
{
    public partial class SalaryForm : Form
    {
        private string sql;
        private DateTime dt, dt2;
        public SalaryForm()
        {
            InitializeComponent();      
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            this.sql = "SELECT `EMP_ID` FROM `employee`";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);           
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.cb_emp_id.Items.Add(reader.GetString("EMP_ID"));
            }
            Program.connect.Close();
        }

        private void cb_emp_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clearTextbox();
            this.sql = "SELECT emp.EMP_TNAME, emp.EMP_FNAME, emp.EMP_LNAME, emp.EMP_TYPE, emp.EMP_SALARY, RANK_NAME FROM employee emp INNER JOIN rank ON emp.RANK_ID = rank.RANK_ID WHERE EMP_ID = '" + cb_emp_id.Text+"' ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.tb_emp_name.Text = reader.GetString("EMP_TNAME") +" "+ reader.GetString("EMP_FNAME") + " " + reader.GetString("EMP_LNAME");
            this.tb_emp_rank.Text = reader.GetString("RANK_NAME");
            if (reader.GetString("EMP_TYPE") == "F")
            {
                this.tb_emp_type.Text = "Fulltime";             
            }
            else
            {
                this.tb_emp_type.Text = "Parttime";
            }
            this.tb_emp_salary.Text = reader.GetString("EMP_SALARY");

            Program.connect.Close();

            this.button_calculate.Enabled = false;
            this.button_save.Enabled = false;
        }

        private void button_backmain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainmenuForm = new MenuForm.MainMenuForm();
            Program.mainmenuForm.ShowDialog();
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            this.clearTextbox();
            this.getLastMonth();

            //เช็คข้อมูลการทำงาน
            if (this.workDay())
            {
                this.absenceDay();
                this.deduction();
            }
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double[] allReceipts = new double[6];
            double[] expenses = new double[4];
            allReceipts[0] = Double.Parse(tb_sm_workday.Text);
            allReceipts[1] = Double.Parse(tb_sm_ot_1.Text);
            allReceipts[2] = Double.Parse(tb_sm_ot_2.Text);
            allReceipts[3] = Double.Parse(tb_diligence.Text);

            expenses[0] = Double.Parse(tb_sm_absence.Text);
            expenses[1] = Double.Parse(tb_sm_late.Text);
            expenses[2] = Double.Parse(tb_insurance.Text);
            expenses[3] = Double.Parse(tb_other_pay.Text);

            this.tb_sm_receipts.Text =  allReceipts.Sum().ToString();
            this.tb_sm_pay.Text = expenses.Sum().ToString();

            this.tb_total.Text = ((allReceipts.Sum() - expenses.Sum())).ToString();
            
        }

        private bool workDay()
        {
            bool checkWorkDay = true;
            this.sql = "SELECT COUNT(DISTINCT(w.WORKING_DATE)) AS worked_date, SUM(TIMESTAMPDIFF(MINUTE, w.WORKING_START, w.WORKING_END))/60 AS worked_hours FROM working w INNER JOIN schedule sch ON w.WORKING_DATE = sch.SCHEDULE_DATE WHERE w.EMP_ID = '" + cb_emp_id.Text + "' AND sch.EMP_ID = '" + cb_emp_id.Text + "' AND w.WORKING_DATE >= '" + dt.ToString("yyyy-MM-dd") + "' AND w.WORKING_DATE <= '" + dt2.ToString("yyyy-MM-dd")+"' ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
                MySqlDataReader reader = cmd.ExecuteReader();;
                reader.Read();
                int checknull = reader.GetOrdinal("worked_hours");
                if (!reader.IsDBNull(checknull))
                {                 
                    if (this.tb_emp_type.Text == "Fulltime")
                    {
                        this.tb_workday.Text = reader.GetInt16("worked_date").ToString();
                        this.tb_sm_workday.Text = tb_emp_salary.Text.ToString();          //คิดเงินเดือน
                        this.tb_insurance.Text = ((Int16.Parse(tb_emp_salary.Text) * 5) / 100).ToString();                                       //คิดค่าประกัน
                        if(reader.GetInt16("worked_date") >= 26)
                        {
                            this.tb_diligence.Text = "500";          // เบี่ยขยัน
                        }else
                        {
                            this.tb_diligence.Text = "0";
                        }
                    }
                    else
                    {
                        this.tb_workday.Text = reader.GetInt16("worked_hours").ToString();
                        this.tb_sm_workday.Text = (reader.GetInt16("worked_hours") * (Int16.Parse(tb_emp_salary.Text))).ToString();
                        this.tb_insurance.Text = ((Int16.Parse(tb_sm_workday.Text) * 5) / 100).ToString();
                        this.tb_diligence.Text = "0";
                    }
                    this.button_calculate.Enabled = true;
                    this.button_save.Enabled = true;
                }   
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลวันที่ทำงาน กรุณาตรวจข้อมูลให้ถูกต้อง", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.button_calculate.Enabled = false;
                    this.button_save.Enabled = false;
                    checkWorkDay = false;
                }
            Program.connect.Close();

            return checkWorkDay;
        }

        private void absenceDay()
        {
            this.sql = "SELECT COUNT(sch.SCHEDULE_DATE) AS workedDay, SUM(COALESCE(SCHEDULE_OT1, 0)) AS ot1, SUM(COALESCE(SCHEDULE_OT2, 0)) AS ot2, SUM(COALESCE(SCHEDULE_LATE, 0)) AS time_late FROM schedule sch WHERE sch.SCHEDULE_DATE >= '" + dt.ToString("yyyy-MM-dd")+ "' AND sch.SCHEDULE_DATE <= '"+ dt2.ToString("yyyy-MM-dd") + "' AND EMP_ID = '" + cb_emp_id.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader(); ;
            reader.Read();
            if (reader.GetInt16("workedDay") > 0)
            {
                int temp = reader.GetInt16("workedDay") - Int16.Parse(tb_workday.Text);
                if (this.tb_emp_type.Text == "Fulltime")
                {
                    if (temp > 4)
                    {
                        this.tb_absence.Text = (temp - 4).ToString();
                        this.tb_sm_absence.Text = ((temp - 4) * (Int16.Parse(tb_emp_salary.Text) / 30)).ToString();
                    }
                    else
                    {
                        this.tb_absence.Text = "0";
                        this.tb_sm_absence.Text = "0";
                    }
                    this.tb_ot_1.Text = reader.GetString("ot1");
                    this.tb_sm_ot_1.Text = (reader.GetInt16("ot1") * 67.5).ToString();
                    this.tb_ot_2.Text = "0";
                    this.tb_sm_ot_2.Text = "0";
                }
                else
                {
                    this.tb_absence.Text = "0";
                    this.tb_sm_absence.Text = "0";
                    this.tb_ot_1.Text = reader.GetString("ot1");
                    this.tb_sm_ot_1.Text = (reader.GetDouble("ot1") * (Double.Parse(tb_emp_salary.Text) * 1.5)).ToString();
                    this.tb_ot_2.Text = reader.GetString("ot2");
                    this.tb_sm_ot_2.Text = (reader.GetDouble("ot2") * (Double.Parse(tb_emp_salary.Text) * 2)).ToString();
                }
                this.tb_late.Text = reader.GetInt16("time_late").ToString();
                this.tb_sm_late.Text = reader.GetInt16("time_late").ToString();
            }
            else
            {
                this.clearTextbox();                
            }                
            Program.connect.Close();
        }

        private void deduction()
        {
            this.sql = "SELECT SUM(DEDUCTION_TOTAL * DEDUCTION_QTY) AS sum_deduction, `EMP_ID` FROM `deduction` WHERE EMP_ID = '" + cb_emp_id.Text + "' AND DEDUCTION_DATE >= '" + dt.ToString("yyyy-MM-dd") + "' AND DEDUCTION_DATE <= '" + dt2.ToString("yyyy-MM-dd")+ "' ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader(); ;
            reader.Read();
            int checknull = reader.GetOrdinal("sum_deduction");
            if (!reader.IsDBNull(checknull))
            {
                this.tb_other_pay.Text = reader.GetString("sum_deduction");
            }
            else
            {
                this.tb_other_pay.Text = "0";
            }
            Program.connect.Close();
            
        }

        private void getLastMonth()
        {
            this.dt = DateTime.ParseExact(dtp_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            dt = dt.AddMonths(-1);
            this.dt2 = DateTime.ParseExact(dtp_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void clearTextbox()
        {
            this.tb_workday.Clear();
            this.tb_sm_workday.Clear();
            this.tb_sm_pay.Clear();
            this.tb_absence.Clear();
            this.tb_sm_absence.Clear();
            this.tb_ot_1.Clear();
            this.tb_sm_ot_1.Clear();
            this.tb_ot_2.Clear();
            this.tb_sm_ot_2.Clear();
            this.tb_late.Clear();
            this.tb_sm_late.Clear();
            this.tb_insurance.Clear();
            this.tb_diligence.Clear();
            this.tb_sm_receipts.Clear();
            this.tb_sm_pay.Clear();
            this.tb_total.Clear();
            this.tb_other_pay.Clear();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (this.checkSalary())
            {
                this.sql = "INSERT INTO `salary`(`SALARY_DATE`,`SALARY_OT1`, `SALARY_OT2`,`SALARY_DILIGENCE`,`SALARY_INSURANCE`, `SALARY_HOLIDAY_PAY`, `SALARY_LATE_PAY`, `SALARY_OTHER_PAY`,`SALARY_TOTAL`,`EMP_ID`) VALUES ('" + dtp_date.Value.ToString("yyyy-MM-dd") + "','" + tb_sm_ot_1.Text + "', '" + tb_sm_ot_2.Text + "', '" + tb_diligence.Text + "', '" + tb_insurance.Text + "', '" + tb_sm_absence.Text + "', '" + tb_sm_late.Text + "', '" + tb_other_pay.Text + "', '" + tb_total.Text + "', '" + cb_emp_id.Text + "') ";
                Program.sqlOther(this.sql);
                DialogResult dr = MessageBox.Show("บันทึกข้อมูลเรียบร้อย!", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    this.clearTextbox();
                }
            }
            else
            {
                MessageBox.Show("คุณได้บันทึกเงินเดือนของพนักงานคนนี้ไปแล้ว", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.clearTextbox();
            }

        }

        private bool checkSalary()
        {

            this.sql = "SELECT * FROM salary WHERE SALARY_DATE = '"+ dtp_date.Value.ToString("yyyy-MM-dd") + "' AND EMP_ID = '"+ cb_emp_id.Text  + "' ";
            DataTable t = Program.SQLlist(this.sql);

            if (t.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listemployeeForm = new ListEmployeeForm();
            Program.listemployeeForm.ShowDialog();
            this.Close();
        }
    }
}

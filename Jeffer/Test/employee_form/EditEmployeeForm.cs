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

namespace Jeffer.employee_form
{
    public partial class EditEmployeeForm : Form
    {
        private string sql = "";
        private string employeeId;
        private string profileId = "";


        public EditEmployeeForm()
        {
            InitializeComponent();

        }

        public EditEmployeeForm(string employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;

        }

        private void selectInformationEmployee()
        {
            this.sql = "SELECT * FROM (`employee` NATURAL JOIN `profile`) NATURAL JOIN `rank` WHERE EMP_ID='" + this.employeeId + "'";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.tb_empId.Text = reader.GetString("EMP_ID");
                this.cb_Type.Text = getType(reader.GetString("EMP_TYPE"));
                this.cb_Rank.SelectedIndex = reader.GetInt16("RANK_ID") - 1;
                this.cb_TName.Text = reader.GetString("EMP_TNAME");
                this.tb_Name.Text = reader.GetString("EMP_FNAME");
                this.tb_Last.Text = reader.GetString("EMP_LNAME");
                this.tb_Tel.Text = reader.GetString("EMP_PHONE");
                this.textAcc.Text = reader.GetString("EMP_ACCOUNT");
                this.tb_Salary.Text = reader.GetString("EMP_SALARY");

                this.comboStatus.Text = getStatus(reader.GetInt16("PROFILE_STATUS"));
                this.tb_Address.Text = reader.GetString("PROFILE_ADDRESS");
                this.tb_Email.Text = reader.GetString("PROFILE_EMAIL");
                this.cb_Edu.Text = reader.GetString("PROFILE_EDUCATION");
                this.tb_Religion.Text = reader.GetString("PROFILE_RELIGION");
                this.tb_Race.Text = reader.GetString("PROFILE_RACE");
                this.tb_Nation.Text = reader.GetString("PROFILE_NATIONALITY");
                this.tb_IDCard.Text = reader.GetString("PROFILE_ID_CARD");
                this.cb_Blood.Text = reader.GetString("PROFILE_BLOOD");
                this.dateStart.Value = reader.GetDateTime("PROFILE_START_DATE");
                this.dateTimePicker1.Value = reader.GetDateTime("PROFILE_BIRTHDATE");

                profileId = reader.GetString("PROFILE_ID");
                int checkNull = reader.GetOrdinal("PROFILE_END_DATE");
                if (!reader.IsDBNull(checkNull))
                {
                    this.dateEnd.Value = reader.GetDateTime("PROFILE_END_DATE");
                }
            }
            Program.connect.Close();
        }
        

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            this.selectInformationEmployee();
        }


        private string getStatus(int s)
        {
            string status = "";
            if (s == 1)
            {
                status = "ใช้งาน";
            }
            else
            {
                status = "ไม่ใช้งาน";
            }
            return status;
        }


        private string getType(String type)
        {
            if (type.Equals("F"))
            {
                type = "FullTime";
            }
            else
            {
                type = "PastTime";
            }
            return type;
        }


        private void updateEmployee()
        {
            char empType = this.checkEmployeeType();
            int rankId = cb_Rank.SelectedIndex + 1;
            this.sql = "UPDATE employee SET EMP_FNAME = '" + tb_Name.Text + "', EMP_LNAME='" + tb_Last.Text + "', EMP_PHONE='" + tb_Tel.Text + "', EMP_ACCOUNT='" + textAcc.Text + "', EMP_TYPE='" + empType + "', EMP_SALARY='" + tb_Salary.Text + "', RANK_ID='" + rankId + "', EMP_TNAME='" + cb_TName.Text + "' WHERE EMP_ID = '" + this.employeeId + "'";
            Program.sqlOther(this.sql);
        }

        private void updateProfile()
        {
            string dateend ;
            if(comboStatus.SelectedIndex == 1)
            {
                dateend = dateEnd.Value.Date.ToString("yyyy-MM-dd");
                this.sql = "UPDATE profile SET PROFILE_BIRTHDATE='" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', PROFILE_EDUCATION='" + cb_Edu.Text + "', PROFILE_ADDRESS='" + tb_Address.Text + "', PROFILE_START_DATE='" + dateStart.Value.Date.ToString("yyyy-MM-dd") + "',PROFILE_END_DATE ='" + dateend + "', PROFILE_STATUS='" + this.getStatus() + "',PROFILE_EMAIL = '" + tb_Email.Text + "', PROFILE_ID_CARD = '" + tb_IDCard.Text + "', PROFILE_RELIGION = '" + tb_Religion.Text + "', PROFILE_NATIONALITY = '" + tb_Nation.Text + "', PROFILE_RACE = '" + tb_Race.Text + "', PROFILE_BLOOD = '" + cb_Blood.Text + "' WHERE PROFILE_ID ='" + profileId + "'";

            }
            else
            {
                this.sql = "UPDATE profile SET PROFILE_BIRTHDATE='" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', PROFILE_EDUCATION='" + cb_Edu.Text + "', PROFILE_ADDRESS='" + tb_Address.Text + "', PROFILE_START_DATE='" + dateStart.Value.Date.ToString("yyyy-MM-dd") + "', PROFILE_END_DATE = NULL, PROFILE_STATUS='" + this.getStatus() + "',PROFILE_EMAIL = '" + tb_Email.Text + "', PROFILE_ID_CARD = '" + tb_IDCard.Text + "', PROFILE_RELIGION = '" + tb_Religion.Text + "', PROFILE_NATIONALITY = '" + tb_Nation.Text + "', PROFILE_RACE = '" + tb_Race.Text + "', PROFILE_BLOOD = '" + cb_Blood.Text + "' WHERE PROFILE_ID ='" + profileId + "'";

            }
           Program.sqlOther(this.sql);
        }
     

        private bool checkEmpty()
        {
            if ((String.IsNullOrEmpty(textAcc.Text)) ||(String.IsNullOrEmpty(tb_Tel.Text)) ||(String.IsNullOrEmpty(tb_Name.Text)) ||
               (String.IsNullOrEmpty(tb_Last.Text)) ||(String.IsNullOrEmpty(tb_IDCard.Text)) ||(String.IsNullOrEmpty(tb_Salary.Text)))
            {
                return true;
            }
            return false;
        }

        private int getStatus()
        {
            if (comboStatus.Text == "ใช้งาน")
            {
                return 1;
            }
          return 0;
        }

        private char checkEmployeeType()
        {
            if (cb_Type.Text == "PastTime")
            {
                return 'P';
            }
            else
            {
                return 'F';
            }
        }

        private bool checkCardNumber(string cardId)
        {
            long sumValue = 0;

            if (cardId.Length != 13)
            {
                return false;
            }

            for (int i = 0; i < cardId.Length - 1; i++)
            {
                sumValue += long.Parse(cardId[i].ToString()) * (13 - i);
            }

            long v = (11 - sumValue % 11) % 10;

            return cardId[12].ToString() == v.ToString();
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStatus.Text == "ใช้งาน")
            {
                dateEnd.Hide();
                endDate.Hide();
            }
            else
            {
                dateEnd.Show();
                endDate.Show();
            }
        }


        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboStatus.SelectedIndex == 1)
            {
                this.dateEnd.Visible = true;
                this.endDate.Visible = true;
            }
            else
            {
                this.dateEnd.Visible = false;
                this.endDate.Visible = false;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (this.checkEmpty())
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่ออัพเดทข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    if (this.checkCardNumber(tb_IDCard.Text))
                    {
                        this.updateEmployee();
                        this.updateProfile();

                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.button_cancel_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("หมายเลขบัตรประชาชนไม่ถูกต้อง", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.tb_IDCard.Clear();
                    }
                }
            }


        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listemployeeForm = new ListEmployeeForm();
            Program.listemployeeForm.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void tb_IDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }
      
        private void textAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }

        private void tb_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }

        private void tb_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }
    }
}

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
                textID.Text = reader.GetString("EMP_ID");
                comboType.Text = getType(reader.GetString("EMP_TYPE"));
                comboRank.SelectedIndex = reader.GetInt16("RANK_ID") - 1;
                comboTName.Text = reader.GetString("EMP_TNAME");
                textName.Text = reader.GetString("EMP_FNAME");
                textLast.Text = reader.GetString("EMP_LNAME");
                textTel.Text = reader.GetString("EMP_PHONE");
                textAcc.Text = reader.GetString("EMP_ACCOUNT");
                textSalary.Text = reader.GetString("EMP_SALARY");

                comboStatus.Text = getStatus(reader.GetInt16("PROFILE_STATUS"));
                textAdd.Text = reader.GetString("PROFILE_ADDRESS");
                textEmail.Text = reader.GetString("PROFILE_EMAIL");
                textEdu.Text = reader.GetString("PROFILE_EDUCATION");
                textReligion.Text = reader.GetString("PROFILE_RELIGION");
                textRace.Text = reader.GetString("PROFILE_RACE");
                textNation.Text = reader.GetString("PROFILE_NATIONALITY");
                textIDCard.Text = reader.GetString("PROFILE_ID_CARD");
                comboBlood.Text = reader.GetString("PROFILE_BLOOD");
                dateStart.Value = reader.GetDateTime("PROFILE_START_DATE");
                dateTimePicker1.Value = reader.GetDateTime("PROFILE_BIRTHDATE");

                profileId = reader.GetString("RANK_ID");
                int checkNull = reader.GetOrdinal("PROFILE_END_DATE");
                if (!reader.IsDBNull(checkNull))
                {
                    dateEnd.Value = reader.GetDateTime("PROFILE_END_DATE");
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
            this.sql = "UPDATE employee SET EMP_FNAME = '" + textName.Text + "', EMP_LNAME='" + textLast.Text + "', EMP_PHONE='" + textTel.Text + "', EMP_ACCOUNT='" + textAcc.Text + "', EMP_TYPE='" + this.checkComboType() + "', EMP_SALARY='" + textSalary.Text + "', RANK_ID='" + (comboRank.SelectedIndex + 1) + "', EMP_TNAME='" + comboTName.Text + "' WHERE EMP_ID = '" + this.employeeId + "'";
            Program.sqlOther(this.sql);
        }

        private void updateProfile()
        {
            string dateend = null;
            if(comboStatus.SelectedIndex == 1)
            {
                dateend = dateEnd.Value.Date.ToString("yyyy-MM-dd");
            }
            this.sql = "UPDATE profile SET PROFILE_BIRTHDATE='" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', PROFILE_EDUCATION='" + textEdu.Text + "', PROFILE_ADDRESS='" + textAdd.Text + "', PROFILE_START_DATE='" + dateStart.Value.Date.ToString("yyyy-MM-dd") + "',PROFILE_END_DATE ='" + dateend + "', PROFILE_STATUS='" + this.getStatus() + "',PROFILE_EMAIL = '" + textEmail.Text + "', PROFILE_ID_CARD = '" + textIDCard.Text + "', PROFILE_RELIGION = '" + textReligion.Text + "', PROFILE_NATIONALITY = '" + textNation.Text + "', PROFILE_RACE = '" + textRace.Text + "', PROFILE_BLOOD = '" + comboBlood.Text + "' WHERE PROFILE_ID ='" + profileId + "'";
            Program.sqlOther(this.sql);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (this.checkEmpty())
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่ออัพเดทข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    updateEmployee();
                    updateProfile();

                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.button_update_Click(sender, e);
                }
            }
        }

        private bool checkEmpty()
        {
            if ((String.IsNullOrEmpty(textAcc.Text)) ||(String.IsNullOrEmpty(textTel.Text)) ||(String.IsNullOrEmpty(textName.Text)) ||
               (String.IsNullOrEmpty(textLast.Text)) ||(String.IsNullOrEmpty(textIDCard.Text)) ||(String.IsNullOrEmpty(textSalary.Text)))
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

        private char checkComboType()
        {
            if (comboType.Text == "PastTime")
            {
                return 'P';
            }
            else
            {
                return 'F';
            }
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
            this.updateEmployee();
            this.updateProfile();
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

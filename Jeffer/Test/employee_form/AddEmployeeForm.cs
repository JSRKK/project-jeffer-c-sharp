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
    public partial class AddEmployeeForm : Form
    {
        String tname = " ";
        char ty = ' ';
        private string sql = "";

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            this.textID.Text = this.getIdEmp();
        }


        private void insertProfile()
        {
            this.sql = "INSERT INTO profile(PROFILE_BIRTHDATE, PROFILE_EDUCATION, PROFILE_ADDRESS, PROFILE_START_DATE, PROFILE_END_DATE, PROFILE_STATUS, PROFILE_EMAIL, PROFILE_ID_CARD, PROFILE_RELIGION, PROFILE_NATIONALITY, PROFILE_RACE, PROFILE_BLOOD) VALUES ('" + dateBirth.Value.Date.ToString("yyyyMMdd") + "', '" + textEdu.Text + "', '" + textAdd.Text + "', '" + dateStart.Value.Date.ToString("yyyyMMdd") + "', NULL, '" + 1 + "', '" + tb_mail.Text + "', '" + tb_idCard.Text + "', '" + textReligion.Text + "', '" + textNation.Text + "', '" + textRace.Text + "', '" + comboBlood.Text + "')";
            Program.sqlOther(this.sql);
        }


        private void insertEmployee()
        {
            String emp_ID = getIdEmp();
            int rankId = comboRank.SelectedIndex + 1;
            string profileId = this.getProfileId();
            this.sql = "INSERT INTO employee(EMP_ID, EMP_PASSWORD, EMP_FNAME, EMP_LNAME, EMP_PHONE, EMP_ACCOUNT, EMP_TYPE, EMP_SALARY, EMP_QUOTA, RANK_ID, EMP_TNAME, PROFILE_ID) VALUES ('" + emp_ID + "', '" + emp_ID + "', '" + tb_FName.Text + "', '" + tb_LName.Text + "', '" + textTel.Text + "', '" + tb_accound.Text + "', '" + ty + "', '" + textSalary.Text + "', '" + 0 + "', '" + rankId + "', '" + tname + "', '"+profileId+"')";
            Program.sqlOther(this.sql);
        }

        private string getProfileId()
        {
            string profileId = "";
            this.sql = "SELECT MAX(PROFILE_ID) FROM profile";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            profileId = reader.GetString("MAX(PROFILE_ID)");
            Program.connect.Close();

            return profileId;
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            checkComboType();

            if (checkEmpty())
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่อบันทึกข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    if(this.checkCardId()){

                        this.insertProfile();
                        this.insertEmployee();
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.button_cancel_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("พบหมายเลขบัตรประชาชนนี้อยู่ในระบบแล้ว", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private bool checkCardId()
        {
            this.sql = "SELECT PROFILE_ID_CARD FROM profile WHERE PROFILE_ID_CARD = '"+ tb_idCard .Text+ "' ";
            DataTable t = Program.SQLlist(this.sql);

            if(t.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

        private bool checkEmpty()
        {
            if ((comboTName.SelectedIndex == -1) ||(comboType.SelectedIndex == -1) || (comboRank.SelectedIndex == -1) ||
               (comboBlood.SelectedIndex == -1) || (String.IsNullOrEmpty(tb_accound.Text)) || (String.IsNullOrEmpty(textTel.Text)) ||
               (String.IsNullOrEmpty(tb_FName.Text)) ||(String.IsNullOrEmpty(tb_LName.Text)) ||(String.IsNullOrEmpty(tb_idCard.Text)) ||(String.IsNullOrEmpty(textSalary.Text)))
            {
                return true;
            }
            return false;
        }
        private void checkComboType()
        {
            if (comboType.Text == "PastTime")
            {
                ty = 'P';
            }
            else
            {
                ty = 'F';
            }
        }
       
        private string getIdEmp()
        {
            string temp = "";
            string sql = "SELECT MAX(`EMP_ID`) FROM `employee`";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int check = reader.GetOrdinal("MAX(`EMP_ID`)");
            if (!reader.IsDBNull(check))
            {
                temp = reader.GetString("MAX(`EMP_ID`)").Substring(2, 4);
                int num = Int32.Parse(temp) + 1;
                temp = num.ToString();
            }
            Program.connect.Close();
            while (temp.Length < 4)
            {
                temp = "0" + temp;
            }
            temp = "JF" + temp;
            return temp;
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
    }
}

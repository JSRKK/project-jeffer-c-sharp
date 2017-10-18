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
        private string sql = "";

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            this.tb_empId.Text = this.getIdEmp();
        }


        private void insertProfile()
        {
            this.sql = "INSERT INTO profile(PROFILE_BIRTHDATE, PROFILE_EDUCATION, PROFILE_ADDRESS, PROFILE_START_DATE, PROFILE_END_DATE, PROFILE_STATUS, PROFILE_EMAIL, PROFILE_ID_CARD, PROFILE_RELIGION, PROFILE_NATIONALITY, PROFILE_RACE, PROFILE_BLOOD) VALUES ('" + dateBirth.Value.Date.ToString("yyyy-MM-dd") + "', '" + cb_Edu.Text + "', '" + tb_Address.Text + "', '" + dateStart.Value.Date.ToString("yyyyMMdd") + "', NULL, '" + 1 + "', '" + tb_mail.Text + "', '" + tb_idCard.Text + "', '" + tb_Religion.Text + "', '" + tb_Nation.Text + "', '" + tb_Race.Text + "', '" + cb_Blood.Text + "')";
            Program.sqlOther(this.sql);
        }


        private void insertEmployee()
        {
            String emp_ID = getIdEmp();
            int rankId = cb_Rank.SelectedIndex + 1;
            string profileId = this.getProfileId();
            char emp_type = this.checkEmployeeType();
            this.sql = "INSERT INTO employee(EMP_ID, EMP_PASSWORD, EMP_TNAME, EMP_FNAME, EMP_LNAME, EMP_PHONE, EMP_ACCOUNT, EMP_TYPE, EMP_SALARY, EMP_QUOTA, RANK_ID, PROFILE_ID) VALUES ('" + emp_ID + "', '" + emp_ID + "', '" + cb_TName.Text + "', '" + tb_FName.Text + "', '" + tb_LName.Text + "', '" + tb_Tel.Text + "', '" + tb_accound.Text + "', '" + emp_type + "', '" + textSalary.Text + "', '" + 0 + "', '" + rankId + "', '"+profileId+"')";
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
            checkEmployeeType();

            if (checkEmpty())
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("กดยืนยันเพื่อบันทึกข้อมูล", "คำเตือน!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    if (this.checkCardNumber(tb_idCard.Text))
                    {
                        if (this.checkCardId())
                        {

                            this.insertProfile();
                            this.insertEmployee();
                            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.button_cancel_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("พบหมายเลขบัตรประชาชนนี้อยู่ในระบบแล้ว", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.tb_idCard.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("หมายเลขบัตรประชาชนไม่ถูกต้อง", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.tb_idCard.Clear();
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
            if ((cb_TName.SelectedIndex == -1) ||(cb_Type.SelectedIndex == -1) || (cb_Rank.SelectedIndex == -1) ||
               (cb_Blood.SelectedIndex == -1) || (String.IsNullOrEmpty(tb_accound.Text)) || (String.IsNullOrEmpty(tb_Tel.Text)) ||
               (String.IsNullOrEmpty(tb_FName.Text)) ||(String.IsNullOrEmpty(tb_LName.Text)) ||(String.IsNullOrEmpty(tb_idCard.Text)) ||(String.IsNullOrEmpty(textSalary.Text)))
            {
                return true;
            }
            return false;
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

        private bool checkCardNumber(string cardId)
        {
            long sumValue = 0;

            if(cardId.Length != 13)
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

        private void tb_idCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }

        private void textSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }

        private void tb_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }

        private void tb_accound_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }
    }
}

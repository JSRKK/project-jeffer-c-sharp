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
    public partial class ListEmployeeForm : Form
    {
        private string empId, empName, empRank, empType;
        private string sql = "";
        public ListEmployeeForm()
        {
            InitializeComponent();
        }

        private void button_backmain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainmenuForm = new MenuForm.MainMenuForm();
            Program.mainmenuForm.ShowDialog();
            this.Close();
        }

        private void ListEmployeeForm_Load(object sender, EventArgs e)
        {
            this.sql = "SELECT emp.EMP_ID, emp.EMP_FNAME, emp.EMP_LNAME, rank.RANK_NAME, emp.EMP_TYPE, emp.EMP_SALARY, prof.PROFILE_STATUS FROM (employee emp NATURAL JOIN rank) NATURAL JOIN profile prof";
            MySqlCommand cmd = new MySqlCommand(this.sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            dgv_listEmp.Rows.Clear();

            while (reader.Read())
            {
                int n = dgv_listEmp.Rows.Add();
                dgv_listEmp.Rows[n].Cells[0].Value = n+1;
                dgv_listEmp.Rows[n].Cells[1].Value = reader.GetString("EMP_ID");
                dgv_listEmp.Rows[n].Cells[2].Value = reader.GetString("EMP_FNAME");
                dgv_listEmp.Rows[n].Cells[3].Value = reader.GetString("EMP_LNAME");
                dgv_listEmp.Rows[n].Cells[4].Value = reader.GetString("RANK_NAME");
                if (reader.GetString("EMP_TYPE") == "F")
                {
                    dgv_listEmp.Rows[n].Cells[5].Value = "Fulltime";
                }
                else
                {
                    dgv_listEmp.Rows[n].Cells[5].Value = "Parttime";
                }
                dgv_listEmp.Rows[n].Cells[6].Value = reader.GetString("EMP_SALARY");
                if (reader.GetString("PROFILE_STATUS") == "1")
                {
                    dgv_listEmp.Rows[n].Cells[7].Value = "ใช้งาน";
                }
                else
                {
                    dgv_listEmp.Rows[n].Cells[7].Value = "ไม่ใช้งาน";
                }
            }
            Program.connect.Close();

            this.dgv_listEmp.CurrentCell.Selected = false;
            this.dgv_listEmp.ClearSelection();
        }

        private void dgv_listEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!= -1)
            {
                this.empId = dgv_listEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.empName = dgv_listEmp.Rows[e.RowIndex].Cells[2].Value.ToString() + dgv_listEmp.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.empRank = dgv_listEmp.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.empType = dgv_listEmp.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (e.ColumnIndex == 8)
                {
                    this.ShowDialogChangePassword();
                }
                else if (e.ColumnIndex == 9)
                {
                    this.empId = dgv_listEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.Hide();
                    Program.editemployeeForm = new EditEmployeeForm(this.empId);
                    Program.editemployeeForm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void ShowDialogChangePassword()
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 220;
            prompt.Text = "Change Password";

            Label text1 = new Label() { Left = 50, Top = 30, Width = 180, Text = "New pasword:" };
            Label text2 = new Label() { Left = 50, Top = 80, Width = 180,Text = "Confirm password:" };
            TextBox newPassword = new TextBox() { Left = 50, Width = 180, Top = 50 };
            TextBox confirmPassword = new TextBox() { Left = 50, Width = 180, Top = 100 };
            Button ok = new Button() { Text = "Ok", Left = 175, Width = 50, Top = 140 };
            Button cancel = new Button() { Text = "Cancel", Left = 225, Width = 50, Top = 140 };

            

            //functions
            ok.Click += (sender, e) => {
                if (newPassword.Text == confirmPassword.Text)
                {
                    if (String.IsNullOrEmpty(newPassword.Text) || String.IsNullOrEmpty(confirmPassword.Text))
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.updatePassword(newPassword.Text);
                        prompt.Close();
                    }
                }
                else if(newPassword.Text != confirmPassword.Text)
                {
                    MessageBox.Show("กรุณากรอก password ให้ถูกต้อง !", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newPassword.ResetText();
                    confirmPassword.ResetText();
                }               
            };

            cancel.Click += (sender, e) => { prompt.Close(); };


            prompt.Controls.Add(ok);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(newPassword);
            prompt.Controls.Add(confirmPassword);
            prompt.Controls.Add(text1);
            prompt.Controls.Add(text2);

            prompt.StartPosition = FormStartPosition.CenterScreen;
            prompt.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            prompt.ShowDialog();
        }

        private void updatePassword(String password)
        {
            this.sql = "UPDATE `employee` SET `EMP_PASSWORD`= '"+ password + "' WHERE EMP_ID = '" +this.empId+ "' ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            cmd.ExecuteNonQuery();
            Program.connect.Close();
        }

        private void button_salary_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.salaryForm = new SalaryForm();
            Program.salaryForm.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void dgv_listEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.empId = dgv_listEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Hide();
            Program.editemployeeForm = new EditEmployeeForm(this.empId);
            Program.editemployeeForm.ShowDialog();
            this.Close();
        }

        private void button_addEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.addemployeeForm = new AddEmployeeForm();
            Program.addemployeeForm.ShowDialog();
            this.Close();
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            if (dgv_listEmp.SelectedRows.Count > 0)
            {
                this.Hide();
                Program.historyworkedForm = new HistoryWorkedForm(this.empId, this.empName, this.empRank, this.empType);
                Program.historyworkedForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกพนักงาน!", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_deduction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listdeductionForm = new deduction_form.ListDeductionForm();
            Program.listdeductionForm.ShowDialog();
            this.Close();
        }
    }
}

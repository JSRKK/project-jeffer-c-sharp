using Jeffer;
using Jeffer.employee_form;
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

namespace jeffer.deduction_form
{
    public partial class DeductuinForm : Form
    {
        int count = 0;
        public DeductuinForm()
        {
            InitializeComponent();
        }

        private void button_emp_Click(object sender, EventArgs e)
        {
            Program.employeeForm = new EmployeeForm();
            Program.employeeForm.ShowDialog();
        }

        public void emp_call(string em_id2)
        {
            txtid.Text = em_id2;
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || txtid.Text == "" || count <= 0)
            {
                MessageBox.Show("Check your informations", "Informations is null!!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You sure ?",
                                                    "Check your informations",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    string sql = "INSERT INTO `deduction`(`DEDUCTION_ID`, `DEDUCTION_DATE`, `DEDUCTION_DETAIL`, `DEDUCTION_TOTAL`, `DEDUCTION_QTY`, `EMP_ID`) VALUES ('" + count + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBox1.Text + "','" + txttotal.Text + "','" + txtqty.Text + "','" + txtid.Text + "')";
                    Program.sqlOther(sql);
                    MessageBox.Show("Insert informations suscess !!");
                }
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                textBox1.Focus();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listemployeeForm = new ListEmployeeForm();
            Program.listemployeeForm.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}

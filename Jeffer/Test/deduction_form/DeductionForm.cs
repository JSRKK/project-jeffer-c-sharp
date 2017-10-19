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
            tb_id.Text = em_id2;
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (tb_detail.Text == "" || tb_id.Text == "" || tb_money.Text == "" || tb_qty.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("กดยืนยันเพื่อบันทึกข้อมูล","เตือน!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string sql = "INSERT INTO `deduction`(`DEDUCTION_DATE`, `DEDUCTION_DETAIL`, `DEDUCTION_TOTAL`, `DEDUCTION_QTY`, `EMP_ID`) VALUES ('" + dtp_date.Value.ToString("yyyy-MM-dd") + "','" + tb_detail.Text + "','" + tb_money.Text + "','" + tb_qty.Text + "','" + tb_id.Text + "')";
                    Program.sqlOther(sql);
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.button_close_Click(sender, e);
                }
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                tb_detail.Focus();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listdeductionForm = new Jeffer.deduction_form.ListDeductionForm();
            Program.listdeductionForm.ShowDialog();
            this.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void tb_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }

        private void tb_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.keyPress(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeffer.deduction_form
{
    public partial class ListDeductionForm : Form
    {
        private string sql = "";
        public ListDeductionForm()
        {
            InitializeComponent();
        }

        private void ListDeductionForm_Load(object sender, EventArgs e)
        {
            this.lisEmployee();
            this.listDeduction("");         
        }

        private void lisEmployee()
        {
            this.sql = "SELECT EMP_ID FROM employee WHERE 1";
            DataTable t = Program.SQLlist(this.sql);
            
            foreach(DataRow item in t.Rows)
            {
                cb_empId.Items.Add(item[0].ToString());
            }
        }

        private void listDeduction(string empId)
        {
            if (empId == "")
            {
                this.sql = "SELECT * FROM `deduction` WHERE 1";
            }
            else
            {
                this.sql = "SELECT * FROM `deduction` WHERE EMP_ID = '" + empId + "' ";
            }

            DataTable t = Program.SQLlist(this.sql);
            this.dgv_lsitDeduction.Rows.Clear();

            foreach(DataRow item in t.Rows)
            {
                int index = this.dgv_lsitDeduction.Rows.Add();
                this.dgv_lsitDeduction.Rows[index].Cells[0].Value = item[0].ToString();
                this.dgv_lsitDeduction.Rows[index].Cells[1].Value = item[1].ToString();
                this.dgv_lsitDeduction.Rows[index].Cells[2].Value = item[2].ToString();
                this.dgv_lsitDeduction.Rows[index].Cells[3].Value = item[3].ToString();
                this.dgv_lsitDeduction.Rows[index].Cells[4].Value = item[4].ToString();
            }
        }

        private void cb_empId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listDeduction(cb_empId.Text);
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.deductionForm = new jeffer.deduction_form.DeductuinForm();
            Program.deductionForm.ShowDialog();
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listemployeeForm = new employee_form.ListEmployeeForm();
            Program.listemployeeForm.ShowDialog();
            this.Close();
        }

       
    }
}

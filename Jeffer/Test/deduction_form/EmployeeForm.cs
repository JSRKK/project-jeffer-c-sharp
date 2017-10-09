using Jeffer;
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
    public partial class EmployeeForm : Form
    {
        public string id_emp_deduction;
        public EmployeeForm()
        {
            InitializeComponent();
        }


        private void Employee_Load(object sender, EventArgs e)
        {
            string sql = "SELECT EMP_ID,EMP_FNAME FROM `employee`";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            DataTable t = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(t);
            Table_view.DataSource = t;
            Program.connect.Close();
        }
        private void get_em_id(DataGridViewCellEventArgs e)
        {
            id_emp_deduction = Table_view.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Table_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            get_em_id(e);

        }

        private void Table_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            get_em_id(e);
            Program.deductionForm.emp_call(id_emp_deduction);
            MessageBox.Show("Employee id : " + id_emp_deduction, "Check id");
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Program.deductionForm.emp_call(id_emp_deduction);
            MessageBox.Show("Employee id : " + id_emp_deduction, "Check id");
            this.Close();
        }
    }
}

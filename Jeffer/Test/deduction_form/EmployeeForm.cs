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
        string id;
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
            id =Table_view.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            MessageBox.Show("Employee id : " + id, "Check id");
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee id : " + id, "Check id");
            this.Close();
        }

    }
}

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

namespace Jeffer
{
    public partial class ScheduleListEmployeeForm : Form
    {
        private string sql = "";
        public ScheduleListEmployeeForm()
        {
            InitializeComponent();
            list_Employee();
        }

        //แสดงรายชื่อพนักงาน
        private void list_Employee()
        {
            this.sql = "SELECT `EMP_ID`, `EMP_FNAME` FROM `employee`";

            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = listEmp.Rows.Add();
                listEmp.Rows[index].Cells[0].Value = reader.GetString("EMP_ID");
                listEmp.Rows[index].Cells[1].Value = reader.GetString("EMP_FNAME");
            }

            Program.connect.Close();
        }

        private void listEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.get_em_id(e);
                this.Close();
            }
        }

        private void listEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.get_em_id(e);
            }
        }

        private void get_em_id(DataGridViewCellEventArgs e)
        {
            AddScheduleForm.empId = listEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            AddScheduleForm.empId = "";
            this.Close();
        }

        private void listEmp_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.get_em_id(e);
                this.Close();
            }
        }
    }
}

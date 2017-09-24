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
        string sql = "";
        public ScheduleListEmployeeForm()
        {
            InitializeComponent();
            list_Employee();
        }

        //แสดงรายชื่อพนักงาน
        private void list_Employee()
        {
            this.sql = "SELECT `EMP_ID`, `EMP_FNAME`, `EMP_LNAME` FROM `employee`";

            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = listEmp.Rows.Add();
                listEmp.Rows[index].Cells[0].Value = index + 1;
                listEmp.Rows[index].Cells[1].Value = reader.GetString("EMP_ID");
                listEmp.Rows[index].Cells[2].Value = reader.GetString("EMP_FNAME") +" "+ reader.GetString("EMP_LNAME");
            }

            Program.connect.Close();
        }

        private void listEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AddScheduleForm.empId = listEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Close();
            }
        }
    }
}

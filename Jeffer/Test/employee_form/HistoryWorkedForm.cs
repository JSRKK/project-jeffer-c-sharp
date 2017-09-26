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
    public partial class HistoryWorkedForm : Form
    {
        private string sql = "";
        private string employee_id = "";

        public HistoryWorkedForm()
        {
            InitializeComponent();
        }

        public HistoryWorkedForm(string employee_id)
        {
            this.employee_id = employee_id;
            InitializeComponent();
        }

        private void HistoryWorkedForm_Load(object sender, EventArgs e)
        {
            
        }
        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.showHistoryWorked("");
        }
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            this.showHistoryWorked(tb_search.Text);
        }

        private void showHistoryWorked(string date)
        {
            bool checkdetail = false;
            if (cb_type.SelectedIndex == 0 && date == "")
            {
                this.sql = "SELECT `WORKING_DATE`, `WORKING_START`, `WORKING_END` FROM `working` WHERE `EMP_ID` = '" + employee_id + "' ORDER BY WORKING_DATE DESC";
            }
            else if (cb_type.SelectedIndex == 0 && date != "")
            {
                this.sql = "SELECT `WORKING_DATE`, `WORKING_START`, `WORKING_END` FROM `working` WHERE `EMP_ID` = '" + employee_id + "' AND `WORKING_DATE` LIKE '%" + date+"' ORDER BY WORKING_DATE DESC";
            }
            else if (cb_type.SelectedIndex == 1 && date == "")
            {
                this.sql = "SELECT `WORKING_DATE`, `WORKING_START`, `WORKING_END`, h.HOLIDAY_DETAIL FROM `working` w INNER JOIN `holiday_entitlememnt` h ON w.WORKING_DATE = h.HOLIDAY_DATE WHERE `EMP_ID` = '" + employee_id + "' ORDER BY WORKING_DATE DESC";
                checkdetail = true;
            }
            else
            {
                sql = "SELECT `WORKING_DATE`, `WORKING_START`, `WORKING_END`, h.HOLIDAY_DETAIL FROM `working` w INNER JOIN `holiday_entitlememnt` h ON w.WORKING_DATE = h.HOLIDAY_DATE WHERE `EMP_ID` = '" + employee_id + "' AND `HOLIDAY_DATE` LIKE '%" + date + "' ORDER BY WORKING_DATE DESC";
                checkdetail = true;
            }
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            dgv_listWorked.Rows.Clear();
            while (reader.Read())
            {
                int index = dgv_listWorked.Rows.Add();
                this.dgv_listWorked.Rows[index].Cells[0].Value = reader.GetDateTime("WORKING_DATE").ToString("dd/MM/yyyy");
                this.dgv_listWorked.Rows[index].Cells[1].Value = reader.GetString("WORKING_START");
                this.dgv_listWorked.Rows[index].Cells[2].Value = reader.GetString("WORKING_END");

                if (checkdetail)
                {
                    this.dgv_listWorked.Rows[index].Cells[3].Value = reader.GetString("HOLIDAY_DETAIL");
                }
                else
                {
                    this.dgv_listWorked.Rows[index].Cells[3].Value = "-";
                }
            }
            Program.connect.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listemployeeForm = new ListEmployeeForm();
            Program.listemployeeForm.ShowDialog();
            this.Close();
        }
    }
}

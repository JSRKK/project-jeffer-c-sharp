
using DGVPrinterHelper;
using jeffer;
using jeffer.deduction_form;
using jeffer.menu_form;
using Jeffer.deduction_form;
using Jeffer.employee_form;
using Jeffer.login_manager_Form;
using Jeffer.MenuForm;
using Jeffer.report_form;
using Jeffer.schedule_employee_form;
using MySql.Data.MySqlClient;
using promotion.promotion_form;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Jeffer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password='';database=db_jeffer;charset=utf8;");
        public static MySqlCommand command;
        public static string user_id = "";

        //define form
        public static OrderProductForm orderproductForm;
        public static ReceiveProductForm receiveproductForm;
        public static ListLotForm listlotForm;
        public static ShippingForm shippingForm;
        public static UpdateProductForm updateproductForm;
        public static ScheduleListEmployeeForm schedulelistemployeeForm;
        public static AddScheduleForm addscheduleForm;
        public static ShowScheduleForm showscheduleForm;
        public static ScantimeForm scantimeForm;
        public static MainMenuForm mainmenuForm;
        public static LoginForm loginForm;
        public static ReportForm reportForm;
        public static ListEmployeeForm listemployeeForm;
        public static AddEmployeeForm addemployeeForm;
        public static EditEmployeeForm editemployeeForm;
        public static AddMenuForm addmenuForm;
        public static EditMenuForm editmenuForm;
        public static ListMenuForm listmenuForm;
        public static DeductuinForm deductionForm;
        public static EmployeeForm employeeForm;
        public static HolidayForm holidayForm;
        public static SalaryForm salaryForm;
        public static HistoryWorkedForm historyworkedForm;
        public static ListPromotionForm listpromotionForm;
        public static AddPromotionForm addpromotionForm;
        public static EditPromotionForm editpromotionForm;
        public static ListDeductionForm listdeductionForm;
       
        public static string SOURCE_CONN_STRING { get; private set; }

        [STAThread] 
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginForm = new LoginForm();
            orderproductForm = new OrderProductForm();
            mainmenuForm = new MainMenuForm();
            historyworkedForm = new HistoryWorkedForm();
            updateproductForm = new UpdateProductForm();
            Application.Run(loginForm);

        }


        public static string getMenuId(string groupName)
        {
            string tmpname = "";
            if (groupName == "Appitizer")
            {
                tmpname = "MAP";
            }
            else if (groupName == "Beef")
            {
                tmpname = "MBF";
            }
            else if (groupName == "Burger")
            {
                tmpname = "MBU";
            }
            else if (groupName == "Chicken")
            {
                tmpname = "MCH";
            }
            else if (groupName == "Combo")
            {
                tmpname = "MCB";
            }
            else if (groupName == "Drinks")
            {
                tmpname = "WDR";
            }
            else if (groupName == "Kids")
            {
                tmpname = "MKD";
            }
            else if (groupName == "Pork")
            {
                tmpname = "MPK";
            }
            else if (groupName == "Seafood")
            {
                tmpname = "MSF";
            }
            else if (groupName == "Spaghetti")
            {
                tmpname = "MSP";
            }
            else if (groupName == "Promotions")
            {
                tmpname = "PRO";
            }
            else if (groupName == "Set")
            {
                tmpname = "SET";
            }

            return tmpname;
        }

        public static DataTable SQLlist(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            DataTable t = new DataTable();
            Program.connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(t);
            Program.connect.Close();

            return t;
        }

        public static void sqlOther(String sql)
        {  
            using (SqlConnection sourceCnx = new SqlConnection(SOURCE_CONN_STRING))
            {
                try
                {
                    command = new MySqlCommand(sql, Program.connect);
                    Program.connect.Open();
                    command.ExecuteNonQuery();
                    Program.connect.Close();
                }
                catch (SqlException e)
                {
                    DisplaySqlErrors(e);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public static void DisplaySqlErrors(SqlException exception)
        {
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                Console.WriteLine("Index #" + i + "\n" +
                    "Error: " + exception.Errors[i].ToString() + "\n");
            }
            Console.ReadLine();
        }
        public static DataGridView check_duplicate(DataGridView Material_view,string material_id,string material_name)
        {
                    bool check_duplicate = false;
                    if (Material_view.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in Material_view.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == material_id)
                            {
                                Material_view.Rows[row.Index].Cells[2].Value = int.Parse(Material_view.Rows[row.Index].Cells[2].Value.ToString()) + 1;
                                check_duplicate = true;
                                break;
                            }
                        }
                        if (check_duplicate == false)
                        {
                            int index = Material_view.Rows.Add();
                            Material_view.Rows[index].Cells[0].Value = material_id;
                            Material_view.Rows[index].Cells[1].Value = material_name;
                            Material_view.Rows[index].Cells[2].Value = 1;
                        }

                    }
                    else
                    {
                        int index = Material_view.Rows.Add();
                        Material_view.Rows[index].Cells[0].Value = material_id;
                        Material_view.Rows[index].Cells[1].Value = material_name;
                        Material_view.Rows[index].Cells[2].Value = 1;
                    }
        
                return Material_view;
        }

        public static void keyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        public static void print(DataGridView dgv, string title)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = title;
            printer.SubTitle = "วันที่พิมพ์ "+DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            printer.SubTitleSpacing = 20;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;           
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Jeffer steak restaurant";
            printer.PrintPreviewDataGridView(dgv);
            //printer.PrintDataGridView(dgv);
        }
    }
}

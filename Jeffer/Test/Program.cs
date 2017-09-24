
using jeffer;
using jeffer.deduction_form;
using jeffer.menu_form;
using Jeffer.employee_form;
using Jeffer.login_manager_Form;
using Jeffer.MenuForm;
using Jeffer.report_form;
using Jeffer.schedule_employee_form;
using Jeffer.update_product_form;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Jeffer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static MySqlConnection connect = new MySqlConnection("host=localhost;user=root;password='';database=db_jeffer;charset=utf8;");
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
        public static string user_id = "JF0001";
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
        public static UpdateDairyMenuForm dairymenuForm;

        public static MySqlCommand command;

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
            dairymenuForm = new UpdateDairyMenuForm();
            Application.Run(mainmenuForm);

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

        
    }
}

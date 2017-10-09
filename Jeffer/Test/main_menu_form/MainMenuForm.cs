using jeffer.menu_form;
using promotion.promotion_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeffer.MenuForm
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            timer1.Start();
            text_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.text_time.Text = dt.ToString("HH:mm:ss");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("คุณต้องการออกจากระบบใช่ หรือ ไม่?", "คำเตือน!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderproductForm = new jeffer.OrderProductForm();
            Program.orderproductForm.ShowDialog();
            this.Close();
        }

        private void button_factory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listlotForm = new ListLotForm();
            Program.listlotForm.ShowDialog();
            this.Close();
        }

        private void button_receive_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.receiveproductForm = new ReceiveProductForm();
            Program.receiveproductForm.ShowDialog();
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.updateproductForm = new UpdateProductForm();
            Program.updateproductForm.ShowDialog();
            this.Close();
        }

        private void button_schedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.showscheduleForm = new ShowScheduleForm();
            Program.showscheduleForm.ShowDialog();
            this.Close();
        }

        private void button_scantime_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.scantimeForm = new ScantimeForm();
            Program.scantimeForm.ShowDialog();
            this.Close();
        }

        

        private void button_list_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.reportForm = new report_form.ReportForm();
            Program.reportForm.ShowDialog();
            this.Close();
        }

        private void button_employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listemployeeForm = new employee_form.ListEmployeeForm();
            Program.listemployeeForm.ShowDialog();
            this.Close();
        }

        private void button_food_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listmenuForm = new ListMenuForm();
            Program.listmenuForm.ShowDialog();
            this.Close();
        }

        private void button_promotion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listpromotionForm = new ListPromotionForm();
            Program.listpromotionForm.ShowDialog();
            this.Close();
        }
    }
}

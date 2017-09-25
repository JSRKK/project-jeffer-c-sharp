using Jeffer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promotion.promotion_form
{
    public partial class AddPromotionForm : Form
    {
        string sql = "";
        public AddPromotionForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.listpromotionForm = new ListPromotionForm();
            Program.listpromotionForm.ShowDialog();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtDetail.Text == "" || numericDiscount.Value == 0 || cmbType.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ!", "Some Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = "INSERT INTO promotion (PRO_NAME,PRO_DETAIL,PRO_DISCOUNT,PRO_MINIMUM,PRO_TYPE,PRO_STATUS) VALUES ('" + txtName.Text + "', '" + txtDetail.Text + "', " + numericDiscount.Value + ", " + numericMinimum.Value + ", '" + PromotionType() + "', " + PromotionStatus() + ")";
                Program.sqlOther(sql);

                this.btnCancel_Click(sender, e);
            }
        }

        private int PromotionStatus()
        {
            if (radioActive.Checked == true) return 1;
            return 0;
        }

        private string PromotionType()
        {
            if (cmbType.Text == "Percent") return "Percent";
            return "Discount";
        }
    }
}

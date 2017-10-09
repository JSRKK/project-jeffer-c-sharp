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

namespace promotion.promotion_form
{
    public partial class EditPromotionForm : Form
    {
        string sql = "";
        string pro_id = "";
        public EditPromotionForm(string pro_id)
        {
            InitializeComponent();
            this.pro_id = pro_id;
        }

        private void EditPromotionForm_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM promotion WHERE PRO_ID=" + pro_id;
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtName.Text = reader.GetString("PRO_NAME");
                txtDetail.Text = reader.GetString("PRO_DETAIL");
                numericMinimum.Value = decimal.Parse(reader.GetDouble("PRO_MINIMUM").ToString());
                numericDiscount.Value = decimal.Parse(reader.GetDouble("PRO_DISCOUNT").ToString());
                cmbType.Text = reader.GetString("PRO_TYPE");
                if (reader.GetInt16("PRO_STATUS") == 0)
                {
                    radioNonActive.Checked = true;
                }
                else
                {
                    radioActive.Checked = true;
                }
            }
            Program.connect.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.listpromotionForm = new ListPromotionForm();
            Program.listpromotionForm.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtDetail.Text == "" || numericDiscount.Value == 0 || cmbType.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ!", "Some Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = "UPDATE `promotion` SET `PRO_NAME`='" + txtName.Text + "',`PRO_DETAIL`='" + txtDetail.Text + "',`PRO_DISCOUNT`=" + numericDiscount.Value + ",`PRO_MINIMUM`=" + numericMinimum.Value + ",`PRO_TYPE`='" + PromotionType() + "',`PRO_STATUS`=" + PromotionStatus() + " WHERE PRO_ID=" + this.pro_id;
                Program.sqlOther(sql);
                Program.listpromotionForm = new ListPromotionForm();
                Program.listpromotionForm.ShowDialog();
                this.Close();
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

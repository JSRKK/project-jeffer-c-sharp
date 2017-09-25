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

        private void EditPromotion_Load(object sender, EventArgs e)
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
            this.Hide();
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

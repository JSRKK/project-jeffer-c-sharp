﻿using Jeffer;
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
    public partial class ListPromotionForm : Form
    {
        string sql = "";
        public ListPromotionForm()
        {
            InitializeComponent();
        }

        private void ListPromotionForm_Load(object sender, EventArgs e)
        {
            sql = "SELECT * from promotion";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connect);
            Program.connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int index = dgvListPromotion.Rows.Add();
                dgvListPromotion.Rows[index].Cells[0].Value = reader.GetString("PRO_ID");
                dgvListPromotion.Rows[index].Cells[1].Value = reader.GetString("PRO_NAME");
                dgvListPromotion.Rows[index].Cells[2].Value = reader.GetString("PRO_MINIMUM");
                dgvListPromotion.Rows[index].Cells[3].Value = reader.GetString("PRO_DISCOUNT");
                dgvListPromotion.Rows[index].Cells[4].Value = reader.GetString("PRO_TYPE");
                dgvListPromotion.Rows[index].Cells[5].Value = reader.GetString("PRO_STATUS");
            }
            Program.connect.Close();
        }

        private void btnInsertFromShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.addpromotionForm = new AddPromotionForm();
            Program.addpromotionForm.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainmenuForm = new Jeffer.MenuForm.MainMenuForm();
            Program.mainmenuForm.ShowDialog();
            this.Close();
        }

        private void dgvListPromotion_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                this.Hide();
                Program.editpromotionForm = new EditPromotionForm(dgvListPromotion.Rows[e.RowIndex].Cells[0].Value.ToString());
                Program.editpromotionForm.ShowDialog();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}

namespace Jeffer.deduction_form
{
    partial class ListDeductionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Time_1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_lsitDeduction = new System.Windows.Forms.DataGridView();
            this.cb_empId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_close = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lsitDeduction)).BeginInit();
            this.SuspendLayout();
            // 
            // Time_1
            // 
            this.Time_1.AutoSize = true;
            this.Time_1.BackColor = System.Drawing.Color.Black;
            this.Time_1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_1.ForeColor = System.Drawing.Color.Lime;
            this.Time_1.Location = new System.Drawing.Point(12, 10);
            this.Time_1.Name = "Time_1";
            this.Time_1.Size = new System.Drawing.Size(45, 28);
            this.Time_1.TabIndex = 133;
            this.Time_1.Text = "Date";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(12, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1326, 65);
            this.panel5.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MAX PINJOHNV2", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 60);
            this.label4.TabIndex = 45;
            this.label4.Text = "Deduction [ ของเสีย ]";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.button_insert);
            this.panel4.Controls.Add(this.button_close);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cb_empId);
            this.panel4.Controls.Add(this.dgv_lsitDeduction);
            this.panel4.Font = new System.Drawing.Font("MAX PINJOHNV2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(12, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1326, 605);
            this.panel4.TabIndex = 134;
            // 
            // dgv_lsitDeduction
            // 
            this.dgv_lsitDeduction.AllowUserToAddRows = false;
            this.dgv_lsitDeduction.AllowUserToDeleteRows = false;
            this.dgv_lsitDeduction.AllowUserToResizeColumns = false;
            this.dgv_lsitDeduction.AllowUserToResizeRows = false;
            this.dgv_lsitDeduction.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_lsitDeduction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("MAX PINJOHNV2", 16F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lsitDeduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_lsitDeduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lsitDeduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.emp_id,
            this.detail,
            this.price,
            this.qty});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("MAX PINJOHNV2", 14F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lsitDeduction.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_lsitDeduction.Location = new System.Drawing.Point(147, 166);
            this.dgv_lsitDeduction.Name = "dgv_lsitDeduction";
            this.dgv_lsitDeduction.ReadOnly = true;
            this.dgv_lsitDeduction.Size = new System.Drawing.Size(1043, 379);
            this.dgv_lsitDeduction.TabIndex = 0;
            // 
            // cb_empId
            // 
            this.cb_empId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_empId.Font = new System.Drawing.Font("MAX PINJOHNV2", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_empId.FormattingEnabled = true;
            this.cb_empId.Location = new System.Drawing.Point(147, 135);
            this.cb_empId.Name = "cb_empId";
            this.cb_empId.Size = new System.Drawing.Size(162, 25);
            this.cb_empId.TabIndex = 1;
            this.cb_empId.SelectedIndexChanged += new System.EventHandler(this.cb_empId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "เลือกพนักงาน";
            // 
            // date
            // 
            this.date.DataPropertyName = "DEDUCTION_DATE";
            dataGridViewCellStyle14.Format = "dd/MM/yyyy";
            this.date.DefaultCellStyle = dataGridViewCellStyle14;
            this.date.HeaderText = "วันที่";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // emp_id
            // 
            this.emp_id.HeaderText = "รหัสพนักงาน";
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            this.emp_id.Width = 150;
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail.DataPropertyName = "DEDUCTION_DETAIL";
            this.detail.HeaderText = "รายละเอียด";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "DEDUCTION_TOTAL";
            dataGridViewCellStyle15.Format = "N2";
            this.price.DefaultCellStyle = dataGridViewCellStyle15;
            this.price.HeaderText = "ราคา";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "DEDUCTION_QTY";
            this.qty.HeaderText = "จำนวน";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.IndianRed;
            this.button_close.BackgroundImage = global::Jeffer.Properties.Resources.Back_thai;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_close.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(880, 85);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(150, 75);
            this.button_close.TabIndex = 7;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.LimeGreen;
            this.button_insert.BackgroundImage = global::Jeffer.Properties.Resources.Insert_thai;
            this.button_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_insert.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.Location = new System.Drawing.Point(1036, 85);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(150, 75);
            this.button_insert.TabIndex = 8;
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // ListDeductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.Time_1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "ListDeductionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListDeductionForm";
            this.Load += new System.EventHandler(this.ListDeductionForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lsitDeduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Time_1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_empId;
        private System.Windows.Forms.DataGridView dgv_lsitDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_insert;
    }
}
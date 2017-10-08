namespace Jeffer.employee_form
{
    partial class ListEmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_listEmp = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_deduction = new System.Windows.Forms.Button();
            this.button_backmain = new System.Windows.Forms.Button();
            this.button_history = new System.Windows.Forms.Button();
            this.button_salary = new System.Windows.Forms.Button();
            this.button_addEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listEmp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_listEmp
            // 
            this.dgv_listEmp.AllowUserToAddRows = false;
            this.dgv_listEmp.AllowUserToDeleteRows = false;
            this.dgv_listEmp.AllowUserToResizeColumns = false;
            this.dgv_listEmp.AllowUserToResizeRows = false;
            this.dgv_listEmp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_listEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listEmp.ColumnHeadersHeight = 30;
            this.dgv_listEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_listEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.id,
            this.fname,
            this.lname,
            this.rank,
            this.type,
            this.salary,
            this.status,
            this.password,
            this.edit});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listEmp.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_listEmp.Location = new System.Drawing.Point(63, 215);
            this.dgv_listEmp.Name = "dgv_listEmp";
            this.dgv_listEmp.ReadOnly = true;
            this.dgv_listEmp.RowHeadersVisible = false;
            this.dgv_listEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listEmp.Size = new System.Drawing.Size(1197, 381);
            this.dgv_listEmp.TabIndex = 47;
            this.dgv_listEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listEmp_CellClick);
            // 
            // number
            // 
            this.number.FillWeight = 228.4264F;
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 50;
            // 
            // id
            // 
            this.id.FillWeight = 363.2582F;
            this.id.HeaderText = "รหัส";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 110;
            // 
            // fname
            // 
            this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fname.FillWeight = 44.04506F;
            this.fname.HeaderText = "ชื่อ";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // lname
            // 
            this.lname.FillWeight = 44.04506F;
            this.lname.HeaderText = "นามสกุล";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 200;
            // 
            // rank
            // 
            this.rank.FillWeight = 44.04506F;
            this.rank.HeaderText = "ตำแหน่ง";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Width = 125;
            // 
            // type
            // 
            this.type.FillWeight = 44.04506F;
            this.type.HeaderText = "ประเภท";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.FillWeight = 44.04506F;
            this.salary.HeaderText = "เงินเดือน";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "สถานะ";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // password
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.password.DefaultCellStyle = dataGridViewCellStyle2;
            this.password.FillWeight = 44.04506F;
            this.password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.password.HeaderText = "";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Text = "เปลี่ยนรหัสผ่าน";
            this.password.UseColumnTextForButtonValue = true;
            this.password.Width = 105;
            // 
            // edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Text = "แก้ไข";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_deduction);
            this.panel1.Controls.Add(this.button_backmain);
            this.panel1.Controls.Add(this.button_history);
            this.panel1.Controls.Add(this.button_salary);
            this.panel1.Controls.Add(this.dgv_listEmp);
            this.panel1.Controls.Add(this.button_addEmp);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 632);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 65);
            this.panel2.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MAX PINJOHNV2", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "รายชื่อพนักงาน";
            // 
            // button_deduction
            // 
            this.button_deduction.BackColor = System.Drawing.Color.DarkOrange;
            this.button_deduction.BackgroundImage = global::Jeffer.Properties.Resources.Hak_thai;
            this.button_deduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_deduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_deduction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deduction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_deduction.Location = new System.Drawing.Point(574, 134);
            this.button_deduction.Name = "button_deduction";
            this.button_deduction.Size = new System.Drawing.Size(150, 75);
            this.button_deduction.TabIndex = 55;
            this.button_deduction.UseVisualStyleBackColor = false;
            this.button_deduction.Click += new System.EventHandler(this.button_deduction_Click);
            // 
            // button_backmain
            // 
            this.button_backmain.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_backmain.BackgroundImage = global::Jeffer.Properties.Resources.Back_Main_thai;
            this.button_backmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_backmain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backmain.Location = new System.Drawing.Point(63, 18);
            this.button_backmain.Name = "button_backmain";
            this.button_backmain.Size = new System.Drawing.Size(300, 50);
            this.button_backmain.TabIndex = 51;
            this.button_backmain.UseVisualStyleBackColor = false;
            this.button_backmain.Click += new System.EventHandler(this.button_backmain_Click);
            // 
            // button_history
            // 
            this.button_history.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_history.BackgroundImage = global::Jeffer.Properties.Resources.Profile_thai;
            this.button_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_history.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_history.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_history.Location = new System.Drawing.Point(231, 134);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(150, 75);
            this.button_history.TabIndex = 54;
            this.button_history.UseVisualStyleBackColor = false;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // button_salary
            // 
            this.button_salary.BackColor = System.Drawing.Color.Gold;
            this.button_salary.BackgroundImage = global::Jeffer.Properties.Resources.Salary_thai;
            this.button_salary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_salary.Location = new System.Drawing.Point(401, 134);
            this.button_salary.Name = "button_salary";
            this.button_salary.Size = new System.Drawing.Size(150, 75);
            this.button_salary.TabIndex = 53;
            this.button_salary.UseVisualStyleBackColor = false;
            this.button_salary.Click += new System.EventHandler(this.button_salary_Click);
            // 
            // button_addEmp
            // 
            this.button_addEmp.BackColor = System.Drawing.Color.LimeGreen;
            this.button_addEmp.BackgroundImage = global::Jeffer.Properties.Resources.Insert_thai;
            this.button_addEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_addEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_addEmp.Location = new System.Drawing.Point(63, 134);
            this.button_addEmp.Name = "button_addEmp";
            this.button_addEmp.Size = new System.Drawing.Size(150, 75);
            this.button_addEmp.TabIndex = 52;
            this.button_addEmp.UseVisualStyleBackColor = false;
            this.button_addEmp.Click += new System.EventHandler(this.button_addEmp_Click);
            // 
            // ListEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ListEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.ListEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listEmp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_listEmp;
        private System.Windows.Forms.Button button_backmain;
        private System.Windows.Forms.Button button_addEmp;
        private System.Windows.Forms.Button button_salary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.Button button_deduction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn password;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}
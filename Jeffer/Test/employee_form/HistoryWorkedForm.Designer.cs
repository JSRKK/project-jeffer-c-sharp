﻿namespace Jeffer.employee_form
{
    partial class HistoryWorkedForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dgv_listWorked = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_empRank = new System.Windows.Forms.Label();
            this.text_empType = new System.Windows.Forms.Label();
            this.text_empName = new System.Windows.Forms.Label();
            this.text_empId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listWorked)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button_back);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1323, 98);
            this.panel4.TabIndex = 5;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(20, 25);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(144, 45);
            this.button_back.TabIndex = 45;
            this.button_back.Text = "ย้อนกลับ";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jeffer.Properties.Resources.if_46_Calendar_290104;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(576, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 31);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(635, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "ประวัติการทำงาน";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cb_type);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_search);
            this.panel3.Controls.Add(this.dgv_listWorked);
            this.panel3.Location = new System.Drawing.Point(262, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 592);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "เลือกประเภท:";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "ทั้งหมด (Select all)",
            "วันหยุดพิเศษ (Holiday)"});
            this.cb_type.Location = new System.Drawing.Point(24, 49);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(148, 26);
            this.cb_type.TabIndex = 3;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(764, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ค้นหาจากวันที่:";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_search.Location = new System.Drawing.Point(867, 48);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(170, 21);
            this.tb_search.TabIndex = 1;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // dgv_listWorked
            // 
            this.dgv_listWorked.AllowUserToAddRows = false;
            this.dgv_listWorked.AllowUserToDeleteRows = false;
            this.dgv_listWorked.AllowUserToResizeColumns = false;
            this.dgv_listWorked.AllowUserToResizeRows = false;
            this.dgv_listWorked.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_listWorked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_listWorked.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listWorked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_listWorked.ColumnHeadersHeight = 30;
            this.dgv_listWorked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.timeIn,
            this.timeOut,
            this.note});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listWorked.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_listWorked.Location = new System.Drawing.Point(24, 85);
            this.dgv_listWorked.Name = "dgv_listWorked";
            this.dgv_listWorked.ReadOnly = true;
            this.dgv_listWorked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listWorked.Size = new System.Drawing.Size(1013, 464);
            this.dgv_listWorked.TabIndex = 0;
            // 
            // date
            // 
            this.date.Frozen = true;
            this.date.HeaderText = "วันที่(Date)";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 300;
            // 
            // timeIn
            // 
            this.timeIn.Frozen = true;
            this.timeIn.HeaderText = "เวลาเข้า(Scan in)";
            this.timeIn.Name = "timeIn";
            this.timeIn.ReadOnly = true;
            this.timeIn.Width = 150;
            // 
            // timeOut
            // 
            this.timeOut.Frozen = true;
            this.timeOut.HeaderText = "เวลาออก(Scan out)";
            this.timeOut.Name = "timeOut";
            this.timeOut.ReadOnly = true;
            this.timeOut.Width = 150;
            // 
            // note
            // 
            this.note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.note.HeaderText = "หมายเหตุ(Note)";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 689);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.text_empRank);
            this.panel2.Controls.Add(this.text_empType);
            this.panel2.Controls.Add(this.text_empName);
            this.panel2.Controls.Add(this.text_empId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 585);
            this.panel2.TabIndex = 2;
            // 
            // text_empRank
            // 
            this.text_empRank.AutoSize = true;
            this.text_empRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.text_empRank.Location = new System.Drawing.Point(83, 149);
            this.text_empRank.Name = "text_empRank";
            this.text_empRank.Size = new System.Drawing.Size(36, 20);
            this.text_empRank.TabIndex = 7;
            this.text_empRank.Text = "test";
            // 
            // text_empType
            // 
            this.text_empType.AutoSize = true;
            this.text_empType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.text_empType.Location = new System.Drawing.Point(74, 200);
            this.text_empType.Name = "text_empType";
            this.text_empType.Size = new System.Drawing.Size(36, 20);
            this.text_empType.TabIndex = 6;
            this.text_empType.Text = "test";
            // 
            // text_empName
            // 
            this.text_empName.AutoSize = true;
            this.text_empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.text_empName.Location = new System.Drawing.Point(48, 98);
            this.text_empName.Name = "text_empName";
            this.text_empName.Size = new System.Drawing.Size(36, 20);
            this.text_empName.TabIndex = 5;
            this.text_empName.Text = "test";
            // 
            // text_empId
            // 
            this.text_empId.AutoSize = true;
            this.text_empId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.text_empId.Location = new System.Drawing.Point(112, 47);
            this.text_empId.Name = "text_empId";
            this.text_empId.Size = new System.Drawing.Size(36, 20);
            this.text_empId.TabIndex = 4;
            this.text_empId.Text = "test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(16, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "ปรเภท:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(16, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "ชื่อ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(16, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "ตำแหน่ง:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(16, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "รหัสพนักงาน:";
            // 
            // HistoryWorkedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.panel1);
            this.Name = "HistoryWorkedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryWorkedForm";
            this.Load += new System.EventHandler(this.HistoryWorkedForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listWorked)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_listWorked;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.Label text_empRank;
        private System.Windows.Forms.Label text_empType;
        private System.Windows.Forms.Label text_empName;
        private System.Windows.Forms.Label text_empId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
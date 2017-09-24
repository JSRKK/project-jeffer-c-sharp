namespace Jeffer
{
    partial class ScantimeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_backmain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_listEmployee1 = new System.Windows.Forms.DataGridView();
            this.dgv_listEmployee2 = new System.Windows.Forms.DataGridView();
            this.EMP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wage1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listEmployee1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listEmployee2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button_backmain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 689);
            this.panel1.TabIndex = 3;
            // 
            // button_backmain
            // 
            this.button_backmain.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_backmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backmain.Location = new System.Drawing.Point(31, 21);
            this.button_backmain.Name = "button_backmain";
            this.button_backmain.Size = new System.Drawing.Size(144, 45);
            this.button_backmain.TabIndex = 45;
            this.button_backmain.Text = "กลับไปหน้าหลัก";
            this.button_backmain.UseVisualStyleBackColor = false;
            this.button_backmain.Click += new System.EventHandler(this.button_backmain_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Controls.Add(this.save);
            this.panel2.Location = new System.Drawing.Point(73, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 577);
            this.panel2.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(55, 54);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LimeGreen;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.save.Location = new System.Drawing.Point(55, 250);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(227, 73);
            this.save.TabIndex = 10;
            this.save.Text = "บันทึกข้อมูล";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dgv_listEmployee1);
            this.panel3.Controls.Add(this.dgv_listEmployee2);
            this.panel3.Location = new System.Drawing.Point(411, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 521);
            this.panel3.TabIndex = 8;
            // 
            // dgv_listEmployee1
            // 
            this.dgv_listEmployee1.AllowUserToAddRows = false;
            this.dgv_listEmployee1.AllowUserToDeleteRows = false;
            this.dgv_listEmployee1.AllowUserToResizeColumns = false;
            this.dgv_listEmployee1.AllowUserToResizeRows = false;
            this.dgv_listEmployee1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_listEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_listEmployee1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listEmployee1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listEmployee1.ColumnHeadersHeight = 30;
            this.dgv_listEmployee1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.add,
            this.dataGridViewTextBoxColumn5,
            this.rank,
            this.wage1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listEmployee1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_listEmployee1.Location = new System.Drawing.Point(27, 41);
            this.dgv_listEmployee1.Name = "dgv_listEmployee1";
            this.dgv_listEmployee1.ReadOnly = true;
            this.dgv_listEmployee1.RowHeadersVisible = false;
            this.dgv_listEmployee1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listEmployee1.Size = new System.Drawing.Size(412, 457);
            this.dgv_listEmployee1.TabIndex = 11;
            this.dgv_listEmployee1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listEmployee1_CellClick);
            // 
            // dgv_listEmployee2
            // 
            this.dgv_listEmployee2.AllowUserToAddRows = false;
            this.dgv_listEmployee2.AllowUserToDeleteRows = false;
            this.dgv_listEmployee2.AllowUserToResizeColumns = false;
            this.dgv_listEmployee2.AllowUserToResizeRows = false;
            this.dgv_listEmployee2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_listEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_listEmployee2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listEmployee2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_listEmployee2.ColumnHeadersHeight = 30;
            this.dgv_listEmployee2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMP_ID,
            this.scan1,
            this.scan2,
            this.delete,
            this.id_emp,
            this.rank2,
            this.wage});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listEmployee2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_listEmployee2.Location = new System.Drawing.Point(456, 41);
            this.dgv_listEmployee2.Name = "dgv_listEmployee2";
            this.dgv_listEmployee2.ReadOnly = true;
            this.dgv_listEmployee2.RowHeadersVisible = false;
            this.dgv_listEmployee2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listEmployee2.Size = new System.Drawing.Size(354, 457);
            this.dgv_listEmployee2.TabIndex = 6;
            this.dgv_listEmployee2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listEmployee2_CellClick);
            this.dgv_listEmployee2.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listEmployee2_CellLeave);
            // 
            // EMP_ID
            // 
            this.EMP_ID.Frozen = true;
            this.EMP_ID.HeaderText = "ชื่อ";
            this.EMP_ID.Name = "EMP_ID";
            this.EMP_ID.ReadOnly = true;
            this.EMP_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EMP_ID.Width = 150;
            // 
            // scan1
            // 
            this.scan1.Frozen = true;
            this.scan1.HeaderText = "สแกนเข้า";
            this.scan1.Name = "scan1";
            this.scan1.ReadOnly = true;
            this.scan1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.scan1.Width = 80;
            // 
            // scan2
            // 
            this.scan2.Frozen = true;
            this.scan2.HeaderText = "สแกนออก";
            this.scan2.Name = "scan2";
            this.scan2.ReadOnly = true;
            this.scan2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.scan2.Width = 80;
            // 
            // delete
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.delete.DefaultCellStyle = dataGridViewCellStyle5;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "ลบ";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 40;
            // 
            // id_emp
            // 
            this.id_emp.HeaderText = "รหัส";
            this.id_emp.Name = "id_emp";
            this.id_emp.ReadOnly = true;
            this.id_emp.Visible = false;
            // 
            // rank2
            // 
            this.rank2.HeaderText = "ตำแหน่ง";
            this.rank2.Name = "rank2";
            this.rank2.ReadOnly = true;
            this.rank2.Visible = false;
            // 
            // wage
            // 
            this.wage.HeaderText = "ค่าแรง";
            this.wage.Name = "wage";
            this.wage.ReadOnly = true;
            this.wage.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(411, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(841, 54);
            this.panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jeffer.Properties.Resources.if_46_Calendar_290104;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(227, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 31);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "ตารางเวลาการทำงานของพนักงาน";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "ชื่อ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "สแกนเข้า";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "สแกนออก";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.add.DefaultCellStyle = dataGridViewCellStyle2;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.HeaderText = "";
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.add.Text = "เพิ่ม";
            this.add.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "รหัส";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // rank
            // 
            this.rank.HeaderText = "ตำแหน่ง";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Visible = false;
            // 
            // wage1
            // 
            this.wage1.HeaderText = "ค่าแรง";
            this.wage1.Name = "wage1";
            this.wage1.ReadOnly = true;
            this.wage1.Visible = false;
            // 
            // ScantimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ScantimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanTime";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listEmployee1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listEmployee2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_listEmployee2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView dgv_listEmployee1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_backmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn scan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scan2;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank2;
        private System.Windows.Forms.DataGridViewTextBoxColumn wage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn wage1;
    }
}
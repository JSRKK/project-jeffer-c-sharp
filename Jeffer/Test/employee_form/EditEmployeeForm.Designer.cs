namespace Jeffer.employee_form
{
    partial class EditEmployeeForm
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
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.tb_Last = new System.Windows.Forms.TextBox();
            this.cb_Rank = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.tb_empId = new System.Windows.Forms.TextBox();
            this.tb_Religion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Blood = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEdu = new System.Windows.Forms.Label();
            this.tb_Race = new System.Windows.Forms.TextBox();
            this.tb_Tel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.cb_TName = new System.Windows.Forms.ComboBox();
            this.tb_Nation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.tb_IDCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textAcc = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAcc = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Time_1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cb_Edu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "ใช้งาน",
            "ไม่ใช้งาน"});
            this.comboStatus.Location = new System.Drawing.Point(163, 470);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(160, 45);
            this.comboStatus.TabIndex = 19;
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ID.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(66, 137);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(134, 37);
            this.ID.TabIndex = 129;
            this.ID.Text = "รหัสพนักงาน";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(72, 473);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(75, 37);
            this.status.TabIndex = 143;
            this.status.Text = "สถานะ";
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "dd/MM/yyyy";
            this.dateEnd.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(1056, 53);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 43);
            this.dateEnd.TabIndex = 142;
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(975, 55);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(72, 37);
            this.endDate.TabIndex = 141;
            this.endDate.Text = "สิ้นสุด";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 37);
            this.label7.TabIndex = 124;
            this.label7.Text = "ประเภท";
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(1093, 132);
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(160, 43);
            this.tb_Salary.TabIndex = 4;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Salary_KeyPress);
            // 
            // tb_Last
            // 
            this.tb_Last.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Last.Location = new System.Drawing.Point(605, 211);
            this.tb_Last.Name = "tb_Last";
            this.tb_Last.Size = new System.Drawing.Size(160, 43);
            this.tb_Last.TabIndex = 7;
            // 
            // cb_Rank
            // 
            this.cb_Rank.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Rank.FormattingEnabled = true;
            this.cb_Rank.Items.AddRange(new object[] {
            "ผู้จัดการ",
            "รองผู้จัดการ",
            "กุ๊กใหญ่",
            "ผู้ช่วยกุ๊ก\t",
            "พนักงานแคชเชียร์",
            "พนักงานทำความสะอาด",
            "พนักงานล้างจาน",
            "พนักงานเสริฟอาหาร"});
            this.cb_Rank.Location = new System.Drawing.Point(752, 132);
            this.cb_Rank.Name = "cb_Rank";
            this.cb_Rank.Size = new System.Drawing.Size(213, 45);
            this.cb_Rank.TabIndex = 3;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkGray;
            this.button_cancel.BackgroundImage = global::Jeffer.Properties.Resources.Back_thai;
            this.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(1149, 510);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(150, 75);
            this.button_cancel.TabIndex = 112;
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // cb_Type
            // 
            this.cb_Type.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "FullTime",
            "PastTime"});
            this.cb_Type.Location = new System.Drawing.Point(488, 132);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(160, 45);
            this.cb_Type.TabIndex = 2;
            // 
            // tb_empId
            // 
            this.tb_empId.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_empId.Location = new System.Drawing.Point(207, 135);
            this.tb_empId.Name = "tb_empId";
            this.tb_empId.ReadOnly = true;
            this.tb_empId.Size = new System.Drawing.Size(160, 43);
            this.tb_empId.TabIndex = 1;
            // 
            // tb_Religion
            // 
            this.tb_Religion.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Religion.Location = new System.Drawing.Point(163, 346);
            this.tb_Religion.Name = "tb_Religion";
            this.tb_Religion.Size = new System.Drawing.Size(160, 43);
            this.tb_Religion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 37);
            this.label4.TabIndex = 119;
            this.label4.Text = "ศาสนา";
            // 
            // cb_Blood
            // 
            this.cb_Blood.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Blood.FormattingEnabled = true;
            this.cb_Blood.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cb_Blood.Location = new System.Drawing.Point(606, 278);
            this.cb_Blood.Name = "cb_Blood";
            this.cb_Blood.Size = new System.Drawing.Size(104, 45);
            this.cb_Blood.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(271, 214);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 37);
            this.labelName.TabIndex = 84;
            this.labelName.Text = "ชื่อ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 37);
            this.label5.TabIndex = 121;
            this.label5.Text = "กรุ๊ปเลือด";
            // 
            // labelEdu
            // 
            this.labelEdu.AutoSize = true;
            this.labelEdu.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdu.Location = new System.Drawing.Point(444, 410);
            this.labelEdu.Name = "labelEdu";
            this.labelEdu.Size = new System.Drawing.Size(142, 37);
            this.labelEdu.TabIndex = 106;
            this.labelEdu.Text = "วุฒิการศึกษา";
            // 
            // tb_Race
            // 
            this.tb_Race.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Race.Location = new System.Drawing.Point(1082, 276);
            this.tb_Race.Name = "tb_Race";
            this.tb_Race.Size = new System.Drawing.Size(171, 43);
            this.tb_Race.TabIndex = 12;
            // 
            // tb_Tel
            // 
            this.tb_Tel.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Tel.Location = new System.Drawing.Point(1082, 343);
            this.tb_Tel.MaxLength = 10;
            this.tb_Tel.Name = "tb_Tel";
            this.tb_Tel.Size = new System.Drawing.Size(171, 43);
            this.tb_Tel.TabIndex = 15;
            this.tb_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Tel_KeyPress);
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(988, 346);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(88, 37);
            this.labelTel.TabIndex = 96;
            this.labelTel.Text = "โทรศัพท์";
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(402, 344);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(572, 43);
            this.tb_Address.TabIndex = 14;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(342, 347);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(56, 37);
            this.labelAdd.TabIndex = 98;
            this.labelAdd.Text = "ที่อยู่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(991, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 37);
            this.label3.TabIndex = 117;
            this.label3.Text = "เชื้อชาติ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 37);
            this.label6.TabIndex = 123;
            this.label6.Text = "คำนำหน้า";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(325, 212);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(160, 43);
            this.tb_Name.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cb_Edu);
            this.panel1.Controls.Add(this.tb_Name);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.comboStatus);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.dateEnd);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_Salary);
            this.panel1.Controls.Add(this.tb_Last);
            this.panel1.Controls.Add(this.cb_Rank);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.cb_Type);
            this.panel1.Controls.Add(this.tb_empId);
            this.panel1.Controls.Add(this.tb_Religion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_Blood);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelEdu);
            this.panel1.Controls.Add(this.tb_Race);
            this.panel1.Controls.Add(this.tb_Tel);
            this.panel1.Controls.Add(this.labelTel);
            this.panel1.Controls.Add(this.tb_Address);
            this.panel1.Controls.Add(this.labelAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_TName);
            this.panel1.Controls.Add(this.tb_Nation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateStart);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.rank);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.labelLast);
            this.panel1.Controls.Add(this.tb_IDCard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_Email);
            this.panel1.Controls.Add(this.labelMail);
            this.panel1.Controls.Add(this.textAcc);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelAcc);
            this.panel1.Controls.Add(this.labelBirth);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 605);
            this.panel1.TabIndex = 130;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Gold;
            this.button_update.BackgroundImage = global::Jeffer.Properties.Resources.Update_thai1;
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button_update.Location = new System.Drawing.Point(980, 510);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(150, 75);
            this.button_update.TabIndex = 110;
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // cb_TName
            // 
            this.cb_TName.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TName.FormattingEnabled = true;
            this.cb_TName.Items.AddRange(new object[] {
            "นาย",
            "นาง",
            "นางสาว"});
            this.cb_TName.Location = new System.Drawing.Point(175, 208);
            this.cb_TName.Name = "cb_TName";
            this.cb_TName.Size = new System.Drawing.Size(79, 45);
            this.cb_TName.TabIndex = 5;
            // 
            // tb_Nation
            // 
            this.tb_Nation.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nation.Location = new System.Drawing.Point(814, 278);
            this.tb_Nation.Name = "tb_Nation";
            this.tb_Nation.Size = new System.Drawing.Size(160, 43);
            this.tb_Nation.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(727, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 115;
            this.label2.Text = "สัญชาติ";
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "dd/MM/yyyy";
            this.dateStart.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(729, 55);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(225, 43);
            this.dateStart.TabIndex = 0;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(614, 58);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(107, 37);
            this.startDate.TabIndex = 107;
            this.startDate.Text = "เริ่มทำงาน";
            // 
            // rank
            // 
            this.rank.AutoSize = true;
            this.rank.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank.Location = new System.Drawing.Point(659, 137);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(92, 37);
            this.rank.TabIndex = 92;
            this.rank.Text = "ตำแหน่ง";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(984, 136);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(93, 37);
            this.labelSalary.TabIndex = 94;
            this.labelSalary.Text = "เงินเดือน";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLast.Location = new System.Drawing.Point(506, 213);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(95, 37);
            this.labelLast.TabIndex = 86;
            this.labelLast.Text = "นามสกุล";
            // 
            // tb_IDCard
            // 
            this.tb_IDCard.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IDCard.Location = new System.Drawing.Point(1008, 211);
            this.tb_IDCard.MaxLength = 13;
            this.tb_IDCard.Name = "tb_IDCard";
            this.tb_IDCard.Size = new System.Drawing.Size(245, 43);
            this.tb_IDCard.TabIndex = 8;
            this.tb_IDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IDCard_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 113;
            this.label1.Text = "เลขประจำตัวประชาชน";
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(163, 409);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(269, 43);
            this.tb_Email.TabIndex = 16;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(66, 414);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(76, 37);
            this.labelMail.TabIndex = 100;
            this.labelMail.Text = "E-mail";
            // 
            // textAcc
            // 
            this.textAcc.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAcc.Location = new System.Drawing.Point(943, 407);
            this.textAcc.MaxLength = 15;
            this.textAcc.Name = "textAcc";
            this.textAcc.Size = new System.Drawing.Size(207, 43);
            this.textAcc.TabIndex = 18;
            this.textAcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAcc_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 43);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcc.Location = new System.Drawing.Point(846, 412);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(100, 37);
            this.labelAcc.TabIndex = 102;
            this.labelAcc.Text = "เลขบัญชี";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirth.Location = new System.Drawing.Point(66, 286);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(170, 37);
            this.labelBirth.TabIndex = 104;
            this.labelBirth.Text = "วัน/เดือน/ปี เกิด";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 65);
            this.panel2.TabIndex = 131;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MAX PINJOHNV2", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 60);
            this.label8.TabIndex = 24;
            this.label8.Text = "อัพเดทข้อมูลพนักงาน";
            // 
            // Time_1
            // 
            this.Time_1.AutoSize = true;
            this.Time_1.BackColor = System.Drawing.Color.Black;
            this.Time_1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_1.ForeColor = System.Drawing.Color.Lime;
            this.Time_1.Location = new System.Drawing.Point(12, 9);
            this.Time_1.Name = "Time_1";
            this.Time_1.Size = new System.Drawing.Size(45, 28);
            this.Time_1.TabIndex = 144;
            this.Time_1.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cb_Edu
            // 
            this.cb_Edu.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F);
            this.cb_Edu.FormattingEnabled = true;
            this.cb_Edu.Items.AddRange(new object[] {
            "ม.6",
            "ปวส",
            "ปวช",
            "ปริญญาตรี",
            "ปริญญาโทร",
            "ปริญญาเอก"});
            this.cb_Edu.Location = new System.Drawing.Point(566, 407);
            this.cb_Edu.Name = "cb_Edu";
            this.cb_Edu.Size = new System.Drawing.Size(256, 45);
            this.cb_Edu.TabIndex = 144;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.Time_1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmployeeForm";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.TextBox tb_Last;
        private System.Windows.Forms.ComboBox cb_Rank;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.TextBox tb_empId;
        private System.Windows.Forms.TextBox tb_Religion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Blood;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEdu;
        private System.Windows.Forms.TextBox tb_Race;
        private System.Windows.Forms.TextBox tb_Tel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_TName;
        private System.Windows.Forms.TextBox tb_Nation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.TextBox tb_IDCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textAcc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelAcc;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Time_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cb_Edu;
    }
}
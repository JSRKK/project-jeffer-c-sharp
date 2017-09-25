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
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.comboRank = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textReligion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBlood = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textEdu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEdu = new System.Windows.Forms.Label();
            this.textRace = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textAdd = new System.Windows.Forms.TextBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboTName = new System.Windows.Forms.ComboBox();
            this.textNation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.textIDCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textAcc = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAcc = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "ใช้งาน",
            "ไม่ใช้งาน"});
            this.comboStatus.Location = new System.Drawing.Point(477, 469);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(160, 33);
            this.comboStatus.TabIndex = 19;
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ID.Location = new System.Drawing.Point(66, 137);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(115, 25);
            this.ID.TabIndex = 129;
            this.ID.Text = "รหัสพนักงาน";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.status.Location = new System.Drawing.Point(396, 470);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(65, 25);
            this.status.TabIndex = 143;
            this.status.Text = "สถานะ";
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(1056, 53);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 31);
            this.dateEnd.TabIndex = 142;
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.endDate.Location = new System.Drawing.Point(964, 55);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(59, 25);
            this.endDate.TabIndex = 141;
            this.endDate.Text = "สิ้นสุด";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(379, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 124;
            this.label7.Text = "ประเภท";
            // 
            // textSalary
            // 
            this.textSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textSalary.Location = new System.Drawing.Point(1093, 132);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(160, 31);
            this.textSalary.TabIndex = 4;
            // 
            // textLast
            // 
            this.textLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textLast.Location = new System.Drawing.Point(605, 211);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(160, 31);
            this.textLast.TabIndex = 7;
            // 
            // comboRank
            // 
            this.comboRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboRank.FormattingEnabled = true;
            this.comboRank.Items.AddRange(new object[] {
            "ผู้จัดการ",
            "รองผู้จัดการ",
            "กุ๊กใหญ่",
            "ผู้ช่วยกุ๊ก\t",
            "พนักงานแคชเชียร์",
            "พนักงานทำความสะอาด",
            "พนักงานล้างจาน",
            "พนักงานเสริฟอาหาร"});
            this.comboRank.Location = new System.Drawing.Point(752, 132);
            this.comboRank.Name = "comboRank";
            this.comboRank.Size = new System.Drawing.Size(213, 33);
            this.comboRank.TabIndex = 3;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkGray;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(1141, 527);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(143, 57);
            this.button_cancel.TabIndex = 21;
            this.button_cancel.Text = "ยกเลิก";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Gold;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button_update.Location = new System.Drawing.Point(988, 527);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(142, 59);
            this.button_update.TabIndex = 20;
            this.button_update.Text = "อัพเดท";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "FullTime",
            "PastTime"});
            this.comboType.Location = new System.Drawing.Point(488, 132);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(160, 33);
            this.comboType.TabIndex = 2;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textID.Location = new System.Drawing.Point(207, 135);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(160, 31);
            this.textID.TabIndex = 1;
            // 
            // textReligion
            // 
            this.textReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textReligion.Location = new System.Drawing.Point(163, 346);
            this.textReligion.Name = "textReligion";
            this.textReligion.Size = new System.Drawing.Size(160, 31);
            this.textReligion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(66, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 119;
            this.label4.Text = "ศาสนา";
            // 
            // comboBlood
            // 
            this.comboBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBlood.FormattingEnabled = true;
            this.comboBlood.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.comboBlood.Location = new System.Drawing.Point(606, 278);
            this.comboBlood.Name = "comboBlood";
            this.comboBlood.Size = new System.Drawing.Size(104, 33);
            this.comboBlood.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelName.Location = new System.Drawing.Point(269, 214);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 25);
            this.labelName.TabIndex = 84;
            this.labelName.Text = "ชื่อ";
            // 
            // textEdu
            // 
            this.textEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textEdu.Location = new System.Drawing.Point(573, 409);
            this.textEdu.Name = "textEdu";
            this.textEdu.Size = new System.Drawing.Size(440, 31);
            this.textEdu.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(493, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 121;
            this.label5.Text = "กรุ๊ปเลือด";
            // 
            // labelEdu
            // 
            this.labelEdu.AutoSize = true;
            this.labelEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelEdu.Location = new System.Drawing.Point(435, 409);
            this.labelEdu.Name = "labelEdu";
            this.labelEdu.Size = new System.Drawing.Size(113, 25);
            this.labelEdu.TabIndex = 106;
            this.labelEdu.Text = "วุฒิการศึกษา";
            // 
            // textRace
            // 
            this.textRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textRace.Location = new System.Drawing.Point(1082, 276);
            this.textRace.Name = "textRace";
            this.textRace.Size = new System.Drawing.Size(171, 31);
            this.textRace.TabIndex = 12;
            // 
            // textTel
            // 
            this.textTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textTel.Location = new System.Drawing.Point(1082, 343);
            this.textTel.MaxLength = 10;
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(171, 31);
            this.textTel.TabIndex = 15;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelTel.Location = new System.Drawing.Point(982, 346);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(81, 25);
            this.labelTel.TabIndex = 96;
            this.labelTel.Text = "โทรศัพท์";
            // 
            // textAdd
            // 
            this.textAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textAdd.Location = new System.Drawing.Point(402, 344);
            this.textAdd.Name = "textAdd";
            this.textAdd.Size = new System.Drawing.Size(572, 31);
            this.textAdd.TabIndex = 14;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelAdd.Location = new System.Drawing.Point(342, 346);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(46, 25);
            this.labelAdd.TabIndex = 98;
            this.labelAdd.Text = "ที่อยู่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(992, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 117;
            this.label3.Text = "เชื้อชาติ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(66, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 123;
            this.label6.Text = "คำนำหน้า";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textName.Location = new System.Drawing.Point(325, 212);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(160, 31);
            this.textName.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.comboStatus);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.dateEnd);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textSalary);
            this.panel1.Controls.Add(this.textLast);
            this.panel1.Controls.Add(this.comboRank);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.comboType);
            this.panel1.Controls.Add(this.textID);
            this.panel1.Controls.Add(this.textReligion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBlood);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textEdu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelEdu);
            this.panel1.Controls.Add(this.textRace);
            this.panel1.Controls.Add(this.textTel);
            this.panel1.Controls.Add(this.labelTel);
            this.panel1.Controls.Add(this.textAdd);
            this.panel1.Controls.Add(this.labelAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboTName);
            this.panel1.Controls.Add(this.textNation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateStart);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.rank);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.labelLast);
            this.panel1.Controls.Add(this.textIDCard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.labelMail);
            this.panel1.Controls.Add(this.textAcc);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelAcc);
            this.panel1.Controls.Add(this.labelBirth);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 632);
            this.panel1.TabIndex = 130;
            // 
            // comboTName
            // 
            this.comboTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboTName.FormattingEnabled = true;
            this.comboTName.Items.AddRange(new object[] {
            "นาย",
            "นาง",
            "นางสาว"});
            this.comboTName.Location = new System.Drawing.Point(175, 208);
            this.comboTName.Name = "comboTName";
            this.comboTName.Size = new System.Drawing.Size(79, 33);
            this.comboTName.TabIndex = 5;
            // 
            // textNation
            // 
            this.textNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textNation.Location = new System.Drawing.Point(814, 278);
            this.textNation.Name = "textNation";
            this.textNation.Size = new System.Drawing.Size(160, 31);
            this.textNation.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(728, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 115;
            this.label2.Text = "สัญชาติ";
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(729, 55);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(225, 31);
            this.dateStart.TabIndex = 0;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.startDate.Location = new System.Drawing.Point(614, 58);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(92, 25);
            this.startDate.TabIndex = 107;
            this.startDate.Text = "เริ่มทำงาน";
            // 
            // rank
            // 
            this.rank.AutoSize = true;
            this.rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rank.Location = new System.Drawing.Point(654, 137);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(80, 25);
            this.rank.TabIndex = 92;
            this.rank.Text = "ตำแหน่ง";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSalary.Location = new System.Drawing.Point(978, 136);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(82, 25);
            this.labelSalary.TabIndex = 94;
            this.labelSalary.Text = "เงินเดือน";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelLast.Location = new System.Drawing.Point(491, 213);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(78, 25);
            this.labelLast.TabIndex = 86;
            this.labelLast.Text = "นามสกุล";
            // 
            // textIDCard
            // 
            this.textIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textIDCard.Location = new System.Drawing.Point(1008, 211);
            this.textIDCard.MaxLength = 13;
            this.textIDCard.Name = "textIDCard";
            this.textIDCard.Size = new System.Drawing.Size(245, 31);
            this.textIDCard.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(772, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 113;
            this.label1.Text = "เลขประจำตัวประชาชน";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textEmail.Location = new System.Drawing.Point(163, 409);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(269, 31);
            this.textEmail.TabIndex = 16;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMail.Location = new System.Drawing.Point(66, 414);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(72, 25);
            this.labelMail.TabIndex = 100;
            this.labelMail.Text = "E-mail";
            // 
            // textAcc
            // 
            this.textAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textAcc.Location = new System.Drawing.Point(163, 467);
            this.textAcc.MaxLength = 15;
            this.textAcc.Name = "textAcc";
            this.textAcc.Size = new System.Drawing.Size(207, 31);
            this.textAcc.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 31);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelAcc.Location = new System.Drawing.Point(66, 472);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(79, 25);
            this.labelAcc.TabIndex = 102;
            this.labelAcc.Text = "เลขบัญชี";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelBirth.Location = new System.Drawing.Point(66, 286);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(136, 25);
            this.labelBirth.TabIndex = 104;
            this.labelBirth.Text = "วัน/เดือน/ปี เกิด";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 65);
            this.panel2.TabIndex = 131;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cordia New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(11, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 38);
            this.label8.TabIndex = 24;
            this.label8.Text = "อัพเดทข้อมูลพนักงาน";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 727);
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

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.ComboBox comboRank;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textReligion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBlood;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textEdu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEdu;
        private System.Windows.Forms.TextBox textRace;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textAdd;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboTName;
        private System.Windows.Forms.TextBox textNation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.TextBox textIDCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textAcc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelAcc;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}
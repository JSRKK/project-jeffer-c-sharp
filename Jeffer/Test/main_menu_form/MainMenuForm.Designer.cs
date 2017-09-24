namespace Jeffer.MenuForm
{
    partial class MainMenuForm
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_list = new System.Windows.Forms.Button();
            this.button_food = new System.Windows.Forms.Button();
            this.button_schedule = new System.Windows.Forms.Button();
            this.button_order = new System.Windows.Forms.Button();
            this.button_employee = new System.Windows.Forms.Button();
            this.button_factory = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_receive = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_scantime = new System.Windows.Forms.Button();
            this.text_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jeffer.Properties.Resources.jeffer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(285, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 153);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button_list
            // 
            this.button_list.BackColor = System.Drawing.Color.IndianRed;
            this.button_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_list.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold);
            this.button_list.Image = global::Jeffer.Properties.Resources.if_94_List_2123935;
            this.button_list.Location = new System.Drawing.Point(285, 417);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(180, 115);
            this.button_list.TabIndex = 9;
            this.button_list.Text = "เรียกดูรายงาน";
            this.button_list.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_list.UseVisualStyleBackColor = false;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_food
            // 
            this.button_food.BackColor = System.Drawing.Color.DarkOrange;
            this.button_food.BackgroundImage = global::Jeffer.Properties.Resources.if_2_1845738;
            this.button_food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_food.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_food.Location = new System.Drawing.Point(285, 296);
            this.button_food.Name = "button_food";
            this.button_food.Size = new System.Drawing.Size(212, 115);
            this.button_food.TabIndex = 8;
            this.button_food.Text = "เมนูอาหาร";
            this.button_food.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_food.UseVisualStyleBackColor = false;
            this.button_food.Click += new System.EventHandler(this.button_food_Click);
            // 
            // button_schedule
            // 
            this.button_schedule.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_schedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_schedule.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold);
            this.button_schedule.Image = global::Jeffer.Properties.Resources.if_17_calender_schedule_time_management_control_day_2109164;
            this.button_schedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_schedule.Location = new System.Drawing.Point(471, 417);
            this.button_schedule.Name = "button_schedule";
            this.button_schedule.Size = new System.Drawing.Size(272, 115);
            this.button_schedule.TabIndex = 6;
            this.button_schedule.Text = "ตารางพนักงาน";
            this.button_schedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_schedule.UseVisualStyleBackColor = false;
            this.button_schedule.Click += new System.EventHandler(this.button_schedule_Click);
            // 
            // button_order
            // 
            this.button_order.BackColor = System.Drawing.Color.ForestGreen;
            this.button_order.BackgroundImage = global::Jeffer.Properties.Resources.if_shopping_cart_loaded_172553;
            this.button_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_order.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold);
            this.button_order.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_order.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_order.Location = new System.Drawing.Point(749, 296);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(303, 115);
            this.button_order.TabIndex = 5;
            this.button_order.Text = "สั่งสินค้า";
            this.button_order.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_order.UseVisualStyleBackColor = false;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // button_employee
            // 
            this.button_employee.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_employee.BackgroundImage = global::Jeffer.Properties.Resources.if_group2_309041;
            this.button_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_employee.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold);
            this.button_employee.Location = new System.Drawing.Point(284, 537);
            this.button_employee.Name = "button_employee";
            this.button_employee.Size = new System.Drawing.Size(317, 115);
            this.button_employee.TabIndex = 4;
            this.button_employee.Text = "พนักงาน";
            this.button_employee.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_employee.UseVisualStyleBackColor = false;
            this.button_employee.Click += new System.EventHandler(this.button_employee_Click);
            // 
            // button_factory
            // 
            this.button_factory.BackColor = System.Drawing.Color.SteelBlue;
            this.button_factory.BackgroundImage = global::Jeffer.Properties.Resources.if_03_Office_290144;
            this.button_factory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_factory.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold);
            this.button_factory.Location = new System.Drawing.Point(608, 538);
            this.button_factory.Name = "button_factory";
            this.button_factory.Size = new System.Drawing.Size(135, 115);
            this.button_factory.TabIndex = 3;
            this.button_factory.Text = "บริษัท";
            this.button_factory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_factory.UseVisualStyleBackColor = false;
            this.button_factory.Click += new System.EventHandler(this.button_factory_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.DarkOrange;
            this.button_update.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold);
            this.button_update.Image = global::Jeffer.Properties.Resources.if_update_172618;
            this.button_update.Location = new System.Drawing.Point(749, 417);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(152, 115);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_receive
            // 
            this.button_receive.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_receive.BackgroundImage = global::Jeffer.Properties.Resources.if_shopping_bag_172551;
            this.button_receive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_receive.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold);
            this.button_receive.Location = new System.Drawing.Point(907, 417);
            this.button_receive.Name = "button_receive";
            this.button_receive.Size = new System.Drawing.Size(145, 115);
            this.button_receive.TabIndex = 1;
            this.button_receive.Text = "รับสินค้า";
            this.button_receive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_receive.UseVisualStyleBackColor = false;
            this.button_receive.Click += new System.EventHandler(this.button_receive_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Red;
            this.button_exit.BackgroundImage = global::Jeffer.Properties.Resources.if_on_off_1370046__1_;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold);
            this.button_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_exit.Location = new System.Drawing.Point(749, 538);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(303, 115);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "ออกจากระบบ";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_scantime
            // 
            this.button_scantime.BackColor = System.Drawing.Color.SlateGray;
            this.button_scantime.BackgroundImage = global::Jeffer.Properties.Resources.if_property_agent_002_1851814;
            this.button_scantime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_scantime.Font = new System.Drawing.Font("Leelawadee UI", 14.26415F, System.Drawing.FontStyle.Bold);
            this.button_scantime.Location = new System.Drawing.Point(501, 293);
            this.button_scantime.Name = "button_scantime";
            this.button_scantime.Size = new System.Drawing.Size(240, 115);
            this.button_scantime.TabIndex = 7;
            this.button_scantime.Text = "ScanTime";
            this.button_scantime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_scantime.UseVisualStyleBackColor = false;
            this.button_scantime.Click += new System.EventHandler(this.button_scantime_Click);
            // 
            // text_time
            // 
            this.text_time.AutoSize = true;
            this.text_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_time.Location = new System.Drawing.Point(978, 653);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(50, 22);
            this.text_time.TabIndex = 0;
            this.text_time.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(755, 653);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(926, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time:";
            // 
            // text_date
            // 
            this.text_date.AutoSize = true;
            this.text_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_date.Location = new System.Drawing.Point(805, 653);
            this.text_date.Name = "text_date";
            this.text_date.Size = new System.Drawing.Size(48, 22);
            this.text_date.TabIndex = 9;
            this.text_date.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.text_time);
            this.panel1.Controls.Add(this.text_date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_scantime);
            this.panel1.Controls.Add(this.button_employee);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 730);
            this.panel1.TabIndex = 11;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_list);
            this.Controls.Add(this.button_food);
            this.Controls.Add(this.button_schedule);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.button_factory);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_receive);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_receive;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_employee;
        private System.Windows.Forms.Button button_factory;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Button button_schedule;
        private System.Windows.Forms.Button button_food;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_scantime;
        private System.Windows.Forms.Label text_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text_date;
        private System.Windows.Forms.Panel panel1;
    }
}
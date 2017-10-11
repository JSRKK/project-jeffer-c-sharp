namespace jeffer.menu_form
{
    partial class ListMenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Table_view = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.GenerateId = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Time_1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Table_view)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_view
            // 
            this.Table_view.AllowUserToAddRows = false;
            this.Table_view.AllowUserToDeleteRows = false;
            this.Table_view.AllowUserToResizeColumns = false;
            this.Table_view.AllowUserToResizeRows = false;
            this.Table_view.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Table_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu,
            this.menu_name,
            this.menu_price,
            this.menu_type,
            this.menu_status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table_view.Location = new System.Drawing.Point(22, 22);
            this.Table_view.Name = "Table_view";
            this.Table_view.ReadOnly = true;
            this.Table_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Table_view.RowTemplate.Height = 40;
            this.Table_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table_view.Size = new System.Drawing.Size(786, 486);
            this.Table_view.TabIndex = 24;
            this.Table_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_view_CellClick);
            this.Table_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_view_CellDoubleClick);
            // 
            // menu
            // 
            this.menu.DataPropertyName = "MENU_ID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.DefaultCellStyle = dataGridViewCellStyle1;
            this.menu.HeaderText = "รหัสเมนู";
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            // 
            // menu_name
            // 
            this.menu_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menu_name.DataPropertyName = "MENU_NAME";
            this.menu_name.HeaderText = "ชื่อเมนู";
            this.menu_name.Name = "menu_name";
            this.menu_name.ReadOnly = true;
            // 
            // menu_price
            // 
            this.menu_price.DataPropertyName = "MENU_PRICE";
            this.menu_price.HeaderText = "ราคาเมนู";
            this.menu_price.Name = "menu_price";
            this.menu_price.ReadOnly = true;
            // 
            // menu_type
            // 
            this.menu_type.DataPropertyName = "MENU_TYPE";
            this.menu_type.HeaderText = "ชนิดเมนู";
            this.menu_type.Name = "menu_type";
            this.menu_type.ReadOnly = true;
            // 
            // menu_status
            // 
            this.menu_status.DataPropertyName = "MENU_STATUS";
            this.menu_status.HeaderText = "สถานะเมนู";
            this.menu_status.Name = "menu_status";
            this.menu_status.ReadOnly = true;
            this.menu_status.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MAX PINJOHNV2", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(68, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 60);
            this.label1.TabIndex = 23;
            this.label1.Text = "รายการอาหารทั้งหมด";
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::Jeffer.Properties.Resources.Back_thai;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(891, 534);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(300, 150);
            this.button_back.TabIndex = 32;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // GenerateId
            // 
            this.GenerateId.Font = new System.Drawing.Font("MAX PINJOHNV2", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GenerateId.FormattingEnabled = true;
            this.GenerateId.Items.AddRange(new object[] {
            "Appitizer",
            "Beef",
            "Burger",
            "Chicken",
            "Combo",
            "Drinks",
            "Kids",
            "Pork",
            "Seafood",
            "Spaghetti",
            "Promotions",
            "Set",
            "All"});
            this.GenerateId.Location = new System.Drawing.Point(164, 95);
            this.GenerateId.Name = "GenerateId";
            this.GenerateId.Size = new System.Drawing.Size(250, 48);
            this.GenerateId.TabIndex = 31;
            this.GenerateId.SelectedIndexChanged += new System.EventHandler(this.GenerateId_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Window;
            this.search.Font = new System.Drawing.Font("MAX PINJOHNV2", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(524, 95);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(276, 47);
            this.search.TabIndex = 30;
            this.search.Text = "SEARCH HERE";
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_MouseClick_1);
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 47);
            this.label3.TabIndex = 29;
            this.label3.Text = "SEARCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 47);
            this.label2.TabIndex = 28;
            this.label2.Text = "GROUP";
            // 
            // button_update
            // 
            this.button_update.BackgroundImage = global::Jeffer.Properties.Resources.Update_thai1;
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(891, 345);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(300, 150);
            this.button_update.TabIndex = 27;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackgroundImage = global::Jeffer.Properties.Resources.Insert_thai1;
            this.button_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_insert.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.Location = new System.Drawing.Point(891, 150);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(300, 150);
            this.button_insert.TabIndex = 26;
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.Table_view);
            this.panel1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(17, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 534);
            this.panel1.TabIndex = 25;
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
            this.Time_1.TabIndex = 70;
            this.Time_1.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.Time_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.GenerateId);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.panel1);
            this.Name = "ListMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListMenuForm";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ComboBox GenerateId;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Time_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_status;
    }
}
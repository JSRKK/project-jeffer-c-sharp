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
            this.Table_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateId = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time_1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_view
            // 
            this.Table_view.AllowUserToResizeColumns = false;
            this.Table_view.AllowUserToResizeRows = false;
            this.Table_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu,
            this.menu_name,
            this.menu_price,
            this.menu_type,
            this.menu_status});
            this.Table_view.Location = new System.Drawing.Point(92, 172);
            this.Table_view.Name = "Table_view";
            this.Table_view.ReadOnly = true;
            this.Table_view.RowHeadersVisible = false;
            this.Table_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Table_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table_view.Size = new System.Drawing.Size(686, 486);
            this.Table_view.TabIndex = 24;
            this.Table_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_view_CellClick);
            this.Table_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_view_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MAX PINJOHNV2", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "รายการอาหารทั้งหมด";
            // 
            // GenerateId
            // 
            this.GenerateId.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
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
            this.GenerateId.Size = new System.Drawing.Size(250, 41);
            this.GenerateId.TabIndex = 31;
            this.GenerateId.SelectedIndexChanged += new System.EventHandler(this.GenerateId_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Window;
            this.search.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(524, 95);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(276, 40);
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
            this.label3.Size = new System.Drawing.Size(98, 42);
            this.label3.TabIndex = 29;
            this.label3.Text = "SEARCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 42);
            this.label2.TabIndex = 28;
            this.label2.Text = "GROUP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Location = new System.Drawing.Point(66, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 534);
            this.panel1.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time_1
            // 
            this.Time_1.AutoSize = true;
            this.Time_1.BackColor = System.Drawing.Color.Black;
            this.Time_1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_1.ForeColor = System.Drawing.Color.Chartreuse;
            this.Time_1.Location = new System.Drawing.Point(12, 9);
            this.Time_1.Name = "Time_1";
            this.Time_1.Size = new System.Drawing.Size(56, 28);
            this.Time_1.TabIndex = 33;
            this.Time_1.Text = "label4";
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::Jeffer.Properties.Resources.Back_Main;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(844, 634);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(300, 50);
            this.button_back.TabIndex = 32;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_update
            // 
            this.button_update.BackgroundImage = global::Jeffer.Properties.Resources.Update_thai2;
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(844, 338);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(300, 150);
            this.button_update.TabIndex = 27;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackgroundImage = global::Jeffer.Properties.Resources.Insert_thai;
            this.button_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_insert.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.Location = new System.Drawing.Point(844, 150);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(300, 150);
            this.button_insert.TabIndex = 26;
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // menu
            // 
            this.menu.DataPropertyName = "MENU_ID";
            this.menu.HeaderText = "รหัสสินค้า";
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
            this.menu_price.HeaderText = "ราคา";
            this.menu_price.Name = "menu_price";
            this.menu_price.ReadOnly = true;
            // 
            // menu_type
            // 
            this.menu_type.DataPropertyName = "MENU_TYPE";
            this.menu_type.HeaderText = "ประเภทเมนู";
            this.menu_type.Name = "menu_type";
            this.menu_type.ReadOnly = true;
            // 
            // menu_status
            // 
            this.menu_status.DataPropertyName = "MENU_STATUS";
            this.menu_status.HeaderText = "สถานะของเมนู";
            this.menu_status.Name = "menu_status";
            this.menu_status.ReadOnly = true;
            // 
            // ListMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.Time_1);
            this.Controls.Add(this.Table_view);
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
            this.Text = "ListMenuForm";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_view)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_status;
    }
}
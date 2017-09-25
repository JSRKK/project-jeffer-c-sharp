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
            // menu
            // 
            this.menu.DataPropertyName = "MENU_ID";
            this.menu.HeaderText = "Menu_id";
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            // 
            // menu_name
            // 
            this.menu_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menu_name.DataPropertyName = "MENU_NAME";
            this.menu_name.HeaderText = "Menu_name";
            this.menu_name.Name = "menu_name";
            this.menu_name.ReadOnly = true;
            // 
            // menu_price
            // 
            this.menu_price.DataPropertyName = "MENU_PRICE";
            this.menu_price.HeaderText = "Menu_price";
            this.menu_price.Name = "menu_price";
            this.menu_price.ReadOnly = true;
            // 
            // menu_type
            // 
            this.menu_type.DataPropertyName = "MENU_TYPE";
            this.menu_type.HeaderText = "Menu_type";
            this.menu_type.Name = "menu_type";
            this.menu_type.ReadOnly = true;
            // 
            // menu_status
            // 
            this.menu_status.DataPropertyName = "MENU_STATUS";
            this.menu_status.HeaderText = "Menu_status";
            this.menu_status.Name = "menu_status";
            this.menu_status.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "รายการอาหารทั้งหมด";
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(891, 534);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(400, 150);
            this.button_back.TabIndex = 32;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // GenerateId
            // 
            this.GenerateId.Font = new System.Drawing.Font("Angsana New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
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
            this.GenerateId.Size = new System.Drawing.Size(250, 51);
            this.GenerateId.TabIndex = 31;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Window;
            this.search.Font = new System.Drawing.Font("Angsana New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(524, 95);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(276, 51);
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
            this.button_update.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(891, 345);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(400, 150);
            this.button_update.TabIndex = 27;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_insert
            // 
            this.button_insert.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.Location = new System.Drawing.Point(891, 150);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(400, 150);
            this.button_insert.TabIndex = 26;
            this.button_insert.Text = "INSERT";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Location = new System.Drawing.Point(66, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 534);
            this.panel1.TabIndex = 25;
            // 
            // ListMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ComboBox GenerateId;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Panel panel1;
    }
}
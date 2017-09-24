namespace jeffer.menu_form
{
    partial class EditMenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TakeMaterial_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeMaterial_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Table_view = new System.Windows.Forms.DataGridView();
            this.Product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchGroup = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menutype1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.menutype = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TAKEGRID = new System.Windows.Forms.DataGridView();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DINEGRID = new System.Windows.Forms.DataGridView();
            this.Material_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table_view)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAKEGRID)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DINEGRID)).BeginInit();
            this.SuspendLayout();
            // 
            // delete1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            this.delete1.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete1.HeaderText = "delete";
            this.delete1.Name = "delete1";
            this.delete1.Text = "delete";
            this.delete1.UseColumnTextForButtonValue = true;
            // 
            // TakeMaterial_id
            // 
            this.TakeMaterial_id.HeaderText = "Material_id";
            this.TakeMaterial_id.Name = "TakeMaterial_id";
            // 
            // TakeMaterial_name
            // 
            this.TakeMaterial_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TakeMaterial_name.HeaderText = "Material_name";
            this.TakeMaterial_name.Name = "TakeMaterial_name";
            // 
            // TakeAmount
            // 
            this.TakeAmount.HeaderText = "Amount";
            this.TakeAmount.Name = "TakeAmount";
            this.TakeAmount.Width = 50;
            // 
            // delete
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            this.delete.DefaultCellStyle = dataGridViewCellStyle5;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 50;
            // 
            // Table_view
            // 
            this.Table_view.AllowUserToAddRows = false;
            this.Table_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_id,
            this.Product_name,
            this.Product_unit,
            this.Add});
            this.Table_view.Location = new System.Drawing.Point(7, 8);
            this.Table_view.Name = "Table_view";
            this.Table_view.ReadOnly = true;
            this.Table_view.RowHeadersVisible = false;
            this.Table_view.RowHeadersWidth = 40;
            this.Table_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table_view.Size = new System.Drawing.Size(704, 227);
            this.Table_view.TabIndex = 27;
            this.Table_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_view_CellClick);
            // 
            // Product_id
            // 
            this.Product_id.DataPropertyName = "PRODUCT_ID";
            this.Product_id.HeaderText = "Product_id";
            this.Product_id.Name = "Product_id";
            this.Product_id.ReadOnly = true;
            // 
            // Product_name
            // 
            this.Product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_name.DataPropertyName = "PRODUCT_NAME";
            this.Product_name.HeaderText = "Product_name";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            // 
            // Product_unit
            // 
            this.Product_unit.DataPropertyName = "PRODUCT_UNIT";
            this.Product_unit.HeaderText = "Product_unit";
            this.Product_unit.Name = "Product_unit";
            this.Product_unit.ReadOnly = true;
            // 
            // Add
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SpringGreen;
            this.Add.DefaultCellStyle = dataGridViewCellStyle6;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Text = "Add";
            this.Add.UseColumnTextForButtonValue = true;
            this.Add.Width = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(27, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 60);
            this.panel2.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(16, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 50);
            this.label4.TabIndex = 18;
            this.label4.Text = "MENU DETAIL";
            // 
            // SearchGroup
            // 
            this.SearchGroup.Font = new System.Drawing.Font("Angsana New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroup.FormattingEnabled = true;
            this.SearchGroup.Items.AddRange(new object[] {
            "DINEIN",
            "TAKEAWAY"});
            this.SearchGroup.Location = new System.Drawing.Point(909, 43);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(177, 51);
            this.SearchGroup.TabIndex = 38;
            this.SearchGroup.SelectedIndexChanged += new System.EventHandler(this.SearchGroup_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Window;
            this.Search.Font = new System.Drawing.Font("Angsana New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Search.Location = new System.Drawing.Point(1092, 43);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(234, 51);
            this.Search.TabIndex = 37;
            this.Search.Text = "SEARCH HERE";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Search_MouseClick);
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(947, 608);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(180, 80);
            this.button_back.TabIndex = 43;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.menutype1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.menutype);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 346);
            this.panel1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "MENU PRICE";
            // 
            // menutype1
            // 
            this.menutype1.AutoSize = true;
            this.menutype1.BackColor = System.Drawing.Color.Transparent;
            this.menutype1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menutype1.Location = new System.Drawing.Point(28, 24);
            this.menutype1.Name = "menutype1";
            this.menutype1.Size = new System.Drawing.Size(158, 50);
            this.menutype1.TabIndex = 5;
            this.menutype1.Text = "MENU TYPE";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Angsana New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(228, 102);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(338, 51);
            this.txtID.TabIndex = 1;
            // 
            // menutype
            // 
            this.menutype.Enabled = false;
            this.menutype.Font = new System.Drawing.Font("Angsana New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.menutype.FormattingEnabled = true;
            this.menutype.Items.AddRange(new object[] {
            "Dinein",
            "Dinein+Take-Away",
            "Take-Away"});
            this.menutype.Location = new System.Drawing.Point(228, 22);
            this.menutype.Name = "menutype";
            this.menutype.Size = new System.Drawing.Size(338, 51);
            this.menutype.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Angsana New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(228, 262);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(338, 51);
            this.txtPrice.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Angsana New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(228, 182);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(338, 51);
            this.txtName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "MENU ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU NAME";
            // 
            // TAKEGRID
            // 
            this.TAKEGRID.AllowUserToAddRows = false;
            this.TAKEGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TAKEGRID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TakeMaterial_id,
            this.TakeMaterial_name,
            this.TakeAmount,
            this.delete});
            this.TAKEGRID.Location = new System.Drawing.Point(361, 294);
            this.TAKEGRID.Name = "TAKEGRID";
            this.TAKEGRID.RowHeadersVisible = false;
            this.TAKEGRID.Size = new System.Drawing.Size(350, 181);
            this.TAKEGRID.TabIndex = 29;
            this.TAKEGRID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TAKEGRID_CellClick_1);
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(13, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 40);
            this.label9.TabIndex = 19;
            this.label9.Text = "DINEIN_MATERIAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(803, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 50);
            this.label8.TabIndex = 36;
            this.label8.Text = "GROUP";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(622, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 60);
            this.panel4.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 50);
            this.label7.TabIndex = 19;
            this.label7.Text = "MATERIAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(13, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 40);
            this.label11.TabIndex = 19;
            this.label11.Text = "TAKEAWAY_MATERIAL";
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(1146, 608);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(180, 80);
            this.button_update.TabIndex = 35;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(7, 246);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 60);
            this.panel5.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(361, 246);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 60);
            this.panel6.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.DINEGRID);
            this.panel3.Controls.Add(this.TAKEGRID);
            this.panel3.Controls.Add(this.Table_view);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(615, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 502);
            this.panel3.TabIndex = 41;
            // 
            // DINEGRID
            // 
            this.DINEGRID.AllowUserToAddRows = false;
            this.DINEGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DINEGRID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material_id,
            this.Material_name,
            this.Amount,
            this.delete1});
            this.DINEGRID.Location = new System.Drawing.Point(7, 294);
            this.DINEGRID.Name = "DINEGRID";
            this.DINEGRID.RowHeadersVisible = false;
            this.DINEGRID.Size = new System.Drawing.Size(348, 181);
            this.DINEGRID.TabIndex = 28;
            this.DINEGRID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DINEGRID_CellClick);
            // 
            // Material_id
            // 
            this.Material_id.HeaderText = "Material_id";
            this.Material_id.Name = "Material_id";
            this.Material_id.ReadOnly = true;
            // 
            // Material_name
            // 
            this.Material_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material_name.HeaderText = "Material_name";
            this.Material_name.Name = "Material_name";
            this.Material_name.ReadOnly = true;
            // 
            // EditMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SearchGroup);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.panel3);
            this.Name = "EditMenuForm";
            this.Text = "EditMenuForm";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_view)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAKEGRID)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DINEGRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn delete1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeMaterial_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeMaterial_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeAmount;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridView Table_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_unit;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SearchGroup;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label menutype1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox menutype;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TAKEGRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DINEGRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_name;
    }
}
namespace Jeffer
{
    partial class UpdateProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botton_save = new System.Windows.Forms.Button();
            this.cb_groupMenu = new System.Windows.Forms.ComboBox();
            this.dgv_checkUpdateProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain_unit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain_perunit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_unit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_perunit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeP = new System.Windows.Forms.DataGridViewButtonColumn();
            this.perunit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_product2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain_perunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_perunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temp_totalproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_check = new System.Windows.Forms.Button();
            this.tb_searchProduct = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_backmain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Time_1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkUpdateProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botton_save
            // 
            this.botton_save.BackColor = System.Drawing.Color.LimeGreen;
            this.botton_save.BackgroundImage = global::Jeffer.Properties.Resources.Save_thai;
            this.botton_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botton_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botton_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.botton_save.Location = new System.Drawing.Point(1097, 85);
            this.botton_save.Name = "botton_save";
            this.botton_save.Size = new System.Drawing.Size(150, 75);
            this.botton_save.TabIndex = 3;
            this.botton_save.UseVisualStyleBackColor = false;
            this.botton_save.Visible = false;
            this.botton_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // cb_groupMenu
            // 
            this.cb_groupMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_groupMenu.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_groupMenu.FormattingEnabled = true;
            this.cb_groupMenu.Location = new System.Drawing.Point(82, 126);
            this.cb_groupMenu.Name = "cb_groupMenu";
            this.cb_groupMenu.Size = new System.Drawing.Size(159, 37);
            this.cb_groupMenu.TabIndex = 7;
            this.cb_groupMenu.SelectedIndexChanged += new System.EventHandler(this.cb_groupMenu_SelectedIndexChanged);
            // 
            // dgv_checkUpdateProduct
            // 
            this.dgv_checkUpdateProduct.AllowUserToAddRows = false;
            this.dgv_checkUpdateProduct.AllowUserToDeleteRows = false;
            this.dgv_checkUpdateProduct.AllowUserToResizeColumns = false;
            this.dgv_checkUpdateProduct.AllowUserToResizeRows = false;
            this.dgv_checkUpdateProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_checkUpdateProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_checkUpdateProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgv_checkUpdateProduct.ColumnHeadersHeight = 30;
            this.dgv_checkUpdateProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_checkUpdateProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.remain_unit2,
            this.remain_perunit2,
            this.count_unit2,
            this.count_perunit2,
            this.removeP,
            this.perunit2,
            this.total_product2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_checkUpdateProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_checkUpdateProduct.Location = new System.Drawing.Point(10, 10);
            this.dgv_checkUpdateProduct.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dgv_checkUpdateProduct.Name = "dgv_checkUpdateProduct";
            this.dgv_checkUpdateProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_checkUpdateProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_checkUpdateProduct.Size = new System.Drawing.Size(1162, 372);
            this.dgv_checkUpdateProduct.TabIndex = 17;
            this.dgv_checkUpdateProduct.Visible = false;
            this.dgv_checkUpdateProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_checkUpdateProduct_CellClick);
            this.dgv_checkUpdateProduct.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_checkUpdateProduct_EditingControlShowing);
            this.dgv_checkUpdateProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_checkUpdateProduct_KeyPress);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "กลุ่มสินค้า";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "รหัสสินค้า";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "ชื่อสินค้า";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "หน่วยนับ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // remain_unit2
            // 
            this.remain_unit2.HeaderText = "คงเหลือหน่วยใหญ่";
            this.remain_unit2.Name = "remain_unit2";
            this.remain_unit2.Width = 150;
            // 
            // remain_perunit2
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.remain_perunit2.DefaultCellStyle = dataGridViewCellStyle1;
            this.remain_perunit2.HeaderText = "คงเหลือหน่วยย่อย";
            this.remain_perunit2.Name = "remain_perunit2";
            this.remain_perunit2.ReadOnly = true;
            this.remain_perunit2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.remain_perunit2.Width = 140;
            // 
            // count_unit2
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.count_unit2.DefaultCellStyle = dataGridViewCellStyle2;
            this.count_unit2.HeaderText = "นับจริงหน่วยใหญ";
            this.count_unit2.Name = "count_unit2";
            this.count_unit2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.count_unit2.Width = 120;
            // 
            // count_perunit2
            // 
            this.count_perunit2.HeaderText = "นับจริงหน่วยย่อย";
            this.count_perunit2.Name = "count_perunit2";
            this.count_perunit2.Width = 120;
            // 
            // removeP
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cordia New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.removeP.DefaultCellStyle = dataGridViewCellStyle3;
            this.removeP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeP.HeaderText = "";
            this.removeP.Name = "removeP";
            this.removeP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.removeP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.removeP.Text = "ลบ";
            this.removeP.UseColumnTextForButtonValue = true;
            this.removeP.Width = 50;
            // 
            // perunit2
            // 
            this.perunit2.HeaderText = "จำนวนต่อหน่วย";
            this.perunit2.Name = "perunit2";
            this.perunit2.Visible = false;
            // 
            // total_product2
            // 
            this.total_product2.HeaderText = "จำนวนทั้งหมด";
            this.total_product2.Name = "total_product2";
            this.total_product2.Visible = false;
            // 
            // tb_amount
            // 
            this.tb_amount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_amount.Font = new System.Drawing.Font("MAX PINJOHNV2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_amount.Location = new System.Drawing.Point(1250, 6);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.ReadOnly = true;
            this.tb_amount.Size = new System.Drawing.Size(65, 40);
            this.tb_amount.TabIndex = 19;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_back.BackgroundImage = global::Jeffer.Properties.Resources.Back_thai;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_back.Location = new System.Drawing.Point(923, 85);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(150, 75);
            this.button_back.TabIndex = 20;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.AllowUserToResizeColumns = false;
            this.dgv_product.AllowUserToResizeRows = false;
            this.dgv_product.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgv_product.ColumnHeadersHeight = 30;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.remain_unit,
            this.remain_perunit,
            this.count_unit,
            this.count_perunit,
            this.perunit,
            this.temp_totalproduct});
            this.dgv_product.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_product.Location = new System.Drawing.Point(10, 10);
            this.dgv_product.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dgv_product.Name = "dgv_product";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_product.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_product.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(1162, 372);
            this.dgv_product.TabIndex = 21;
            this.dgv_product.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellEndEdit);
            this.dgv_product.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_product_EditingControlShowing);
            this.dgv_product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_product_KeyPress);
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn7.HeaderText = "กลุ่มสินค้า";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "รหัสสินค้า";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "ชื่อสินค้า";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "หน่วยนับ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // remain_unit
            // 
            this.remain_unit.HeaderText = "คงเหลือหน่วยใหญ่";
            this.remain_unit.Name = "remain_unit";
            this.remain_unit.Width = 150;
            // 
            // remain_perunit
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.remain_perunit.DefaultCellStyle = dataGridViewCellStyle6;
            this.remain_perunit.HeaderText = "คงเหลือหน่วยย่อย";
            this.remain_perunit.Name = "remain_perunit";
            this.remain_perunit.ReadOnly = true;
            this.remain_perunit.Width = 140;
            // 
            // count_unit
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = null;
            this.count_unit.DefaultCellStyle = dataGridViewCellStyle7;
            this.count_unit.HeaderText = "นับจริงหน่วยใหญ่";
            this.count_unit.Name = "count_unit";
            this.count_unit.Width = 120;
            // 
            // count_perunit
            // 
            this.count_perunit.HeaderText = "นับจริงหน่วยย่อย";
            this.count_perunit.Name = "count_perunit";
            this.count_perunit.Width = 120;
            // 
            // perunit
            // 
            this.perunit.HeaderText = "จำนวนต่อหน่วย";
            this.perunit.Name = "perunit";
            this.perunit.Visible = false;
            // 
            // temp_totalproduct
            // 
            this.temp_totalproduct.HeaderText = "จำนวนทั้งหมด";
            this.temp_totalproduct.Name = "temp_totalproduct";
            this.temp_totalproduct.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_check);
            this.panel1.Controls.Add(this.tb_searchProduct);
            this.panel1.Controls.Add(this.botton_save);
            this.panel1.Controls.Add(this.text2);
            this.panel1.Controls.Add(this.text1);
            this.panel1.Controls.Add(this.cb_groupMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.button_backmain);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 598);
            this.panel1.TabIndex = 26;
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.Gold;
            this.button_check.BackgroundImage = global::Jeffer.Properties.Resources.Check_thai;
            this.button_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_check.Location = new System.Drawing.Point(1097, 85);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(150, 75);
            this.button_check.TabIndex = 43;
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // tb_searchProduct
            // 
            this.tb_searchProduct.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_searchProduct.Location = new System.Drawing.Point(267, 126);
            this.tb_searchProduct.Name = "tb_searchProduct";
            this.tb_searchProduct.Size = new System.Drawing.Size(193, 37);
            this.tb_searchProduct.TabIndex = 37;
            this.tb_searchProduct.TextChanged += new System.EventHandler(this.tb_searchProduct_TextChanged);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.text2.Location = new System.Drawing.Point(264, 94);
            this.text2.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(156, 31);
            this.text2.TabIndex = 22;
            this.text2.Text = "ค้นหาจากชื่อสินค้า:";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.text1.Location = new System.Drawing.Point(80, 93);
            this.text1.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(93, 31);
            this.text1.TabIndex = 21;
            this.text1.Text = "กลุ่มสินค้า:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dgv_checkUpdateProduct);
            this.panel3.Controls.Add(this.dgv_product);
            this.panel3.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.panel3.Location = new System.Drawing.Point(73, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1188, 398);
            this.panel3.TabIndex = 42;
            // 
            // button_backmain
            // 
            this.button_backmain.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_backmain.BackgroundImage = global::Jeffer.Properties.Resources.Back_Main_thai;
            this.button_backmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_backmain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backmain.Location = new System.Drawing.Point(22, 20);
            this.button_backmain.Name = "button_backmain";
            this.button_backmain.Size = new System.Drawing.Size(300, 50);
            this.button_backmain.TabIndex = 44;
            this.button_backmain.UseVisualStyleBackColor = false;
            this.button_backmain.Click += new System.EventHandler(this.button_backmain_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_amount);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1405, 64);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jeffer.Properties.Resources.if_update_172618;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 31);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MAX PINJOHNV2", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(45, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 46);
            this.label4.TabIndex = 24;
            this.label4.Text = "อัพเดทสินค้าคงเหลือ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MAX PINJOHNV2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(1115, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 34);
            this.label3.TabIndex = 23;
            this.label3.Text = "จำนวนรายการ:";
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
            this.Time_1.TabIndex = 71;
            this.Time_1.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1362, 720);
            this.Controls.Add(this.Time_1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkUpdateProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botton_save;
        private System.Windows.Forms.ComboBox cb_groupMenu;
        private System.Windows.Forms.DataGridView dgv_checkUpdateProduct;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_searchProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_backmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain_unit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain_perunit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_unit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_perunit2;
        private System.Windows.Forms.DataGridViewButtonColumn removeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn perunit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_product2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain_perunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_perunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn perunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn temp_totalproduct;
        private System.Windows.Forms.Label Time_1;
        private System.Windows.Forms.Timer timer1;
    }
}
﻿namespace jeffer
{
    partial class OrderProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showGroup = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.countOrder = new System.Windows.Forms.TextBox();
            this.dateOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_checkProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_searchProduct = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.button_backmain = new System.Windows.Forms.Button();
            this.Time_1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGroup)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkProduct)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.AllowUserToResizeRows = false;
            this.dgv_product.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgv_product.ColumnHeadersHeight = 30;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.unit,
            this.balance,
            this.amount});
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle70.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle70.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle70.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_product.DefaultCellStyle = dataGridViewCellStyle70;
            this.dgv_product.Location = new System.Drawing.Point(9, 11);
            this.dgv_product.MultiSelect = false;
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.RowHeadersWidth = 100;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_product.RowsDefaultCellStyle = dataGridViewCellStyle71;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(956, 403);
            this.dgv_product.TabIndex = 1;
            this.dgv_product.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_product_CellEndEdit);
            this.dgv_product.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtg_product_EditingControlShowing);
            this.dgv_product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listProduct_KeyPress);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "รหัสสินค้า";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 120;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "ชื่อสินค้า (Product Name)";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // unit
            // 
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unit.DefaultCellStyle = dataGridViewCellStyle67;
            this.unit.HeaderText = "หน่วยนับ";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unit.Width = 120;
            // 
            // balance
            // 
            dataGridViewCellStyle68.Format = "N2";
            dataGridViewCellStyle68.NullValue = null;
            this.balance.DefaultCellStyle = dataGridViewCellStyle68;
            this.balance.HeaderText = "คงเหลือ";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.balance.Width = 120;
            // 
            // amount
            // 
            dataGridViewCellStyle69.Format = "N2";
            dataGridViewCellStyle69.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle69;
            this.amount.HeaderText = "จำนวนที่สั่ง";
            this.amount.Name = "amount";
            this.amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.amount.Width = 110;
            // 
            // showGroup
            // 
            this.showGroup.AllowUserToAddRows = false;
            this.showGroup.AllowUserToDeleteRows = false;
            this.showGroup.AllowUserToResizeRows = false;
            this.showGroup.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showGroup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.showGroup.ColumnHeadersHeight = 30;
            this.showGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.group});
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle72.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle72.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showGroup.DefaultCellStyle = dataGridViewCellStyle72;
            this.showGroup.Location = new System.Drawing.Point(10, 12);
            this.showGroup.MultiSelect = false;
            this.showGroup.Name = "showGroup";
            this.showGroup.ReadOnly = true;
            this.showGroup.RowHeadersVisible = false;
            this.showGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showGroup.Size = new System.Drawing.Size(179, 403);
            this.showGroup.TabIndex = 2;
            this.showGroup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showGroup_CellDoubleClick);
            // 
            // id2
            // 
            this.id2.HeaderText = "ID";
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            this.id2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id2.Width = 40;
            // 
            // group
            // 
            this.group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.group.HeaderText = "Group";
            this.group.Name = "group";
            this.group.ReadOnly = true;
            this.group.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.countOrder);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dateOrder);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 60);
            this.panel2.TabIndex = 28;
            // 
            // countOrder
            // 
            this.countOrder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.countOrder.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countOrder.Location = new System.Drawing.Point(1242, 10);
            this.countOrder.Name = "countOrder";
            this.countOrder.ReadOnly = true;
            this.countOrder.Size = new System.Drawing.Size(63, 34);
            this.countOrder.TabIndex = 19;
            // 
            // dateOrder
            // 
            this.dateOrder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateOrder.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOrder.Location = new System.Drawing.Point(990, 10);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.ReadOnly = true;
            this.dateOrder.Size = new System.Drawing.Size(97, 34);
            this.dateOrder.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MAX PINJOHNV2", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 54);
            this.label4.TabIndex = 24;
            this.label4.Text = "รายการสั่งสินค้า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1105, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "จำนวนรายการ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(872, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "วันที่สั่งสินค้า:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.showGroup);
            this.panel1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(54, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 427);
            this.panel1.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dgv_checkProduct);
            this.panel3.Controls.Add(this.dgv_product);
            this.panel3.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(296, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 427);
            this.panel3.TabIndex = 30;
            // 
            // dgv_checkProduct
            // 
            this.dgv_checkProduct.AllowUserToAddRows = false;
            this.dgv_checkProduct.AllowUserToDeleteRows = false;
            this.dgv_checkProduct.AllowUserToResizeRows = false;
            this.dgv_checkProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_checkProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_checkProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgv_checkProduct.ColumnHeadersHeight = 30;
            this.dgv_checkProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.remain,
            this.dataGridViewTextBoxColumn4,
            this.remove});
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle76.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle76.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle76.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle76.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle76.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle76.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_checkProduct.DefaultCellStyle = dataGridViewCellStyle76;
            this.dgv_checkProduct.Location = new System.Drawing.Point(9, 11);
            this.dgv_checkProduct.MultiSelect = false;
            this.dgv_checkProduct.Name = "dgv_checkProduct";
            this.dgv_checkProduct.RowHeadersVisible = false;
            this.dgv_checkProduct.RowHeadersWidth = 100;
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_checkProduct.RowsDefaultCellStyle = dataGridViewCellStyle77;
            this.dgv_checkProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_checkProduct.Size = new System.Drawing.Size(956, 403);
            this.dgv_checkProduct.TabIndex = 2;
            this.dgv_checkProduct.Visible = false;
            this.dgv_checkProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_check_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสสินค้า";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "ชื่อสินค้า (Product Name)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle73;
            this.dataGridViewTextBoxColumn3.HeaderText = "หน่วยนับ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // remain
            // 
            this.remain.HeaderText = "คงเหลือ";
            this.remain.Name = "remain";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle74.Format = "N2";
            dataGridViewCellStyle74.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle74;
            this.dataGridViewTextBoxColumn4.HeaderText = "จำนวนที่สั่ง";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // remove
            // 
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle75.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle75.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle75.SelectionForeColor = System.Drawing.Color.Black;
            this.remove.DefaultCellStyle = dataGridViewCellStyle75;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove.HeaderText = "";
            this.remove.Name = "remove";
            this.remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remove.Text = "ลบ";
            this.remove.UseColumnTextForButtonValue = true;
            this.remove.Width = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.tb_searchProduct);
            this.panel4.Controls.Add(this.button_back);
            this.panel4.Controls.Add(this.button_save);
            this.panel4.Controls.Add(this.button_check);
            this.panel4.Controls.Add(this.button_backmain);
            this.panel4.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(12, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1326, 637);
            this.panel4.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(294, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 50;
            this.label2.Text = "ค้นหาจากชื่อสินค้า:";
            // 
            // tb_searchProduct
            // 
            this.tb_searchProduct.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_searchProduct.Location = new System.Drawing.Point(456, 93);
            this.tb_searchProduct.Name = "tb_searchProduct";
            this.tb_searchProduct.Size = new System.Drawing.Size(203, 34);
            this.tb_searchProduct.TabIndex = 49;
            this.tb_searchProduct.TextChanged += new System.EventHandler(this.tb_searchProduct_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jeffer.Properties.Resources.if_track_172602;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 51);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.DarkGray;
            this.button_back.BackgroundImage = global::Jeffer.Properties.Resources.Back_thai;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(959, 71);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(150, 75);
            this.button_back.TabIndex = 48;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.LimeGreen;
            this.button_save.BackgroundImage = global::Jeffer.Properties.Resources.Save_thai1;
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_save.Location = new System.Drawing.Point(1124, 71);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 75);
            this.button_save.TabIndex = 6;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Visible = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.Gold;
            this.button_check.BackgroundImage = global::Jeffer.Properties.Resources.Check_thai;
            this.button_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_check.Location = new System.Drawing.Point(1124, 71);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(150, 75);
            this.button_check.TabIndex = 5;
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_backmain
            // 
            this.button_backmain.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_backmain.BackgroundImage = global::Jeffer.Properties.Resources.Back_Main_thai;
            this.button_backmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_backmain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backmain.Location = new System.Drawing.Point(28, 27);
            this.button_backmain.Name = "button_backmain";
            this.button_backmain.Size = new System.Drawing.Size(300, 50);
            this.button_backmain.TabIndex = 47;
            this.button_backmain.UseVisualStyleBackColor = false;
            this.button_backmain.Click += new System.EventHandler(this.button_backmain_Click);
            // 
            // Time_1
            // 
            this.Time_1.AutoSize = true;
            this.Time_1.BackColor = System.Drawing.Color.Black;
            this.Time_1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_1.ForeColor = System.Drawing.Color.Lime;
            this.Time_1.Location = new System.Drawing.Point(12, 9);
            this.Time_1.Name = "Time_1";
            this.Time_1.Size = new System.Drawing.Size(39, 25);
            this.Time_1.TabIndex = 145;
            this.Time_1.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrderProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Time_1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGroup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkProduct)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridView showGroup;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox dateOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_backmain;
        public System.Windows.Forms.DataGridView dgv_checkProduct;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox tb_searchProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
        private System.Windows.Forms.Label Time_1;
        private System.Windows.Forms.Timer timer1;
    }
}


﻿namespace Jeffer
{
    partial class ReceiveProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkReceived = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.text3 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.lotID = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_backmain = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dateOrder = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.dateReceived = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_lotProduct = new System.Windows.Forms.DataGridView();
            this.listLotId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listDateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listDateReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Time_1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkReceived)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lotProduct)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkReceived
            // 
            this.checkReceived.AllowUserToAddRows = false;
            this.checkReceived.AllowUserToDeleteRows = false;
            this.checkReceived.AllowUserToResizeColumns = false;
            this.checkReceived.AllowUserToResizeRows = false;
            this.checkReceived.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.checkReceived.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.checkReceived.ColumnHeadersHeight = 30;
            this.checkReceived.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.id,
            this.name,
            this.unit,
            this.order,
            this.received,
            this.status});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkReceived.DefaultCellStyle = dataGridViewCellStyle17;
            this.checkReceived.Location = new System.Drawing.Point(12, 12);
            this.checkReceived.Name = "checkReceived";
            this.checkReceived.RowHeadersVisible = false;
            this.checkReceived.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkReceived.Size = new System.Drawing.Size(1242, 354);
            this.checkReceived.TabIndex = 0;
            this.checkReceived.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkReceived_CellEndEdit);
            this.checkReceived.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.checkReceived_DataError);
            // 
            // number
            // 
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // id
            // 
            this.id.HeaderText = "รหัสสินค้า";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "ชื่อสินค้า (Product Name)";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "หน่วยนับ";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // order
            // 
            this.order.HeaderText = "จำนวนที่สั่ง";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // received
            // 
            this.received.HeaderText = "จำนวนที่ได้รับ";
            this.received.Name = "received";
            // 
            // status
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.status.DefaultCellStyle = dataGridViewCellStyle16;
            this.status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.status.HeaderText = "สถานะ";
            this.status.Items.AddRange(new object[] {
            "Received",
            "Not Received"});
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adasdToolStripMenuItem,
            this.asdToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 48);
            // 
            // adasdToolStripMenuItem
            // 
            this.adasdToolStripMenuItem.Name = "adasdToolStripMenuItem";
            this.adasdToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.adasdToolStripMenuItem.Text = "adasd";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.asdToolStripMenuItem.Text = "asd";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(363, 120);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(99, 28);
            this.text3.TabIndex = 7;
            this.text3.Text = "วันที่รับสินค้า";
            this.text3.Visible = false;
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text4.Location = new System.Drawing.Point(363, 173);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(116, 28);
            this.text4.TabIndex = 9;
            this.text4.Text = "รายการทั้งหมด";
            this.text4.Visible = false;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.total.Location = new System.Drawing.Point(495, 169);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(146, 34);
            this.total.TabIndex = 8;
            this.total.Visible = false;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(47, 119);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(114, 28);
            this.text1.TabIndex = 11;
            this.text1.Text = "เลขที่ใบสั่งสินค้า";
            this.text1.Visible = false;
            // 
            // lotID
            // 
            this.lotID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lotID.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotID.Location = new System.Drawing.Point(159, 119);
            this.lotID.Name = "lotID";
            this.lotID.ReadOnly = true;
            this.lotID.Size = new System.Drawing.Size(146, 34);
            this.lotID.TabIndex = 10;
            this.lotID.Visible = false;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(47, 173);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(98, 28);
            this.text2.TabIndex = 13;
            this.text2.Text = "วันที่สั่งสินค้า";
            this.text2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_backmain);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.dateOrder);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.dateReceived);
            this.panel1.Controls.Add(this.text4);
            this.panel1.Controls.Add(this.text3);
            this.panel1.Controls.Add(this.text2);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.lotID);
            this.panel1.Controls.Add(this.text1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 631);
            this.panel1.TabIndex = 27;
            // 
            // button_backmain
            // 
            this.button_backmain.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_backmain.BackgroundImage = global::Jeffer.Properties.Resources.Back_Main_thai;
            this.button_backmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_backmain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backmain.Location = new System.Drawing.Point(42, 24);
            this.button_backmain.Name = "button_backmain";
            this.button_backmain.Size = new System.Drawing.Size(300, 50);
            this.button_backmain.TabIndex = 46;
            this.button_backmain.UseVisualStyleBackColor = false;
            this.button_backmain.Click += new System.EventHandler(this.button_backmain_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.LimeGreen;
            this.button_save.BackgroundImage = global::Jeffer.Properties.Resources.Save_thai1;
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button_save.Location = new System.Drawing.Point(1134, 128);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 75);
            this.button_save.TabIndex = 21;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Visible = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dateOrder
            // 
            this.dateOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateOrder.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOrder.Location = new System.Drawing.Point(159, 169);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.ReadOnly = true;
            this.dateOrder.Size = new System.Drawing.Size(146, 34);
            this.dateOrder.TabIndex = 19;
            this.dateOrder.Visible = false;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_back.BackgroundImage = global::Jeffer.Properties.Resources.Back_thai;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_back.Location = new System.Drawing.Point(1134, 24);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(150, 75);
            this.button_back.TabIndex = 17;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dateReceived
            // 
            this.dateReceived.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateReceived.Location = new System.Drawing.Point(495, 116);
            this.dateReceived.Name = "dateReceived";
            this.dateReceived.ReadOnly = true;
            this.dateReceived.Size = new System.Drawing.Size(146, 34);
            this.dateReceived.TabIndex = 15;
            this.dateReceived.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dgv_lotProduct);
            this.panel3.Controls.Add(this.checkReceived);
            this.panel3.Location = new System.Drawing.Point(28, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1268, 380);
            this.panel3.TabIndex = 20;
            // 
            // dgv_lotProduct
            // 
            this.dgv_lotProduct.AllowUserToAddRows = false;
            this.dgv_lotProduct.AllowUserToDeleteRows = false;
            this.dgv_lotProduct.AllowUserToResizeColumns = false;
            this.dgv_lotProduct.AllowUserToResizeRows = false;
            this.dgv_lotProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_lotProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_lotProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgv_lotProduct.ColumnHeadersHeight = 30;
            this.dgv_lotProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listLotId,
            this.listDateOrder,
            this.listDateReceive});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lotProduct.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_lotProduct.Location = new System.Drawing.Point(12, 12);
            this.dgv_lotProduct.Name = "dgv_lotProduct";
            this.dgv_lotProduct.RowTemplate.Height = 30;
            this.dgv_lotProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lotProduct.Size = new System.Drawing.Size(1242, 354);
            this.dgv_lotProduct.TabIndex = 16;
            this.dgv_lotProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listLot_CellDoubleClick);
            // 
            // listLotId
            // 
            this.listLotId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.listLotId.HeaderText = "หมายเลขสั่งซื้อ";
            this.listLotId.Name = "listLotId";
            this.listLotId.ReadOnly = true;
            this.listLotId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // listDateOrder
            // 
            this.listDateOrder.HeaderText = "วันที่สั่งซื้อ";
            this.listDateOrder.Name = "listDateOrder";
            this.listDateOrder.ReadOnly = true;
            this.listDateOrder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.listDateOrder.Width = 200;
            // 
            // listDateReceive
            // 
            this.listDateReceive.HeaderText = "วันที่รับ";
            this.listDateReceive.Name = "listDateReceive";
            this.listDateReceive.ReadOnly = true;
            this.listDateReceive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.listDateReceive.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 64);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jeffer.Properties.Resources.if_put_in_172531;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 51);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MAX PINJOHNV2", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 54);
            this.label1.TabIndex = 24;
            this.label1.Text = "รายการรับสินค้า";
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
            this.Time_1.TabIndex = 147;
            this.Time_1.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ReceiveProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Time_1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceiveProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.checkReceived)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lotProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView checkReceived;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox lotID;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateReceived;
        private System.Windows.Forms.DataGridView dgv_lotProduct;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox dateOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_backmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn received;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn listLotId;
        private System.Windows.Forms.DataGridViewTextBoxColumn listDateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn listDateReceive;
        private System.Windows.Forms.Label Time_1;
        private System.Windows.Forms.Timer timer1;
    }
}
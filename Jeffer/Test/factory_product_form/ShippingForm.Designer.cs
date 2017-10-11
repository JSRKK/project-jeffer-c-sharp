namespace Jeffer
{
    partial class ShippingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_save = new System.Windows.Forms.Button();
            this.dateOrder = new System.Windows.Forms.TextBox();
            this.dateSent = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.numberProduct = new System.Windows.Forms.TextBox();
            this.dgv_checkReceived = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.Time_1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkReceived)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.LimeGreen;
            this.button_save.BackgroundImage = global::Jeffer.Properties.Resources.Save_thai1;
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_save.ImageIndex = 163;
            this.button_save.Location = new System.Drawing.Point(1097, 137);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 75);
            this.button_save.TabIndex = 21;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dateOrder
            // 
            this.dateOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateOrder.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOrder.Location = new System.Drawing.Point(523, 101);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.ReadOnly = true;
            this.dateOrder.Size = new System.Drawing.Size(146, 43);
            this.dateOrder.TabIndex = 2;
            this.dateOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateSent
            // 
            this.dateSent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateSent.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSent.Location = new System.Drawing.Point(523, 169);
            this.dateSent.Name = "dateSent";
            this.dateSent.ReadOnly = true;
            this.dateSent.Size = new System.Drawing.Size(146, 43);
            this.dateSent.TabIndex = 4;
            this.dateSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text4.Location = new System.Drawing.Point(37, 169);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(152, 37);
            this.text4.TabIndex = 9;
            this.text4.Text = "รายการทั้งหมด";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(373, 169);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(132, 37);
            this.text3.TabIndex = 7;
            this.text3.Text = "วันที่ส่งสินค้า";
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.total.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(201, 169);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(146, 43);
            this.total.TabIndex = 3;
            // 
            // numberProduct
            // 
            this.numberProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberProduct.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberProduct.Location = new System.Drawing.Point(201, 101);
            this.numberProduct.Name = "numberProduct";
            this.numberProduct.ReadOnly = true;
            this.numberProduct.Size = new System.Drawing.Size(146, 43);
            this.numberProduct.TabIndex = 1;
            // 
            // dgv_checkReceived
            // 
            this.dgv_checkReceived.AllowUserToAddRows = false;
            this.dgv_checkReceived.AllowUserToDeleteRows = false;
            this.dgv_checkReceived.AllowUserToResizeColumns = false;
            this.dgv_checkReceived.AllowUserToResizeRows = false;
            this.dgv_checkReceived.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_checkReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_checkReceived.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgv_checkReceived.ColumnHeadersHeight = 30;
            this.dgv_checkReceived.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.id,
            this.name,
            this.unit,
            this.order,
            this.sent,
            this.exp,
            this.status});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_checkReceived.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_checkReceived.Location = new System.Drawing.Point(12, 12);
            this.dgv_checkReceived.Name = "dgv_checkReceived";
            this.dgv_checkReceived.RowHeadersVisible = false;
            this.dgv_checkReceived.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_checkReceived.Size = new System.Drawing.Size(1242, 348);
            this.dgv_checkReceived.TabIndex = 0;
            this.dgv_checkReceived.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_checkReceived_CellClick);
            this.dgv_checkReceived.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_checkReceived_CellLeave);
            // 
            // number
            // 
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 50;
            // 
            // id
            // 
            this.id.HeaderText = "รหัสสินค้า";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.unit.HeaderText = "หน่วยนับ";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // order
            // 
            this.order.HeaderText = "จำนวนที่สั่ง";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            this.order.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sent
            // 
            this.sent.HeaderText = "จำนวนที่จัดส่ง";
            this.sent.Name = "sent";
            this.sent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // exp
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.exp.DefaultCellStyle = dataGridViewCellStyle3;
            this.exp.HeaderText = "วันหมดอายุ";
            this.exp.Name = "exp";
            this.exp.ReadOnly = true;
            this.exp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exp.Width = 120;
            // 
            // status
            // 
            this.status.HeaderText = "สถานะ";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.Visible = false;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(373, 100);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(132, 37);
            this.text2.TabIndex = 13;
            this.text2.Text = "วันที่สั่งสินค้า";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("MAX PINJOHNV2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(33, 101);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(156, 37);
            this.text1.TabIndex = 11;
            this.text1.Text = "เลขที่ใบสั่งสินค้า";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dgv_checkReceived);
            this.panel3.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(26, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1268, 367);
            this.panel3.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MAX PINJOHNV2", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "รายการจัดส่งสินค้า";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 64);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jeffer.Properties.Resources.if_put_in_172531;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numberProduct);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.dateOrder);
            this.panel1.Controls.Add(this.dateSent);
            this.panel1.Controls.Add(this.text4);
            this.panel1.Controls.Add(this.text3);
            this.panel1.Controls.Add(this.text2);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.text1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 607);
            this.panel1.TabIndex = 32;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_back.BackgroundImage = global::Jeffer.Properties.Resources.Back_thai;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_back.Location = new System.Drawing.Point(1097, 28);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(150, 75);
            this.button_back.TabIndex = 22;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
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
            this.Time_1.TabIndex = 69;
            this.Time_1.Text = "Date";
            this.Time_1.Click += new System.EventHandler(this.Time_1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Time_1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ShippingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkReceived)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox dateOrder;
        private System.Windows.Forms.TextBox dateSent;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox numberProduct;
        private System.Windows.Forms.DataGridView dgv_checkReceived;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn sent;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label Time_1;
        private System.Windows.Forms.Timer timer1;
    }
}
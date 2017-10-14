using System;
using promotion.promotion_form;

namespace promotion.promotion_form
{
    partial class ListPromotionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListPromotion = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInsertFromShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time_1 = new System.Windows.Forms.Label();
            this.PRO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_MINIMUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPromotion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.dgvListPromotion);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnInsertFromShow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 706);
            this.panel1.TabIndex = 2;
            // 
            // dgvListPromotion
            // 
            this.dgvListPromotion.AllowUserToAddRows = false;
            this.dgvListPromotion.AllowUserToDeleteRows = false;
            this.dgvListPromotion.AllowUserToResizeColumns = false;
            this.dgvListPromotion.AllowUserToResizeRows = false;
            this.dgvListPromotion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListPromotion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPromotion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_ID,
            this.PRO_NAME,
            this.PRO_MINIMUM,
            this.PRO_DISCOUNT,
            this.PRO_TYPE,
            this.PRO_STATUS,
            this.PRO_EDIT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPromotion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListPromotion.Location = new System.Drawing.Point(68, 182);
            this.dgvListPromotion.Name = "dgvListPromotion";
            this.dgvListPromotion.ReadOnly = true;
            this.dgvListPromotion.RowTemplate.Height = 40;
            this.dgvListPromotion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListPromotion.Size = new System.Drawing.Size(1198, 473);
            this.dgvListPromotion.TabIndex = 0;
            this.dgvListPromotion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPromotion_CellClick_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.BackgroundImage = global::Jeffer.Properties.Resources.Back_thai;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(949, 101);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 75);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsertFromShow
            // 
            this.btnInsertFromShow.BackColor = System.Drawing.Color.Maroon;
            this.btnInsertFromShow.BackgroundImage = global::Jeffer.Properties.Resources.Insert_thai;
            this.btnInsertFromShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertFromShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertFromShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertFromShow.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFromShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertFromShow.Location = new System.Drawing.Point(1115, 101);
            this.btnInsertFromShow.Name = "btnInsertFromShow";
            this.btnInsertFromShow.Size = new System.Drawing.Size(150, 75);
            this.btnInsertFromShow.TabIndex = 4;
            this.btnInsertFromShow.UseVisualStyleBackColor = false;
            this.btnInsertFromShow.Click += new System.EventHandler(this.btnInsertFromShow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(88, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 70);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promotion";
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
            this.Time_1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_1.ForeColor = System.Drawing.Color.Lime;
            this.Time_1.Location = new System.Drawing.Point(12, 9);
            this.Time_1.Name = "Time_1";
            this.Time_1.Size = new System.Drawing.Size(45, 28);
            this.Time_1.TabIndex = 147;
            this.Time_1.Text = "Date";
            // 
            // PRO_ID
            // 
            this.PRO_ID.HeaderText = "PRO_ID";
            this.PRO_ID.Name = "PRO_ID";
            this.PRO_ID.ReadOnly = true;
            this.PRO_ID.Visible = false;
            // 
            // PRO_NAME
            // 
            this.PRO_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRO_NAME.HeaderText = "Name";
            this.PRO_NAME.Name = "PRO_NAME";
            this.PRO_NAME.ReadOnly = true;
            // 
            // PRO_MINIMUM
            // 
            this.PRO_MINIMUM.HeaderText = "least (Baht)";
            this.PRO_MINIMUM.Name = "PRO_MINIMUM";
            this.PRO_MINIMUM.ReadOnly = true;
            this.PRO_MINIMUM.Width = 150;
            // 
            // PRO_DISCOUNT
            // 
            this.PRO_DISCOUNT.HeaderText = "Discount";
            this.PRO_DISCOUNT.Name = "PRO_DISCOUNT";
            this.PRO_DISCOUNT.ReadOnly = true;
            // 
            // PRO_TYPE
            // 
            this.PRO_TYPE.HeaderText = "Type";
            this.PRO_TYPE.Name = "PRO_TYPE";
            this.PRO_TYPE.ReadOnly = true;
            this.PRO_TYPE.Width = 120;
            // 
            // PRO_STATUS
            // 
            this.PRO_STATUS.HeaderText = "Status";
            this.PRO_STATUS.Name = "PRO_STATUS";
            this.PRO_STATUS.ReadOnly = true;
            // 
            // PRO_EDIT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.PRO_EDIT.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRO_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PRO_EDIT.HeaderText = "Edit";
            this.PRO_EDIT.Name = "PRO_EDIT";
            this.PRO_EDIT.ReadOnly = true;
            this.PRO_EDIT.Text = "แก้ไข";
            this.PRO_EDIT.UseColumnTextForButtonValue = true;
            // 
            // ListPromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.Time_1);
            this.Controls.Add(this.panel1);
            this.Name = "ListPromotionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListPromotionForm";
            this.Load += new System.EventHandler(this.ListPromotionForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPromotion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListPromotion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertFromShow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_MINIMUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_STATUS;
        private System.Windows.Forms.DataGridViewButtonColumn PRO_EDIT;
    }
}
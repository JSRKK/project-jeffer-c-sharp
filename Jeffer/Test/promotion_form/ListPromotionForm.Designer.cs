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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListPromotion = new System.Windows.Forms.DataGridView();
            this.PRO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_MINIMUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertFromShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPromotion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.dgvListPromotion);
            this.panel1.Location = new System.Drawing.Point(47, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 541);
            this.panel1.TabIndex = 2;
            // 
            // dgvListPromotion
            // 
            this.dgvListPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPromotion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_ID,
            this.PRO_NAME,
            this.PRO_MINIMUM,
            this.PRO_DISCOUNT,
            this.PRO_TYPE,
            this.PRO_STATUS,
            this.PRO_EDIT});
            this.dgvListPromotion.Location = new System.Drawing.Point(23, 25);
            this.dgvListPromotion.Name = "dgvListPromotion";
            this.dgvListPromotion.Size = new System.Drawing.Size(1215, 493);
            this.dgvListPromotion.TabIndex = 0;
            this.dgvListPromotion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPromotion_CellContentClick);
            // 
            // PRO_ID
            // 
            this.PRO_ID.HeaderText = "PRO_ID";
            this.PRO_ID.Name = "PRO_ID";
            this.PRO_ID.Visible = false;
            // 
            // PRO_NAME
            // 
            this.PRO_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRO_NAME.HeaderText = "Name";
            this.PRO_NAME.Name = "PRO_NAME";
            // 
            // PRO_MINIMUM
            // 
            this.PRO_MINIMUM.HeaderText = "least (Baht)";
            this.PRO_MINIMUM.Name = "PRO_MINIMUM";
            // 
            // PRO_DISCOUNT
            // 
            this.PRO_DISCOUNT.HeaderText = "Discount";
            this.PRO_DISCOUNT.Name = "PRO_DISCOUNT";
            // 
            // PRO_TYPE
            // 
            this.PRO_TYPE.HeaderText = "Type";
            this.PRO_TYPE.Name = "PRO_TYPE";
            this.PRO_TYPE.Width = 120;
            // 
            // PRO_STATUS
            // 
            this.PRO_STATUS.HeaderText = "Status";
            this.PRO_STATUS.Name = "PRO_STATUS";
            // 
            // PRO_EDIT
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.PRO_EDIT.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRO_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PRO_EDIT.HeaderText = "Edit";
            this.PRO_EDIT.Name = "PRO_EDIT";
            this.PRO_EDIT.Text = "แก้ไข";
            this.PRO_EDIT.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(47, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 70);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promotion";
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
            this.btnInsertFromShow.Location = new System.Drawing.Point(975, 12);
            this.btnInsertFromShow.Name = "btnInsertFromShow";
            this.btnInsertFromShow.Size = new System.Drawing.Size(200, 100);
            this.btnInsertFromShow.TabIndex = 4;
            this.btnInsertFromShow.UseVisualStyleBackColor = false;
            this.btnInsertFromShow.Click += new System.EventHandler(this.btnInsertFromShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(1191, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "เพิ่มข้อมูล";
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::Jeffer.Properties.Resources.Back_Main_thai;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(1038, 665);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(300, 50);
            this.button_back.TabIndex = 35;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Black;
            this.Time.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Chartreuse;
            this.Time.Location = new System.Drawing.Point(12, 9);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(56, 28);
            this.Time.TabIndex = 36;
            this.Time.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListPromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnInsertFromShow);
            this.Controls.Add(this.panel1);
            this.Name = "ListPromotionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListPromotionForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_MINIMUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_STATUS;
        private System.Windows.Forms.DataGridViewButtonColumn PRO_EDIT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertFromShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
    }
}
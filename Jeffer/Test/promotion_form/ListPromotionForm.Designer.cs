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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPromotion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.dgvListPromotion);
            this.panel1.Location = new System.Drawing.Point(59, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 568);
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
            this.dgvListPromotion.Location = new System.Drawing.Point(26, 57);
            this.dgvListPromotion.Name = "dgvListPromotion";
            this.dgvListPromotion.Size = new System.Drawing.Size(1186, 493);
            this.dgvListPromotion.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.PRO_EDIT.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.panel2.Location = new System.Drawing.Point(73, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 70);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promotion";
            // 
            // btnInsertFromShow
            // 
            this.btnInsertFromShow.BackColor = System.Drawing.Color.Maroon;
            this.btnInsertFromShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertFromShow.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFromShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertFromShow.Location = new System.Drawing.Point(73, 40);
            this.btnInsertFromShow.Name = "btnInsertFromShow";
            this.btnInsertFromShow.Size = new System.Drawing.Size(213, 58);
            this.btnInsertFromShow.TabIndex = 4;
            this.btnInsertFromShow.Text = "INSERT";
            this.btnInsertFromShow.UseVisualStyleBackColor = false;
            // 
            // ListPromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnInsertFromShow);
            this.Name = "ListPromotionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListPromotionForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPromotion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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

        public static implicit operator ListPromotionForm(promotion.promotion_form.ListPromotionForm v)
        {
            throw new NotImplementedException();
        }
    }
}
namespace Jeffer
{
    partial class ScheduleListEmployeeForm
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
            this.listEmp = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // listEmp
            // 
            this.listEmp.AllowUserToAddRows = false;
            this.listEmp.AllowUserToDeleteRows = false;
            this.listEmp.AllowUserToResizeColumns = false;
            this.listEmp.AllowUserToResizeRows = false;
            this.listEmp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listEmp.ColumnHeadersHeight = 30;
            this.listEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.id,
            this.name});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listEmp.DefaultCellStyle = dataGridViewCellStyle1;
            this.listEmp.Location = new System.Drawing.Point(0, 0);
            this.listEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listEmp.Name = "listEmp";
            this.listEmp.ReadOnly = true;
            this.listEmp.RowHeadersVisible = false;
            this.listEmp.RowTemplate.Height = 30;
            this.listEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listEmp.Size = new System.Drawing.Size(541, 1133);
            this.listEmp.TabIndex = 0;
            this.listEmp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listEmp_CellDoubleClick);
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
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "รหัสพนักงาน";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "ชื่อ";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // ScheduleListEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 733);
            this.Controls.Add(this.listEmp);
            this.Font = new System.Drawing.Font("MAX PINJOHNV2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ScheduleListEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.listEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}
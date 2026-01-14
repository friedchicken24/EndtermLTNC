namespace SalesManagement.UI
{
    partial class frmReport
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
            grpChonThoiGian = new GroupBox();
            btnGenerate = new Button();
            dtpEndDate = new DateTimePicker();
            label2 = new Label();
            dtpStartDate = new DateTimePicker();
            label1 = new Label();
            dgvReport = new DataGridView();
            grpChonThoiGian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // grpChonThoiGian
            // 
            grpChonThoiGian.Controls.Add(btnGenerate);
            grpChonThoiGian.Controls.Add(dtpEndDate);
            grpChonThoiGian.Controls.Add(label2);
            grpChonThoiGian.Controls.Add(dtpStartDate);
            grpChonThoiGian.Controls.Add(label1);
            grpChonThoiGian.Location = new Point(12, 12);
            grpChonThoiGian.Name = "grpChonThoiGian";
            grpChonThoiGian.Size = new Size(414, 209);
            grpChonThoiGian.TabIndex = 0;
            grpChonThoiGian.TabStop = false;
            grpChonThoiGian.Text = "Chọn khoảng thời gian";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(19, 153);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(112, 29);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Xem Báo cáo";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(132, 91);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(132, 39);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(11, 240);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(777, 188);
            dgvReport.TabIndex = 1;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReport);
            Controls.Add(grpChonThoiGian);
            Name = "frmReport";
            Text = "Báo cáo";
            Click += frmReport_Load;
            grpChonThoiGian.ResumeLayout(false);
            grpChonThoiGian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpChonThoiGian;
        private DateTimePicker dtpStartDate;
        private Label label1;
        private Button btnGenerate;
        private DateTimePicker dtpEndDate;
        private Label label2;
        private DataGridView dgvReport;
    }
}
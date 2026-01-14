namespace SalesManagement.UI
{
    partial class frmCustomer
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
            grpThongTin = new GroupBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpChucNang = new GroupBox();
            btnClearCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnAddCustomer = new Button();
            label5 = new Label();
            txtSearchCustomer = new TextBox();
            dgvCustomers = new DataGridView();
            grpThongTin.SuspendLayout();
            grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtAddress);
            grpThongTin.Controls.Add(txtPhoneNumber);
            grpThongTin.Controls.Add(txtCustomerName);
            grpThongTin.Controls.Add(txtCustomerId);
            grpThongTin.Controls.Add(label4);
            grpThongTin.Controls.Add(label3);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Controls.Add(label1);
            grpThongTin.Location = new Point(23, 35);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(390, 240);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin khách hàng";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(158, 192);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(158, 142);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(158, 91);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(125, 27);
            txtCustomerName.TabIndex = 5;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(158, 41);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(125, 27);
            txtCustomerId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 199);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 149);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 98);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Khách Hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 48);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Khách Hàng:";
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnClearCustomer);
            grpChucNang.Controls.Add(btnDeleteCustomer);
            grpChucNang.Controls.Add(btnUpdateCustomer);
            grpChucNang.Controls.Add(btnAddCustomer);
            grpChucNang.Location = new Point(433, 35);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(355, 118);
            grpChucNang.TabIndex = 1;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng";
            // 
            // btnClearCustomer
            // 
            btnClearCustomer.Location = new Point(208, 74);
            btnClearCustomer.Name = "btnClearCustomer";
            btnClearCustomer.Size = new Size(94, 29);
            btnClearCustomer.TabIndex = 3;
            btnClearCustomer.Text = "Làm mới";
            btnClearCustomer.UseVisualStyleBackColor = true;
            btnClearCustomer.Click += btnClearCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(22, 74);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(94, 29);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Xóa";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(208, 26);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(94, 29);
            btnUpdateCustomer.TabIndex = 1;
            btnUpdateCustomer.Text = "Sửa";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(22, 26);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(94, 29);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Thêm";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(571, 168);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 2;
            label5.Text = "Tìm kiếm";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(433, 201);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(355, 27);
            txtSearchCustomer.TabIndex = 3;
            txtSearchCustomer.Click += txtSearchCustomer_TextChanged;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged_1;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(23, 281);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(765, 157);
            dgvCustomers.TabIndex = 4;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCustomers);
            Controls.Add(txtSearchCustomer);
            Controls.Add(label5);
            Controls.Add(grpChucNang);
            Controls.Add(grpThongTin);
            Name = "frmCustomer";
            Text = "Form1";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtCustomerName;
        private TextBox txtCustomerId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpChucNang;
        private Button btnClearCustomer;
        private Button btnDeleteCustomer;
        private Button btnUpdateCustomer;
        private Button btnAddCustomer;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private Label label5;
        private TextBox txtSearchCustomer;
        private DataGridView dgvCustomers;
    }
}
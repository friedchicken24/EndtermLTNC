namespace SalesManagement.UI
{
    partial class frmSale
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
            grpThongTinChung = new GroupBox();
            cboCustomer = new ComboBox();
            label1 = new Label();
            grpThemSanPham = new GroupBox();
            btnAddItem = new Button();
            cboProduct = new ComboBox();
            numQuantity = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            dgvInvoiceItems = new DataGridView();
            label5 = new Label();
            lblTotalAmount = new Label();
            btnCreateInvoice = new Button();
            btnCancel = new Button();
            grpThongTinChung.SuspendLayout();
            grpThemSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinChung
            // 
            grpThongTinChung.Controls.Add(cboCustomer);
            grpThongTinChung.Controls.Add(label1);
            grpThongTinChung.Location = new Point(12, 12);
            grpThongTinChung.Name = "grpThongTinChung";
            grpThongTinChung.Size = new Size(776, 75);
            grpThongTinChung.TabIndex = 0;
            grpThongTinChung.TabStop = false;
            grpThongTinChung.Text = "Thông tin chung";
            // 
            // cboCustomer
            // 
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(134, 30);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(253, 28);
            cboCustomer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Khách hàng:";
            // 
            // grpThemSanPham
            // 
            grpThemSanPham.Controls.Add(btnAddItem);
            grpThemSanPham.Controls.Add(cboProduct);
            grpThemSanPham.Controls.Add(numQuantity);
            grpThemSanPham.Controls.Add(label3);
            grpThemSanPham.Controls.Add(label2);
            grpThemSanPham.Location = new Point(12, 93);
            grpThemSanPham.Name = "grpThemSanPham";
            grpThemSanPham.Size = new Size(776, 112);
            grpThemSanPham.TabIndex = 1;
            grpThemSanPham.TabStop = false;
            grpThemSanPham.Text = "Thêm sản phẩm";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(20, 72);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(129, 29);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "Thêm vào HĐ";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(134, 32);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(306, 28);
            cboProduct.TabIndex = 4;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(542, 35);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 35);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 1;
            label3.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 35);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 0;
            label2.Text = "Sản phẩm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 227);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 2;
            label4.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // dgvInvoiceItems
            // 
            dgvInvoiceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceItems.Location = new Point(12, 257);
            dgvInvoiceItems.Name = "dgvInvoiceItems";
            dgvInvoiceItems.RowHeadersWidth = 51;
            dgvInvoiceItems.Size = new Size(776, 96);
            dgvInvoiceItems.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 372);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(111, 372);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(52, 20);
            lblTotalAmount.TabIndex = 5;
            lblTotalAmount.Text = "0 VNĐ";
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.Location = new Point(16, 409);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(120, 29);
            btnCreateInvoice.TabIndex = 6;
            btnCreateInvoice.Text = "Tạo hóa đơn";
            btnCreateInvoice.UseVisualStyleBackColor = true;
            btnCreateInvoice.Click += btnCreateInvoice_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(208, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateInvoice);
            Controls.Add(lblTotalAmount);
            Controls.Add(label5);
            Controls.Add(dgvInvoiceItems);
            Controls.Add(label4);
            Controls.Add(grpThemSanPham);
            Controls.Add(grpThongTinChung);
            Name = "frmSale";
            Text = "Form1";
            Click += frmSale_Load;
            grpThongTinChung.ResumeLayout(false);
            grpThongTinChung.PerformLayout();
            grpThemSanPham.ResumeLayout(false);
            grpThemSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTinChung;
        private ComboBox cboCustomer;
        private Label label1;
        private GroupBox grpThemSanPham;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Button btnCreateInvoice;
        private NumericUpDown numQuantity;
        private Button btnAddItem;
        private ComboBox cboProduct;
        private Label label4;
        private DataGridView dgvInvoiceItems;
        private Label label5;
        private Label lblTotalAmount;
        private Button btnCancel;
    }
}
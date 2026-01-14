namespace SalesManagement.UI
{
    partial class frmProduct
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
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label5 = new Label();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            grpThongTin.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtStock);
            grpThongTin.Controls.Add(txtPrice);
            grpThongTin.Controls.Add(txtProductName);
            grpThongTin.Controls.Add(txtProductId);
            grpThongTin.Controls.Add(label4);
            grpThongTin.Controls.Add(label3);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Controls.Add(label1);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(364, 213);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin sản phẩm";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(121, 157);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(121, 120);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 6;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(121, 81);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 5;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(121, 38);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(125, 27);
            txtProductId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 164);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Tồn kho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 127);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 88);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(382, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(248, 73);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(27, 73);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(248, 27);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 132);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 2;
            label5.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(382, 169);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(406, 27);
            txtSearch.TabIndex = 3;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 231);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(776, 204);
            dgvProducts.TabIndex = 4;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(grpThongTin);
            Name = "frmProduct";
            Text = "Form1";
            Click += frmProduct_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnAdd;
        private Label label5;
        private TextBox txtSearch;
        private DataGridView dgvProducts;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
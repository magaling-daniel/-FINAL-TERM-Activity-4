namespace InventoryManagementSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.stripeTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.pnlInStock = new System.Windows.Forms.Panel();
            this.stripeInStock = new System.Windows.Forms.Panel();
            this.lblInStockTitle = new System.Windows.Forms.Label();
            this.lblInStockCount = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.stripeLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.lblLowStockCount = new System.Windows.Forms.Label();
            this.pnlOutStock = new System.Windows.Forms.Panel();
            this.stripeOutStock = new System.Windows.Forms.Panel();
            this.lblOutStockTitle = new System.Windows.Forms.Label();
            this.lblOutStockCount = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblReorder = new System.Windows.Forms.Label();
            this.txtReorder = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlInStock.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlOutStock.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTop
            //
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 56);
            this.pnlTop.TabIndex = 0;
            //
            // lblWelcome
            //
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(24, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(90, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            //
            // btnLogout
            //
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1076, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 36);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(22, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Product Management";
            //
            // lblSubtitle
            //
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(25, 103);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(179, 19);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Manage your inventory products";
            //
            // pnlTotal
            //
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.lblTotalCount);
            this.pnlTotal.Controls.Add(this.lblTotalTitle);
            this.pnlTotal.Controls.Add(this.stripeTotal);
            this.pnlTotal.Location = new System.Drawing.Point(24, 136);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(270, 92);
            this.pnlTotal.TabIndex = 3;
            //
            // stripeTotal
            //
            this.stripeTotal.BackColor = System.Drawing.Color.FromArgb(70, 112, 166);
            this.stripeTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.stripeTotal.Location = new System.Drawing.Point(0, 0);
            this.stripeTotal.Name = "stripeTotal";
            this.stripeTotal.Size = new System.Drawing.Size(6, 90);
            this.stripeTotal.TabIndex = 2;
            //
            // lblTotalTitle
            //
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblTotalTitle.Location = new System.Drawing.Point(22, 12);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(93, 19);
            this.lblTotalTitle.TabIndex = 1;
            this.lblTotalTitle.Text = "Total Products";
            //
            // lblTotalCount
            //
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(70, 112, 166);
            this.lblTotalCount.Location = new System.Drawing.Point(20, 34);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(34, 41);
            this.lblTotalCount.TabIndex = 0;
            this.lblTotalCount.Text = "0";
            //
            // pnlInStock
            //
            this.pnlInStock.BackColor = System.Drawing.Color.White;
            this.pnlInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInStock.Controls.Add(this.lblInStockCount);
            this.pnlInStock.Controls.Add(this.lblInStockTitle);
            this.pnlInStock.Controls.Add(this.stripeInStock);
            this.pnlInStock.Location = new System.Drawing.Point(318, 136);
            this.pnlInStock.Name = "pnlInStock";
            this.pnlInStock.Size = new System.Drawing.Size(270, 92);
            this.pnlInStock.TabIndex = 4;
            //
            // stripeInStock
            //
            this.stripeInStock.BackColor = System.Drawing.Color.FromArgb(34, 139, 87);
            this.stripeInStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.stripeInStock.Location = new System.Drawing.Point(0, 0);
            this.stripeInStock.Name = "stripeInStock";
            this.stripeInStock.Size = new System.Drawing.Size(6, 90);
            this.stripeInStock.TabIndex = 2;
            //
            // lblInStockTitle
            //
            this.lblInStockTitle.AutoSize = true;
            this.lblInStockTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInStockTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblInStockTitle.Location = new System.Drawing.Point(22, 12);
            this.lblInStockTitle.Name = "lblInStockTitle";
            this.lblInStockTitle.Size = new System.Drawing.Size(56, 19);
            this.lblInStockTitle.TabIndex = 1;
            this.lblInStockTitle.Text = "In Stock";
            //
            // lblInStockCount
            //
            this.lblInStockCount.AutoSize = true;
            this.lblInStockCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblInStockCount.ForeColor = System.Drawing.Color.FromArgb(34, 139, 87);
            this.lblInStockCount.Location = new System.Drawing.Point(20, 34);
            this.lblInStockCount.Name = "lblInStockCount";
            this.lblInStockCount.Size = new System.Drawing.Size(34, 41);
            this.lblInStockCount.TabIndex = 0;
            this.lblInStockCount.Text = "0";
            //
            // pnlLowStock
            //
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLowStock.Controls.Add(this.lblLowStockCount);
            this.pnlLowStock.Controls.Add(this.lblLowStockTitle);
            this.pnlLowStock.Controls.Add(this.stripeLowStock);
            this.pnlLowStock.Location = new System.Drawing.Point(612, 136);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(270, 92);
            this.pnlLowStock.TabIndex = 5;
            //
            // stripeLowStock
            //
            this.stripeLowStock.BackColor = System.Drawing.Color.FromArgb(230, 145, 30);
            this.stripeLowStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.stripeLowStock.Location = new System.Drawing.Point(0, 0);
            this.stripeLowStock.Name = "stripeLowStock";
            this.stripeLowStock.Size = new System.Drawing.Size(6, 90);
            this.stripeLowStock.TabIndex = 2;
            //
            // lblLowStockTitle
            //
            this.lblLowStockTitle.AutoSize = true;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblLowStockTitle.Location = new System.Drawing.Point(22, 12);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(65, 19);
            this.lblLowStockTitle.TabIndex = 1;
            this.lblLowStockTitle.Text = "Low Stock";
            //
            // lblLowStockCount
            //
            this.lblLowStockCount.AutoSize = true;
            this.lblLowStockCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblLowStockCount.ForeColor = System.Drawing.Color.FromArgb(230, 145, 30);
            this.lblLowStockCount.Location = new System.Drawing.Point(20, 34);
            this.lblLowStockCount.Name = "lblLowStockCount";
            this.lblLowStockCount.Size = new System.Drawing.Size(34, 41);
            this.lblLowStockCount.TabIndex = 0;
            this.lblLowStockCount.Text = "0";
            //
            // pnlOutStock
            //
            this.pnlOutStock.BackColor = System.Drawing.Color.White;
            this.pnlOutStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutStock.Controls.Add(this.lblOutStockCount);
            this.pnlOutStock.Controls.Add(this.lblOutStockTitle);
            this.pnlOutStock.Controls.Add(this.stripeOutStock);
            this.pnlOutStock.Location = new System.Drawing.Point(906, 136);
            this.pnlOutStock.Name = "pnlOutStock";
            this.pnlOutStock.Size = new System.Drawing.Size(270, 92);
            this.pnlOutStock.TabIndex = 6;
            //
            // stripeOutStock
            //
            this.stripeOutStock.BackColor = System.Drawing.Color.FromArgb(200, 60, 60);
            this.stripeOutStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.stripeOutStock.Location = new System.Drawing.Point(0, 0);
            this.stripeOutStock.Name = "stripeOutStock";
            this.stripeOutStock.Size = new System.Drawing.Size(6, 90);
            this.stripeOutStock.TabIndex = 2;
            //
            // lblOutStockTitle
            //
            this.lblOutStockTitle.AutoSize = true;
            this.lblOutStockTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOutStockTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblOutStockTitle.Location = new System.Drawing.Point(22, 12);
            this.lblOutStockTitle.Name = "lblOutStockTitle";
            this.lblOutStockTitle.Size = new System.Drawing.Size(77, 19);
            this.lblOutStockTitle.TabIndex = 1;
            this.lblOutStockTitle.Text = "Out of Stock";
            //
            // lblOutStockCount
            //
            this.lblOutStockCount.AutoSize = true;
            this.lblOutStockCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblOutStockCount.ForeColor = System.Drawing.Color.FromArgb(200, 60, 60);
            this.lblOutStockCount.Location = new System.Drawing.Point(20, 34);
            this.lblOutStockCount.Name = "lblOutStockCount";
            this.lblOutStockCount.Size = new System.Drawing.Size(34, 41);
            this.lblOutStockCount.TabIndex = 0;
            this.lblOutStockCount.Text = "0";
            //
            // pnlForm
            //
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Controls.Add(this.btnClear);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnUpdate);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.lblHint);
            this.pnlForm.Controls.Add(this.txtReorder);
            this.pnlForm.Controls.Add(this.lblReorder);
            this.pnlForm.Controls.Add(this.txtPrice);
            this.pnlForm.Controls.Add(this.lblPrice);
            this.pnlForm.Controls.Add(this.txtQuantity);
            this.pnlForm.Controls.Add(this.lblQuantity);
            this.pnlForm.Controls.Add(this.cboCategory);
            this.pnlForm.Controls.Add(this.lblCategory);
            this.pnlForm.Controls.Add(this.txtDescription);
            this.pnlForm.Controls.Add(this.lblDescription);
            this.pnlForm.Controls.Add(this.txtName);
            this.pnlForm.Controls.Add(this.lblName);
            this.pnlForm.Location = new System.Drawing.Point(24, 244);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1152, 196);
            this.pnlForm.TabIndex = 7;
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblName.Location = new System.Drawing.Point(20, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Product Name *";
            //
            // txtName
            //
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(20, 38);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 25);
            this.txtName.TabIndex = 1;
            //
            // lblDescription
            //
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDescription.Location = new System.Drawing.Point(20, 80);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            //
            // txtDescription
            //
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(20, 104);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(300, 68);
            this.txtDescription.TabIndex = 3;
            //
            // lblCategory
            //
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblCategory.Location = new System.Drawing.Point(350, 14);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(66, 17);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category *";
            //
            // cboCategory
            //
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(350, 38);
            this.cboCategory.MaxLength = 50;
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(260, 25);
            this.cboCategory.TabIndex = 5;
            //
            // lblQuantity
            //
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblQuantity.Location = new System.Drawing.Point(350, 80);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 17);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity *";
            //
            // txtQuantity
            //
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(350, 104);
            this.txtQuantity.MaxLength = 9;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(260, 25);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly_KeyPress);
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPrice.Location = new System.Drawing.Point(640, 14);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Unit Price (₱) *";
            //
            // txtPrice
            //
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(640, 38);
            this.txtPrice.MaxLength = 12;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(220, 25);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            //
            // lblReorder
            //
            this.lblReorder.AutoSize = true;
            this.lblReorder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblReorder.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblReorder.Location = new System.Drawing.Point(640, 80);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(89, 17);
            this.lblReorder.TabIndex = 10;
            this.lblReorder.Text = "Reorder Level *";
            //
            // txtReorder
            //
            this.txtReorder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReorder.Location = new System.Drawing.Point(640, 104);
            this.txtReorder.MaxLength = 9;
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(220, 25);
            this.txtReorder.TabIndex = 11;
            this.txtReorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly_KeyPress);
            //
            // lblHint
            //
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(120, 134, 154);
            this.lblHint.Location = new System.Drawing.Point(350, 152);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(363, 15);
            this.lblHint.TabIndex = 12;
            this.lblHint.Text = "* required.  Low stock = quantity at or below the reorder level.";
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(34, 139, 87);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(900, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(900, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(232, 36);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(900, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 36);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(900, 148);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 36);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // lblList
            //
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblList.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblList.Location = new System.Drawing.Point(22, 456);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(113, 25);
            this.lblList.TabIndex = 8;
            this.lblList.Text = "Product List";
            //
            // btnRefresh
            //
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnRefresh.Location = new System.Drawing.Point(150, 455);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 30);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // lblRecordCount
            //
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRecordCount.Location = new System.Drawing.Point(246, 462);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(66, 17);
            this.lblRecordCount.TabIndex = 10;
            this.lblRecordCount.Text = "0 products";
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSearch.Location = new System.Drawing.Point(858, 462);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 17);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search";
            //
            // txtSearch
            //
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(916, 458);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 25);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            //
            // dgvProducts
            //
            this.dgvProducts.Location = new System.Drawing.Point(24, 494);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(1152, 262);
            this.dgvProducts.TabIndex = 13;
            this.dgvProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProducts_CellFormatting);
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            //
            // DashboardForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(238, 241, 246);
            this.ClientSize = new System.Drawing.Size(1200, 780);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlOutStock);
            this.Controls.Add(this.pnlLowStock);
            this.Controls.Add(this.pnlInStock);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System - Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlInStock.ResumeLayout(false);
            this.pnlInStock.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlOutStock.ResumeLayout(false);
            this.pnlOutStock.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel stripeTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlInStock;
        private System.Windows.Forms.Panel stripeInStock;
        private System.Windows.Forms.Label lblInStockTitle;
        private System.Windows.Forms.Label lblInStockCount;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel stripeLowStock;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Label lblLowStockCount;
        private System.Windows.Forms.Panel pnlOutStock;
        private System.Windows.Forms.Panel stripeOutStock;
        private System.Windows.Forms.Label lblOutStockTitle;
        private System.Windows.Forms.Label lblOutStockCount;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.TextBox txtReorder;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}

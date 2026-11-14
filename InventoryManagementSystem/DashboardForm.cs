using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    /// <summary>Product Management screen: stats cards + Add / Update / Delete + searchable list.</summary>
    public partial class DashboardForm : Form
    {
        private readonly ProductRepository _repo = new ProductRepository();
        private readonly string _username;
        private readonly Font _statusFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);

        private int? _selectedId;
        private bool _loading;
        private bool _loggingOut;

        // Works whether SignInForm calls new DashboardForm() or new DashboardForm(username)
        public DashboardForm() : this("")
        {
        }

        public DashboardForm(string username)
        {
            _username = username ?? "";
            InitializeComponent();
        }

        // ------------------------------------------------------------ setup
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = _username.Length > 0 ? "Welcome, " + _username + "!" : "Welcome!";

            cboCategory.Items.AddRange(new object[]
            {
                "Electronics", "Office Supplies", "Groceries", "Beverages",
                "Hardware", "Personal Care", "Others"
            });

            SetupGrid();

            LoadProducts();
            RefreshStats();
            ClearForm();
        }

        private void SetupGrid()
        {
            var g = dgvProducts;
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.ReadOnly = true;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.RowHeadersVisible = false;
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.FixedSingle;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = Color.FromArgb(226, 232, 240);
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 36;
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            g.RowTemplate.Height = 30;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            g.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 112, 166);
            g.DefaultCellStyle.SelectionForeColor = Color.White;
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 248, 251);

            var id = Col("ProductID", "ID", 6, DataGridViewContentAlignment.MiddleCenter);
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            id.Width = 56;

            var price = Col("UnitPrice", "Unit Price", 10, DataGridViewContentAlignment.MiddleRight);
            price.DefaultCellStyle.Format = "N2";

            var added = Col("DateAdded", "Date Added", 11, DataGridViewContentAlignment.MiddleCenter);
            added.DefaultCellStyle.Format = "yyyy-MM-dd";

            g.Columns.Add(id);
            g.Columns.Add(Col("ProductName", "Product Name", 19, DataGridViewContentAlignment.MiddleLeft));
            g.Columns.Add(Col("Category", "Category", 13, DataGridViewContentAlignment.MiddleLeft));
            g.Columns.Add(Col("Description", "Description", 21, DataGridViewContentAlignment.MiddleLeft));
            g.Columns.Add(price);
            g.Columns.Add(Col("Quantity", "Qty", 7, DataGridViewContentAlignment.MiddleCenter));
            g.Columns.Add(Col("ReorderLevel", "Reorder Lvl", 9, DataGridViewContentAlignment.MiddleCenter));
            g.Columns.Add(Col("Status", "Status", 11, DataGridViewContentAlignment.MiddleCenter));
            g.Columns.Add(added);
        }

        private static DataGridViewTextBoxColumn Col(string property, string header, float weight,
            DataGridViewContentAlignment align)
        {
            var c = new DataGridViewTextBoxColumn
            {
                DataPropertyName = property,
                HeaderText = header,
                Name = "col" + property,
                FillWeight = weight,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            c.DefaultCellStyle.Alignment = align;
            return c;
        }

        // ------------------------------------------------------------ data
        private void LoadProducts()
        {
            _loading = true;
            try
            {
                DataTable dt = _repo.GetAll(txtSearch.Text.Trim());
                dgvProducts.DataSource = dt;
                lblRecordCount.Text = dt.Rows.Count + (dt.Rows.Count == 1 ? " product" : " products");

                dgvProducts.ClearSelection();
                if (_selectedId.HasValue)
                {
                    foreach (DataGridViewRow row in dgvProducts.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["colProductID"].Value) == _selectedId.Value)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
            finally
            {
                _loading = false;
            }
        }

        private void RefreshStats()
        {
            try
            {
                ProductStats s = _repo.GetStats();
                lblTotalCount.Text = s.Total.ToString();
                lblInStockCount.Text = s.InStock.ToString();
                lblLowStockCount.Text = s.LowStock.ToString();
                lblOutStockCount.Text = s.OutOfStock.ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Colors the Status column text
        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            if (dgvProducts.Columns[e.ColumnIndex].DataPropertyName != "Status") return;

            string s = e.Value.ToString();
            e.CellStyle.Font = _statusFont;
            if (s == "Out of Stock") e.CellStyle.ForeColor = Color.FromArgb(192, 57, 43);
            else if (s == "Low Stock") e.CellStyle.ForeColor = Color.FromArgb(196, 112, 0);
            else e.CellStyle.ForeColor = Color.FromArgb(33, 128, 79);
        }

        // Clicking a row copies it into the form so it can be edited / deleted
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (_loading || dgvProducts.SelectedRows.Count == 0) return;

            DataGridViewRow r = dgvProducts.SelectedRows[0];
            _selectedId = Convert.ToInt32(r.Cells["colProductID"].Value);
            txtName.Text = Convert.ToString(r.Cells["colProductName"].Value);
            cboCategory.Text = Convert.ToString(r.Cells["colCategory"].Value);
            txtDescription.Text = Convert.ToString(r.Cells["colDescription"].Value);
            txtPrice.Text = ToDecimal(r.Cells["colUnitPrice"].Value).ToString("0.00");
            txtQuantity.Text = Convert.ToString(r.Cells["colQuantity"].Value);
            txtReorder.Text = Convert.ToString(r.Cells["colReorderLevel"].Value);
            SetEditMode(true);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!IsHandleCreated) return;
            LoadProducts();
        }

        // ------------------------------------------------------------ buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p;
            if (!TryReadForm(out p)) return;

            try
            {
                if (_repo.NameExists(p.Name, 0))
                {
                    Warn("A product named \"" + p.Name + "\" already exists.", txtName);
                    return;
                }

                _repo.Add(p);
                ClearForm();
                LoadProducts();
                RefreshStats();
                MessageBox.Show("Product added successfully.", "Add Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == null) return;

            Product p;
            if (!TryReadForm(out p)) return;
            p.Id = _selectedId.Value;

            try
            {
                if (_repo.NameExists(p.Name, p.Id))
                {
                    Warn("Another product is already named \"" + p.Name + "\".", txtName);
                    return;
                }

                _repo.Update(p);
                LoadProducts();
                RefreshStats();
                MessageBox.Show("Product updated successfully.", "Update Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == null) return;

            DialogResult confirm = MessageBox.Show(
                "Delete \"" + txtName.Text.Trim() + "\"?\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _repo.Delete(_selectedId.Value);
                ClearForm();
                LoadProducts();
                RefreshStats();
                MessageBox.Show("Product deleted.", "Delete Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearForm();
            LoadProducts();
            RefreshStats();
        }

        // ------------------------------------------------------------ logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Log out of your account?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            _loggingOut = true;
            Close();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Closed with the X button: end the program
            if (!_loggingOut)
            {
                Application.Exit();
                return;
            }

            // Logout: bring the Sign In screen back
            foreach (Form f in Application.OpenForms)
            {
                var signIn = f as SignInForm;
                if (signIn != null)
                {
                    signIn.ResetForm();
                    signIn.Show();
                    signIn.BringToFront();
                    return;
                }
            }
            new SignInForm().Show();
        }

        // ------------------------------------------------------------ input rules
        private void DigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;

            string sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (e.KeyChar.ToString() == sep && !txtPrice.Text.Contains(sep)) return;

            e.Handled = true;
        }

        // ------------------------------------------------------------ helpers
        private bool TryReadForm(out Product p)
        {
            p = null;

            string name = txtName.Text.Trim();
            if (name.Length == 0)
                return Warn("Product name is required.", txtName);

            string category = cboCategory.Text.Trim();
            if (category.Length == 0)
                return Warn("Please choose or type a category.", cboCategory);

            decimal price;
            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out price)
                || price < 0)
                return Warn("Enter a valid unit price (0 or higher).", txtPrice);

            int qty;
            if (!int.TryParse(txtQuantity.Text.Trim(), out qty) || qty < 0)
                return Warn("Enter a valid quantity (whole number, 0 or higher).", txtQuantity);

            int reorder;
            if (!int.TryParse(txtReorder.Text.Trim(), out reorder) || reorder < 0)
                return Warn("Enter a valid reorder level (whole number, 0 or higher).", txtReorder);

            p = new Product
            {
                Name = name,
                Category = category,
                Description = txtDescription.Text.Trim(),
                UnitPrice = price,
                Quantity = qty,
                ReorderLevel = reorder
            };
            return true;
        }

        private void ClearForm()
        {
            _selectedId = null;
            txtName.Clear();
            cboCategory.SelectedIndex = -1;
            cboCategory.Text = "";
            txtDescription.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtReorder.Clear();

            bool wasLoading = _loading;
            _loading = true;
            dgvProducts.ClearSelection();
            _loading = wasLoading;

            SetEditMode(false);
            txtName.Focus();
        }

        // Add is for new products; Update / Delete need a selected product
        private void SetEditMode(bool editing)
        {
            btnAdd.Enabled = !editing;
            btnUpdate.Enabled = editing;
            btnDelete.Enabled = editing;
        }

        private static decimal ToDecimal(object o)
        {
            return (o == null || o == DBNull.Value) ? 0m : Convert.ToDecimal(o);
        }

        // Shows the message, focuses the bad field and returns false so callers can "return Warn(...)"
        private static bool Warn(string message, Control focus)
        {
            MessageBox.Show(message, "Check your input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focus.Focus();
            return false;
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

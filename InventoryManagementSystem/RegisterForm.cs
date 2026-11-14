using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    /// <summary>Register screen (opens from the Sign In screen).</summary>
    public partial class RegisterForm : Form
    {
        private readonly UserRepository _users = new UserRepository();

        public string CreatedUsername { get; private set; } = "";

        public RegisterForm()
        {
            InitializeComponent();
            AcceptButton = btnCreate;
            CancelButton = btnBack;
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
            txtConfirm.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (fullName.Length == 0)
            { Fail("Full name is required.", txtFullName); return; }

            if (!Regex.IsMatch(username, @"^[A-Za-z0-9_]{3,20}$"))
            { Fail("Username must be 3-20 characters: letters, numbers or underscore.", txtUsername); return; }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            { Fail("Enter a valid email address.", txtEmail); return; }

            if (password.Length < 6)
            { Fail("Password must be at least 6 characters.", txtPassword); return; }

            if (password != txtConfirm.Text)
            { Fail("Passwords do not match.", txtConfirm); return; }

            try
            {
                string error;
                if (_users.Register(fullName, username, email, password, out error))
                {
                    CreatedUsername = username;
                    DialogResult = DialogResult.OK; // closes the dialog
                }
                else
                {
                    Fail(error, txtUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fail(string message, Control focus)
        {
            lblError.Text = message;
            focus.Focus();
        }
    }
}

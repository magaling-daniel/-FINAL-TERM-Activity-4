using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    /// <summary>Sign In screen (the first form that opens).</summary>
    public partial class SignInForm : Form
    {
        private readonly UserRepository _users = new UserRepository();

        public SignInForm()
        {
            InitializeComponent();
            AcceptButton = btnSignIn; // Enter key signs in
        }

        // Called by the dashboard after Logout so the next person starts with empty fields
        public void ResetForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            chkShow.Checked = false;
            lblError.Text = "";
            txtUsername.Focus();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                lblError.Text = "Enter your username and password.";
                return;
            }

            try
            {
                User user = _users.Authenticate(username, password);
                if (user == null)
                {
                    lblError.Text = "Incorrect username or password.";
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                Hide();
                new DashboardForm(user.FullName).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var register = new RegisterForm())
            {
                if (register.ShowDialog(this) == DialogResult.OK)
                {
                    txtUsername.Text = register.CreatedUsername;
                    txtPassword.Clear();
                    txtPassword.Focus();
                    lblError.Text = "";
                    MessageBox.Show("Account created. Sign in to continue.", "Register",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

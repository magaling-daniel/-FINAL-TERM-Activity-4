namespace InventoryManagementSystem
{
    partial class SignInForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlHeader.Controls.Add(this.lblTagline);
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(420, 110);
            this.pnlHeader.TabIndex = 0;
            //
            // lblBrand
            //
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(26, 30);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(293, 28);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Inventory Management System";
            //
            // lblTagline
            //
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTagline.Location = new System.Drawing.Point(29, 66);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(177, 17);
            this.lblTagline.TabIndex = 1;
            this.lblTagline.Text = "Track products. Stay in stock.";
            //
            // lblHeading
            //
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblHeading.Location = new System.Drawing.Point(26, 136);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(172, 32);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Welcome back";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSub.Location = new System.Drawing.Point(29, 172);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(113, 19);
            this.lblSub.TabIndex = 2;
            this.lblSub.Text = "Sign in to continue";
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblUsername.Location = new System.Drawing.Point(30, 216);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 17);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            //
            // txtUsername
            //
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(30, 238);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(360, 27);
            this.txtUsername.TabIndex = 0;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPassword.Location = new System.Drawing.Point(30, 282);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 17);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            //
            // txtPassword
            //
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(30, 304);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(360, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // chkShow
            //
            this.chkShow.AutoSize = true;
            this.chkShow.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkShow.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.chkShow.Location = new System.Drawing.Point(30, 340);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(116, 21);
            this.chkShow.TabIndex = 2;
            this.chkShow.Text = "Show password";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            //
            // lblError
            //
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblError.Location = new System.Drawing.Point(30, 370);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(360, 20);
            this.lblError.TabIndex = 8;
            //
            // btnSignIn
            //
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(30, 398);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(360, 42);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            //
            // linkRegister
            //
            this.linkRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.linkRegister.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.linkRegister.LinkArea = new System.Windows.Forms.LinkArea(23, 8);
            this.linkRegister.LinkColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.linkRegister.Location = new System.Drawing.Point(30, 458);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(360, 24);
            this.linkRegister.TabIndex = 4;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Don\'t have an account? Register";
            this.linkRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            //
            // SignInForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(238, 241, 246);
            this.ClientSize = new System.Drawing.Size(420, 510);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel linkRegister;
    }
}

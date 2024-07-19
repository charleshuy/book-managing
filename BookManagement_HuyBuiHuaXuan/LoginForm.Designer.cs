namespace BookManagement_HuyBuiHuaXuan
{
    partial class LoginForm
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
            lblPassword = new Label();
            grpLoginInfo = new GroupBox();
            btnCancelLogin = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblHeader = new Label();
            grpLoginInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(70, 166);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // grpLoginInfo
            // 
            grpLoginInfo.Controls.Add(btnCancelLogin);
            grpLoginInfo.Controls.Add(btnLogin);
            grpLoginInfo.Controls.Add(txtPassword);
            grpLoginInfo.Controls.Add(txtEmail);
            grpLoginInfo.Controls.Add(lblPassword);
            grpLoginInfo.Controls.Add(lblEmail);
            grpLoginInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpLoginInfo.Location = new Point(34, 115);
            grpLoginInfo.Name = "grpLoginInfo";
            grpLoginInfo.Size = new Size(608, 307);
            grpLoginInfo.TabIndex = 5;
            grpLoginInfo.TabStop = false;
            grpLoginInfo.Text = "Account Info";
            // 
            // btnCancelLogin
            // 
            btnCancelLogin.FlatStyle = FlatStyle.Popup;
            btnCancelLogin.Location = new Point(361, 240);
            btnCancelLogin.Name = "btnCancelLogin";
            btnCancelLogin.Size = new Size(108, 39);
            btnCancelLogin.TabIndex = 3;
            btnCancelLogin.Text = "Cancel";
            btnCancelLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(193, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 39);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(208, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(301, 34);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(208, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(301, 34);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(70, 77);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 28);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold);
            lblHeader.Location = new Point(184, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(350, 62);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "Book Manager";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(695, 450);
            Controls.Add(grpLoginInfo);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            grpLoginInfo.ResumeLayout(false);
            grpLoginInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private GroupBox grpLoginInfo;
        private Button btnCancelLogin;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblHeader;
    }
}
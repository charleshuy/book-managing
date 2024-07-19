using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HuyBuiHuaXuan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(btnLogin.Text) || string.IsNullOrEmpty(txtPassword.Text)) 
            {
                MessageBox.Show("Please input both email and password!!", "Input please", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserAccountService _service = new UserAccountService();
            UserAccount? acc = _service.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (acc == null)
            {
                MessageBox.Show("Login Failed. Check again!!", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(acc.Role != 1) { MessageBox.Show("No permission to access!!", "Wrong Privilege", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            BookManagerMainUI f = new BookManagerMainUI();
            f.Show();    
            this.Hide();
        }
    }
}

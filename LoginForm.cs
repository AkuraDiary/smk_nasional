using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studikasus_smk_nasional
{
    public partial class LoginForm : Form       
    {
      
        public string captcha;
        public LoginForm()
        {           
            InitializeComponent();
           
        }

        private bool formIsValid()
        {
            if (string.IsNullOrEmpty(edtUsername.Text))
            {
                MessageBox.Show("Username is required");
                edtUsername.Focus();
                return false;

            }
            else if (string.IsNullOrEmpty(edtPass.Text))
            {
                MessageBox.Show("Password is required");
                edtPass.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(edtCaptcha.Text))
            {
                MessageBox.Show("Captcha is required");
                edtCaptcha.Focus();
                return false;
            }
            else if (edtCaptcha.Text != captcha)
            {
                MessageBox.Show("Captcha is not valid");
                edtCaptcha.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void resetCaptcha()
        {
            captcha = utilities.generateCaptcha();
            captchaLabel.Text = captcha;

        }
        private void captchaReset_Click(object sender, EventArgs e)
        {
            resetCaptcha();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            resetCaptcha();
        
    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (formIsValid())
            {
                //TODO DO Login Here
            }
        }
    }
}

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
using System.Drawing;
using System.Timers;

using studikasus_smk_nasional.model;

namespace studikasus_smk_nasional
{
    public partial class LoginForm : Form       
    {
      
        public string captcha;
        public int logincounter = 0;
        private static System.Timers.Timer timer;
        public LoginForm()
        {           
            InitializeComponent();
            KeyPreview = true;
            lblTimer.Hide();
           
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
                labelCaptcha.Text = "Captcha is required";
                edtCaptcha.Focus();
                labelCaptcha.ForeColor = Color.Red;
                return false;
            }
            else if (edtCaptcha.Text != captcha)
            {
                labelCaptcha.Text = "Captcha is not valid";
                labelCaptcha.ForeColor = Color.Red;
                edtCaptcha.Focus();
                return false;
            }
            else
            {
                labelCaptcha.Text = "Captcha OK";
                labelCaptcha.ForeColor = Color.SteelBlue;
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

        private void doLogin()
        {
            {
                if (formIsValid())
                {
                    sql_utilities.con.Open();
                    sql_utilities.cmd = new SqlCommand("SELECT * FROM [User] WHERE username = '"+edtUsername.Text+"' AND password = '"+edtPass.Text+"'", sql_utilities.con);
                    //sql_utilities.cmd.Parameters.AddWithValue("@username", edtUsername.Text);
                    //sql_utilities.cmd.Parameters.AddWithValue("@password", edtPass.Text);
                    sql_utilities.reader = sql_utilities.cmd.ExecuteReader();
                    if (sql_utilities.reader.HasRows)
                    {
                        sql_utilities.reader.Read();
                        UserModel user = new UserModel(sql_utilities.reader.GetInt32(0), sql_utilities.reader.GetString(1), sql_utilities.reader.GetString(2), sql_utilities.reader.GetString(3));
                        if (user.level == "admin")
                        {
                            MessageBox.Show("Login as admin Success");
                            //AdminForm adminForm = new AdminForm();
                            //adminForm.Show();
                            //this.Hide();
                        }
                        else if (user.level == "user")
                        {
                            //UserForm userForm = new UserForm();
                            //userForm.Show();
                            //this.Hide();
                            MessageBox.Show("Login as user Success");
                        }
                    }
                   
                    else
                    {
                        MessageBox.Show("Invalid login");
                        logincounter++;
                        disableLoginTemp();
                    }
                    sql_utilities.con.Close();
                }
            }
        }

        private void disableLoginTemp()
        {
            
                if (logincounter == 3)
                {
                timer = new System.Timers.Timer(120000);
                MessageBox.Show("You have been blocked for 2 minutes");
                btnLogin.Enabled = false;
                
                timer.AutoReset = false;
                timer.Start();
                lblTimer.Text = "Status : Login Blocked";
                lblTimer.Show();
                
                timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                
            }
            
            
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                btnLogin.Enabled = true;
                resetCaptcha();
                lblTimer.Hide();
            }));
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (formIsValid())
            {
                //TODO DO Login Here
                doLogin();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnLogin.PerformClick();
            }
        }
    }
}

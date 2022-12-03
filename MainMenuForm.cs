using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studikasus_smk_nasional.model;

namespace studikasus_smk_nasional
{
    public partial class MainMenuForm : Form
    {
        
       
        public MainMenuForm()
        {
            InitializeComponent();
            labelWelcome.Text ="Selamat Datang " + utilities.currentUser.username;

         
        }
        

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            utilities.currentUser = null;
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void menuAnggotaFragment_Load(object sender, EventArgs e)
        {
            if (utilities.currentUser.level == "admin")
            {
                menuAdminFragment.Visible = true;
                menuAnggotaFragment.Visible = false;
            }
            else
            {
                menuAdminFragment.Visible = false;
                menuAnggotaFragment.Visible = true;
            }

        }
    }
}

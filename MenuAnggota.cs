using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studikasus_smk_nasional
{
    public partial class MenuAnggota : UserControl
    {
        public MenuAnggota()
        {
            InitializeComponent();
        }

        private void MenuAnggota_Load(object sender, EventArgs e)
        {
            hideAllUserControl();
        }


        private void hideAllUserControl()
        {
            cariBukuFragment.Visible = false;
            historyPeminjamanFragment.Visible = false;
        }



        private void showForm(UserControl form)
        {
            hideAllUserControl();
            form.Visible = true;
        }

        private void btnCariBuku_Click(object sender, EventArgs e)
        {
            showForm(cariBukuFragment);
        }

        private void btnHisoryPinjam_Click(object sender, EventArgs e)
        {
            showForm(historyPeminjamanFragment);
        }
    }
}

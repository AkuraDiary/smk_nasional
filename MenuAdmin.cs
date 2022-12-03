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
    public partial class MenuAdmin : UserControl
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            hideAllUserControl();
        }

        private void hideAllUserControl()
        {
            kategoriForm.Visible = false;
            dataPeminjamanFragment.Visible = false;
            detailPeminjamanFragment.Visible = false;
            historyPengembalianFragment.Visible = false;
            masterAnggotaFragment.Visible = false;
            masterBukuFragment.Visible = false;
            masterLokasiFragment.Visible = false;
            masterPetugasFragment.Visible = false;
            masterUserFragment.Visible = false;
            peminjamanFragment.Visible = false;
            pengembalianFragment.Visible = false;
        }

        

        private void showForm(UserControl form)
        {
            hideAllUserControl();
            form.Visible = true;
        }

        private void btnKategoriBuku_Click(object sender, EventArgs e)
        {
            showForm(kategoriForm);
        }

        private void btnMasterBuku_Click(object sender, EventArgs e)
        {
            showForm(masterBukuFragment);
        }

        private void btnAnggota_Click(object sender, EventArgs e)
        {
            showForm(masterAnggotaFragment);
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            showForm(masterPetugasFragment);
        }

        private void btnLokasi_Click(object sender, EventArgs e)
        {
            showForm(masterLokasiFragment);
        }

        private void btnMasterUser_Click(object sender, EventArgs e)
        {
            showForm(masterUserFragment);
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            showForm(peminjamanFragment);
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            showForm(pengembalianFragment);
        }

        private void btnDataPeminjaman_Click(object sender, EventArgs e)
        {
            showForm(dataPeminjamanFragment);
        }

        private void btnDetilPeminjaman_Click(object sender, EventArgs e)
        {
            showForm(detailPeminjamanFragment);
        }
    }
}

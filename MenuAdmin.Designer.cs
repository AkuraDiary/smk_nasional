namespace studikasus_smk_nasional
{
    partial class MenuAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnggota = new System.Windows.Forms.Button();
            this.btnMasterBuku = new System.Windows.Forms.Button();
            this.btnPetugas = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnMasterUser = new System.Windows.Forms.Button();
            this.btnKategoriBuku = new System.Windows.Forms.Button();
            this.btnLokasi = new System.Windows.Forms.Button();
            this.adminPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.masterUserFragment = new studikasus_smk_nasional.admin.MasterUser();
            this.masterPetugasFragment = new studikasus_smk_nasional.admin.MasterPetugas();
            this.masterBukuFragment = new studikasus_smk_nasional.admin.MasterBuku();
            this.masterLokasiFragment = new studikasus_smk_nasional.admin.MasterLokasi();
            this.masterAnggotaFragment = new studikasus_smk_nasional.admin.MasterAnggota();
            this.peminjamanFragment = new studikasus_smk_nasional.admin.Peminjaman();
            this.historyPengembalianFragment = new studikasus_smk_nasional.admin.HistoryPengembalian();
            this.pengembalianFragment = new studikasus_smk_nasional.admin.Pengembalian();
            this.detailPeminjamanFragment = new studikasus_smk_nasional.admin.DetailPeminjaman();
            this.dataPeminjamanFragment = new studikasus_smk_nasional.admin.DataPeminjaman();
            this.kategoriForm = new studikasus_smk_nasional.admin.KategoriForm();
            this.btnDataPeminjaman = new System.Windows.Forms.Button();
            this.btnDetilPeminjaman = new System.Windows.Forms.Button();
            this.adminPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnggota
            // 
            this.btnAnggota.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAnggota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnggota.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnggota.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAnggota.Location = new System.Drawing.Point(4, 43);
            this.btnAnggota.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnggota.Name = "btnAnggota";
            this.btnAnggota.Size = new System.Drawing.Size(166, 31);
            this.btnAnggota.TabIndex = 48;
            this.btnAnggota.Text = "ANGGOTA";
            this.btnAnggota.UseVisualStyleBackColor = false;
            this.btnAnggota.Click += new System.EventHandler(this.btnAnggota_Click);
            // 
            // btnMasterBuku
            // 
            this.btnMasterBuku.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMasterBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterBuku.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasterBuku.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMasterBuku.Location = new System.Drawing.Point(4, 4);
            this.btnMasterBuku.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasterBuku.Name = "btnMasterBuku";
            this.btnMasterBuku.Size = new System.Drawing.Size(166, 31);
            this.btnMasterBuku.TabIndex = 47;
            this.btnMasterBuku.Text = "MASTER BUKU";
            this.btnMasterBuku.UseVisualStyleBackColor = false;
            this.btnMasterBuku.Click += new System.EventHandler(this.btnMasterBuku_Click);
            // 
            // btnPetugas
            // 
            this.btnPetugas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetugas.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPetugas.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPetugas.Location = new System.Drawing.Point(4, 82);
            this.btnPetugas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPetugas.Name = "btnPetugas";
            this.btnPetugas.Size = new System.Drawing.Size(166, 31);
            this.btnPetugas.TabIndex = 49;
            this.btnPetugas.Text = "PETUGAS";
            this.btnPetugas.UseVisualStyleBackColor = false;
            this.btnPetugas.Click += new System.EventHandler(this.btnPetugas_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengembalian.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPengembalian.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPengembalian.Location = new System.Drawing.Point(4, 355);
            this.btnPengembalian.Margin = new System.Windows.Forms.Padding(4);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(166, 31);
            this.btnPengembalian.TabIndex = 50;
            this.btnPengembalian.Text = "PENGEMBALIAN BUKU";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeminjaman.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPeminjaman.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPeminjaman.Location = new System.Drawing.Point(4, 316);
            this.btnPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(166, 31);
            this.btnPeminjaman.TabIndex = 51;
            this.btnPeminjaman.Text = "PEMINJAMAN BUKU";
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnMasterUser
            // 
            this.btnMasterUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMasterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterUser.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasterUser.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMasterUser.Location = new System.Drawing.Point(4, 199);
            this.btnMasterUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasterUser.Name = "btnMasterUser";
            this.btnMasterUser.Size = new System.Drawing.Size(166, 31);
            this.btnMasterUser.TabIndex = 52;
            this.btnMasterUser.Text = "MASTER USER";
            this.btnMasterUser.UseVisualStyleBackColor = false;
            this.btnMasterUser.Click += new System.EventHandler(this.btnMasterUser_Click);
            // 
            // btnKategoriBuku
            // 
            this.btnKategoriBuku.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKategoriBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriBuku.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriBuku.ForeColor = System.Drawing.SystemColors.Info;
            this.btnKategoriBuku.Location = new System.Drawing.Point(4, 160);
            this.btnKategoriBuku.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriBuku.Name = "btnKategoriBuku";
            this.btnKategoriBuku.Size = new System.Drawing.Size(166, 31);
            this.btnKategoriBuku.TabIndex = 53;
            this.btnKategoriBuku.Text = "KATEGORI BUKU";
            this.btnKategoriBuku.UseVisualStyleBackColor = false;
            this.btnKategoriBuku.Click += new System.EventHandler(this.btnKategoriBuku_Click);
            // 
            // btnLokasi
            // 
            this.btnLokasi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLokasi.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLokasi.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLokasi.Location = new System.Drawing.Point(4, 121);
            this.btnLokasi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLokasi.Name = "btnLokasi";
            this.btnLokasi.Size = new System.Drawing.Size(166, 31);
            this.btnLokasi.TabIndex = 54;
            this.btnLokasi.Text = "LOKASI";
            this.btnLokasi.UseVisualStyleBackColor = false;
            this.btnLokasi.Click += new System.EventHandler(this.btnLokasi_Click);
            // 
            // adminPanelContainer
            // 
            this.adminPanelContainer.Controls.Add(this.masterLokasiFragment);
            this.adminPanelContainer.Controls.Add(this.masterUserFragment);
            this.adminPanelContainer.Controls.Add(this.masterPetugasFragment);
            this.adminPanelContainer.Controls.Add(this.masterBukuFragment);
            this.adminPanelContainer.Controls.Add(this.masterAnggotaFragment);
            this.adminPanelContainer.Controls.Add(this.peminjamanFragment);
            this.adminPanelContainer.Controls.Add(this.historyPengembalianFragment);
            this.adminPanelContainer.Controls.Add(this.pengembalianFragment);
            this.adminPanelContainer.Controls.Add(this.detailPeminjamanFragment);
            this.adminPanelContainer.Controls.Add(this.dataPeminjamanFragment);
            this.adminPanelContainer.Controls.Add(this.kategoriForm);
            this.adminPanelContainer.Location = new System.Drawing.Point(177, 3);
            this.adminPanelContainer.Name = "adminPanelContainer";
            this.adminPanelContainer.Size = new System.Drawing.Size(802, 470);
            this.adminPanelContainer.TabIndex = 55;
            // 
            // masterUserFragment
            // 
            this.masterUserFragment.Location = new System.Drawing.Point(3, 355);
            this.masterUserFragment.Name = "masterUserFragment";
            this.masterUserFragment.Size = new System.Drawing.Size(596, 360);
            this.masterUserFragment.TabIndex = 56;
            // 
            // masterPetugasFragment
            // 
            this.masterPetugasFragment.Location = new System.Drawing.Point(3, 721);
            this.masterPetugasFragment.Name = "masterPetugasFragment";
            this.masterPetugasFragment.Size = new System.Drawing.Size(696, 397);
            this.masterPetugasFragment.TabIndex = 60;
            // 
            // masterBukuFragment
            // 
            this.masterBukuFragment.Location = new System.Drawing.Point(3, 1124);
            this.masterBukuFragment.Name = "masterBukuFragment";
            this.masterBukuFragment.Size = new System.Drawing.Size(716, 533);
            this.masterBukuFragment.TabIndex = 56;
            // 
            // masterLokasiFragment
            // 
            this.masterLokasiFragment.Location = new System.Drawing.Point(3, 3);
            this.masterLokasiFragment.Name = "masterLokasiFragment";
            this.masterLokasiFragment.Size = new System.Drawing.Size(696, 346);
            this.masterLokasiFragment.TabIndex = 59;
            // 
            // masterAnggotaFragment
            // 
            this.masterAnggotaFragment.Location = new System.Drawing.Point(3, 1663);
            this.masterAnggotaFragment.Name = "masterAnggotaFragment";
            this.masterAnggotaFragment.Size = new System.Drawing.Size(696, 457);
            this.masterAnggotaFragment.TabIndex = 58;
            // 
            // peminjamanFragment
            // 
            this.peminjamanFragment.Location = new System.Drawing.Point(3, 2126);
            this.peminjamanFragment.Name = "peminjamanFragment";
            this.peminjamanFragment.Size = new System.Drawing.Size(734, 462);
            this.peminjamanFragment.TabIndex = 57;
            // 
            // historyPengembalianFragment
            // 
            this.historyPengembalianFragment.Location = new System.Drawing.Point(3, 2594);
            this.historyPengembalianFragment.Name = "historyPengembalianFragment";
            this.historyPengembalianFragment.Size = new System.Drawing.Size(596, 360);
            this.historyPengembalianFragment.TabIndex = 3;
            // 
            // pengembalianFragment
            // 
            this.pengembalianFragment.Location = new System.Drawing.Point(3, 2960);
            this.pengembalianFragment.Name = "pengembalianFragment";
            this.pengembalianFragment.Size = new System.Drawing.Size(670, 360);
            this.pengembalianFragment.TabIndex = 56;
            // 
            // detailPeminjamanFragment
            // 
            this.detailPeminjamanFragment.Location = new System.Drawing.Point(3, 3326);
            this.detailPeminjamanFragment.Name = "detailPeminjamanFragment";
            this.detailPeminjamanFragment.Size = new System.Drawing.Size(672, 359);
            this.detailPeminjamanFragment.TabIndex = 2;
            // 
            // dataPeminjamanFragment
            // 
            this.dataPeminjamanFragment.Location = new System.Drawing.Point(3, 3691);
            this.dataPeminjamanFragment.Name = "dataPeminjamanFragment";
            this.dataPeminjamanFragment.Size = new System.Drawing.Size(670, 388);
            this.dataPeminjamanFragment.TabIndex = 1;
            // 
            // kategoriForm
            // 
            this.kategoriForm.Location = new System.Drawing.Point(3, 4085);
            this.kategoriForm.Name = "kategoriForm";
            this.kategoriForm.Size = new System.Drawing.Size(331, 423);
            this.kategoriForm.TabIndex = 0;
            // 
            // btnDataPeminjaman
            // 
            this.btnDataPeminjaman.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDataPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataPeminjaman.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDataPeminjaman.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDataPeminjaman.Location = new System.Drawing.Point(4, 238);
            this.btnDataPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.btnDataPeminjaman.Name = "btnDataPeminjaman";
            this.btnDataPeminjaman.Size = new System.Drawing.Size(166, 31);
            this.btnDataPeminjaman.TabIndex = 56;
            this.btnDataPeminjaman.Text = "DATA PEMINJAMAN";
            this.btnDataPeminjaman.UseVisualStyleBackColor = false;
            this.btnDataPeminjaman.Click += new System.EventHandler(this.btnDataPeminjaman_Click);
            // 
            // btnDetilPeminjaman
            // 
            this.btnDetilPeminjaman.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDetilPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetilPeminjaman.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDetilPeminjaman.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDetilPeminjaman.Location = new System.Drawing.Point(4, 277);
            this.btnDetilPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetilPeminjaman.Name = "btnDetilPeminjaman";
            this.btnDetilPeminjaman.Size = new System.Drawing.Size(166, 31);
            this.btnDetilPeminjaman.TabIndex = 57;
            this.btnDetilPeminjaman.Text = "DETIL PEMINJAMAN ";
            this.btnDetilPeminjaman.UseVisualStyleBackColor = false;
            this.btnDetilPeminjaman.Click += new System.EventHandler(this.btnDetilPeminjaman_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetilPeminjaman);
            this.Controls.Add(this.btnDataPeminjaman);
            this.Controls.Add(this.adminPanelContainer);
            this.Controls.Add(this.btnLokasi);
            this.Controls.Add(this.btnKategoriBuku);
            this.Controls.Add(this.btnMasterUser);
            this.Controls.Add(this.btnPeminjaman);
            this.Controls.Add(this.btnPengembalian);
            this.Controls.Add(this.btnPetugas);
            this.Controls.Add(this.btnAnggota);
            this.Controls.Add(this.btnMasterBuku);
            this.Name = "MenuAdmin";
            this.Size = new System.Drawing.Size(982, 488);
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.adminPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAnggota;
        private Button btnMasterBuku;
        private Button btnPetugas;
        private Button btnPengembalian;
        private Button btnPeminjaman;
        private Button btnMasterUser;
        private Button btnKategoriBuku;
        private Button btnLokasi;
        private FlowLayoutPanel adminPanelContainer;
        private admin.KategoriForm kategoriForm;
        private admin.MasterUser masterUserFragment;
        private admin.MasterPetugas masterPetugasFragment;
        private admin.MasterBuku masterBukuFragment;
        private admin.MasterLokasi masterLokasiFragment;
        private admin.MasterAnggota masterAnggotaFragment;
        private admin.Peminjaman peminjamanFragment;
        private admin.HistoryPengembalian historyPengembalianFragment;
        private admin.Pengembalian pengembalianFragment;
        private admin.DetailPeminjaman detailPeminjamanFragment;
        private admin.DataPeminjaman dataPeminjamanFragment;
        private Button btnDataPeminjaman;
        private Button btnDetilPeminjaman;
    }
}

namespace studikasus_smk_nasional
{
    partial class MenuAnggota
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
            this.btnCariBuku = new System.Windows.Forms.Button();
            this.btnHisoryPinjam = new System.Windows.Forms.Button();
            this.anggotaPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.historyPeminjamanFragment = new studikasus_smk_nasional.anggota.HistoryPeminjaman();
            this.cariBukuFragment = new studikasus_smk_nasional.anggota.CariBukuForm();
            this.anggotaPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCariBuku
            // 
            this.btnCariBuku.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCariBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariBuku.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCariBuku.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCariBuku.Location = new System.Drawing.Point(4, 4);
            this.btnCariBuku.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariBuku.Name = "btnCariBuku";
            this.btnCariBuku.Size = new System.Drawing.Size(166, 45);
            this.btnCariBuku.TabIndex = 44;
            this.btnCariBuku.Text = "CARI BUKU";
            this.btnCariBuku.UseVisualStyleBackColor = false;
            this.btnCariBuku.Click += new System.EventHandler(this.btnCariBuku_Click);
            // 
            // btnHisoryPinjam
            // 
            this.btnHisoryPinjam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHisoryPinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHisoryPinjam.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHisoryPinjam.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHisoryPinjam.Location = new System.Drawing.Point(4, 57);
            this.btnHisoryPinjam.Margin = new System.Windows.Forms.Padding(4);
            this.btnHisoryPinjam.Name = "btnHisoryPinjam";
            this.btnHisoryPinjam.Size = new System.Drawing.Size(166, 45);
            this.btnHisoryPinjam.TabIndex = 45;
            this.btnHisoryPinjam.Text = "HISTORY PEMINJAMAN";
            this.btnHisoryPinjam.UseVisualStyleBackColor = false;
            this.btnHisoryPinjam.Click += new System.EventHandler(this.btnHisoryPinjam_Click);
            // 
            // anggotaPanelContainer
            // 
            this.anggotaPanelContainer.Controls.Add(this.cariBukuFragment);
            this.anggotaPanelContainer.Controls.Add(this.historyPeminjamanFragment);
            this.anggotaPanelContainer.Location = new System.Drawing.Point(177, 4);
            this.anggotaPanelContainer.Name = "anggotaPanelContainer";
            this.anggotaPanelContainer.Size = new System.Drawing.Size(596, 359);
            this.anggotaPanelContainer.TabIndex = 46;
            // 
            // historyPeminjamanFragment
            // 
            this.historyPeminjamanFragment.Location = new System.Drawing.Point(3, 368);
            this.historyPeminjamanFragment.Name = "historyPeminjamanFragment";
            this.historyPeminjamanFragment.Size = new System.Drawing.Size(596, 359);
            this.historyPeminjamanFragment.TabIndex = 0;
            // 
            // cariBukuFragment
            // 
            this.cariBukuFragment.Location = new System.Drawing.Point(3, 3);
            this.cariBukuFragment.Name = "cariBukuFragment";
            this.cariBukuFragment.Size = new System.Drawing.Size(596, 359);
            this.cariBukuFragment.TabIndex = 1;
            // 
            // MenuAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.anggotaPanelContainer);
            this.Controls.Add(this.btnHisoryPinjam);
            this.Controls.Add(this.btnCariBuku);
            this.Name = "MenuAnggota";
            this.Size = new System.Drawing.Size(776, 366);
            this.Load += new System.EventHandler(this.MenuAnggota_Load);
            this.anggotaPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCariBuku;
        private Button btnHisoryPinjam;
        private FlowLayoutPanel anggotaPanelContainer;
        private anggota.CariBukuForm cariBukuFragment;
        private anggota.HistoryPeminjaman historyPeminjamanFragment;
    }
}

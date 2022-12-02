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
            this.labelLevel = new System.Windows.Forms.Label();
            this.btnCariBuku = new System.Windows.Forms.Button();
            this.btnHisoryPinjam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLevel
            // 
            this.labelLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLevel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLevel.Location = new System.Drawing.Point(4, 0);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(110, 48);
            this.labelLevel.TabIndex = 43;
            this.labelLevel.Text = "Status";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCariBuku
            // 
            this.btnCariBuku.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCariBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariBuku.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCariBuku.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCariBuku.Location = new System.Drawing.Point(4, 52);
            this.btnCariBuku.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariBuku.Name = "btnCariBuku";
            this.btnCariBuku.Size = new System.Drawing.Size(166, 45);
            this.btnCariBuku.TabIndex = 44;
            this.btnCariBuku.Text = "CARI BUKU";
            this.btnCariBuku.UseVisualStyleBackColor = false;
            // 
            // btnHisoryPinjam
            // 
            this.btnHisoryPinjam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHisoryPinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHisoryPinjam.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHisoryPinjam.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHisoryPinjam.Location = new System.Drawing.Point(4, 105);
            this.btnHisoryPinjam.Margin = new System.Windows.Forms.Padding(4);
            this.btnHisoryPinjam.Name = "btnHisoryPinjam";
            this.btnHisoryPinjam.Size = new System.Drawing.Size(166, 45);
            this.btnHisoryPinjam.TabIndex = 45;
            this.btnHisoryPinjam.Text = "HISTORY PEMINJAMAN";
            this.btnHisoryPinjam.UseVisualStyleBackColor = false;
            // 
            // MenuAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHisoryPinjam);
            this.Controls.Add(this.btnCariBuku);
            this.Controls.Add(this.labelLevel);
            this.Name = "MenuAnggota";
            this.Size = new System.Drawing.Size(776, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLevel;
        private Button btnCariBuku;
        private Button btnHisoryPinjam;
    }
}

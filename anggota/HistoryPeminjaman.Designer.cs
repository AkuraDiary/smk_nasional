namespace studikasus_smk_nasional.anggota
{
    partial class HistoryPeminjaman
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
            this.dataBuku = new System.Windows.Forms.DataGridView();
            this.edtSearchBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblHistoryPinjam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBuku
            // 
            this.dataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBuku.Location = new System.Drawing.Point(4, 109);
            this.dataBuku.Name = "dataBuku";
            this.dataBuku.RowTemplate.Height = 25;
            this.dataBuku.Size = new System.Drawing.Size(589, 248);
            this.dataBuku.TabIndex = 51;
            // 
            // edtSearchBook
            // 
            this.edtSearchBook.Location = new System.Drawing.Point(4, 67);
            this.edtSearchBook.Name = "edtSearchBook";
            this.edtSearchBook.Size = new System.Drawing.Size(468, 23);
            this.edtSearchBook.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Pencarian Buku";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(506, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 24);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblHistoryPinjam
            // 
            this.lblHistoryPinjam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistoryPinjam.AutoSize = true;
            this.lblHistoryPinjam.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHistoryPinjam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHistoryPinjam.Location = new System.Drawing.Point(4, 1);
            this.lblHistoryPinjam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistoryPinjam.Name = "lblHistoryPinjam";
            this.lblHistoryPinjam.Size = new System.Drawing.Size(306, 48);
            this.lblHistoryPinjam.TabIndex = 47;
            this.lblHistoryPinjam.Text = "History Peminjaman";
            this.lblHistoryPinjam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataBuku);
            this.Controls.Add(this.edtSearchBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblHistoryPinjam);
            this.Name = "HistoryPeminjaman";
            this.Size = new System.Drawing.Size(596, 359);
            this.Load += new System.EventHandler(this.HistoryPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataBuku;
        private TextBox edtSearchBook;
        private Label label1;
        private Button btnSearch;
        private Label lblHistoryPinjam;
    }
}

namespace studikasus_smk_nasional.admin
{
    partial class HistoryPengembalian
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
            this.lblMasterUser = new System.Windows.Forms.Label();
            this.dataBuku = new System.Windows.Forms.DataGridView();
            this.edtSearchBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMasterUser
            // 
            this.lblMasterUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasterUser.AutoSize = true;
            this.lblMasterUser.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasterUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMasterUser.Location = new System.Drawing.Point(0, 0);
            this.lblMasterUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasterUser.Name = "lblMasterUser";
            this.lblMasterUser.Size = new System.Drawing.Size(330, 48);
            this.lblMasterUser.TabIndex = 48;
            this.lblMasterUser.Text = "History Pengembalian";
            this.lblMasterUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataBuku
            // 
            this.dataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBuku.Location = new System.Drawing.Point(3, 102);
            this.dataBuku.Name = "dataBuku";
            this.dataBuku.RowTemplate.Height = 25;
            this.dataBuku.Size = new System.Drawing.Size(589, 248);
            this.dataBuku.TabIndex = 55;
            // 
            // edtSearchBook
            // 
            this.edtSearchBook.Location = new System.Drawing.Point(3, 60);
            this.edtSearchBook.Name = "edtSearchBook";
            this.edtSearchBook.Size = new System.Drawing.Size(468, 23);
            this.edtSearchBook.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Pencarian Buku";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(505, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 24);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // HistoryPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataBuku);
            this.Controls.Add(this.edtSearchBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblMasterUser);
            this.Name = "HistoryPengembalian";
            this.Size = new System.Drawing.Size(596, 360);
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMasterUser;
        private DataGridView dataBuku;
        private TextBox edtSearchBook;
        private Label label1;
        private Button btnSearch;
    }
}

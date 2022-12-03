namespace studikasus_smk_nasional.anggota
{
    partial class CariBukuForm
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
            this.lblCariBuku = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtSearchBook = new System.Windows.Forms.TextBox();
            this.dataBuku = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCariBuku
            // 
            this.lblCariBuku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCariBuku.AutoSize = true;
            this.lblCariBuku.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCariBuku.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCariBuku.Location = new System.Drawing.Point(4, 0);
            this.lblCariBuku.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCariBuku.Name = "lblCariBuku";
            this.lblCariBuku.Size = new System.Drawing.Size(156, 48);
            this.lblCariBuku.TabIndex = 42;
            this.lblCariBuku.Text = "Cari Buku";
            this.lblCariBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(506, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 24);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Pencarian Buku";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtSearchBook
            // 
            this.edtSearchBook.Location = new System.Drawing.Point(4, 66);
            this.edtSearchBook.Name = "edtSearchBook";
            this.edtSearchBook.Size = new System.Drawing.Size(468, 23);
            this.edtSearchBook.TabIndex = 45;
            // 
            // dataBuku
            // 
            this.dataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBuku.Location = new System.Drawing.Point(4, 108);
            this.dataBuku.Name = "dataBuku";
            this.dataBuku.RowTemplate.Height = 25;
            this.dataBuku.Size = new System.Drawing.Size(589, 248);
            this.dataBuku.TabIndex = 46;
            // 
            // CariBukuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataBuku);
            this.Controls.Add(this.edtSearchBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCariBuku);
            this.Name = "CariBukuForm";
            this.Size = new System.Drawing.Size(596, 359);
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCariBuku;
        private Button btnSearch;
        private Label label1;
        private TextBox edtSearchBook;
        private DataGridView dataBuku;
    }
}

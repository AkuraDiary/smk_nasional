namespace studikasus_smk_nasional.admin
{
    partial class DataPeminjaman
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.edtSearchPinjaman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBuku
            // 
            this.dataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBuku.Location = new System.Drawing.Point(3, 102);
            this.dataBuku.Name = "dataBuku";
            this.dataBuku.RowTemplate.Height = 25;
            this.dataBuku.Size = new System.Drawing.Size(664, 283);
            this.dataBuku.TabIndex = 66;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 48);
            this.lblTitle.TabIndex = 65;
            this.lblTitle.Text = "Data Peminjaman";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtSearchPinjaman
            // 
            this.edtSearchPinjaman.Location = new System.Drawing.Point(3, 73);
            this.edtSearchPinjaman.Name = "edtSearchPinjaman";
            this.edtSearchPinjaman.Size = new System.Drawing.Size(317, 23);
            this.edtSearchPinjaman.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "Cari Peminjaman";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 24);
            this.btnSearch.TabIndex = 67;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // DataPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edtSearchPinjaman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataBuku);
            this.Controls.Add(this.lblTitle);
            this.Name = "DataPeminjaman";
            this.Size = new System.Drawing.Size(670, 388);
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataBuku;
        private Label lblTitle;
        private TextBox edtSearchPinjaman;
        private Label label1;
        private Button btnSearch;
    }
}

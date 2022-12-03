namespace studikasus_smk_nasional.admin
{
    partial class DetailPeminjaman
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
            this.lblTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBuku
            // 
            this.dataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBuku.Location = new System.Drawing.Point(4, 52);
            this.dataBuku.Name = "dataBuku";
            this.dataBuku.RowTemplate.Height = 25;
            this.dataBuku.Size = new System.Drawing.Size(665, 305);
            this.dataBuku.TabIndex = 48;
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTittle.Location = new System.Drawing.Point(4, 1);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(270, 48);
            this.lblTittle.TabIndex = 47;
            this.lblTittle.Text = "Detil Peminjaman";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataBuku);
            this.Controls.Add(this.lblTittle);
            this.Name = "DetailPeminjaman";
            this.Size = new System.Drawing.Size(672, 359);
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataBuku;
        private Label lblTittle;
    }
}

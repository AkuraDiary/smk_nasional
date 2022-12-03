namespace studikasus_smk_nasional.admin
{
    partial class Pengembalian
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
            this.edtDenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dataBuku = new System.Windows.Forms.DataGridView();
            this.edtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKembalikan = new System.Windows.Forms.Button();
            this.lblPengembalian = new System.Windows.Forms.Label();
            this.btnSearchIdPinjam = new System.Windows.Forms.Button();
            this.edtIDBuku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateKembali = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // edtDenda
            // 
            this.edtDenda.Location = new System.Drawing.Point(370, 239);
            this.edtDenda.Name = "edtDenda";
            this.edtDenda.Size = new System.Drawing.Size(292, 23);
            this.edtDenda.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 68;
            this.label2.Text = "Denda";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(370, 311);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(292, 24);
            this.btnBatal.TabIndex = 65;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // dataBuku
            // 
            this.dataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBuku.Location = new System.Drawing.Point(15, 53);
            this.dataBuku.Name = "dataBuku";
            this.dataBuku.RowTemplate.Height = 25;
            this.dataBuku.Size = new System.Drawing.Size(349, 304);
            this.dataBuku.TabIndex = 64;
            // 
            // edtSearch
            // 
            this.edtSearch.Location = new System.Drawing.Point(370, 71);
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.Size = new System.Drawing.Size(211, 23);
            this.edtSearch.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "ID PEMINJAMAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKembalikan
            // 
            this.btnKembalikan.Location = new System.Drawing.Point(370, 268);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.Size = new System.Drawing.Size(292, 37);
            this.btnKembalikan.TabIndex = 61;
            this.btnKembalikan.Text = "Kembalikan Buku";
            this.btnKembalikan.UseVisualStyleBackColor = true;
            // 
            // lblPengembalian
            // 
            this.lblPengembalian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPengembalian.AutoSize = true;
            this.lblPengembalian.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPengembalian.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPengembalian.Location = new System.Drawing.Point(15, 2);
            this.lblPengembalian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPengembalian.Name = "lblPengembalian";
            this.lblPengembalian.Size = new System.Drawing.Size(303, 48);
            this.lblPengembalian.TabIndex = 60;
            this.lblPengembalian.Text = "Form Pengembalian";
            this.lblPengembalian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchIdPinjam
            // 
            this.btnSearchIdPinjam.Location = new System.Drawing.Point(587, 70);
            this.btnSearchIdPinjam.Name = "btnSearchIdPinjam";
            this.btnSearchIdPinjam.Size = new System.Drawing.Size(75, 23);
            this.btnSearchIdPinjam.TabIndex = 70;
            this.btnSearchIdPinjam.Text = "CARI";
            this.btnSearchIdPinjam.UseVisualStyleBackColor = true;
            // 
            // edtIDBuku
            // 
            this.edtIDBuku.Location = new System.Drawing.Point(370, 122);
            this.edtIDBuku.Name = "edtIDBuku";
            this.edtIDBuku.Size = new System.Drawing.Size(292, 23);
            this.edtIDBuku.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 71;
            this.label3.Text = "ID BUKU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateKembali
            // 
            this.dateKembali.Location = new System.Drawing.Point(370, 176);
            this.dateKembali.Name = "dateKembali";
            this.dateKembali.Size = new System.Drawing.Size(200, 23);
            this.dateKembali.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Tanggal Kembali";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateKembali);
            this.Controls.Add(this.edtIDBuku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchIdPinjam);
            this.Controls.Add(this.edtDenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.dataBuku);
            this.Controls.Add(this.edtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.lblPengembalian);
            this.Name = "Pengembalian";
            this.Size = new System.Drawing.Size(670, 360);
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox edtDenda;
        private Label label2;
        private Button btnBatal;
        private DataGridView dataBuku;
        private TextBox edtSearch;
        private Label label1;
        private Button btnKembalikan;
        private Label lblPengembalian;
        private Button btnSearchIdPinjam;
        private TextBox edtIDBuku;
        private Label label3;
        private DateTimePicker dateKembali;
        private Label label4;
    }
}

namespace studikasus_smk_nasional.admin
{
    partial class MasterUser
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
            this.edtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblMasterUser = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.edtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxLevel = new System.Windows.Forms.GroupBox();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioUser = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).BeginInit();
            this.groupBoxLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBuku
            // 
            this.dataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBuku.Location = new System.Drawing.Point(4, 53);
            this.dataBuku.Name = "dataBuku";
            this.dataBuku.RowTemplate.Height = 25;
            this.dataBuku.Size = new System.Drawing.Size(349, 305);
            this.dataBuku.TabIndex = 51;
            // 
            // edtUsername
            // 
            this.edtUsername.Location = new System.Drawing.Point(373, 99);
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.Size = new System.Drawing.Size(197, 23);
            this.edtUsername.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(373, 242);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(197, 24);
            this.btnTambah.TabIndex = 48;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // lblMasterUser
            // 
            this.lblMasterUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasterUser.AutoSize = true;
            this.lblMasterUser.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasterUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMasterUser.Location = new System.Drawing.Point(4, 2);
            this.lblMasterUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasterUser.Name = "lblMasterUser";
            this.lblMasterUser.Size = new System.Drawing.Size(257, 48);
            this.lblMasterUser.TabIndex = 47;
            this.lblMasterUser.Text = "Manajemen User";
            this.lblMasterUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(373, 272);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(197, 24);
            this.btnHapus.TabIndex = 52;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(373, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 24);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(373, 332);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(197, 24);
            this.btnBatal.TabIndex = 54;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // edtPass
            // 
            this.edtPass.Location = new System.Drawing.Point(373, 143);
            this.edtPass.Name = "edtPass";
            this.edtPass.Size = new System.Drawing.Size(197, 23);
            this.edtPass.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxLevel
            // 
            this.groupBoxLevel.Controls.Add(this.radioUser);
            this.groupBoxLevel.Controls.Add(this.radioAdmin);
            this.groupBoxLevel.Location = new System.Drawing.Point(373, 181);
            this.groupBoxLevel.Name = "groupBoxLevel";
            this.groupBoxLevel.Size = new System.Drawing.Size(143, 55);
            this.groupBoxLevel.TabIndex = 57;
            this.groupBoxLevel.TabStop = false;
            this.groupBoxLevel.Text = "Level";
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(6, 22);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(59, 19);
            this.radioAdmin.TabIndex = 58;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Location = new System.Drawing.Point(81, 22);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(47, 19);
            this.radioUser.TabIndex = 59;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "user";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // MasterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxLevel);
            this.Controls.Add(this.edtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dataBuku);
            this.Controls.Add(this.edtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblMasterUser);
            this.Name = "MasterUser";
            this.Size = new System.Drawing.Size(596, 360);
            this.Load += new System.EventHandler(this.MasterUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).EndInit();
            this.groupBoxLevel.ResumeLayout(false);
            this.groupBoxLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataBuku;
        private TextBox edtUsername;
        private Label label1;
        private Button btnTambah;
        private Label lblMasterUser;
        private Button btnHapus;
        private Button btnUpdate;
        private Button btnBatal;
        private TextBox edtPass;
        private Label label2;
        private GroupBox groupBoxLevel;
        private RadioButton radioUser;
        private RadioButton radioAdmin;
    }
}

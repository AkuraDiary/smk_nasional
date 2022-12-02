namespace studikasus_smk_nasional
{
    partial class MainMenuForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menuAnggotaFragment = new studikasus_smk_nasional.MenuAnggota();
            this.menuAdminFragment = new studikasus_smk_nasional.MenuAdmin();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.menuAnggotaFragment);
            this.panelContainer.Controls.Add(this.menuAdminFragment);
            this.panelContainer.Location = new System.Drawing.Point(12, 72);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(776, 387);
            this.panelContainer.TabIndex = 0;
            // 
            // menuAnggotaFragment
            // 
            this.menuAnggotaFragment.Location = new System.Drawing.Point(3, 3);
            this.menuAnggotaFragment.Name = "menuAnggotaFragment";
            this.menuAnggotaFragment.Size = new System.Drawing.Size(776, 384);
            this.menuAnggotaFragment.TabIndex = 0;
            // 
            // menuAdminFragment
            // 
            this.menuAdminFragment.Location = new System.Drawing.Point(3, 393);
            this.menuAdminFragment.Name = "menuAdminFragment";
            this.menuAdminFragment.Size = new System.Drawing.Size(776, 378);
            this.menuAdminFragment.TabIndex = 1;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelWelcome.Location = new System.Drawing.Point(13, 9);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(253, 48);
            this.labelWelcome.TabIndex = 42;
            this.labelWelcome.Text = "Selamat Datang ";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panelContainer);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel panelContainer;
        private Label labelWelcome;
        private MenuAnggota menuAnggotaFragment;
        private MenuAdmin menuAdminFragment;
    }
}
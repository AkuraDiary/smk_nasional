namespace studikasus_smk_nasional
{
    partial class LoginForm
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
            this.captchaReset = new System.Windows.Forms.Button();
            this.captchaLabel = new System.Windows.Forms.Label();
            this.edtCaptcha = new System.Windows.Forms.TextBox();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.edtPass = new System.Windows.Forms.TextBox();
            this.edtUsername = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // captchaReset
            // 
            this.captchaReset.BackColor = System.Drawing.Color.SteelBlue;
            this.captchaReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captchaReset.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.captchaReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.captchaReset.Location = new System.Drawing.Point(216, 277);
            this.captchaReset.Margin = new System.Windows.Forms.Padding(4);
            this.captchaReset.Name = "captchaReset";
            this.captchaReset.Size = new System.Drawing.Size(68, 34);
            this.captchaReset.TabIndex = 40;
            this.captchaReset.Text = "Reset";
            this.captchaReset.UseVisualStyleBackColor = false;
            this.captchaReset.Click += new System.EventHandler(this.captchaReset_Click);
            // 
            // captchaLabel
            // 
            this.captchaLabel.AutoSize = true;
            this.captchaLabel.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.captchaLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.captchaLabel.Location = new System.Drawing.Point(66, 233);
            this.captchaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.captchaLabel.Name = "captchaLabel";
            this.captchaLabel.Size = new System.Drawing.Size(124, 42);
            this.captchaLabel.TabIndex = 39;
            this.captchaLabel.Text = "Captcha";
            this.captchaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtCaptcha
            // 
            this.edtCaptcha.Location = new System.Drawing.Point(66, 279);
            this.edtCaptcha.Margin = new System.Windows.Forms.Padding(4);
            this.edtCaptcha.Name = "edtCaptcha";
            this.edtCaptcha.Size = new System.Drawing.Size(142, 27);
            this.edtCaptcha.TabIndex = 38;
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCaptcha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCaptcha.Location = new System.Drawing.Point(66, 310);
            this.labelCaptcha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(135, 22);
            this.labelCaptcha.TabIndex = 37;
            this.labelCaptcha.Text = "Please Enter Captcha";
            this.labelCaptcha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtPass
            // 
            this.edtPass.Location = new System.Drawing.Point(66, 187);
            this.edtPass.Margin = new System.Windows.Forms.Padding(4);
            this.edtPass.Name = "edtPass";
            this.edtPass.Size = new System.Drawing.Size(218, 27);
            this.edtPass.TabIndex = 36;
            this.edtPass.UseSystemPasswordChar = true;
            // 
            // edtUsername
            // 
            this.edtUsername.Location = new System.Drawing.Point(66, 110);
            this.edtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.Size = new System.Drawing.Size(218, 27);
            this.edtUsername.TabIndex = 35;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPass.Location = new System.Drawing.Point(66, 157);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(85, 26);
            this.labelPass.TabIndex = 34;
            this.labelPass.Text = "Password";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelUsername.Location = new System.Drawing.Point(66, 80);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(89, 26);
            this.labelUsername.TabIndex = 33;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(236, 463);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 31);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Tutup Aplikasi";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLogin.Location = new System.Drawing.Point(66, 366);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(218, 45);
            this.btnLogin.TabIndex = 31;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(87, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 48);
            this.label1.TabIndex = 41;
            this.label1.Text = "LOGIN USER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 507);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captchaReset);
            this.Controls.Add(this.captchaLabel);
            this.Controls.Add(this.edtCaptcha);
            this.Controls.Add(this.labelCaptcha);
            this.Controls.Add(this.edtPass);
            this.Controls.Add(this.edtUsername);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button captchaReset;
        private Label captchaLabel;
        private TextBox edtCaptcha;
        private Label labelCaptcha;
        private TextBox edtPass;
        private TextBox edtUsername;
        private Label labelPass;
        private Label labelUsername;
        private Button btnClose;
        private Button btnLogin;
        private Label label1;
    }
}
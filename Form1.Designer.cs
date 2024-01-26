namespace Ola_App
{
    partial class OaApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label UserName;
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OaApp));
            BtnLogin = new Button();
            TxtUserName = new TextBox();
            TxtPassword = new TextBox();
            UserName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserName.BackColor = SystemColors.Highlight;
            UserName.BorderStyle = BorderStyle.Fixed3D;
            UserName.Enabled = false;
            UserName.ForeColor = SystemColors.ButtonHighlight;
            UserName.Location = new Point(206, 142);
            UserName.Name = "UserName";
            UserName.Padding = new Padding(2);
            UserName.Size = new Size(103, 28);
            UserName.TabIndex = 1;
            UserName.Text = "UserName :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.Highlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Enabled = false;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(206, 194);
            label1.Name = "label1";
            label1.Padding = new Padding(2);
            label1.Size = new Size(94, 28);
            label1.TabIndex = 2;
            label1.Text = "Password :";
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnLogin.Location = new Point(373, 330);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(198, 44);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TxtUserName
            // 
            TxtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtUserName.Location = new Point(373, 143);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.PlaceholderText = "Username";
            TxtUserName.Size = new Size(198, 25);
            TxtUserName.TabIndex = 3;
            TxtUserName.TextAlign = HorizontalAlignment.Center;
            TxtUserName.TextChanged += TxtUserName_TextChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.Location = new Point(373, 194);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.PlaceholderText = "Password";
            TxtPassword.Size = new Size(198, 25);
            TxtPassword.TabIndex = 4;
            TxtPassword.TextAlign = HorizontalAlignment.Center;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // OaApp
            // 
            AccessibleDescription = "This App Is A Demo App or Virtual app that is usedd to measure distance between a driver and a cabUser and give a suitable amount that is used for measuring";
            AccessibleName = "OlamApp";
            AccessibleRole = AccessibleRole.Application;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.android_chrome_192x192;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(849, 450);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserName);
            Controls.Add(label1);
            Controls.Add(UserName);
            Controls.Add(BtnLogin);
            DoubleBuffered = true;
            Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OaApp";
            Padding = new Padding(3);
            Text = "Ola";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLogin;
        private TextBox TxtUserName;
        private TextBox TxtPassword;
    }
}

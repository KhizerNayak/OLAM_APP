namespace Ola_App
{
    partial class HomeOlam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeOlam));
            BtnMeasure = new Button();
            LblEntry = new Label();
            LblExit = new Label();
            TxtPickup = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // BtnMeasure
            // 
            BtnMeasure.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnMeasure.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnMeasure.BackColor = SystemColors.ActiveCaption;
            BtnMeasure.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            BtnMeasure.FlatAppearance.BorderSize = 3;
            BtnMeasure.Location = new Point(372, 340);
            BtnMeasure.Name = "BtnMeasure";
            BtnMeasure.Padding = new Padding(2);
            BtnMeasure.Size = new Size(138, 29);
            BtnMeasure.TabIndex = 0;
            BtnMeasure.Text = "Measure";
            BtnMeasure.UseVisualStyleBackColor = false;
            BtnMeasure.Click += BtnMeasure_Click;
            // 
            // LblEntry
            // 
            LblEntry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEntry.BackColor = SystemColors.Highlight;
            LblEntry.BorderStyle = BorderStyle.Fixed3D;
            LblEntry.Location = new Point(179, 139);
            LblEntry.Name = "LblEntry";
            LblEntry.Padding = new Padding(2);
            LblEntry.Size = new Size(83, 27);
            LblEntry.TabIndex = 1;
            LblEntry.Text = "Pickup :";
            LblEntry.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblExit
            // 
            LblExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblExit.BackColor = SystemColors.Highlight;
            LblExit.BorderStyle = BorderStyle.Fixed3D;
            LblExit.Location = new Point(179, 206);
            LblExit.Name = "LblExit";
            LblExit.Padding = new Padding(2);
            LblExit.Size = new Size(83, 27);
            LblExit.TabIndex = 2;
            LblExit.Text = "Drop :";
            LblExit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPickup
            // 
            TxtPickup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPickup.CausesValidation = false;
            TxtPickup.Location = new Point(336, 141);
            TxtPickup.Name = "TxtPickup";
            TxtPickup.PlaceholderText = "Pickup";
            TxtPickup.Size = new Size(180, 27);
            TxtPickup.TabIndex = 3;
            TxtPickup.TextAlign = HorizontalAlignment.Center;
            TxtPickup.TextChanged += TxtPickup_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.CausesValidation = false;
            textBox1.Location = new Point(336, 206);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Drop";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(5, 5);
            button1.Name = "button1";
            button1.Padding = new Padding(2);
            button1.Size = new Size(28, 29);
            button1.TabIndex = 5;
            button1.Text = "<";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HomeOlam
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.android_chrome_192x192;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(TxtPickup);
            Controls.Add(LblExit);
            Controls.Add(LblEntry);
            Controls.Add(BtnMeasure);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeOlam";
            Padding = new Padding(2);
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMeasure;
        private Label LblEntry;
        private Label LblExit;
        private TextBox TxtPickup;
        private TextBox textBox1;
        private Button button1;
    }
}
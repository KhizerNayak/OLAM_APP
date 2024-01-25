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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OaApp));
            SuspendLayout();
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
            ClientSize = new Size(808, 450);
            DoubleBuffered = true;
            Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OaApp";
            Padding = new Padding(3);
            Text = "Ola";
            ResumeLayout(false);
        }

        #endregion
    }
}

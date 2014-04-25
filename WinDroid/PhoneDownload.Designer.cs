namespace WinDroid
{
    partial class PhoneDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneDownload));
            this.soffProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.mainLabel = new MetroFramework.Controls.MetroLabel();
            this.installApp = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // soffProgressBar
            // 
            this.soffProgressBar.HideProgressText = false;
            this.soffProgressBar.Location = new System.Drawing.Point(23, 55);
            this.soffProgressBar.Name = "soffProgressBar";
            this.soffProgressBar.Size = new System.Drawing.Size(156, 23);
            this.soffProgressBar.TabIndex = 3;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainLabel.Location = new System.Drawing.Point(18, 25);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(167, 19);
            this.mainLabel.TabIndex = 4;
            this.mainLabel.Text = "Downloading Recoveries...";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // installApp
            // 
            this.installApp.WorkerSupportsCancellation = true;
            this.installApp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.installApp_DoWork);
            // 
            // PhoneDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 101);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.soffProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhoneDownload";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PhoneDownload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroProgressBar soffProgressBar;
        public MetroFramework.Controls.MetroLabel mainLabel;
        private System.ComponentModel.BackgroundWorker installApp;
    }
}
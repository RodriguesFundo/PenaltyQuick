namespace PenaltyQuick.Views
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.startLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // startLink
            // 
            this.startLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.startLink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(61)))));
            this.startLink.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLink.ForeColor = System.Drawing.Color.White;
            this.startLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.startLink.LinkColor = System.Drawing.Color.FloralWhite;
            this.startLink.Location = new System.Drawing.Point(336, 89);
            this.startLink.Name = "startLink";
            this.startLink.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startLink.Size = new System.Drawing.Size(128, 48);
            this.startLink.TabIndex = 0;
            this.startLink.TabStop = true;
            this.startLink.Text = "Start";
            this.startLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startLink.VisitedLinkColor = System.Drawing.Color.White;
            this.startLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startLink_LinkClicked);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startLink);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel startLink;
    }
}
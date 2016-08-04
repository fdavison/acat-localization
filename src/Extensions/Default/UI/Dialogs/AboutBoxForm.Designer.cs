namespace ACAT.Extensions.Default.UI.Dialogs
{
    partial class AboutBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBoxForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxOtherInfo = new System.Windows.Forms.TextBox();
            this.labelCopyrightInfo = new System.Windows.Forms.Label();
            this.labelVersionInfo = new System.Windows.Forms.Label();
            this.labelUserProfileInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelAppTitle
            // 
            resources.ApplyResources(this.labelAppTitle, "labelAppTitle");
            this.labelAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAppTitle.ForeColor = System.Drawing.Color.Black;
            this.labelAppTitle.Name = "labelAppTitle";
            // 
            // pictureBoxLogo
            // 
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxOtherInfo
            // 
            resources.ApplyResources(this.textBoxOtherInfo, "textBoxOtherInfo");
            this.textBoxOtherInfo.BackColor = System.Drawing.Color.White;
            this.textBoxOtherInfo.Name = "textBoxOtherInfo";
            this.textBoxOtherInfo.ReadOnly = true;
            this.textBoxOtherInfo.TabStop = false;
            // 
            // labelCopyrightInfo
            // 
            resources.ApplyResources(this.labelCopyrightInfo, "labelCopyrightInfo");
            this.labelCopyrightInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyrightInfo.ForeColor = System.Drawing.Color.Black;
            this.labelCopyrightInfo.Name = "labelCopyrightInfo";
            // 
            // labelVersionInfo
            // 
            resources.ApplyResources(this.labelVersionInfo, "labelVersionInfo");
            this.labelVersionInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelVersionInfo.ForeColor = System.Drawing.Color.Black;
            this.labelVersionInfo.Name = "labelVersionInfo";
            // 
            // labelUserProfileInfo
            // 
            resources.ApplyResources(this.labelUserProfileInfo, "labelUserProfileInfo");
            this.labelUserProfileInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelUserProfileInfo.ForeColor = System.Drawing.Color.Black;
            this.labelUserProfileInfo.Name = "labelUserProfileInfo";
            // 
            // AboutBoxForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.labelUserProfileInfo);
            this.Controls.Add(this.labelVersionInfo);
            this.Controls.Add(this.labelCopyrightInfo);
            this.Controls.Add(this.textBoxOtherInfo);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelAppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AboutBoxForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxOtherInfo;
        private System.Windows.Forms.Label labelCopyrightInfo;
        private System.Windows.Forms.Label labelVersionInfo;
        private System.Windows.Forms.Label labelUserProfileInfo;

    }
}
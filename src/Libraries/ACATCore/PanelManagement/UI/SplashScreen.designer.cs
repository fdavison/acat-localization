namespace ACAT.Lib.Core.PanelManagement
{
    partial class SplashScreen 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.splashPictureBox = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.intelLogo = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashPictureBox
            // 
            resources.ApplyResources(this.splashPictureBox, "splashPictureBox");
            this.splashPictureBox.Name = "splashPictureBox";
            this.splashPictureBox.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Splash1.png");
            this.imageList.Images.SetKeyName(1, "Splash2.png");
            this.imageList.Images.SetKeyName(2, "Splash3.png");
            this.imageList.Images.SetKeyName(3, "Splash4.png");
            this.imageList.Images.SetKeyName(4, "Splash5.png");
            // 
            // intelLogo
            // 
            this.intelLogo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.intelLogo, "intelLogo");
            this.intelLogo.Name = "intelLogo";
            this.intelLogo.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.line3, "line3");
            this.line3.Name = "line3";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.line2, "line2");
            this.line2.Name = "line2";
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBoxStatus, "pictureBoxStatus");
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.BackgroundImage = global::ACAT.Lib.Core.Properties.Resources.SplashScreenBg;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.pictureBoxStatus);
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.line3);
            this.panel1.Controls.Add(this.intelLogo);
            this.panel1.Name = "panel1";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.line1, "line1");
            this.line1.Name = "line1";
            // 
            // SplashScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.splashPictureBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox splashPictureBox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox intelLogo;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label line1;
    }
}


using System.Windows.Forms;

namespace ACAT.Extensions.Default.UI.Dialogs
{
    partial class ResizeScannerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizeScannerForm));
            this.lblBack = new System.Windows.Forms.Button();
            this.lblIncrease = new System.Windows.Forms.Button();
            this.lblDecrease = new System.Windows.Forms.Button();
            this.lblMove = new System.Windows.Forms.Button();
            this.lblDefault = new System.Windows.Forms.Button();
            this.labelToolTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            resources.ApplyResources(this.lblBack, "lblBack");
            this.lblBack.Name = "lblBack";
            this.lblBack.TabStop = false;
            this.lblBack.UseVisualStyleBackColor = true;
            // 
            // lblIncrease
            // 
            resources.ApplyResources(this.lblIncrease, "lblIncrease");
            this.lblIncrease.Name = "lblIncrease";
            this.lblIncrease.TabStop = false;
            this.lblIncrease.UseVisualStyleBackColor = true;
            // 
            // lblDecrease
            // 
            resources.ApplyResources(this.lblDecrease, "lblDecrease");
            this.lblDecrease.Name = "lblDecrease";
            this.lblDecrease.TabStop = false;
            this.lblDecrease.UseVisualStyleBackColor = true;
            // 
            // lblMove
            // 
            resources.ApplyResources(this.lblMove, "lblMove");
            this.lblMove.Name = "lblMove";
            this.lblMove.TabStop = false;
            this.lblMove.UseVisualStyleBackColor = true;
            // 
            // lblDefault
            // 
            resources.ApplyResources(this.lblDefault, "lblDefault");
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.TabStop = false;
            this.lblDefault.UseVisualStyleBackColor = true;
            // 
            // labelToolTip
            // 
            resources.ApplyResources(this.labelToolTip, "labelToolTip");
            this.labelToolTip.Name = "labelToolTip";
            // 
            // ResizeScannerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblIncrease);
            this.Controls.Add(this.lblDecrease);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.lblDefault);
            this.Controls.Add(this.labelToolTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResizeScannerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button lblBack;
        private Button lblIncrease;
        private Button lblDecrease;
        private Button lblMove;
        private Button lblDefault;
        private Label labelToolTip;

    }
}
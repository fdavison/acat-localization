namespace ACAT.Lib.Core.ActuatorManagement
{
    partial class CalibrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationForm));
            this.labelPrompt = new System.Windows.Forms.Label();
            this.buttonConfigure = new System.Windows.Forms.Button();
            this.labelCaption = new System.Windows.Forms.Label();
            this.labelTimePrompt = new System.Windows.Forms.Label();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.BorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            resources.ApplyResources(this.labelPrompt, "labelPrompt");
            this.labelPrompt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelPrompt.ForeColor = System.Drawing.Color.Red;
            this.labelPrompt.Name = "labelPrompt";
            // 
            // buttonConfigure
            // 
            resources.ApplyResources(this.buttonConfigure, "buttonConfigure");
            this.buttonConfigure.Name = "buttonConfigure";
            this.buttonConfigure.UseVisualStyleBackColor = true;
            this.buttonConfigure.Click += new System.EventHandler(this.buttonConfigure_Click);
            // 
            // labelCaption
            // 
            resources.ApplyResources(this.labelCaption, "labelCaption");
            this.labelCaption.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelCaption.Name = "labelCaption";
            // 
            // labelTimePrompt
            // 
            resources.ApplyResources(this.labelTimePrompt, "labelTimePrompt");
            this.labelTimePrompt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelTimePrompt.Name = "labelTimePrompt";
            // 
            // BorderPanel
            // 
            resources.ApplyResources(this.BorderPanel, "BorderPanel");
            this.BorderPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BorderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderPanel.Controls.Add(this.buttonConfigure);
            this.BorderPanel.Name = "BorderPanel";
            // 
            // CalibrationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ControlBox = false;
            this.Controls.Add(this.labelTimePrompt);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.BorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalibrationForm";
            this.BorderPanel.ResumeLayout(false);
            this.BorderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button buttonConfigure;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Label labelTimePrompt;
        private System.Windows.Forms.Panel BorderPanel;
    }
}


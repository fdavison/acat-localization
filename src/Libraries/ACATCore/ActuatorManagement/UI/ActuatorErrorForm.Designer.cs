namespace ACAT.Lib.Core.ActuatorManagement
{
    partial class ActuatorErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActuatorErrorForm));
            this.labelPrompt = new System.Windows.Forms.Label();
            this.buttonConfigure = new System.Windows.Forms.Button();
            this.labelCaption = new System.Windows.Forms.Label();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.BorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            resources.ApplyResources(this.labelPrompt, "labelPrompt");
            this.labelPrompt.BackColor = System.Drawing.Color.White;
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
            this.labelCaption.BackColor = System.Drawing.Color.White;
            this.labelCaption.Name = "labelCaption";
            // 
            // BorderPanel
            // 
            resources.ApplyResources(this.BorderPanel, "BorderPanel");
            this.BorderPanel.BackColor = System.Drawing.Color.White;
            this.BorderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderPanel.Controls.Add(this.buttonOK);
            this.BorderPanel.Controls.Add(this.buttonConfigure);
            this.BorderPanel.Name = "BorderPanel";
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // ActuatorErrorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.BorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActuatorErrorForm";
            this.BorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button buttonConfigure;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Button buttonOK;
    }
}


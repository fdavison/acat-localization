namespace ACAT.Extensions.Default.FunctionalAgents.AbbreviationsAgent
{
    // TODO see if we should make a base class to encapsulate these three inherited classes/interfaces
    partial class AbbreviationEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbbreviationEditorForm));
            this.lblExpansion = new System.Windows.Forms.Label();
            this.tbExpansion = new System.Windows.Forms.TextBox();
            this.lblSpoken = new System.Windows.Forms.Label();
            this.lblFinished = new System.Windows.Forms.Button();
            this.lblAbbreviation = new System.Windows.Forms.Label();
            this.boxType = new System.Windows.Forms.Panel();
            this.lblWritten = new System.Windows.Forms.Label();
            this.pbTypeSpoken = new System.Windows.Forms.Label();
            this.pbTypeWritten = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.tbAbbreviation = new System.Windows.Forms.TextBox();
            this.lblCancel = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExpansion
            // 
            resources.ApplyResources(this.lblExpansion, "lblExpansion");
            this.lblExpansion.Name = "lblExpansion";
            // 
            // tbExpansion
            // 
            resources.ApplyResources(this.tbExpansion, "tbExpansion");
            this.tbExpansion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbExpansion.Name = "tbExpansion";
            // 
            // lblSpoken
            // 
            resources.ApplyResources(this.lblSpoken, "lblSpoken");
            this.lblSpoken.Name = "lblSpoken";
            // 
            // lblFinished
            // 
            resources.ApplyResources(this.lblFinished, "lblFinished");
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.TabStop = false;
            this.lblFinished.UseVisualStyleBackColor = true;
            // 
            // lblAbbreviation
            // 
            resources.ApplyResources(this.lblAbbreviation, "lblAbbreviation");
            this.lblAbbreviation.Name = "lblAbbreviation";
            // 
            // boxType
            // 
            resources.ApplyResources(this.boxType, "boxType");
            this.boxType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxType.Controls.Add(this.lblSpoken);
            this.boxType.Controls.Add(this.lblWritten);
            this.boxType.Controls.Add(this.pbTypeSpoken);
            this.boxType.Controls.Add(this.pbTypeWritten);
            this.boxType.Name = "boxType";
            // 
            // lblWritten
            // 
            resources.ApplyResources(this.lblWritten, "lblWritten");
            this.lblWritten.Name = "lblWritten";
            // 
            // pbTypeSpoken
            // 
            resources.ApplyResources(this.pbTypeSpoken, "pbTypeSpoken");
            this.pbTypeSpoken.Name = "pbTypeSpoken";
            // 
            // pbTypeWritten
            // 
            resources.ApplyResources(this.pbTypeWritten, "pbTypeWritten");
            this.pbTypeWritten.Name = "pbTypeWritten";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // tbAbbreviation
            // 
            resources.ApplyResources(this.tbAbbreviation, "tbAbbreviation");
            this.tbAbbreviation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAbbreviation.Name = "tbAbbreviation";
            // 
            // lblCancel
            // 
            resources.ApplyResources(this.lblCancel, "lblCancel");
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.TabStop = false;
            this.lblCancel.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.lblAbbreviation);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.tbAbbreviation);
            this.groupBox1.Controls.Add(this.boxType);
            this.groupBox1.Controls.Add(this.tbExpansion);
            this.groupBox1.Controls.Add(this.lblExpansion);
            this.groupBox1.Controls.Add(this.lblFinished);
            this.groupBox1.Controls.Add(this.lblCancel);
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AbbreviationEditorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AbbreviationEditorForm";
            this.boxType.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExpansion;
        private System.Windows.Forms.TextBox tbExpansion;
        private System.Windows.Forms.Label lblSpoken;
        private System.Windows.Forms.Button lblFinished;
        private System.Windows.Forms.Label lblAbbreviation;
        private System.Windows.Forms.Panel boxType;
        private System.Windows.Forms.Label lblWritten;
        private System.Windows.Forms.Label pbTypeSpoken;
        private System.Windows.Forms.Label pbTypeWritten;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbAbbreviation;
        private System.Windows.Forms.Button lblCancel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}
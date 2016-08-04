namespace ACAT.Extensions.Default.UI.Dialogs
{
    partial class ACATTryoutForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACATTryoutForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.labelSteppingTimeValue = new System.Windows.Forms.ToolStripLabel();
            this.buttonSteppingTimeIncrease = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSteppingTimeDecrease = new System.Windows.Forms.ToolStripButton();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.labelTryWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEntry = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.labelTryWord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxEntry);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonBackspace);
            this.panel1.Controls.Add(this.B4);
            this.panel1.Controls.Add(this.B3);
            this.panel1.Controls.Add(this.B2);
            this.panel1.Controls.Add(this.B1);
            this.panel1.Name = "panel1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.Color.OldLace;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.labelSteppingTimeValue,
            this.buttonSteppingTimeIncrease,
            this.toolStripSeparator1,
            this.buttonSteppingTimeDecrease,
            this.buttonSave});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Name = "toolStripLabel1";
            // 
            // labelSteppingTimeValue
            // 
            resources.ApplyResources(this.labelSteppingTimeValue, "labelSteppingTimeValue");
            this.labelSteppingTimeValue.Name = "labelSteppingTimeValue";
            // 
            // buttonSteppingTimeIncrease
            // 
            resources.ApplyResources(this.buttonSteppingTimeIncrease, "buttonSteppingTimeIncrease");
            this.buttonSteppingTimeIncrease.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSteppingTimeIncrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSteppingTimeIncrease.Name = "buttonSteppingTimeIncrease";
            this.buttonSteppingTimeIncrease.Click += new System.EventHandler(this.buttonSteppingTimeIncrease_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // buttonSteppingTimeDecrease
            // 
            resources.ApplyResources(this.buttonSteppingTimeDecrease, "buttonSteppingTimeDecrease");
            this.buttonSteppingTimeDecrease.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSteppingTimeDecrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSteppingTimeDecrease.Name = "buttonSteppingTimeDecrease";
            this.buttonSteppingTimeDecrease.Click += new System.EventHandler(this.buttonSteppingTimeDecrease_Click);
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonSave.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTryWord
            // 
            resources.ApplyResources(this.labelTryWord, "labelTryWord");
            this.labelTryWord.ForeColor = System.Drawing.Color.Red;
            this.labelTryWord.Name = "labelTryWord";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxEntry
            // 
            resources.ApplyResources(this.textBoxEntry, "textBoxEntry");
            this.textBoxEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.ReadOnly = true;
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.TabStop = false;
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.TabStop = false;
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonBackspace
            // 
            resources.ApplyResources(this.buttonBackspace, "buttonBackspace");
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.TabStop = false;
            this.buttonBackspace.UseVisualStyleBackColor = true;
            // 
            // B4
            // 
            resources.ApplyResources(this.B4, "B4");
            this.B4.Name = "B4";
            this.B4.TabStop = false;
            this.B4.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            resources.ApplyResources(this.B3, "B3");
            this.B3.Name = "B3";
            this.B3.TabStop = false;
            this.B3.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            resources.ApplyResources(this.B2, "B2");
            this.B2.Name = "B2";
            this.B2.TabStop = false;
            this.B2.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            resources.ApplyResources(this.B1, "B1");
            this.B1.Name = "B1";
            this.B1.TabStop = false;
            this.B1.UseVisualStyleBackColor = true;
            // 
            // ACATTryoutForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ACATTryoutForm";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTryWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEntry;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel labelSteppingTimeValue;
        private System.Windows.Forms.ToolStripButton buttonSteppingTimeIncrease;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonSteppingTimeDecrease;
        private System.Windows.Forms.ToolStripButton buttonSave;


    }
}


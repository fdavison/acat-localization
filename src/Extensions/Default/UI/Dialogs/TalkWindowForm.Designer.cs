namespace ACAT.Extensions.Default.UI.Dialogs
{
    partial class TalkWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkWindowForm));
            this.textBox = new System.Windows.Forms.TextBox();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelIcon = new System.Windows.Forms.ToolStripLabel();
            this.labelVolumeLevel = new System.Windows.Forms.Label();
            this.labelSpeaker = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.BorderPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.BackColor = System.Drawing.Color.Black;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Name = "textBox";
            this.textBox.TabStop = false;
            // 
            // BorderPanel
            // 
            resources.ApplyResources(this.BorderPanel, "BorderPanel");
            this.BorderPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BorderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderPanel.Controls.Add(this.toolStrip1);
            this.BorderPanel.Controls.Add(this.labelVolumeLevel);
            this.BorderPanel.Controls.Add(this.labelSpeaker);
            this.BorderPanel.Controls.Add(this.trackBarVolume);
            this.BorderPanel.Name = "BorderPanel";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClear,
            this.toolStripSeparator1,
            this.toolStripLabelDate,
            this.toolStripLabel1,
            this.toolStripLabelIcon});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButtonClear
            // 
            resources.ApplyResources(this.toolStripButtonClear, "toolStripButtonClear");
            this.toolStripButtonClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClear.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripLabelDate
            // 
            resources.ApplyResources(this.toolStripLabelDate, "toolStripLabelDate");
            this.toolStripLabelDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelDate.Name = "toolStripLabelDate";
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Name = "toolStripLabel1";
            // 
            // toolStripLabelIcon
            // 
            resources.ApplyResources(this.toolStripLabelIcon, "toolStripLabelIcon");
            this.toolStripLabelIcon.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabelIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabelIcon.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripLabelIcon.Name = "toolStripLabelIcon";
            // 
            // labelVolumeLevel
            // 
            resources.ApplyResources(this.labelVolumeLevel, "labelVolumeLevel");
            this.labelVolumeLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelVolumeLevel.ForeColor = System.Drawing.Color.Black;
            this.labelVolumeLevel.Name = "labelVolumeLevel";
            // 
            // labelSpeaker
            // 
            resources.ApplyResources(this.labelSpeaker, "labelSpeaker");
            this.labelSpeaker.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeaker.ForeColor = System.Drawing.Color.Black;
            this.labelSpeaker.Name = "labelSpeaker";
            // 
            // trackBarVolume
            // 
            resources.ApplyResources(this.trackBarVolume, "trackBarVolume");
            this.trackBarVolume.LargeChange = 3;
            this.trackBarVolume.Maximum = 9;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.TabStop = false;
            this.trackBarVolume.TickFrequency = 3;
            // 
            // TalkWindowForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.BorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TalkWindowForm";
            this.TopMost = true;
            this.BorderPanel.ResumeLayout(false);
            this.BorderPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelSpeaker;
        private System.Windows.Forms.Label labelVolumeLevel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelIcon;


    }
}
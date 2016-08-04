namespace ACAT.Extensions.Default.UI.Dialogs
{
    partial class WordPredictionSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordPredictionSettingsForm));
            this.svalWordCount = new System.Windows.Forms.Label();
            this.ltbWordCountLess = new System.Windows.Forms.Label();
            this.lblUseCorpus = new System.Windows.Forms.Label();
            this.lblDynamicLearning = new System.Windows.Forms.Label();
            this.ltbWordCountMore = new System.Windows.Forms.Label();
            this.tbWordCount = new System.Windows.Forms.TrackBar();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblRestoreDefaults = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Button();
            this.lblOK = new System.Windows.Forms.Button();
            this.sminWordCount = new System.Windows.Forms.Label();
            this.smaxWordCount = new System.Windows.Forms.Label();
            this.pbDynamicLearning = new System.Windows.Forms.Label();
            this.pbUseCorpus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbWordCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // svalWordCount
            // 
            resources.ApplyResources(this.svalWordCount, "svalWordCount");
            this.svalWordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.svalWordCount.Name = "svalWordCount";
            // 
            // ltbWordCountLess
            // 
            resources.ApplyResources(this.ltbWordCountLess, "ltbWordCountLess");
            this.ltbWordCountLess.BackColor = System.Drawing.Color.Transparent;
            this.ltbWordCountLess.Name = "ltbWordCountLess";
            // 
            // lblUseCorpus
            // 
            resources.ApplyResources(this.lblUseCorpus, "lblUseCorpus");
            this.lblUseCorpus.Name = "lblUseCorpus";
            // 
            // lblDynamicLearning
            // 
            resources.ApplyResources(this.lblDynamicLearning, "lblDynamicLearning");
            this.lblDynamicLearning.Name = "lblDynamicLearning";
            // 
            // ltbWordCountMore
            // 
            resources.ApplyResources(this.ltbWordCountMore, "ltbWordCountMore");
            this.ltbWordCountMore.BackColor = System.Drawing.Color.Transparent;
            this.ltbWordCountMore.Name = "ltbWordCountMore";
            // 
            // tbWordCount
            // 
            resources.ApplyResources(this.tbWordCount, "tbWordCount");
            this.tbWordCount.Name = "tbWordCount";
            this.tbWordCount.TabStop = false;
            // 
            // lblWordCount
            // 
            resources.ApplyResources(this.lblWordCount, "lblWordCount");
            this.lblWordCount.Name = "lblWordCount";
            // 
            // lblRestoreDefaults
            // 
            resources.ApplyResources(this.lblRestoreDefaults, "lblRestoreDefaults");
            this.lblRestoreDefaults.BackColor = System.Drawing.SystemColors.Control;
            this.lblRestoreDefaults.Name = "lblRestoreDefaults";
            this.lblRestoreDefaults.TabStop = false;
            this.lblRestoreDefaults.UseVisualStyleBackColor = false;
            // 
            // lblBack
            // 
            resources.ApplyResources(this.lblBack, "lblBack");
            this.lblBack.BackColor = System.Drawing.SystemColors.Control;
            this.lblBack.Name = "lblBack";
            this.lblBack.TabStop = false;
            this.lblBack.UseVisualStyleBackColor = false;
            // 
            // lblOK
            // 
            resources.ApplyResources(this.lblOK, "lblOK");
            this.lblOK.BackColor = System.Drawing.SystemColors.Control;
            this.lblOK.Name = "lblOK";
            this.lblOK.TabStop = false;
            this.lblOK.UseVisualStyleBackColor = false;
            // 
            // sminWordCount
            // 
            resources.ApplyResources(this.sminWordCount, "sminWordCount");
            this.sminWordCount.Name = "sminWordCount";
            // 
            // smaxWordCount
            // 
            resources.ApplyResources(this.smaxWordCount, "smaxWordCount");
            this.smaxWordCount.Name = "smaxWordCount";
            // 
            // pbDynamicLearning
            // 
            resources.ApplyResources(this.pbDynamicLearning, "pbDynamicLearning");
            this.pbDynamicLearning.Name = "pbDynamicLearning";
            // 
            // pbUseCorpus
            // 
            resources.ApplyResources(this.pbUseCorpus, "pbUseCorpus");
            this.pbUseCorpus.Name = "pbUseCorpus";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.smaxWordCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sminWordCount);
            this.groupBox1.Controls.Add(this.tbWordCount);
            this.groupBox1.Controls.Add(this.svalWordCount);
            this.groupBox1.Controls.Add(this.ltbWordCountMore);
            this.groupBox1.Controls.Add(this.ltbWordCountLess);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // WordPredictionSettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblRestoreDefaults);
            this.Controls.Add(this.lblUseCorpus);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblDynamicLearning);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pbUseCorpus);
            this.Controls.Add(this.lblOK);
            this.Controls.Add(this.pbDynamicLearning);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WordPredictionSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbWordCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltbWordCountMore;
        private System.Windows.Forms.TrackBar tbWordCount;
        private System.Windows.Forms.Label ltbWordCountLess;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label sminWordCount;
        private System.Windows.Forms.Label smaxWordCount;
        private System.Windows.Forms.Label lblDynamicLearning;
        private System.Windows.Forms.Label pbDynamicLearning;
        private System.Windows.Forms.Label lblUseCorpus;
        private System.Windows.Forms.Label pbUseCorpus;
        private System.Windows.Forms.Label svalWordCount;
        private System.Windows.Forms.Button lblRestoreDefaults;
        private System.Windows.Forms.Button lblBack;
        private System.Windows.Forms.Button lblOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


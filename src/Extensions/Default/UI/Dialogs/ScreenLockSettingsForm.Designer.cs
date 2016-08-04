using System.Windows.Forms;

namespace ACAT.Extensions.Default.UI.Dialogs
{
    // TODO see if we should make a base class to encapsulate these three inherited classes/interfaces
    partial class ScreenLockSettingsForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenLockSettingsForm));
            this.lblCancel = new System.Windows.Forms.Button();
            this.lblOK = new System.Windows.Forms.Button();
            this.svalMaxDigit = new System.Windows.Forms.Label();
            this.ltbMaxDigitLess = new System.Windows.Forms.Label();
            this.lblPINCode = new System.Windows.Forms.Label();
            this.smaxMaxDigit = new System.Windows.Forms.Label();
            this.ltbMaxDigitMore = new System.Windows.Forms.Label();
            this.tbMaxDigit = new System.Windows.Forms.TrackBar();
            this.sminMaxDigit = new System.Windows.Forms.Label();
            this.lblMaxDigit = new System.Windows.Forms.Label();
            this.tbPINCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxDigit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCancel
            // 
            resources.ApplyResources(this.lblCancel, "lblCancel");
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.TabStop = false;
            this.lblCancel.UseVisualStyleBackColor = true;
            // 
            // lblOK
            // 
            resources.ApplyResources(this.lblOK, "lblOK");
            this.lblOK.Name = "lblOK";
            this.lblOK.TabStop = false;
            this.lblOK.UseVisualStyleBackColor = true;
            // 
            // svalMaxDigit
            // 
            resources.ApplyResources(this.svalMaxDigit, "svalMaxDigit");
            this.svalMaxDigit.Name = "svalMaxDigit";
            // 
            // ltbMaxDigitLess
            // 
            resources.ApplyResources(this.ltbMaxDigitLess, "ltbMaxDigitLess");
            this.ltbMaxDigitLess.BackColor = System.Drawing.Color.Transparent;
            this.ltbMaxDigitLess.Name = "ltbMaxDigitLess";
            // 
            // lblPINCode
            // 
            resources.ApplyResources(this.lblPINCode, "lblPINCode");
            this.lblPINCode.Name = "lblPINCode";
            // 
            // smaxMaxDigit
            // 
            resources.ApplyResources(this.smaxMaxDigit, "smaxMaxDigit");
            this.smaxMaxDigit.Name = "smaxMaxDigit";
            // 
            // ltbMaxDigitMore
            // 
            resources.ApplyResources(this.ltbMaxDigitMore, "ltbMaxDigitMore");
            this.ltbMaxDigitMore.BackColor = System.Drawing.Color.Transparent;
            this.ltbMaxDigitMore.Name = "ltbMaxDigitMore";
            // 
            // tbMaxDigit
            // 
            resources.ApplyResources(this.tbMaxDigit, "tbMaxDigit");
            this.tbMaxDigit.Name = "tbMaxDigit";
            this.tbMaxDigit.TabStop = false;
            // 
            // sminMaxDigit
            // 
            resources.ApplyResources(this.sminMaxDigit, "sminMaxDigit");
            this.sminMaxDigit.Name = "sminMaxDigit";
            // 
            // lblMaxDigit
            // 
            resources.ApplyResources(this.lblMaxDigit, "lblMaxDigit");
            this.lblMaxDigit.Name = "lblMaxDigit";
            // 
            // tbPINCode
            // 
            resources.ApplyResources(this.tbPINCode, "tbPINCode");
            this.tbPINCode.Name = "tbPINCode";
            this.tbPINCode.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ScreenLockSettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblOK);
            this.Controls.Add(this.svalMaxDigit);
            this.Controls.Add(this.ltbMaxDigitLess);
            this.Controls.Add(this.lblPINCode);
            this.Controls.Add(this.smaxMaxDigit);
            this.Controls.Add(this.ltbMaxDigitMore);
            this.Controls.Add(this.tbMaxDigit);
            this.Controls.Add(this.sminMaxDigit);
            this.Controls.Add(this.lblMaxDigit);
            this.Controls.Add(this.tbPINCode);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScreenLockSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxDigit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button lblCancel;
        private Button lblOK;
        private Label svalMaxDigit;
        private Label ltbMaxDigitLess;
        private Label lblPINCode;
        private Label smaxMaxDigit;
        private Label ltbMaxDigitMore;
        private TrackBar tbMaxDigit;
        private Label sminMaxDigit;
        private Label lblMaxDigit;
        private TextBox tbPINCode;
        private GroupBox groupBox1;
        private Label label1;

    }
}
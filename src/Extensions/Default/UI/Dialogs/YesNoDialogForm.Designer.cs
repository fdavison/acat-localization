namespace ACAT.Extensions.Default.UI.Dialogs
{
    partial class YesNoDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YesNoDialogForm));
            this.labelCaption = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button1Blank = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Label();
            this.Button2Blank = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCaption
            // 
            resources.ApplyResources(this.labelCaption, "labelCaption");
            this.labelCaption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCaption.ForeColor = System.Drawing.Color.Black;
            this.labelCaption.Name = "labelCaption";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Name = "label2";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.Button1Blank, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button2Blank, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button2, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Button1Blank
            // 
            resources.ApplyResources(this.Button1Blank, "Button1Blank");
            this.Button1Blank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button1Blank.Name = "Button1Blank";
            // 
            // Button1
            // 
            resources.ApplyResources(this.Button1, "Button1");
            this.Button1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button1.Name = "Button1";
            // 
            // Button2Blank
            // 
            resources.ApplyResources(this.Button2Blank, "Button2Blank");
            this.Button2Blank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button2Blank.Name = "Button2Blank";
            // 
            // Button2
            // 
            resources.ApplyResources(this.Button2, "Button2");
            this.Button2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button2.Name = "Button2";
            // 
            // YesNoDialogForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "YesNoDialogForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Button1Blank;
        private System.Windows.Forms.Label Button1;
        private System.Windows.Forms.Label Button2Blank;
        private System.Windows.Forms.Label Button2;

    }
}
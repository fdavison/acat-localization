using System.Windows.Forms;

namespace ACAT.Extensions.Default.UI.Dialogs
{
    // TODO see if we should make a base class to encapsulate these three inherited classes/interfaces
    partial class WindowMoveResizeScannerForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMoveResizeScannerForm));
            this.Title = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Name = "Title";
            // 
            // B1
            // 
            resources.ApplyResources(this.B1, "B1");
            this.B1.Name = "B1";
            this.B1.TabStop = false;
            this.B1.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            resources.ApplyResources(this.B2, "B2");
            this.B2.Name = "B2";
            this.B2.TabStop = false;
            this.B2.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            resources.ApplyResources(this.B3, "B3");
            this.B3.Name = "B3";
            this.B3.TabStop = false;
            this.B3.UseVisualStyleBackColor = true;
            // 
            // B4
            // 
            resources.ApplyResources(this.B4, "B4");
            this.B4.Name = "B4";
            this.B4.TabStop = false;
            this.B4.UseVisualStyleBackColor = true;
            // 
            // B6
            // 
            resources.ApplyResources(this.B6, "B6");
            this.B6.Name = "B6";
            this.B6.TabStop = false;
            this.B6.UseVisualStyleBackColor = true;
            // 
            // B5
            // 
            resources.ApplyResources(this.B5, "B5");
            this.B5.Name = "B5";
            this.B5.TabStop = false;
            this.B5.UseVisualStyleBackColor = true;
            // 
            // WindowMoveResizeScannerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WindowMoveResizeScannerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Label Title;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button B4;
        private Button B6;
        private Button B5;
    }
}
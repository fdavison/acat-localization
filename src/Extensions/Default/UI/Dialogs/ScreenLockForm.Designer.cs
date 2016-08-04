namespace ACAT.Extensions.Default.UI.Dialogs
{
    partial class ScreenLockForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenLockForm));
            this.TopRow = new System.Windows.Forms.Panel();
            this.B14 = new System.Windows.Forms.Label();
            this.B13 = new System.Windows.Forms.Label();
            this.B12 = new System.Windows.Forms.Label();
            this.B11 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.B0 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Label();
            this.B3 = new System.Windows.Forms.Label();
            this.B4 = new System.Windows.Forms.Label();
            this.B5 = new System.Windows.Forms.Label();
            this.B6 = new System.Windows.Forms.Label();
            this.B7 = new System.Windows.Forms.Label();
            this.B8 = new System.Windows.Forms.Label();
            this.B9 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.TopRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopRow
            // 
            resources.ApplyResources(this.TopRow, "TopRow");
            this.TopRow.BackColor = System.Drawing.Color.Black;
            this.TopRow.Controls.Add(this.B14);
            this.TopRow.Controls.Add(this.B13);
            this.TopRow.Controls.Add(this.B12);
            this.TopRow.Controls.Add(this.B11);
            this.TopRow.Name = "TopRow";
            // 
            // B14
            // 
            resources.ApplyResources(this.B14, "B14");
            this.B14.Name = "B14";
            // 
            // B13
            // 
            resources.ApplyResources(this.B13, "B13");
            this.B13.Name = "B13";
            // 
            // B12
            // 
            resources.ApplyResources(this.B12, "B12");
            this.B12.Name = "B12";
            // 
            // B11
            // 
            resources.ApplyResources(this.B11, "B11");
            this.B11.Name = "B11";
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Name = "Title";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblDate.Name = "lblDate";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // B0
            // 
            resources.ApplyResources(this.B0, "B0");
            this.B0.Name = "B0";
            // 
            // B1
            // 
            resources.ApplyResources(this.B1, "B1");
            this.B1.Name = "B1";
            // 
            // B2
            // 
            resources.ApplyResources(this.B2, "B2");
            this.B2.Name = "B2";
            // 
            // B3
            // 
            resources.ApplyResources(this.B3, "B3");
            this.B3.Name = "B3";
            // 
            // B4
            // 
            resources.ApplyResources(this.B4, "B4");
            this.B4.Name = "B4";
            // 
            // B5
            // 
            resources.ApplyResources(this.B5, "B5");
            this.B5.Name = "B5";
            // 
            // B6
            // 
            resources.ApplyResources(this.B6, "B6");
            this.B6.Name = "B6";
            // 
            // B7
            // 
            resources.ApplyResources(this.B7, "B7");
            this.B7.Name = "B7";
            // 
            // B8
            // 
            resources.ApplyResources(this.B8, "B8");
            this.B8.Name = "B8";
            // 
            // B9
            // 
            resources.ApplyResources(this.B9, "B9");
            this.B9.Name = "B9";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTime.Name = "lblTime";
            // 
            // ScreenLockForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TopRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ScreenLockForm";
            this.TopRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopRow;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label B0;
        private System.Windows.Forms.Label B1;
        private System.Windows.Forms.Label B2;
        private System.Windows.Forms.Label B3;
        private System.Windows.Forms.Label B4;
        private System.Windows.Forms.Label B5;
        private System.Windows.Forms.Label B6;
        private System.Windows.Forms.Label B7;
        private System.Windows.Forms.Label B8;
        private System.Windows.Forms.Label B14;
        private System.Windows.Forms.Label B13;
        private System.Windows.Forms.Label B12;
        private System.Windows.Forms.Label B11;
        private System.Windows.Forms.Label B9;
        private System.Windows.Forms.Label lblTime;

    }
}


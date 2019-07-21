namespace RADUTC
{
    partial class FormUTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUTC));
            this.cmsRADUTC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.lblUTCDate = new System.Windows.Forms.Label();
            this.lblUTCTime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRADUTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsRADUTC
            // 
            this.cmsRADUTC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy,
            this.tsmiQuit,
            this.tsmiAbout,
            this.tsmiSettings});
            this.cmsRADUTC.Name = "cmsRADUTC";
            this.cmsRADUTC.Size = new System.Drawing.Size(181, 114);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(180, 22);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(180, 22);
            this.tsmiSettings.Text = "Settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // lblUTCDate
            // 
            this.lblUTCDate.AutoSize = true;
            this.lblUTCDate.CausesValidation = false;
            this.lblUTCDate.ContextMenuStrip = this.cmsRADUTC;
            this.lblUTCDate.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUTCDate.Location = new System.Drawing.Point(17, 9);
            this.lblUTCDate.Name = "lblUTCDate";
            this.lblUTCDate.Size = new System.Drawing.Size(240, 47);
            this.lblUTCDate.TabIndex = 1;
            this.lblUTCDate.Text = "0000-00-00";
            this.ttMain.SetToolTip(this.lblUTCDate, "Right Click for options");
            this.lblUTCDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormUTC_MouseDown);
            this.lblUTCDate.MouseEnter += new System.EventHandler(this.LabelMouseEnter);
            this.lblUTCDate.MouseLeave += new System.EventHandler(this.LabelMouseLeave);
            // 
            // lblUTCTime
            // 
            this.lblUTCTime.AutoSize = true;
            this.lblUTCTime.CausesValidation = false;
            this.lblUTCTime.ContextMenuStrip = this.cmsRADUTC;
            this.lblUTCTime.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUTCTime.Location = new System.Drawing.Point(61, 50);
            this.lblUTCTime.Name = "lblUTCTime";
            this.lblUTCTime.Size = new System.Drawing.Size(152, 47);
            this.lblUTCTime.TabIndex = 2;
            this.lblUTCTime.Text = "000000";
            this.ttMain.SetToolTip(this.lblUTCTime, "Right Click for options");
            this.lblUTCTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormUTC_MouseDown);
            this.lblUTCTime.MouseEnter += new System.EventHandler(this.LabelMouseEnter);
            this.lblUTCTime.MouseLeave += new System.EventHandler(this.LabelMouseLeave);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 10;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopy.Text = "Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // FormUTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(279, 100);
            this.ContextMenuStrip = this.cmsRADUTC;
            this.Controls.Add(this.lblUTCTime);
            this.Controls.Add(this.lblUTCDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUTC";
            this.Opacity = 0.5D;
            this.ttMain.SetToolTip(this, "Right Click for options");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUTC_FormClosing);
            this.Load += new System.EventHandler(this.FormUTC_Load);
            this.Shown += new System.EventHandler(this.FormUTC_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormUTC_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FormUTC_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FormUTC_MouseLeave);
            this.cmsRADUTC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsRADUTC;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label lblUTCDate;
        private System.Windows.Forms.Label lblUTCTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
    }
}


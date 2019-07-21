namespace RADUTC
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.cdSelect = new System.Windows.Forms.ColorDialog();
            this.lFontColor = new System.Windows.Forms.Label();
            this.lBackgroundColor = new System.Windows.Forms.Label();
            this.lFontColorText = new System.Windows.Forms.Label();
            this.lBackgroundColorText = new System.Windows.Forms.Label();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.lFocusedOpacity = new System.Windows.Forms.Label();
            this.lUnFocusedOpacity = new System.Windows.Forms.Label();
            this.nudFocusedOpacity = new System.Windows.Forms.NumericUpDown();
            this.nudUnFocusedOpacity = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFocusedOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnFocusedOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // cdSelect
            // 
            this.cdSelect.AllowFullOpen = false;
            // 
            // lFontColor
            // 
            this.lFontColor.AutoSize = true;
            this.lFontColor.Location = new System.Drawing.Point(62, 15);
            this.lFontColor.Name = "lFontColor";
            this.lFontColor.Size = new System.Drawing.Size(58, 13);
            this.lFontColor.TabIndex = 0;
            this.lFontColor.Text = "Font Color:";
            // 
            // lBackgroundColor
            // 
            this.lBackgroundColor.AutoSize = true;
            this.lBackgroundColor.Location = new System.Drawing.Point(25, 32);
            this.lBackgroundColor.Name = "lBackgroundColor";
            this.lBackgroundColor.Size = new System.Drawing.Size(95, 13);
            this.lBackgroundColor.TabIndex = 1;
            this.lBackgroundColor.Text = "Background Color:";
            // 
            // lFontColorText
            // 
            this.lFontColorText.AutoSize = true;
            this.lFontColorText.Location = new System.Drawing.Point(140, 15);
            this.lFontColorText.Name = "lFontColorText";
            this.lFontColorText.Size = new System.Drawing.Size(52, 13);
            this.lFontColorText.TabIndex = 2;
            this.lFontColorText.Text = "FontColor";
            // 
            // lBackgroundColorText
            // 
            this.lBackgroundColorText.AutoSize = true;
            this.lBackgroundColorText.Location = new System.Drawing.Point(140, 32);
            this.lBackgroundColorText.Name = "lBackgroundColorText";
            this.lBackgroundColorText.Size = new System.Drawing.Size(89, 13);
            this.lBackgroundColorText.TabIndex = 3;
            this.lBackgroundColorText.Text = "BackgroundColor";
            // 
            // btnFontColor
            // 
            this.btnFontColor.CausesValidation = false;
            this.btnFontColor.Image = ((System.Drawing.Image)(resources.GetObject("btnFontColor.Image")));
            this.btnFontColor.Location = new System.Drawing.Point(117, 15);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(17, 17);
            this.btnFontColor.TabIndex = 4;
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.CausesValidation = false;
            this.btnBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("btnBackgroundColor.Image")));
            this.btnBackgroundColor.Location = new System.Drawing.Point(117, 31);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(17, 17);
            this.btnBackgroundColor.TabIndex = 5;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // lFocusedOpacity
            // 
            this.lFocusedOpacity.AutoSize = true;
            this.lFocusedOpacity.Location = new System.Drawing.Point(30, 51);
            this.lFocusedOpacity.Name = "lFocusedOpacity";
            this.lFocusedOpacity.Size = new System.Drawing.Size(90, 13);
            this.lFocusedOpacity.TabIndex = 6;
            this.lFocusedOpacity.Text = "Focused Opacity:";
            // 
            // lUnFocusedOpacity
            // 
            this.lUnFocusedOpacity.AutoSize = true;
            this.lUnFocusedOpacity.Location = new System.Drawing.Point(16, 74);
            this.lUnFocusedOpacity.Name = "lUnFocusedOpacity";
            this.lUnFocusedOpacity.Size = new System.Drawing.Size(104, 13);
            this.lUnFocusedOpacity.TabIndex = 7;
            this.lUnFocusedOpacity.Text = "UnFocused Opacity:";
            // 
            // nudFocusedOpacity
            // 
            this.nudFocusedOpacity.Location = new System.Drawing.Point(117, 51);
            this.nudFocusedOpacity.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFocusedOpacity.Name = "nudFocusedOpacity";
            this.nudFocusedOpacity.Size = new System.Drawing.Size(41, 20);
            this.nudFocusedOpacity.TabIndex = 8;
            this.nudFocusedOpacity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudUnFocusedOpacity
            // 
            this.nudUnFocusedOpacity.Location = new System.Drawing.Point(117, 74);
            this.nudUnFocusedOpacity.Name = "nudUnFocusedOpacity";
            this.nudUnFocusedOpacity.Size = new System.Drawing.Size(41, 20);
            this.nudUnFocusedOpacity.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(36, 113);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(117, 113);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(75, 23);
            this.btnCan.TabIndex = 11;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 151);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nudUnFocusedOpacity);
            this.Controls.Add(this.nudFocusedOpacity);
            this.Controls.Add(this.lUnFocusedOpacity);
            this.Controls.Add(this.lFocusedOpacity);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.lBackgroundColorText);
            this.Controls.Add(this.lFontColorText);
            this.Controls.Add(this.lBackgroundColor);
            this.Controls.Add(this.lFontColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudFocusedOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnFocusedOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog cdSelect;
        private System.Windows.Forms.Label lFontColor;
        private System.Windows.Forms.Label lBackgroundColor;
        private System.Windows.Forms.Label lFontColorText;
        private System.Windows.Forms.Label lBackgroundColorText;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Label lFocusedOpacity;
        private System.Windows.Forms.Label lUnFocusedOpacity;
        private System.Windows.Forms.NumericUpDown nudFocusedOpacity;
        private System.Windows.Forms.NumericUpDown nudUnFocusedOpacity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCan;
    }
}
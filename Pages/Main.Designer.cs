namespace StretchBreak
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_nextText = new System.Windows.Forms.Label();
            this.lbl_nextTime = new System.Windows.Forms.Label();
            this.lbl_versions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(0, 365);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(468, 70);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_Close);
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_settings.Location = new System.Drawing.Point(0, 295);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(468, 70);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_Settings);
            // 
            // lbl_time
            // 
            this.lbl_time.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_time.Location = new System.Drawing.Point(7, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(450, 82);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "label1";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nextText
            // 
            this.lbl_nextText.AutoSize = true;
            this.lbl_nextText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nextText.Location = new System.Drawing.Point(7, 109);
            this.lbl_nextText.Name = "lbl_nextText";
            this.lbl_nextText.Size = new System.Drawing.Size(426, 46);
            this.lbl_nextText.TabIndex = 3;
            this.lbl_nextText.Text = "Next time for a break";
            this.lbl_nextText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nextTime
            // 
            this.lbl_nextTime.AutoSize = true;
            this.lbl_nextTime.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nextTime.Location = new System.Drawing.Point(7, 156);
            this.lbl_nextTime.Name = "lbl_nextTime";
            this.lbl_nextTime.Size = new System.Drawing.Size(100, 47);
            this.lbl_nextTime.TabIndex = 3;
            this.lbl_nextTime.Text = "Time";
            this.lbl_nextTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_versions
            // 
            this.lbl_versions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_versions.AutoSize = true;
            this.lbl_versions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_versions.Location = new System.Drawing.Point(135, 253);
            this.lbl_versions.Name = "lbl_versions";
            this.lbl_versions.Size = new System.Drawing.Size(237, 34);
            this.lbl_versions.TabIndex = 3;
            this.lbl_versions.Text = "version : 1.0.25";
            this.lbl_versions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 435);
            this.Controls.Add(this.lbl_versions);
            this.Controls.Add(this.lbl_nextTime);
            this.Controls.Add(this.lbl_nextText);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StretchBreak";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_nextText;
        private System.Windows.Forms.Label lbl_nextTime;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Label lbl_versions;
    }
}


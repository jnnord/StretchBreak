namespace StretchBreak.Pages
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lbl_minuts = new System.Windows.Forms.Label();
            this.txt_minuts = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_seconds = new System.Windows.Forms.Label();
            this.txt_seconds = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_minuts
            // 
            this.lbl_minuts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minuts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_minuts.Location = new System.Drawing.Point(12, 9);
            this.lbl_minuts.Name = "lbl_minuts";
            this.lbl_minuts.Size = new System.Drawing.Size(336, 70);
            this.lbl_minuts.TabIndex = 0;
            this.lbl_minuts.Text = "Set the time between your breaks in minuts";
            // 
            // txt_minuts
            // 
            this.txt_minuts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_minuts.BackColor = System.Drawing.SystemColors.Info;
            this.txt_minuts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_minuts.Location = new System.Drawing.Point(12, 66);
            this.txt_minuts.Name = "txt_minuts";
            this.txt_minuts.Size = new System.Drawing.Size(336, 34);
            this.txt_minuts.TabIndex = 2;
            this.txt_minuts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(0, 291);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(360, 74);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_Close);
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(0, 212);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(360, 79);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_Save);
            // 
            // lbl_seconds
            // 
            this.lbl_seconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_seconds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_seconds.Location = new System.Drawing.Point(12, 101);
            this.lbl_seconds.Name = "lbl_seconds";
            this.lbl_seconds.Size = new System.Drawing.Size(336, 70);
            this.lbl_seconds.TabIndex = 0;
            this.lbl_seconds.Text = "Set the length of your power break in seconds  (minuts X 60)";
            // 
            // txt_seconds
            // 
            this.txt_seconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_seconds.BackColor = System.Drawing.SystemColors.Info;
            this.txt_seconds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_seconds.Location = new System.Drawing.Point(12, 160);
            this.txt_seconds.Name = "txt_seconds";
            this.txt_seconds.Size = new System.Drawing.Size(336, 34);
            this.txt_seconds.TabIndex = 2;
            this.txt_seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(360, 365);
            this.Controls.Add(this.txt_seconds);
            this.Controls.Add(this.lbl_seconds);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_minuts);
            this.Controls.Add(this.lbl_minuts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_minuts;
        private System.Windows.Forms.TextBox txt_minuts;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_seconds;
        private System.Windows.Forms.TextBox txt_seconds;
    }
}
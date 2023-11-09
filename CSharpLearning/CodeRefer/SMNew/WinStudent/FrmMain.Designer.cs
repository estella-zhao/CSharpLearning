
namespace WinStudent
{
    partial class FrmMain
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
            this.stuMenus = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // stuMenus
            // 
            this.stuMenus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stuMenus.Location = new System.Drawing.Point(0, 0);
            this.stuMenus.Name = "stuMenus";
            this.stuMenus.Size = new System.Drawing.Size(1018, 24);
            this.stuMenus.TabIndex = 1;
            this.stuMenus.Text = "stuMenus";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 629);
            this.Controls.Add(this.stuMenus);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.stuMenus;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "学生管理系统主页面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip stuMenus;
    }
}
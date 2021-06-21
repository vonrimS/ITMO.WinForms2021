
namespace Lab03_Exercise01
{
    partial class WinTimer1
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
            this.userControlTimer2 = new Lab03_Exercise01.UserControlTimer();
            this.SuspendLayout();
            // 
            // userControlTimer2
            // 
            this.userControlTimer2.Location = new System.Drawing.Point(36, 62);
            this.userControlTimer2.Name = "userControlTimer2";
            this.userControlTimer2.Size = new System.Drawing.Size(150, 150);
            this.userControlTimer2.TabIndex = 0;
            this.userControlTimer2.TimeEnabled = true;
            // 
            // WinTimer1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.userControlTimer2);
            this.Name = "WinTimer1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer userControlTimer1;
        private UserControlTimer userControlTimer2;
    }
}



namespace Lab03_Exercise04
{
    partial class Form2
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
            this.regWithValidationForm1 = new Lab03_Exercise04.RegWithValidationForm();
            this.SuspendLayout();
            // 
            // regWithValidationForm1
            // 
            this.regWithValidationForm1.FatherName = "";
            this.regWithValidationForm1.FirstName = "";
            this.regWithValidationForm1.Location = new System.Drawing.Point(12, 12);
            this.regWithValidationForm1.Name = "regWithValidationForm1";
            this.regWithValidationForm1.SecondName = "";
            this.regWithValidationForm1.Size = new System.Drawing.Size(400, 300);
            this.regWithValidationForm1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 313);
            this.Controls.Add(this.regWithValidationForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private RegWithValidationForm regWithValidationForm1;
    }
}
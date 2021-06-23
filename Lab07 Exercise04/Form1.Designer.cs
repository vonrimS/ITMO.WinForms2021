
namespace Lab07_Exercise04
{
    partial class Form1
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
            this.lblA = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(28, 32);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Значение А";
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(99, 29);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(161, 20);
            this.txbA.TabIndex = 1;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(28, 97);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(65, 13);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "Значение В";
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(99, 94);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(161, 20);
            this.txbB.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(284, 27);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Сумма";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(284, 91);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(75, 23);
            this.btnWork.TabIndex = 3;
            this.btnWork.Text = "Работа";
            this.btnWork.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(28, 139);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(10, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Разность";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Асинхронный запуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
    }
}


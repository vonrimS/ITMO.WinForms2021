using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Exercise05
{
    public partial class Task2Form2 : Form
    {

        Task2Form1 t2F1;

        public Task2Form2()
        {
            InitializeComponent();
            t2F1 = new Task2Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t2F1.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                t2F1.Show();
                t2F1.Activate();
                
            }
            catch (ObjectDisposedException ex)
            {
                t2F1 = new Task2Form1();
                t2F1.Show();
                t2F1.Activate();
            }

        }

        private void Task2Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

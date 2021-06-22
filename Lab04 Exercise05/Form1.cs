using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Exercise05._2
{
    public partial class Form1 : Form
    {  

        public string SolData
        {
            get
            {
                return richTextBox1.Text;
            }
            set
            {
                richTextBox1.Text = value;
            }
        }
              

        public Form1()
        {
            InitializeComponent();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(this.Location.X + this.Width + 10, this.Location.Y);
            frm2.Show(this);
        }
    }
}

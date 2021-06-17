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
    public partial class Task2Form1 : Form
    {
        public Task2Form1()
        {
            InitializeComponent();
        }

        private void Task2Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            //myPath.AddPolygon(new Point[] { new Point(0, 0), new Point(0, this.Height), new Point(this.Width, 0) });
            myPath.AddPolygon(new Point[] { new Point(0, this.Height/2), new Point(this.Width / 2, this.Height), new Point(this.Width, this.Height/2), new Point(this.Width / 2, 0) });
            //myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

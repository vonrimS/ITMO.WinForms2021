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
    public partial class Form2 : Form
    {

        public decimal MinRange // нижнее значение диапазона
        {
            get { return (decimal)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public decimal MaxRange // верхнее значение диапазона
        {
            get { return (decimal)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Нижнее значение диапазона :  " + MinRange.ToString() + "\nВерхнее значение диапазона :  "+ MaxRange.ToString();

            double h = 0.1, x, y, a;
            x = Convert.ToDouble(MinRange);
            a = Convert.ToDouble(MaxRange);

            StringBuilder sb = new StringBuilder();

            while (x <= a)
            {
                y = Math.Sin(x);
                sb.Append(x + "   =>   " + y + "\n");
                x += h;
            }

            Form1 frm1 = this.Owner as Form1;
            if (frm1 != null)
            {
                frm1.SolData = sb.ToString();
            }

            //label5.Text = sb.ToString();

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;
            if (frm1 != null)
            {
                frm1.SolData = "";
            }

            label4.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 
 Разработайте приложение в котором реализуйте вывод в подходящий 
для этого компонент последовательность чисел по алгоритму Эратосфена, 
рассчитанных во вторичном потоке. Исходной информацией является передаваемое, 
например из текстового поля максимальное число последовательности.
В качестве реализации указанного алгоритма можно использовать метод, 
в котором последовательность до максимального числа (получаемого из текстового 
поля MaxValue.Text) формируется и возвращается в виде строки: 

    public string GoButt()
    { 
        int maxValue = 0; 
        System.Text.StringBuilder resultText = new System.Text.StringBuilder();
        if (int.TryParse(MaxValue.Text, out maxValue)) 
        {
            for (int trial = 2; trial <= maxValue; trial++) 
            { 
                bool isPrime = true; 
                for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++) 
                { 
                    if (trial % divisor == 0) 
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) 
                { 
                    resultText.AppendFormat("{0} ", trial); 
                }
            } 
         } else { resultText.Append("Unable to parse maximum value."); 
    } 
    return resultText.ToString(); 
}

 */

namespace Lab07_Exercise05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        private delegate int EratosthenesSieve(int a);

        public string GoButt()
        {
            int maxValue = 0;
            System.Text.StringBuilder resultText = new System.Text.StringBuilder();
            if (int.TryParse(MaxValue.Text, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        resultText.AppendFormat("{0} ", trial);
                    }
                    backgroundWorker1.ReportProgress((int)(trial*100/maxValue));

                }
            }
            else
            {
                resultText.Append("Unable to parse maximum value.");
            }
            return resultText.ToString();
        }



        private void MaxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(100);
            richTextBox1.Text = GoButt();

            //int i;
            //i = int.Parse(e.Argument.ToString());
            //for (int j = 1; j <= i; j++)
            //{
            //    if (backgroundWorker1.CancellationPending)
            //    {
            //        e.Cancel = true;
            //        return;
            //    }
            //    System.Threading.Thread.Sleep(1000);
            //    backgroundWorker1.ReportProgress((int)(j * 100 / i));
            //}
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Cancelled))
                System.Windows.Forms.MessageBox.Show("Рассчет завершен!");
            else
                System.Windows.Forms.MessageBox.Show("Рассчет прерван");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!(MaxValue.Text == ""))
            {
                int i = int.Parse(MaxValue.Text);
                backgroundWorker1.RunWorkerAsync(i);
                button1.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}

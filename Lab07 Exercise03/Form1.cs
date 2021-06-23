using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Exercise03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrintDlegateFunc = new PrintLabel(PrintFunc);
            
        }

        private delegate int AsyncSumm(int a, int b);

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Результат операции");
            lblResult.Invoke(PrintDlegateFunc, new object[] { str });
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);

            summdelegate.BeginInvoke(a, b, cb, summdelegate);
            MessageBox.Show("Работа кипит!!!");
        }

        void PrintFunc(string str)
        {
            lblResult.Text = str;
        }

        delegate void PrintLabel(string str);
        private PrintLabel PrintDlegateFunc;

        
    }
}

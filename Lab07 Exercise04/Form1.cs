using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Exercise04
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

        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return a - b;
            }
            );
        }

        delegate void PrintLabel(string str);
        private PrintLabel PrintDlegateFunc;

        private async void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
                int res = await Subb(a, b);
                string str = String.Format("Разница введенных чисел равна {0}", res.ToString());
                lblResult.Text = str;
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
            }
            return;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Exercise04
{
    public partial class Form1 : Form
    {

        public string FirstName // Фамилия
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string SecondName // Имя
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public string FatherName // Отчество
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        List<User> userList = new List<User>(); // Список пользователей

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать цифры");
                errorProvider1.SetError(textBox2, "Must be letter");
                errorProvider2.SetError(textBox3, "Must be letter");
                errorProvider3.SetError(textBox4, "Must be letter");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FirstName == "" || SecondName == "" || FatherName == "")
            {
                MessageBox.Show("Заполните все поля формы");

            }
            else
            {
                MessageBox.Show("Новый пользователь создан");
                User u = new User(FirstName, SecondName, FatherName);
                userList.Add(u);
            }
                      
            
            FirstName = SecondName = FatherName = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userList.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (User user in userList)
            {
                sb.Append("\n" + user.ToString());
            }
           
            MessageBox.Show(sb.ToString());
        }
    }
}

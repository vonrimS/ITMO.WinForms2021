using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03_Exercise04
{
    class User 
    {
        private String firstname;
        private String secondname;
        private String fathername;      
        
        static User()       //статический конструктор
        {
        }

        public User(String firstname, String secondname, String fathername)
        {
            this.firstname = firstname;
            this.secondname = secondname;
            this.fathername = fathername;
        }

        public User()
        { }


        public override string ToString()
        {
            return "\n ФИО пользователя: " + firstname + " " + secondname + " " + fathername;
        }

    }
}

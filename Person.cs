using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Project
{
    class Person
    {
        public String Book_Id;
        public String Customer_Id;
        public String Mobile;
        public String Book_Name;
        public String Author_Name;
        public String Quantity;

        public Person()
        {

        }

        public Person(String Book_Id, String Customer_Id, String Mobile, String Book_Name, String Author_Name,String Quantity)
        {
            this.Book_Id = Book_Id;
            this.Customer_Id = Customer_Id;
            this.Mobile = Mobile;
            this.Book_Name = Book_Name;
            this.Author_Name = Author_Name;
            this.Quantity = Quantity;
        }

        public Person(string Book_ID, string Book_Name, string Author_Name, string Quantity)
        {
            this.Book_Id = Book_ID;
            this.Book_Name = Book_Name;
            this.Author_Name = Author_Name;
            this.Quantity = Quantity;
        }
    }
}

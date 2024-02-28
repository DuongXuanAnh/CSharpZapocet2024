using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BooksManagement
{
    internal class Customer
    {
        public string name;
        public string email;
        public string phoneNumber;

        public Customer(string name, string email, string phoneNumber) { 
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
       
        public void createNewCustomer()
        {
            MessageBox.Show(name);
        }
    }
}

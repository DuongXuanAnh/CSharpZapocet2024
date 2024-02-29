using BooksManagement.Config;
using System;
using System.Collections.Generic;
using System.Data;
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
            DataProvider dataProvider = new DataProvider();

            // Parametrizovaný SQL dotaz pro vložení nového zákazníka do databáze
             string query = "INSERT INTO zakaznik (jmeno, email, phoneNumber) VALUES (@name, @email, @phoneNumber);";

            // Vytvoření Dictionary pro parametry
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@name", this.name },
                { "@email", this.email },
                { "@phoneNumber", this.phoneNumber }
            };

            // Volání metody ExecuteQuery s parametry
            dataProvider.ExecuteModifiedQuery(query, parameters);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    string jmeno = row["jmeno"].ToString();
            //    string email = row["email"].ToString();
            //    string phoneNumber = row["phoneNumber"].ToString();

            //    MessageBox.Show($"Jméno: {jmeno}, Email: {email}, Telefonní číslo: {phoneNumber}");
            //}
        }
    }
}

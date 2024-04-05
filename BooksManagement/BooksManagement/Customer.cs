using BooksManagement.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BooksManagement
{
    public class Customer
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
            if (IsValidEmail(this.email))
            {
                try
                {
                    DataProvider dataProvider = DataProvider.Instance;

                    string checkQuery = "SELECT COUNT(*) FROM zakaznik WHERE email = @email OR phoneNumber = @phoneNumber";
                    Dictionary<string, object> checkParameters = new Dictionary<string, object>
                        {
                            { "@email", this.email },
                            { "@phoneNumber", this.phoneNumber }
                        };

                    object result = dataProvider.ExecuteScalarQuery(checkQuery, checkParameters);
                    int count = Convert.ToInt32(result);

                    if (count > 0)
                    {
                        MessageBox.Show("Zákazník s tímto emailem nebo telefonním číslem již existuje.", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO zakaznik (jmeno, email, phoneNumber) VALUES (@name, @email, @phoneNumber);";
                        Dictionary<string, object> insertParameters = new Dictionary<string, object>
                        {
                            { "@name", this.name },
                            { "@email", this.email },
                            { "@phoneNumber", this.phoneNumber }
                        };

                        int customerId = dataProvider.ExecuteModifiedQueryWithID(insertQuery, insertParameters);

                        if (customerId > -1)
                        {
                            MessageBox.Show($"Zákazník byl úspěšně přidán. ID zákazníka: {customerId}", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nepodařilo se přidat zákazníka do databáze.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Při přidávání zákazníka došlo k chybě: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Neplatný email!", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normální forma emailové adresy pro jednoduchou validaci (příklad: jmeno@domena)
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                // Použití Regex.IsMatch pro kontrolu, zda email odpovídá vzoru
                return Regex.IsMatch(email, pattern);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
       
    }
}

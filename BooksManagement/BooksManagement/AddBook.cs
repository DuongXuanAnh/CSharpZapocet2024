using BooksManagement.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BooksManagement
{
    internal class AddBook
    {
        string name;
        List<Author> author;
        string genre;
        double price;
        int publicYear;
        int amount;
        string description;

        public AddBook()
        {

        }


        public void addNewBook()
        {

        }

        public static void fillComboBoxWithAuthor(ComboBox comboBoxAuthorName)
        {
            try
            {
                DataProvider dataProvider = new DataProvider();

                string query = "SELECT id, jmeno FROM autor ORDER BY jmeno";

                var dataTable = dataProvider.ExecuteSelectQuery(query);

                comboBoxAuthorName.Items.Clear(); // Vyčistíme ComboBox před naplněním

                foreach (DataRow row in dataTable.Rows)
                {
                    string authorName = row["jmeno"].ToString();
                    int authorId = Convert.ToInt32(row["id"]);
                    Author authorItem = new Author(authorName, authorId);

                    comboBoxAuthorName.Items.Add(authorItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Došlo k chybě: {ex.Message}");
            }
        }



    }
}

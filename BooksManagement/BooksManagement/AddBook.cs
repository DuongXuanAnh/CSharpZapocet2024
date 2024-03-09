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
        string genre;
        double price;
        int publicYear;
        int amount;
        string description;
        List<int> authorID;

        public AddBook(string name, string genre, double price, int publicYear, int amout, string description, List<int> authorID)
        {
            this.name = name;
            this.genre = genre;
            this.price = price;
            this.publicYear = publicYear;
            this.amount = amout;
            this.description = description;
            this.authorID = authorID;        
        }


        public void addNewBook()
        {
            try
            {
                DataProvider dataProvider = new DataProvider();

                // Kontrola, zda již kniha s daným názvem a rokem vydání existuje
                string checkQuery = "SELECT COUNT(*) FROM kniha WHERE nazev = @name AND rok_vydani = @publicYear";
                Dictionary<string, object> checkParameters = new Dictionary<string, object>
                {
                    { "@name", this.name },
                    { "@publicYear", this.publicYear }
                };

                object result = dataProvider.ExecuteScalarQuery(checkQuery, checkParameters);
                int count = Convert.ToInt32(result);

                if (count > 0)
                {
                    MessageBox.Show("Kniha s tímto názvem a rokem vydání již existuje.", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kniha neexistuje, vložení nové knihy do databáze
                string insertQuery = "INSERT INTO kniha (nazev, zanr, cena, rok_vydani, amount, popis) VALUES (@name, @genre, @price, @publicYear, @amount, @description);";
                Dictionary<string, object> insertParameters = new Dictionary<string, object>
                {
                    { "@name", this.name },
                    { "@genre", this.genre },
                    { "@price", this.price },
                    { "@publicYear", this.publicYear },
                    { "@amount", this.amount },
                    { "@description", this.description }
                };

                int insertedBookId = dataProvider.ExecuteModifiedQueryWithID(insertQuery, insertParameters);

                // Vložení záznamů do spojovací tabulky kniha_autor
                foreach (int authorId in this.authorID)
                {

                    // Insert do spojovací tabulky
                    string bookAuthorInsertQuery = "INSERT INTO kniha_autor (id_kniha, id_autor) VALUES (@bookId, @authorId)";
                    Dictionary<string, object> bookAuthorInsertParameters = new Dictionary<string, object>
                {
                    { "@bookId", insertedBookId },
                    { "@authorId", authorId }
                };

                    dataProvider.ExecuteModifiedQuery(bookAuthorInsertQuery, bookAuthorInsertParameters);
                }

                MessageBox.Show("Kniha byla úspěšně přidána.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Při přidávání knihy došlo k chybě: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

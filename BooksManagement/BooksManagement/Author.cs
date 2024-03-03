using BooksManagement.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagement
{
    public class Author
    {
        string authorName;
        string nationality;
        public Author(string authorName, string nationality)
        {
            this.authorName = authorName;
            this.nationality = nationality;
        }

        public static void fillComboBoxWithNationalities(ComboBox nationalityComboBox)
        {
            List<string> nationalities = new List<string>()
        {
            "Americká",
            "Argentinská",
            "Australská",
            "Belgická",
            "Brazilská",
            "Britská",
            "Česká",
            "Čínská",
            "Dánská",
            "Egyptská",
            "Finská",
            "Francouzská",
            "Německá",
            "Řecká",
            "Indická",
            "Indonéská",
            "Irská",
            "Italská",
            "Japonská",
            "Kanadská",
            "Mexická",
            "Nizozemská",
            "Norská",
            "Polská",
            "Portugalská",
            "Ruská",
            "Saúdskoarabská",
            "Singapurská",
            "Slovenská",
            "Jihoafrická",
            "Španělská",
            "Švédská",
            "Švýcarská",
            "Turecká",
            "Ukrajinská",
            "Vietnamská"
        };

            nationalityComboBox.Items.Clear();
            nationalityComboBox.Items.AddRange(nationalities.ToArray());
        }

        public void createNewAuthor()
        {
            try
            {
                DataProvider dataProvider = new DataProvider();

                // Nejprve zkontrolujte, zda autor s daným jménem a narodností již existuje
                string checkQuery = "SELECT COUNT(*) FROM autor WHERE jmeno = @name AND narodnost = @nationality";
                Dictionary<string, object> checkParameters = new Dictionary<string, object>
        {
            { "@name", this.authorName },
            { "@nationality", this.nationality }
        };

                object result = dataProvider.ExecuteScalarQuery(checkQuery, checkParameters);
                int count = Convert.ToInt32(result);

                if (count > 0)
                {
                    // Autor již existuje
                    MessageBox.Show("Autor s tímto jménem a narodností již existuje.", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Ukončí funkci, nevkládá duplicitní záznam
                }

                // Zákazník neexistuje, vložení nového autora do databáze
                string insertQuery = "INSERT INTO autor (jmeno, narodnost) VALUES (@name, @nationality);";
                Dictionary<string, object> insertParameters = new Dictionary<string, object>
        {
            { "@name", this.authorName },
            { "@nationality", this.nationality },
        };

                dataProvider.ExecuteModifiedQuery(insertQuery, insertParameters);

                // Zobrazení zprávy o úspěchu
                MessageBox.Show("Autor byl úspěšně přidán.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Ošetření výjimek
                MessageBox.Show($"Při přidávání autora došlo k chybě: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

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
    internal class Books
    {

        public Books(DataGridView dataGridView1) {

            DataProvider dataProvider = new DataProvider();

            DataTable dataTable = dataProvider.ExecuteSelectQuery(
                "SELECT kniha.id AS 'ID', nazev AS 'název', rok_vydani AS 'Rok vydání', GROUP_CONCAT(autor.jmeno SEPARATOR ', ') AS 'Autor', zanr AS 'Žánr', cena AS 'Cena', amount AS 'Počet kusů' " +
                "FROM kniha JOIN kniha_autor AS ka " +
                "ON kniha.id=ka.id_kniha " +
                "JOIN autor " +
                "ON ka.id_autor=autor.id " +
                "GROUP BY kniha.id, nazev, rok_vydani, zanr, cena, amount");
            dataGridView1.DataSource = dataTable;

        }

        public static void fillComboBoxWithGenres(ComboBox genresComboBox)
        {
            List<string> genres = new List<string>()
            {
                "aforismus",
                "anekdota",
                "apokryf",
                "bajka",
                "balada",
                "báje",
                "beletrie",
                "biografie",
                "červená knihovna",
                "drama",
                "encyklopedie",
                "epika",
                "epos",
                "esej",
                "fantasy",
                "fejeton",
                "komedie",
                "komiks",
                "legenda",
                "limerik",
                "lyrika",
                "magický realismus",
                "memoár",
                "mýtus",
                "novela",
                "óda",
                "parodie",
                "pamflet",
                "polemika",
                "realismus",
                "reportáž",
                "román",
                "satira",
                "sci-fi",
                "sonet",
                "thriller",
                "tragédie",
                "utopie",
                "western"
            };

            genresComboBox.Items.Clear();
            genresComboBox.Items.AddRange(genres.ToArray());
        }



    }
}

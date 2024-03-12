using BooksManagement.Config;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagement
{
    public partial class BookDetailForm : Form
    {
        int bookID;
        public BookDetailForm()
        {
            InitializeComponent();
        }

        public BookDetailForm(int bookID)
        {
            InitializeComponent();
            this.bookID = bookID;
            Books.fillComboBoxWithGenres(cb_BookDetail_zanr);
            Author.fillComboBoxWithAuthor(cb_BookDetail_author);
            fillBookInformation(bookID);
        }

        void fillBookInformation(int id)
        {
            try
            {
                DataProvider dataProvider = new DataProvider();

                var query = "SELECT `nazev`, `rok_vydani`, `cena`, `zanr`, `amount`, `popis` FROM `kniha` WHERE id = @id";

                var queryAuthors = "SELECT autor.id, jmeno FROM autor JOIN kniha_autor ON autor.id = kniha_autor.id_autor WHERE kniha_autor.id_kniha = @id";

                Dictionary<string, object> checkParameters = new Dictionary<string, object>
                {
                    { "@id", id },
                };

                DataTable data = dataProvider.ExecuteSelectQueryWithParameter(query, checkParameters);

                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    string nazev = row["nazev"].ToString();
                    string rokVydani = row["rok_vydani"].ToString();
                    string cena = row["cena"].ToString();
                    string zanr = row["zanr"].ToString();
                    int amount = (int)row["amount"];
                    string popis = row["popis"].ToString();

                    txt_BookDetail_name.Text = nazev;
                    txt_BookDetail_year.Text = rokVydani;
                    txt_BookDetail_price.Text = cena;
                    rtxt_BookDetail_popis.Text = popis;
                    cb_BookDetail_zanr.Text = zanr;
                    numUpDown_BookDetail_quantity.Value = amount;
                }
                else
                {
                    MessageBox.Show("Kniha s daným ID nebyla nalezena.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DataTable dataAuthor = dataProvider.ExecuteSelectQueryWithParameter(queryAuthors, checkParameters);
                if (dataAuthor.Rows.Count > 0)
                {
                    listBox_BookDetail_Authors.Items.Clear();

                    foreach (DataRow row in dataAuthor.Rows)
                    {
                        Author author = new Author(row["jmeno"].ToString(), (int)row["id"]);
                        bool authorExists = listBox_BookDetail_Authors.Items.Cast<Author>().Any(item => item.id == author.id);
                        if (!authorExists)
                        {
                            listBox_BookDetail_Authors.Items.Add(author);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při načítání informací o knize: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_BookDetail_addAuthor_Click(object sender, EventArgs e)
        {
            if (cb_BookDetail_author.SelectedItem is Author selectedAuthor)
            {
                // Kontrola, zda ListBox již obsahuje vybraného autora, zde předpokládáme, že porovnáváme objekty na základě ID
                bool authorExists = listBox_BookDetail_Authors.Items.Cast<Author>().Any(item => item.id == selectedAuthor.id);
                if (!authorExists)
                {
                    listBox_BookDetail_Authors.Items.Add(selectedAuthor);
                }
                else
                {
                    MessageBox.Show("Tento autor již byl přidán.");
                }
            }
            else
            {
                MessageBox.Show("Prosím, vyberte autora.");
            }
        }

        private void btn_BookDetail_removeAuthor_Click(object sender, EventArgs e)
        {
            if (listBox_BookDetail_Authors.SelectedIndex != -1)
            {
                listBox_BookDetail_Authors.Items.RemoveAt(listBox_BookDetail_Authors.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Prosím, vyberte autora, kterého chcete odebrat.");
            }
        }

        private void btn_BookDetail_update_Click(object sender, EventArgs e)
        {
            string nazev = txt_BookDetail_name.Text;
            string rokVydani = txt_BookDetail_year.Text;
            string cena = txt_BookDetail_price.Text;
            string zanr = cb_BookDetail_zanr.Text;
            int amount = (int)numUpDown_BookDetail_quantity.Value;
            string popis = rtxt_BookDetail_popis.Text;

            List<int> authorIDs = new List<int>();
            foreach (Author item in listBox_BookDetail_Authors.Items)
            {
                authorIDs.Add(item.id);
            }

            var query = "UPDATE `kniha` SET `nazev`=@nazev,`rok_vydani`=@rokVydani,`cena`=@cena,`zanr`=@zanr,`amount`=@amount,`popis`=@popis WHERE `id`=@bookID";

            // Vytvoření slovníku pro parametry
            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nazev", nazev },
                    { "@rokVydani", rokVydani },
                    { "@cena", cena },
                    { "@zanr", zanr },
                    { "@amount", amount },
                    { "@popis", popis },
                    { "@bookID", bookID }
                };


            // Smazání existujících autorů pro danou knihu

            var deleteQuery = "DELETE FROM `kniha_autor` WHERE `id_kniha`=@bookID";
            Dictionary<string, object> deleteParameters = new Dictionary<string, object>
            {
                { "@bookID", bookID }
            };

            // Přidání nových autorů pro danou knihu
            var insertQuery = "INSERT INTO `kniha_autor` (`id_kniha`, `id_autor`) VALUES (@bookID, @authorID)";

            try
            {
                // Vytvoření instance DataProvider a spuštění aktualizačního dotazu
                DataProvider dataProvider = new DataProvider();
                dataProvider.ExecuteModifiedQuery(query, parameters);

             
                            dataProvider.ExecuteModifiedQuery(deleteQuery, deleteParameters);

                           
            foreach (var authorID in authorIDs)
            {
                Dictionary<string, object> insertParameters = new Dictionary<string, object>
                {
                    { "@bookID", bookID },
                    { "@authorID", authorID }
                };
                    dataProvider.ExecuteModifiedQuery(insertQuery, insertParameters);
                }

                MessageBox.Show("Informace o knize byly úspěšně aktualizovány.", "Aktualizace úspěšná", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba při aktualizaci informací o knize: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_BookDetail_addToCart_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("OrderBook.txt", true))
                {
                    sw.WriteLine(bookID);
                }
                MessageBox.Show("Kniha byla úspěšně přidaná do košíku!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

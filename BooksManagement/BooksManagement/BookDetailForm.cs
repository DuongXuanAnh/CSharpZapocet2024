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

        }

        private void btn_BookDetail_addToCart_Click(object sender, EventArgs e)
        {

        }
    }
}

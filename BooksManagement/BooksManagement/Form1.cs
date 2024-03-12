using BooksManagement.Config;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BooksManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel_knihy.Visible = true;
            panel_addAuthor.Visible = false;
            panel_addBook.Visible = false;
            panel_addCustomer.Visible = false;
            panel_Order.Visible = false;
            panel_returnBook.Visible = false;
            // Simulace kliknut� na tla��tko btn_menu_knihy
            btn_menu_knihy_Click(this, EventArgs.Empty);

        }

        private void btn_menu_knihy_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_knihy.Visible = true;
            Books books = new Books(dataGridView1);
            Author.fillComboBoxWithAuthor(cb_knihy_authors);
            Books.fillComboBoxWithGenres(cb_knihy_zanr);
        }

        private void btn_menu_addAuthor_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_addAuthor.Visible = true;
            Author.fillComboBoxWithNationalities(cbox_Nationality);

        }

        private void btn_menu_addBook_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_addBook.Visible = true;
            Author.fillComboBoxWithAuthor(cb_AddNewBook_author);
            Books.fillComboBoxWithGenres(cb_addBook_zarn);
        }

        private void btn_menu_addCustomer_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_addCustomer.Visible = true;
        }

        private void btn_menu_order_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_Order.Visible = true;
            SetupDataGridViewOrder();
        }

        private void btn_menu_returnBook_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_returnBook.Visible = true;
        }
        private void HideAllPanels()
        {
            panel_knihy.Visible = false;
            panel_addAuthor.Visible = false;
            panel_addBook.Visible = false;
            panel_addCustomer.Visible = false;
            panel_Order.Visible = false;
            panel_returnBook.Visible = false;
        }

        #region Knihy


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            int id = (int)selectedRow.Cells["ID"].Value;
            BookDetailForm bookDetailForm = new BookDetailForm(id);
            bookDetailForm.Show();
        }

        private void txt_knihy_nazevKnihy_TextChanged(object sender, EventArgs e)
        {
            // Vyhled�v�n� knihy podle n�zvu          
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataView dataView = dataTable.DefaultView;
            string filterValue = txt_knihy_nazevKnihy.Text.Replace("'", "''");
            dataView.RowFilter = string.Format("n�zev LIKE '%{0}%'", filterValue);
        }

        private void cb_knihy_zanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataView dataView = dataTable.DefaultView;

            if (cb_knihy_zanr.SelectedItem.ToString() == "All")
            {
                dataView.RowFilter = ""; // Clear the filter
            }
            else
            {
                string filterValue = cb_knihy_zanr.SelectedItem.ToString().Replace("'", "''"); // Escape single quotes
                dataView.RowFilter = string.Format("��nr = '{0}'", filterValue);
            }
        }


        private void cb_knihy_zanr_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataView dataView = dataTable.DefaultView;

            string filterValue = cb_knihy_zanr.Text.Replace("'", "''"); // Escape single quotes
            if (string.IsNullOrWhiteSpace(filterValue))
            {
                dataView.RowFilter = ""; // Zobraz� v�echny z�znamy, pokud nen� vybr�na ��dn� hodnota
            }
            else
            {
                dataView.RowFilter = string.Format("��nr LIKE '%{0}%'", filterValue); // Filtrov�n� na z�klad� textu
            }
        }

        private void cb_knihy_authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataView dataView = dataTable.DefaultView;

            if (cb_knihy_authors.SelectedItem.ToString() == "All")
            {
                dataView.RowFilter = ""; // Clear the filter
            }
            else
            {
                string filterValue = cb_knihy_authors.SelectedItem.ToString().Replace("'", "''"); // Escape single quotes
                dataView.RowFilter = string.Format("Autor LIKE '%{0}%'", filterValue);
            }
        }

        private void cb_knihy_authors_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataView dataView = dataTable.DefaultView;

            string filterValue = cb_knihy_authors.Text.Replace("'", "''"); // Escape single quotes
            if (string.IsNullOrWhiteSpace(filterValue))
            {
                dataView.RowFilter = ""; // Zobraz� v�echny z�znamy, pokud nen� vybr�na ��dn� hodnota
            }
            else
            {
                dataView.RowFilter = string.Format("Autor LIKE '%{0}%'", filterValue); // Filtrov�n� na z�klad� textu
            }
        }


        #endregion

        #region AddAuthor
        private void btn_addAuthor_Click(object sender, EventArgs e)
        {
            string authorName = txt_AuthorName.Text;
            string nationality = cbox_Nationality.Text;
            Author author = new Author(authorName, nationality);
            author.createNewAuthor();
        }

        #endregion

        #region AddBook

        private void btn_AddBook_addAuthor_Click(object sender, EventArgs e)
        {
            if (cb_AddNewBook_author.SelectedItem is Author selectedAuthor)
            {
                // Kontrola, zda ListBox ji� obsahuje vybran�ho autora, zde p�edpokl�d�me, �e porovn�v�me objekty na z�klad� ID
                bool authorExists = listBox_AddNewBook_Authors.Items.Cast<Author>().Any(item => item.id == selectedAuthor.id);
                if (!authorExists)
                {
                    listBox_AddNewBook_Authors.Items.Add(selectedAuthor);
                }
                else
                {
                    MessageBox.Show("Tento autor ji� byl p�id�n.");
                }
            }
            else
            {
                MessageBox.Show("Pros�m, vyberte autora.");
            }
        }

        private void btn_AddBook_removeAuthor_Click(object sender, EventArgs e)
        {
            // Kontrola, jestli je n�jak� autor vybr�n v ListBoxu
            if (listBox_AddNewBook_Authors.SelectedIndex != -1)
            {
                // Odebr�n� vybran�ho autora
                listBox_AddNewBook_Authors.Items.RemoveAt(listBox_AddNewBook_Authors.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Pros�m, vyberte autora, kter�ho chcete odebrat.");
            }
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            string name = txt_addBook_name.Text;
            string genre = cb_addBook_zarn.Text;
            double price;
            int year;
            int amount;

            // Kontrola, zda jsou v�echna pole vypln�na
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(genre) ||
                !double.TryParse(txt_addBook_price.Text, out price) ||
                !int.TryParse(txt_addBook_year.Text, out year) ||
                !int.TryParse(numUpDown_addBook_quantity.Text, out amount) ||
                listBox_AddNewBook_Authors.Items.Count == 0)
            {
                MessageBox.Show("Pros�m, vypl�te v�echna pole.", "Upozorn�n�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kontrola, zda jsou v�echna pole vypln�na
            string description = rtxt_addBook_popis.Text;
            List<int> authorID = new List<int>();

            foreach (Author item in listBox_AddNewBook_Authors.Items)
            {
                authorID.Add(item.id);
            }

            AddBook addBook = new AddBook(name, genre, price, year, amount, description, authorID);
            addBook.addNewBook();
        }

        #endregion

        #region AddCustomer
        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txt_customerName.Text;
            string customerEmail = txt_email.Text;
            string customerPhoneNumber = txt_phoneNumber.Text;
            Customer customer = new Customer(customerName, customerEmail, customerPhoneNumber);
            customer.createNewCustomer();
        }

        private void txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validation telephone number
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handle the event, effectively ignoring the key press
            }
        }
        #endregion

        #region Objednavka
        private void dataGridView_Order_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Kontrola, zda je ud�lost ve sloupci "Quantity"
            if (dataGridView_Order.Columns[e.ColumnIndex].Name == "Quantity")
            {
                int newInteger;

                // Kontrola, zda je hodnota, kterou u�ivatel vlo�il, ��slo
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger < 0)
                {
                    // Pokud nen�, zobrazit chybovou zpr�vu a zru�it zm�nu
                    e.Cancel = true;
                    MessageBox.Show("Pros�m, vlo�te pouze kladn� ��seln� hodnoty do sloupce 'Po�et'.");
                }
            }
        }
        private void SetupDataGridViewOrder()
        {
            dataGridView_Order.Columns.Add("Name", "N�zev knihy");
            dataGridView_Order.Columns["Name"].ReadOnly = true;

            dataGridView_Order.Columns.Add("Price", "Cena");
            dataGridView_Order.Columns["Price"].ReadOnly = true;

            dataGridView_Order.Columns.Add("Quantity", "Po�et");
            dataGridView_Order.Columns["Quantity"].ReadOnly = false;
            dataGridView_Order.CellValidating += new DataGridViewCellValidatingEventHandler(dataGridView_Order_CellValidating);

            int index = dataGridView_Order.Rows.Add();
            dataGridView_Order.Rows[index].Cells["Name"].Value = "Romeo and Juliet";
            dataGridView_Order.Rows[index].Cells["Price"].Value = "200.0 K�";
            dataGridView_Order.Rows[index].Cells["Quantity"].Value = "1";
            // Adding the second row
            int index2 = dataGridView_Order.Rows.Add();
            dataGridView_Order.Rows[index2].Cells["Name"].Value = "Hamlet";
            dataGridView_Order.Rows[index2].Cells["Price"].Value = "150.0 K�";
            dataGridView_Order.Rows[index2].Cells["Quantity"].Value = "1"; // Assuming quantity

            // Adding the third row
            int index3 = dataGridView_Order.Rows.Add();
            dataGridView_Order.Rows[index3].Cells["Name"].Value = "Macbeth";
            dataGridView_Order.Rows[index3].Cells["Price"].Value = "180.0 K�";
            dataGridView_Order.Rows[index3].Cells["Quantity"].Value = "1"; // Assuming quantity



            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "deleteColumn";
            deleteButtonColumn.Text = "X";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            deleteButtonColumn.HeaderText = "";

            dataGridView_Order.Columns.Add(deleteButtonColumn);
            dataGridView_Order.CellClick += new DataGridViewCellEventHandler(dataGridView_CellClick);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kontrola, zda index sloupce a ��dku jsou v platn�m rozsahu
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.ColumnIndex == dataGridView_Order.Columns["deleteColumn"].Index)
            {
                // Te� je bezpe�n� odstranit ��dek
                dataGridView_Order.Rows.RemoveAt(e.RowIndex);
            }
        }


        #endregion

        #region ReturnBooks
        #endregion





    }
}

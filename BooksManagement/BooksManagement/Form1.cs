using BooksManagement.Config;
using System.Data;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

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
            dataGridView1.Columns["id"].Visible = false;
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
            cb_Objednavka_typ.SelectedIndex = 0;
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

        private void btn_Knihy_AddToOrder_Click(object sender, EventArgs e)
        {
            // Ov��en�, �e je skute�n� vybr�n n�jak� ��dek
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                var id = Convert.ToString(selectedRow.Cells["id"].Value);
                var title = Convert.ToString(selectedRow.Cells["n�zev"].Value);
                var price = Convert.ToString(selectedRow.Cells["Cena"].Value);

                try
                {
                    using (StreamWriter sw = new StreamWriter("OrderBook.txt", true))
                    {
                        sw.WriteLine(id + "_" + title + "_" + price);
                    }
                    MessageBox.Show("Kniha byla �sp�n� p�idan� do ko��ku!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Pros�m, vyberte ��dek v tabulce.");
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
            dataGridView_Order.Rows.Clear();
            dataGridView_Order.Columns.Clear();

            dataGridView_Order.Columns.Add("ID", "ID");
            dataGridView_Order.Columns["ID"].ReadOnly = true;
            dataGridView_Order.Columns["ID"].Visible = false;


            dataGridView_Order.Columns.Add("Name", "N�zev knihy");
            dataGridView_Order.Columns["Name"].ReadOnly = true;

            dataGridView_Order.Columns.Add("Price", "Cena");
            dataGridView_Order.Columns["Price"].ReadOnly = true;

            dataGridView_Order.Columns.Add("Quantity", "Po�et");
            dataGridView_Order.Columns["Quantity"].ReadOnly = false;
            dataGridView_Order.CellValidating += new DataGridViewCellValidatingEventHandler(dataGridView_Order_CellValidating);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "deleteColumn",
                Text = "X",
                UseColumnTextForButtonValue = true,
                HeaderText = ""
            };

            dataGridView_Order.Columns.Add(deleteButtonColumn);

            dataGridView_Order.CellClick -= dataGridView_CellClick; // Unsubscribe first to avoid multiple subscriptions
            dataGridView_Order.CellClick += dataGridView_CellClick; // Then subscribe

            FillOrderBook();


        }

        private void ShowTotalOrderPrice()
        {
            double totalSum = 0;
            for (int i = 0; i < dataGridView_Order.Rows.Count; ++i)
            {
                double price = Convert.ToDouble(dataGridView_Order.Rows[i].Cells["Price"].Value ?? 0);
                double quantity = Convert.ToDouble(dataGridView_Order.Rows[i].Cells["Quantity"].Value ?? 0);
                totalSum += price * quantity;
            }

            lb_Objednavka_TotalPrice.Text = totalSum.ToString() + "-,K�";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView_Order.Columns["deleteColumn"].Index)
            {
                var rowID = dataGridView_Order.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                Order.DeleteBookFromFIle(rowID);

                dataGridView_Order.Rows.RemoveAt(e.RowIndex);

            }
            ShowTotalOrderPrice();
        }

        private void FillOrderBook()
        {
            using (StreamReader sr = new StreamReader("OrderBook.txt"))
            {

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] token = line.Split('_');
                        AddOrUpdateOrderRow(token[0], token[1], token[2], "1");
                    }

                }

            }
        }

        private void AddOrUpdateOrderRow(string id, string name, string price, string quantity)
        {
            bool rowExists = false;
            foreach (DataGridViewRow row in dataGridView_Order.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == id)
                {
                    // If the row with the given ID exists, increase its quantity by 1
                    int currentQuantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    row.Cells["Quantity"].Value = (currentQuantity + 1).ToString();
                    rowExists = true;
                    break;
                }
            }

            if (!rowExists)
            {
                // If the ID does not exist, add a new row
                int rowIndex = dataGridView_Order.Rows.Add();
                dataGridView_Order.Rows[rowIndex].Cells["ID"].Value = id;
                dataGridView_Order.Rows[rowIndex].Cells["Name"].Value = name;
                dataGridView_Order.Rows[rowIndex].Cells["Price"].Value = price;
                dataGridView_Order.Rows[rowIndex].Cells["Quantity"].Value = quantity;
                ShowTotalOrderPrice();
            }
        }

        private void cb_Objednavka_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cb_Objednavka_typ.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    lb_Objednavka_Id.Visible = true;
                    lb_Objdenavka_returnDate.Visible = true;
                    dateTimePicker_Objednavka.Visible = true;
                    txt_Objednavka_Id.Visible = true;
                    lb_Objednavka_total.Visible = false;
                    lb_Objednavka_TotalPrice.Visible = false;
                    break;
                case 1:
                    lb_Objednavka_Id.Visible = false;
                    lb_Objdenavka_returnDate.Visible = false;
                    dateTimePicker_Objednavka.Visible = false;
                    txt_Objednavka_Id.Visible = false;
                    lb_Objednavka_total.Visible = true;
                    lb_Objednavka_TotalPrice.Visible = true;
                    break;

            }
        }

        private void txt_Objednavka_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handle the event, effectively ignoring the key press
            }
        }

        private void btn_Objednavka_Create_Click(object sender, EventArgs e)
        {

            int selectedIndex = cb_Objednavka_typ.SelectedIndex;

            Dictionary<int, int> bookInOrder = new Dictionary<int, int>();

            foreach (DataGridViewRow row in dataGridView_Order.Rows)
            {
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                bookInOrder.Add(id, quantity);
            }

            if (bookInOrder.Count == 0)
            {
                MessageBox.Show("Ko��k je pr�zdn�!");
                return;
            }

            Order order = new Order(bookInOrder);


            switch (selectedIndex)
            {
                case 0: // Pujcit

                    if (string.IsNullOrWhiteSpace(txt_Objednavka_Id.Text))
                    {
                        MessageBox.Show("ID z�kazn�ka nesm� b�t pr�zdn�.", "Varov�n�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break; // P�eru�en� case, nepokra�ovat v dal��m zpracov�n�
                    }

                    int customerID = int.Parse(txt_Objednavka_Id.Text);

                    DateTime returnDate = dateTimePicker_Objednavka.Value;

                    if (returnDate.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("Datum vr�cen� nesm� b�t v minulosti.", "Varov�n�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    try
                    {
                        order.Borrow(customerID, returnDate);
                        MessageBox.Show("Objedn�vka byla �sp�n� vytvo�en�!");
                        ResetMenuObjednavka();
                    }
                    catch
                    {
                        MessageBox.Show("Nepoda�ilo se vytvo�it objedn�vku!");
                    }
                    break;
                case 1: // Koupit
                    try
                    {
                        order.Sell();
                        MessageBox.Show("�sp�n� jste prodali knihy!");
                        ResetMenuObjednavka();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nepoda�ilo se koupit knihy!");
                    }
                    break;
            }
        }

        private void ResetMenuObjednavka()
        {
            string path = "OrderBook.txt";
            File.WriteAllText(path, string.Empty);
            txt_Objednavka_Id.Text = string.Empty;
            btn_menu_order_Click(this, EventArgs.Empty);
        }


        #endregion

        #region ReturnBooks

        private void checkBox_ReturnBook_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ReturnBook.Checked)
            {
                lb_ReturnBook_Do.Visible = true;
                lb_ReturnBook_Od.Visible = true;
                dateTimePicker_ReturnBook_FromDate.Visible = true;
                dateTimePicker_ReturnBook_ReturnDate.Visible = true;
            }
            else
            {
                lb_ReturnBook_Do.Visible = false;
                lb_ReturnBook_Od.Visible = false;
                dateTimePicker_ReturnBook_FromDate.Visible = false;
                dateTimePicker_ReturnBook_ReturnDate.Visible = false;
            }
        }

        private void btn_ReturnBook_Find_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(txt_ReturnBook_CustomerID.Text);

            ReturnBook returnBook = new ReturnBook(customerID);

            if (checkBox_ReturnBook.Checked)
            {
                string startDate = dateTimePicker_ReturnBook_FromDate.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker_ReturnBook_ReturnDate.Value.ToString("yyyy-MM-dd");

                dataGridViewReturnBook.DataSource = returnBook.GetCustomOrderInfo(startDate, endDate);
            }
            else
            {
                dataGridViewReturnBook.DataSource = returnBook.GetCustomOrderInfo();
            }
            

        }

        private void btn_ReturnBook_Return_Click(object sender, EventArgs e)
        {
            if (dataGridViewReturnBook.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewReturnBook.SelectedRows[0];


                int dokladID = (int) selectedRow.Cells["dokladID"].Value;
                int bookID = (int) selectedRow.Cells["bookID"].Value;
                int customerID = (int) selectedRow.Cells["zakaznikID"].Value;

                ReturnBook returnBook = new ReturnBook(customerID);

                try
                {
                    returnBook.ReturnSeletedBook(dokladID, bookID);
                    btn_ReturnBook_Find_Click(this, EventArgs.Empty);
                    MessageBox.Show("Kniha byla �sp�n� vr�cena!");
                }
                catch
                {
                    MessageBox.Show("Nastala chyba!");
                }
            }
            else
            {
                MessageBox.Show("Vyberte si pros�m ��dek.");
            }
        }

        private void btn_ReturnBook_ReturnAll_Click(object sender, EventArgs e)
        {

        }

      

        #endregion












       
    }
}

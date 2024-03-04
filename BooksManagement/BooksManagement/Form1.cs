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

        }

        private void btn_menu_knihy_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_knihy.Visible = true;
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
            AddBook.fillComboBoxWithAuthor(cb_AddNewBook_author);
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
            var selectedAuthor = cb_AddNewBook_author.SelectedItem;
            if (selectedAuthor == null)
            {
                MessageBox.Show("Pros�m, vyberte autora.");
                return;
            }
            if (!listBox_AddNewBook_Authors.Items.Contains(selectedAuthor))
            {
                // P�id�n� autora do ListBoxu
                listBox_AddNewBook_Authors.Items.Add(selectedAuthor);
            }
            else
            {
                MessageBox.Show("Tento autor ji� byl p�id�n.");
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
            AddBook addBook = new AddBook();
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
        #endregion

        #region ReturnBooks
        #endregion



       
    }
}

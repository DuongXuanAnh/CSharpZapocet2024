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
        }

        private void btn_menu_addBook_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_addBook.Visible = true;
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

     
    }
}

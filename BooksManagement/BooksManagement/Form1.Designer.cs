namespace BooksManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_menu_knihy = new Button();
            btn_menu_addAuthor = new Button();
            btn_menu_addBook = new Button();
            btn_menu_addCustomer = new Button();
            btn_menu_order = new Button();
            btn_menu_returnBook = new Button();
            label1 = new Label();
            panel_knihy = new Panel();
            btn_Knihy_AddToOrder = new Button();
            dataGridView1 = new DataGridView();
            cb_knihy_zanr = new ComboBox();
            label15 = new Label();
            cb_knihy_authors = new ComboBox();
            label14 = new Label();
            txt_knihy_nazevKnihy = new TextBox();
            label13 = new Label();
            label2 = new Label();
            panel_addAuthor = new Panel();
            btn_addAuthor = new Button();
            cbox_Nationality = new ComboBox();
            txt_AuthorName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel_addBook = new Panel();
            btn_AddBook_removeAuthor = new Button();
            btn_AddBook_addAuthor = new Button();
            listBox_AddNewBook_Authors = new ListBox();
            btn_addBook = new Button();
            rtxt_addBook_popis = new RichTextBox();
            cb_AddNewBook_author = new ComboBox();
            numUpDown_addBook_quantity = new NumericUpDown();
            label22 = new Label();
            txt_addBook_year = new TextBox();
            txt_addBook_price = new TextBox();
            cb_addBook_zarn = new ComboBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            txt_addBook_name = new TextBox();
            label16 = new Label();
            label7 = new Label();
            panel_addCustomer = new Panel();
            txt_phoneNumber = new TextBox();
            txt_email = new TextBox();
            label6 = new Label();
            btn_addCustomer = new Button();
            txt_customerName = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel_Order = new Panel();
            dataGridView_Order = new DataGridView();
            lb_Objednavka_TotalPrice = new Label();
            txt_Objednavka_Id = new TextBox();
            dateTimePicker_Objednavka = new DateTimePicker();
            cb_Objednavka_typ = new ComboBox();
            btn_Objednavka_Create = new Button();
            lb_Objednavka_total = new Label();
            label26 = new Label();
            lb_Objednavka_Id = new Label();
            lb_Objdenavka_returnDate = new Label();
            label23 = new Label();
            label8 = new Label();
            panel_returnBook = new Panel();
            label27 = new Label();
            label25 = new Label();
            dateTimePicker_ReturnBook_ReturnDate = new DateTimePicker();
            dateTimePicker_ReturnBook_FromDate = new DateTimePicker();
            btn_ReturnBook_Return = new Button();
            btn_ReturnBook_ReturnAll = new Button();
            dataGridViewReturnBook = new DataGridView();
            btn_ReturnBook_Find = new Button();
            txt_ReturnBook_CustomerID = new TextBox();
            label24 = new Label();
            label9 = new Label();
            panel_knihy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_addAuthor.SuspendLayout();
            panel_addBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown_addBook_quantity).BeginInit();
            panel_addCustomer.SuspendLayout();
            panel_Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).BeginInit();
            panel_returnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturnBook).BeginInit();
            SuspendLayout();
            // 
            // btn_menu_knihy
            // 
            btn_menu_knihy.Location = new Point(23, 156);
            btn_menu_knihy.Name = "btn_menu_knihy";
            btn_menu_knihy.Size = new Size(201, 50);
            btn_menu_knihy.TabIndex = 0;
            btn_menu_knihy.Text = "Knihy";
            btn_menu_knihy.UseVisualStyleBackColor = true;
            btn_menu_knihy.Click += btn_menu_knihy_Click;
            // 
            // btn_menu_addAuthor
            // 
            btn_menu_addAuthor.Location = new Point(23, 212);
            btn_menu_addAuthor.Name = "btn_menu_addAuthor";
            btn_menu_addAuthor.Size = new Size(201, 50);
            btn_menu_addAuthor.TabIndex = 1;
            btn_menu_addAuthor.Text = "Přidat autora";
            btn_menu_addAuthor.UseVisualStyleBackColor = true;
            btn_menu_addAuthor.Click += btn_menu_addAuthor_Click;
            // 
            // btn_menu_addBook
            // 
            btn_menu_addBook.Location = new Point(23, 268);
            btn_menu_addBook.Name = "btn_menu_addBook";
            btn_menu_addBook.Size = new Size(201, 50);
            btn_menu_addBook.TabIndex = 2;
            btn_menu_addBook.Text = "Přidat knihu";
            btn_menu_addBook.UseVisualStyleBackColor = true;
            btn_menu_addBook.Click += btn_menu_addBook_Click;
            // 
            // btn_menu_addCustomer
            // 
            btn_menu_addCustomer.Location = new Point(23, 324);
            btn_menu_addCustomer.Name = "btn_menu_addCustomer";
            btn_menu_addCustomer.Size = new Size(201, 50);
            btn_menu_addCustomer.TabIndex = 3;
            btn_menu_addCustomer.Text = "Přidat zákazníka ";
            btn_menu_addCustomer.UseVisualStyleBackColor = true;
            btn_menu_addCustomer.Click += btn_menu_addCustomer_Click;
            // 
            // btn_menu_order
            // 
            btn_menu_order.Location = new Point(23, 380);
            btn_menu_order.Name = "btn_menu_order";
            btn_menu_order.Size = new Size(201, 50);
            btn_menu_order.TabIndex = 4;
            btn_menu_order.Text = "Objednávka";
            btn_menu_order.UseVisualStyleBackColor = true;
            btn_menu_order.Click += btn_menu_order_Click;
            // 
            // btn_menu_returnBook
            // 
            btn_menu_returnBook.Location = new Point(23, 436);
            btn_menu_returnBook.Name = "btn_menu_returnBook";
            btn_menu_returnBook.Size = new Size(201, 50);
            btn_menu_returnBook.TabIndex = 5;
            btn_menu_returnBook.Text = "Vrátit knihu";
            btn_menu_returnBook.UseVisualStyleBackColor = true;
            btn_menu_returnBook.Click += btn_menu_returnBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(196, 81);
            label1.TabIndex = 6;
            label1.Text = "Menu";
            // 
            // panel_knihy
            // 
            panel_knihy.BackColor = SystemColors.ButtonHighlight;
            panel_knihy.Controls.Add(btn_Knihy_AddToOrder);
            panel_knihy.Controls.Add(dataGridView1);
            panel_knihy.Controls.Add(cb_knihy_zanr);
            panel_knihy.Controls.Add(label15);
            panel_knihy.Controls.Add(cb_knihy_authors);
            panel_knihy.Controls.Add(label14);
            panel_knihy.Controls.Add(txt_knihy_nazevKnihy);
            panel_knihy.Controls.Add(label13);
            panel_knihy.Controls.Add(label2);
            panel_knihy.Location = new Point(253, 12);
            panel_knihy.Name = "panel_knihy";
            panel_knihy.Size = new Size(955, 653);
            panel_knihy.TabIndex = 7;
            // 
            // btn_Knihy_AddToOrder
            // 
            btn_Knihy_AddToOrder.Location = new Point(270, 587);
            btn_Knihy_AddToOrder.Name = "btn_Knihy_AddToOrder";
            btn_Knihy_AddToOrder.Size = new Size(443, 56);
            btn_Knihy_AddToOrder.TabIndex = 8;
            btn_Knihy_AddToOrder.Text = "Přidat do objednávky";
            btn_Knihy_AddToOrder.UseVisualStyleBackColor = true;
            btn_Knihy_AddToOrder.Click += btn_Knihy_AddToOrder_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(948, 392);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // cb_knihy_zanr
            // 
            cb_knihy_zanr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cb_knihy_zanr.FormattingEnabled = true;
            cb_knihy_zanr.Location = new Point(631, 134);
            cb_knihy_zanr.Name = "cb_knihy_zanr";
            cb_knihy_zanr.Size = new Size(263, 36);
            cb_knihy_zanr.TabIndex = 6;
            cb_knihy_zanr.SelectedIndexChanged += cb_knihy_zanr_SelectedIndexChanged;
            cb_knihy_zanr.TextChanged += cb_knihy_zanr_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label15.Location = new Point(559, 137);
            label15.Name = "label15";
            label15.Size = new Size(55, 28);
            label15.TabIndex = 5;
            label15.Text = "Žánr:";
            // 
            // cb_knihy_authors
            // 
            cb_knihy_authors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cb_knihy_authors.FormattingEnabled = true;
            cb_knihy_authors.Location = new Point(631, 69);
            cb_knihy_authors.Name = "cb_knihy_authors";
            cb_knihy_authors.Size = new Size(263, 36);
            cb_knihy_authors.TabIndex = 4;
            cb_knihy_authors.SelectedIndexChanged += cb_knihy_authors_SelectedIndexChanged;
            cb_knihy_authors.TextChanged += cb_knihy_authors_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label14.Location = new Point(559, 72);
            label14.Name = "label14";
            label14.Size = new Size(66, 28);
            label14.TabIndex = 3;
            label14.Text = "Autor:";
            // 
            // txt_knihy_nazevKnihy
            // 
            txt_knihy_nazevKnihy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_knihy_nazevKnihy.Location = new Point(163, 110);
            txt_knihy_nazevKnihy.Name = "txt_knihy_nazevKnihy";
            txt_knihy_nazevKnihy.Size = new Size(305, 34);
            txt_knihy_nazevKnihy.TabIndex = 2;
            txt_knihy_nazevKnihy.TextChanged += txt_knihy_nazevKnihy_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label13.Location = new Point(35, 110);
            label13.Name = "label13";
            label13.Size = new Size(122, 28);
            label13.TabIndex = 1;
            label13.Text = "Název knihy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(27, 24);
            label2.Name = "label2";
            label2.Size = new Size(130, 54);
            label2.TabIndex = 0;
            label2.Text = "Knihy";
            // 
            // panel_addAuthor
            // 
            panel_addAuthor.BackColor = SystemColors.ButtonHighlight;
            panel_addAuthor.Controls.Add(btn_addAuthor);
            panel_addAuthor.Controls.Add(cbox_Nationality);
            panel_addAuthor.Controls.Add(txt_AuthorName);
            panel_addAuthor.Controls.Add(label5);
            panel_addAuthor.Controls.Add(label4);
            panel_addAuthor.Controls.Add(label3);
            panel_addAuthor.Location = new Point(253, 12);
            panel_addAuthor.Name = "panel_addAuthor";
            panel_addAuthor.Size = new Size(955, 653);
            panel_addAuthor.TabIndex = 8;
            // 
            // btn_addAuthor
            // 
            btn_addAuthor.Location = new Point(259, 328);
            btn_addAuthor.Name = "btn_addAuthor";
            btn_addAuthor.Size = new Size(454, 57);
            btn_addAuthor.TabIndex = 5;
            btn_addAuthor.Text = "Přidat autora";
            btn_addAuthor.UseVisualStyleBackColor = true;
            btn_addAuthor.Click += btn_addAuthor_Click;
            // 
            // cbox_Nationality
            // 
            cbox_Nationality.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbox_Nationality.FormattingEnabled = true;
            cbox_Nationality.Location = new Point(259, 249);
            cbox_Nationality.Name = "cbox_Nationality";
            cbox_Nationality.Size = new Size(554, 39);
            cbox_Nationality.TabIndex = 4;
            // 
            // txt_AuthorName
            // 
            txt_AuthorName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_AuthorName.Location = new Point(259, 189);
            txt_AuthorName.Name = "txt_AuthorName";
            txt_AuthorName.Size = new Size(554, 38);
            txt_AuthorName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(104, 253);
            label5.Name = "label5";
            label5.Size = new Size(127, 31);
            label5.TabIndex = 2;
            label5.Text = "Národnost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(83, 192);
            label4.Name = "label4";
            label4.Size = new Size(157, 31);
            label4.TabIndex = 1;
            label4.Text = "Jméno autora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(27, 15);
            label3.Name = "label3";
            label3.Size = new Size(204, 41);
            label3.TabIndex = 0;
            label3.Text = "Přidat autora";
            // 
            // panel_addBook
            // 
            panel_addBook.BackColor = SystemColors.ControlLightLight;
            panel_addBook.Controls.Add(btn_AddBook_removeAuthor);
            panel_addBook.Controls.Add(btn_AddBook_addAuthor);
            panel_addBook.Controls.Add(listBox_AddNewBook_Authors);
            panel_addBook.Controls.Add(btn_addBook);
            panel_addBook.Controls.Add(rtxt_addBook_popis);
            panel_addBook.Controls.Add(cb_AddNewBook_author);
            panel_addBook.Controls.Add(numUpDown_addBook_quantity);
            panel_addBook.Controls.Add(label22);
            panel_addBook.Controls.Add(txt_addBook_year);
            panel_addBook.Controls.Add(txt_addBook_price);
            panel_addBook.Controls.Add(cb_addBook_zarn);
            panel_addBook.Controls.Add(label21);
            panel_addBook.Controls.Add(label20);
            panel_addBook.Controls.Add(label19);
            panel_addBook.Controls.Add(label18);
            panel_addBook.Controls.Add(label17);
            panel_addBook.Controls.Add(txt_addBook_name);
            panel_addBook.Controls.Add(label16);
            panel_addBook.Controls.Add(label7);
            panel_addBook.Location = new Point(251, 12);
            panel_addBook.Name = "panel_addBook";
            panel_addBook.Size = new Size(957, 653);
            panel_addBook.TabIndex = 6;
            // 
            // btn_AddBook_removeAuthor
            // 
            btn_AddBook_removeAuthor.Location = new Point(669, 276);
            btn_AddBook_removeAuthor.Name = "btn_AddBook_removeAuthor";
            btn_AddBook_removeAuthor.Size = new Size(119, 36);
            btn_AddBook_removeAuthor.TabIndex = 26;
            btn_AddBook_removeAuthor.Text = "Odebrat autora";
            btn_AddBook_removeAuthor.UseVisualStyleBackColor = true;
            btn_AddBook_removeAuthor.Click += btn_AddBook_removeAuthor_Click;
            // 
            // btn_AddBook_addAuthor
            // 
            btn_AddBook_addAuthor.Location = new Point(794, 121);
            btn_AddBook_addAuthor.Name = "btn_AddBook_addAuthor";
            btn_AddBook_addAuthor.Size = new Size(119, 36);
            btn_AddBook_addAuthor.TabIndex = 25;
            btn_AddBook_addAuthor.Text = "Přidat";
            btn_AddBook_addAuthor.UseVisualStyleBackColor = true;
            btn_AddBook_addAuthor.Click += btn_AddBook_addAuthor_Click;
            // 
            // listBox_AddNewBook_Authors
            // 
            listBox_AddNewBook_Authors.FormattingEnabled = true;
            listBox_AddNewBook_Authors.Location = new Point(539, 170);
            listBox_AddNewBook_Authors.Name = "listBox_AddNewBook_Authors";
            listBox_AddNewBook_Authors.Size = new Size(374, 84);
            listBox_AddNewBook_Authors.TabIndex = 24;
            // 
            // btn_addBook
            // 
            btn_addBook.Location = new Point(348, 560);
            btn_addBook.Name = "btn_addBook";
            btn_addBook.Size = new Size(268, 48);
            btn_addBook.TabIndex = 23;
            btn_addBook.Text = "Přidat knihu";
            btn_addBook.UseVisualStyleBackColor = true;
            btn_addBook.Click += btn_addBook_Click;
            // 
            // rtxt_addBook_popis
            // 
            rtxt_addBook_popis.Location = new Point(131, 339);
            rtxt_addBook_popis.Name = "rtxt_addBook_popis";
            rtxt_addBook_popis.Size = new Size(782, 190);
            rtxt_addBook_popis.TabIndex = 22;
            rtxt_addBook_popis.Text = "";
            // 
            // cb_AddNewBook_author
            // 
            cb_AddNewBook_author.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_AddNewBook_author.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cb_AddNewBook_author.FormattingEnabled = true;
            cb_AddNewBook_author.Location = new Point(539, 121);
            cb_AddNewBook_author.Name = "cb_AddNewBook_author";
            cb_AddNewBook_author.Size = new Size(249, 36);
            cb_AddNewBook_author.TabIndex = 21;
            // 
            // numUpDown_addBook_quantity
            // 
            numUpDown_addBook_quantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            numUpDown_addBook_quantity.Location = new Point(131, 274);
            numUpDown_addBook_quantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numUpDown_addBook_quantity.Name = "numUpDown_addBook_quantity";
            numUpDown_addBook_quantity.Size = new Size(374, 38);
            numUpDown_addBook_quantity.TabIndex = 20;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label22.Location = new Point(52, 339);
            label22.Name = "label22";
            label22.Size = new Size(63, 28);
            label22.TabIndex = 19;
            label22.Text = "Popis:";
            // 
            // txt_addBook_year
            // 
            txt_addBook_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_addBook_year.Location = new Point(131, 226);
            txt_addBook_year.Name = "txt_addBook_year";
            txt_addBook_year.Size = new Size(374, 34);
            txt_addBook_year.TabIndex = 18;
            // 
            // txt_addBook_price
            // 
            txt_addBook_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_addBook_price.Location = new Point(132, 175);
            txt_addBook_price.Name = "txt_addBook_price";
            txt_addBook_price.Size = new Size(374, 34);
            txt_addBook_price.TabIndex = 17;
            // 
            // cb_addBook_zarn
            // 
            cb_addBook_zarn.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_addBook_zarn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cb_addBook_zarn.FormattingEnabled = true;
            cb_addBook_zarn.Location = new Point(131, 129);
            cb_addBook_zarn.Name = "cb_addBook_zarn";
            cb_addBook_zarn.Size = new Size(374, 36);
            cb_addBook_zarn.TabIndex = 16;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label21.Location = new Point(13, 278);
            label21.Name = "label21";
            label21.Size = new Size(109, 28);
            label21.TabIndex = 15;
            label21.Text = "Počet kusů:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label20.Location = new Point(10, 226);
            label20.Name = "label20";
            label20.Size = new Size(112, 28);
            label20.TabIndex = 14;
            label20.Text = "Rok vydání:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label19.Location = new Point(29, 178);
            label19.Name = "label19";
            label19.Size = new Size(97, 28);
            label19.TabIndex = 13;
            label19.Text = "Cena (Kč):";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label18.Location = new Point(67, 129);
            label18.Name = "label18";
            label18.Size = new Size(55, 28);
            label18.TabIndex = 12;
            label18.Text = "Žárn:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label17.Location = new Point(539, 81);
            label17.Name = "label17";
            label17.Size = new Size(66, 28);
            label17.TabIndex = 11;
            label17.Text = "Autor:";
            // 
            // txt_addBook_name
            // 
            txt_addBook_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_addBook_name.Location = new Point(131, 81);
            txt_addBook_name.Name = "txt_addBook_name";
            txt_addBook_name.Size = new Size(374, 34);
            txt_addBook_name.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label16.Location = new Point(52, 81);
            label16.Name = "label16";
            label16.Size = new Size(70, 28);
            label16.TabIndex = 9;
            label16.Text = "Název:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(16, 11);
            label7.Name = "label7";
            label7.Size = new Size(383, 54);
            label7.TabIndex = 8;
            label7.Text = "Přidat novou knihu";
            // 
            // panel_addCustomer
            // 
            panel_addCustomer.BackColor = SystemColors.ControlLightLight;
            panel_addCustomer.Controls.Add(txt_phoneNumber);
            panel_addCustomer.Controls.Add(txt_email);
            panel_addCustomer.Controls.Add(label6);
            panel_addCustomer.Controls.Add(btn_addCustomer);
            panel_addCustomer.Controls.Add(txt_customerName);
            panel_addCustomer.Controls.Add(label10);
            panel_addCustomer.Controls.Add(label11);
            panel_addCustomer.Controls.Add(label12);
            panel_addCustomer.Location = new Point(251, 12);
            panel_addCustomer.Name = "panel_addCustomer";
            panel_addCustomer.Size = new Size(957, 653);
            panel_addCustomer.TabIndex = 7;
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_phoneNumber.Location = new Point(272, 312);
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.Size = new Size(554, 38);
            txt_phoneNumber.TabIndex = 15;
            txt_phoneNumber.KeyPress += txt_phoneNumber_KeyPress;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_email.Location = new Point(272, 256);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(554, 38);
            txt_email.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(180, 259);
            label6.Name = "label6";
            label6.Size = new Size(75, 31);
            label6.TabIndex = 13;
            label6.Text = "Email:";
            // 
            // btn_addCustomer
            // 
            btn_addCustomer.Location = new Point(272, 394);
            btn_addCustomer.Name = "btn_addCustomer";
            btn_addCustomer.Size = new Size(454, 57);
            btn_addCustomer.TabIndex = 11;
            btn_addCustomer.Text = "Přidat zákazníka";
            btn_addCustomer.UseVisualStyleBackColor = true;
            btn_addCustomer.Click += btn_addCustomer_Click;
            // 
            // txt_customerName
            // 
            txt_customerName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_customerName.Location = new Point(272, 203);
            txt_customerName.Name = "txt_customerName";
            txt_customerName.Size = new Size(554, 38);
            txt_customerName.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label10.Location = new Point(85, 315);
            label10.Name = "label10";
            label10.Size = new Size(163, 31);
            label10.TabIndex = 8;
            label10.Text = "Telefonní číslo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label11.Location = new Point(67, 206);
            label11.Name = "label11";
            label11.Size = new Size(188, 31);
            label11.TabIndex = 7;
            label11.Text = "Jméno zákazníka:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.Location = new Point(29, 24);
            label12.Name = "label12";
            label12.Size = new Size(249, 41);
            label12.TabIndex = 6;
            label12.Text = "Přidat zákazníka";
            // 
            // panel_Order
            // 
            panel_Order.BackColor = SystemColors.ButtonHighlight;
            panel_Order.Controls.Add(dataGridView_Order);
            panel_Order.Controls.Add(lb_Objednavka_TotalPrice);
            panel_Order.Controls.Add(txt_Objednavka_Id);
            panel_Order.Controls.Add(dateTimePicker_Objednavka);
            panel_Order.Controls.Add(cb_Objednavka_typ);
            panel_Order.Controls.Add(btn_Objednavka_Create);
            panel_Order.Controls.Add(lb_Objednavka_total);
            panel_Order.Controls.Add(label26);
            panel_Order.Controls.Add(lb_Objednavka_Id);
            panel_Order.Controls.Add(lb_Objdenavka_returnDate);
            panel_Order.Controls.Add(label23);
            panel_Order.Controls.Add(label8);
            panel_Order.Location = new Point(251, 12);
            panel_Order.Name = "panel_Order";
            panel_Order.Size = new Size(957, 653);
            panel_Order.TabIndex = 8;
            // 
            // dataGridView_Order
            // 
            dataGridView_Order.AllowUserToAddRows = false;
            dataGridView_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Order.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Order.Location = new Point(94, 253);
            dataGridView_Order.Name = "dataGridView_Order";
            dataGridView_Order.RowHeadersWidth = 51;
            dataGridView_Order.Size = new Size(738, 221);
            dataGridView_Order.TabIndex = 11;
            // 
            // lb_Objednavka_TotalPrice
            // 
            lb_Objednavka_TotalPrice.AutoSize = true;
            lb_Objednavka_TotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lb_Objednavka_TotalPrice.Location = new Point(306, 496);
            lb_Objednavka_TotalPrice.Name = "lb_Objednavka_TotalPrice";
            lb_Objednavka_TotalPrice.Size = new Size(26, 31);
            lb_Objednavka_TotalPrice.TabIndex = 10;
            lb_Objednavka_TotalPrice.Text = "0";
            // 
            // txt_Objednavka_Id
            // 
            txt_Objednavka_Id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_Objednavka_Id.Location = new Point(231, 156);
            txt_Objednavka_Id.Name = "txt_Objednavka_Id";
            txt_Objednavka_Id.Size = new Size(288, 38);
            txt_Objednavka_Id.TabIndex = 9;
            txt_Objednavka_Id.KeyPress += txt_Objednavka_Id_KeyPress;
            // 
            // dateTimePicker_Objednavka
            // 
            dateTimePicker_Objednavka.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateTimePicker_Objednavka.Location = new Point(528, 99);
            dateTimePicker_Objednavka.Name = "dateTimePicker_Objednavka";
            dateTimePicker_Objednavka.Size = new Size(418, 38);
            dateTimePicker_Objednavka.TabIndex = 8;
            // 
            // cb_Objednavka_typ
            // 
            cb_Objednavka_typ.AutoCompleteCustomSource.AddRange(new string[] { "Půjčit", "Koupit" });
            cb_Objednavka_typ.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Objednavka_typ.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cb_Objednavka_typ.FormattingEnabled = true;
            cb_Objednavka_typ.Items.AddRange(new object[] { "Půjčit", "Koupit" });
            cb_Objednavka_typ.Location = new Point(107, 100);
            cb_Objednavka_typ.Name = "cb_Objednavka_typ";
            cb_Objednavka_typ.Size = new Size(151, 39);
            cb_Objednavka_typ.TabIndex = 7;
            cb_Objednavka_typ.SelectedIndexChanged += cb_Objednavka_typ_SelectedIndexChanged;
            // 
            // btn_Objednavka_Create
            // 
            btn_Objednavka_Create.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_Objednavka_Create.Location = new Point(328, 560);
            btn_Objednavka_Create.Name = "btn_Objednavka_Create";
            btn_Objednavka_Create.Size = new Size(299, 73);
            btn_Objednavka_Create.TabIndex = 6;
            btn_Objednavka_Create.Text = "Vytvořit objednávku";
            btn_Objednavka_Create.UseVisualStyleBackColor = true;
            btn_Objednavka_Create.Click += btn_Objednavka_Create_Click;
            // 
            // lb_Objednavka_total
            // 
            lb_Objednavka_total.AutoSize = true;
            lb_Objednavka_total.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lb_Objednavka_total.Location = new Point(133, 491);
            lb_Objednavka_total.Name = "lb_Objednavka_total";
            lb_Objednavka_total.Size = new Size(122, 38);
            lb_Objednavka_total.TabIndex = 5;
            lb_Objednavka_total.Text = "Celkem:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label26.Location = new Point(34, 206);
            label26.Name = "label26";
            label26.Size = new Size(215, 38);
            label26.TabIndex = 4;
            label26.Text = "Vybrané knihy:";
            // 
            // lb_Objednavka_Id
            // 
            lb_Objednavka_Id.AutoSize = true;
            lb_Objednavka_Id.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lb_Objednavka_Id.Location = new Point(34, 156);
            lb_Objednavka_Id.Name = "lb_Objednavka_Id";
            lb_Objednavka_Id.Size = new Size(191, 38);
            lb_Objednavka_Id.TabIndex = 3;
            lb_Objednavka_Id.Text = "ID zákazníka:";
            // 
            // lb_Objdenavka_returnDate
            // 
            lb_Objdenavka_returnDate.AutoSize = true;
            lb_Objdenavka_returnDate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lb_Objdenavka_returnDate.Location = new Point(283, 100);
            lb_Objdenavka_returnDate.Name = "lb_Objdenavka_returnDate";
            lb_Objdenavka_returnDate.Size = new Size(217, 38);
            lb_Objdenavka_returnDate.TabIndex = 2;
            lb_Objdenavka_returnDate.Text = "Datum vrácení:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label23.Location = new Point(29, 98);
            label23.Name = "label23";
            label23.Size = new Size(72, 38);
            label23.TabIndex = 1;
            label23.Text = "Typ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.Location = new Point(13, 15);
            label8.Name = "label8";
            label8.Size = new Size(409, 54);
            label8.TabIndex = 0;
            label8.Text = "Vytvořit objdenávku";
            // 
            // panel_returnBook
            // 
            panel_returnBook.BackColor = SystemColors.ControlLightLight;
            panel_returnBook.Controls.Add(label27);
            panel_returnBook.Controls.Add(label25);
            panel_returnBook.Controls.Add(dateTimePicker_ReturnBook_ReturnDate);
            panel_returnBook.Controls.Add(dateTimePicker_ReturnBook_FromDate);
            panel_returnBook.Controls.Add(btn_ReturnBook_Return);
            panel_returnBook.Controls.Add(btn_ReturnBook_ReturnAll);
            panel_returnBook.Controls.Add(dataGridViewReturnBook);
            panel_returnBook.Controls.Add(btn_ReturnBook_Find);
            panel_returnBook.Controls.Add(txt_ReturnBook_CustomerID);
            panel_returnBook.Controls.Add(label24);
            panel_returnBook.Controls.Add(label9);
            panel_returnBook.Location = new Point(250, 12);
            panel_returnBook.Name = "panel_returnBook";
            panel_returnBook.Size = new Size(957, 653);
            panel_returnBook.TabIndex = 9;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label27.Location = new Point(558, 163);
            label27.Name = "label27";
            label27.Size = new Size(44, 28);
            label27.TabIndex = 10;
            label27.Text = "Do:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label25.Location = new Point(63, 163);
            label25.Name = "label25";
            label25.Size = new Size(44, 28);
            label25.TabIndex = 9;
            label25.Text = "Od:";
            // 
            // dateTimePicker_ReturnBook_ReturnDate
            // 
            dateTimePicker_ReturnBook_ReturnDate.Location = new Point(612, 163);
            dateTimePicker_ReturnBook_ReturnDate.Name = "dateTimePicker_ReturnBook_ReturnDate";
            dateTimePicker_ReturnBook_ReturnDate.Size = new Size(250, 27);
            dateTimePicker_ReturnBook_ReturnDate.TabIndex = 8;
            // 
            // dateTimePicker_ReturnBook_FromDate
            // 
            dateTimePicker_ReturnBook_FromDate.Location = new Point(123, 165);
            dateTimePicker_ReturnBook_FromDate.Name = "dateTimePicker_ReturnBook_FromDate";
            dateTimePicker_ReturnBook_FromDate.Size = new Size(250, 27);
            dateTimePicker_ReturnBook_FromDate.TabIndex = 7;
            // 
            // btn_ReturnBook_Return
            // 
            btn_ReturnBook_Return.Location = new Point(516, 572);
            btn_ReturnBook_Return.Name = "btn_ReturnBook_Return";
            btn_ReturnBook_Return.Size = new Size(420, 71);
            btn_ReturnBook_Return.TabIndex = 6;
            btn_ReturnBook_Return.Text = "Vrátit";
            btn_ReturnBook_Return.UseVisualStyleBackColor = true;
            btn_ReturnBook_Return.Click += btn_ReturnBook_Return_Click;
            // 
            // btn_ReturnBook_ReturnAll
            // 
            btn_ReturnBook_ReturnAll.Location = new Point(30, 572);
            btn_ReturnBook_ReturnAll.Name = "btn_ReturnBook_ReturnAll";
            btn_ReturnBook_ReturnAll.Size = new Size(476, 71);
            btn_ReturnBook_ReturnAll.TabIndex = 5;
            btn_ReturnBook_ReturnAll.Text = "Vrátit všechno";
            btn_ReturnBook_ReturnAll.UseVisualStyleBackColor = true;
            btn_ReturnBook_ReturnAll.Click += btn_ReturnBook_ReturnAll_Click;
            // 
            // dataGridViewReturnBook
            // 
            dataGridViewReturnBook.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewReturnBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReturnBook.Location = new Point(30, 226);
            dataGridViewReturnBook.Name = "dataGridViewReturnBook";
            dataGridViewReturnBook.RowHeadersWidth = 51;
            dataGridViewReturnBook.Size = new Size(906, 335);
            dataGridViewReturnBook.TabIndex = 4;
            // 
            // btn_ReturnBook_Find
            // 
            btn_ReturnBook_Find.Location = new Point(612, 81);
            btn_ReturnBook_Find.Name = "btn_ReturnBook_Find";
            btn_ReturnBook_Find.Size = new Size(103, 39);
            btn_ReturnBook_Find.TabIndex = 3;
            btn_ReturnBook_Find.Text = "Hledat";
            btn_ReturnBook_Find.UseVisualStyleBackColor = true;
            btn_ReturnBook_Find.Click += btn_ReturnBook_Find_Click;
            // 
            // txt_ReturnBook_CustomerID
            // 
            txt_ReturnBook_CustomerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_ReturnBook_CustomerID.Location = new Point(208, 84);
            txt_ReturnBook_CustomerID.Name = "txt_ReturnBook_CustomerID";
            txt_ReturnBook_CustomerID.Size = new Size(389, 34);
            txt_ReturnBook_CustomerID.TabIndex = 2;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label24.Location = new Point(47, 87);
            label24.Name = "label24";
            label24.Size = new Size(155, 31);
            label24.TabIndex = 1;
            label24.Text = "ID zákazníka:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.Location = new Point(6, 5);
            label9.Name = "label9";
            label9.Size = new Size(244, 54);
            label9.TabIndex = 0;
            label9.Text = "Vrátit knihy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 677);
            Controls.Add(label1);
            Controls.Add(btn_menu_returnBook);
            Controls.Add(btn_menu_order);
            Controls.Add(btn_menu_addCustomer);
            Controls.Add(btn_menu_addBook);
            Controls.Add(btn_menu_addAuthor);
            Controls.Add(btn_menu_knihy);
            Controls.Add(panel_returnBook);
            Controls.Add(panel_Order);
            Controls.Add(panel_addCustomer);
            Controls.Add(panel_addBook);
            Controls.Add(panel_addAuthor);
            Controls.Add(panel_knihy);
            Name = "Form1";
            Text = "Books Management";
            panel_knihy.ResumeLayout(false);
            panel_knihy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_addAuthor.ResumeLayout(false);
            panel_addAuthor.PerformLayout();
            panel_addBook.ResumeLayout(false);
            panel_addBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown_addBook_quantity).EndInit();
            panel_addCustomer.ResumeLayout(false);
            panel_addCustomer.PerformLayout();
            panel_Order.ResumeLayout(false);
            panel_Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).EndInit();
            panel_returnBook.ResumeLayout(false);
            panel_returnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturnBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_menu_knihy;
        private Button btn_menu_addAuthor;
        private Button btn_menu_addBook;
        private Button btn_menu_addCustomer;
        private Button btn_menu_order;
        private Button btn_menu_returnBook;
        private Label label1;
        private Panel panel_knihy;
        private Panel panel_addAuthor;
        private Label label2;
        private Label label3;
        private TextBox txt_AuthorName;
        private Label label5;
        private Label label4;
        private ComboBox cbox_Nationality;
        private Button btn_addAuthor;
        private Panel panel_addBook;
        private Panel panel_addCustomer;
        private Panel panel_Order;
        private Label label8;
        private Panel panel_returnBook;
        private Label label9;
        private Label label7;
        private Button btn_addCustomer;
        private TextBox txt_customerName;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txt_email;
        private Label label6;
        private TextBox txt_phoneNumber;
        private ComboBox cb_knihy_authors;
        private Label label14;
        private TextBox txt_knihy_nazevKnihy;
        private Label label13;
        private ComboBox cb_knihy_zanr;
        private Label label15;
        private TextBox txt_addBook_name;
        private Label label16;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private ComboBox cb_addBook_zarn;
        private TextBox txt_addBook_price;
        private TextBox txt_addBook_year;
        private NumericUpDown numUpDown_addBook_quantity;
        private Label label22;
        private ComboBox cb_AddNewBook_author;
        private RichTextBox rtxt_addBook_popis;
        private Button btn_addBook;
        private ListBox listBox_AddNewBook_Authors;
        private Button btn_AddBook_addAuthor;
        private Button btn_AddBook_removeAuthor;
        private DataGridView dataGridView1;
        private Label lb_Objdenavka_returnDate;
        private Label label23;
        private Button btn_Objednavka_Create;
        private Label lb_Objednavka_total;
        private Label label26;
        private Label lb_Objednavka_Id;
        private ComboBox cb_Objednavka_typ;
        private Label lb_Objednavka_TotalPrice;
        private TextBox txt_Objednavka_Id;
        private DateTimePicker dateTimePicker_Objednavka;
        private DataGridView dataGridView_Order;
        private Button btn_Knihy_AddToOrder;
        private Button btn_ReturnBook_Find;
        private TextBox txt_ReturnBook_CustomerID;
        private Label label24;
        private Button btn_ReturnBook_Return;
        private Button btn_ReturnBook_ReturnAll;
        private DataGridView dataGridViewReturnBook;
        private Label label27;
        private Label label25;
        private DateTimePicker dateTimePicker_ReturnBook_ReturnDate;
        private DateTimePicker dateTimePicker_ReturnBook_FromDate;
    }
}

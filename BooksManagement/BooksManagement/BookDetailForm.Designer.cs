namespace BooksManagement
{
    partial class BookDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_addBook = new Panel();
            btn_BookDetail_addToCart = new Button();
            btn_BookDetail_removeAuthor = new Button();
            btn_BookDetail_addAuthor = new Button();
            listBox_BookDetail_Authors = new ListBox();
            btn_BookDetail_update = new Button();
            rtxt_BookDetail_popis = new RichTextBox();
            cb_BookDetail_author = new ComboBox();
            numUpDown_BookDetail_quantity = new NumericUpDown();
            label22 = new Label();
            txt_BookDetail_year = new TextBox();
            txt_BookDetail_price = new TextBox();
            cb_BookDetail_zanr = new ComboBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            txt_BookDetail_name = new TextBox();
            label16 = new Label();
            label7 = new Label();
            panel_addBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown_BookDetail_quantity).BeginInit();
            SuspendLayout();
            // 
            // panel_addBook
            // 
            panel_addBook.BackColor = SystemColors.ControlLightLight;
            panel_addBook.Controls.Add(btn_BookDetail_addToCart);
            panel_addBook.Controls.Add(btn_BookDetail_removeAuthor);
            panel_addBook.Controls.Add(btn_BookDetail_addAuthor);
            panel_addBook.Controls.Add(listBox_BookDetail_Authors);
            panel_addBook.Controls.Add(btn_BookDetail_update);
            panel_addBook.Controls.Add(rtxt_BookDetail_popis);
            panel_addBook.Controls.Add(cb_BookDetail_author);
            panel_addBook.Controls.Add(numUpDown_BookDetail_quantity);
            panel_addBook.Controls.Add(label22);
            panel_addBook.Controls.Add(txt_BookDetail_year);
            panel_addBook.Controls.Add(txt_BookDetail_price);
            panel_addBook.Controls.Add(cb_BookDetail_zanr);
            panel_addBook.Controls.Add(label21);
            panel_addBook.Controls.Add(label20);
            panel_addBook.Controls.Add(label19);
            panel_addBook.Controls.Add(label18);
            panel_addBook.Controls.Add(label17);
            panel_addBook.Controls.Add(txt_BookDetail_name);
            panel_addBook.Controls.Add(label16);
            panel_addBook.Controls.Add(label7);
            panel_addBook.Location = new Point(12, 12);
            panel_addBook.Name = "panel_addBook";
            panel_addBook.Size = new Size(957, 653);
            panel_addBook.TabIndex = 7;
            // 
            // btn_BookDetail_addToCart
            // 
            btn_BookDetail_addToCart.Location = new Point(580, 553);
            btn_BookDetail_addToCart.Name = "btn_BookDetail_addToCart";
            btn_BookDetail_addToCart.Size = new Size(365, 92);
            btn_BookDetail_addToCart.TabIndex = 27;
            btn_BookDetail_addToCart.Text = "Přidat do košíku";
            btn_BookDetail_addToCart.UseVisualStyleBackColor = true;
            btn_BookDetail_addToCart.Click += btn_BookDetail_addToCart_Click;
            // 
            // btn_BookDetail_removeAuthor
            // 
            btn_BookDetail_removeAuthor.Location = new Point(669, 276);
            btn_BookDetail_removeAuthor.Name = "btn_BookDetail_removeAuthor";
            btn_BookDetail_removeAuthor.Size = new Size(119, 36);
            btn_BookDetail_removeAuthor.TabIndex = 26;
            btn_BookDetail_removeAuthor.Text = "Odebrat autora";
            btn_BookDetail_removeAuthor.UseVisualStyleBackColor = true;
            btn_BookDetail_removeAuthor.Click += btn_BookDetail_removeAuthor_Click;
            // 
            // btn_BookDetail_addAuthor
            // 
            btn_BookDetail_addAuthor.Location = new Point(794, 121);
            btn_BookDetail_addAuthor.Name = "btn_BookDetail_addAuthor";
            btn_BookDetail_addAuthor.Size = new Size(119, 36);
            btn_BookDetail_addAuthor.TabIndex = 25;
            btn_BookDetail_addAuthor.Text = "Přidat";
            btn_BookDetail_addAuthor.UseVisualStyleBackColor = true;
            btn_BookDetail_addAuthor.Click += btn_BookDetail_addAuthor_Click;
            // 
            // listBox_BookDetail_Authors
            // 
            listBox_BookDetail_Authors.FormattingEnabled = true;
            listBox_BookDetail_Authors.Location = new Point(539, 170);
            listBox_BookDetail_Authors.Name = "listBox_BookDetail_Authors";
            listBox_BookDetail_Authors.Size = new Size(374, 84);
            listBox_BookDetail_Authors.TabIndex = 24;
            // 
            // btn_BookDetail_update
            // 
            btn_BookDetail_update.Location = new Point(16, 571);
            btn_BookDetail_update.Name = "btn_BookDetail_update";
            btn_BookDetail_update.Size = new Size(305, 56);
            btn_BookDetail_update.TabIndex = 23;
            btn_BookDetail_update.Text = "Aktualizovat knihu";
            btn_BookDetail_update.UseVisualStyleBackColor = true;
            btn_BookDetail_update.Click += btn_BookDetail_update_Click;
            // 
            // rtxt_BookDetail_popis
            // 
            rtxt_BookDetail_popis.Location = new Point(131, 339);
            rtxt_BookDetail_popis.Name = "rtxt_BookDetail_popis";
            rtxt_BookDetail_popis.Size = new Size(782, 190);
            rtxt_BookDetail_popis.TabIndex = 22;
            rtxt_BookDetail_popis.Text = "";
            // 
            // cb_BookDetail_author
            // 
            cb_BookDetail_author.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_BookDetail_author.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cb_BookDetail_author.FormattingEnabled = true;
            cb_BookDetail_author.Location = new Point(539, 121);
            cb_BookDetail_author.Name = "cb_BookDetail_author";
            cb_BookDetail_author.Size = new Size(249, 36);
            cb_BookDetail_author.TabIndex = 21;
            // 
            // numUpDown_BookDetail_quantity
            // 
            numUpDown_BookDetail_quantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            numUpDown_BookDetail_quantity.Location = new Point(131, 274);
            numUpDown_BookDetail_quantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numUpDown_BookDetail_quantity.Name = "numUpDown_BookDetail_quantity";
            numUpDown_BookDetail_quantity.Size = new Size(374, 38);
            numUpDown_BookDetail_quantity.TabIndex = 20;
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
            // txt_BookDetail_year
            // 
            txt_BookDetail_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_BookDetail_year.Location = new Point(131, 226);
            txt_BookDetail_year.Name = "txt_BookDetail_year";
            txt_BookDetail_year.Size = new Size(374, 34);
            txt_BookDetail_year.TabIndex = 18;
            // 
            // txt_BookDetail_price
            // 
            txt_BookDetail_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_BookDetail_price.Location = new Point(132, 175);
            txt_BookDetail_price.Name = "txt_BookDetail_price";
            txt_BookDetail_price.Size = new Size(374, 34);
            txt_BookDetail_price.TabIndex = 17;
            // 
            // cb_BookDetail_zanr
            // 
            cb_BookDetail_zanr.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_BookDetail_zanr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cb_BookDetail_zanr.FormattingEnabled = true;
            cb_BookDetail_zanr.Location = new Point(131, 129);
            cb_BookDetail_zanr.Name = "cb_BookDetail_zanr";
            cb_BookDetail_zanr.Size = new Size(374, 36);
            cb_BookDetail_zanr.TabIndex = 16;
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
            // txt_BookDetail_name
            // 
            txt_BookDetail_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_BookDetail_name.Location = new Point(131, 81);
            txt_BookDetail_name.Name = "txt_BookDetail_name";
            txt_BookDetail_name.Size = new Size(374, 34);
            txt_BookDetail_name.TabIndex = 10;
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
            label7.Size = new Size(249, 54);
            label7.TabIndex = 8;
            label7.Text = "Detail knihy";
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 674);
            Controls.Add(panel_addBook);
            Name = "BookDetailForm";
            Text = "Book Detail";
            panel_addBook.ResumeLayout(false);
            panel_addBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown_BookDetail_quantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_addBook;
        private Button btn_BookDetail_removeAuthor;
        private Button btn_BookDetail_addAuthor;
        private ListBox listBox_BookDetail_Authors;
        private Button btn_BookDetail_update;
        private RichTextBox rtxt_BookDetail_popis;
        private ComboBox cb_BookDetail_author;
        private NumericUpDown numUpDown_BookDetail_quantity;
        private Label label22;
        private TextBox txt_BookDetail_year;
        private TextBox txt_BookDetail_price;
        private ComboBox cb_BookDetail_zanr;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private TextBox txt_BookDetail_name;
        private Label label16;
        private Label label7;
        private Button btn_BookDetail_addToCart;
    }
}
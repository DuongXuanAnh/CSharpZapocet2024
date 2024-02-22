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
            label2 = new Label();
            panel_addAuthor = new Panel();
            btn_addAuthor = new Button();
            cbox_Nationality = new ComboBox();
            txt_AuthorName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel_addBook = new Panel();
            label7 = new Label();
            panel_addCustomer = new Panel();
            panel_Order = new Panel();
            label8 = new Label();
            panel_returnBook = new Panel();
            label9 = new Label();
            btn_addCustomer = new Button();
            txt_customerName = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dateTimePicker_customer = new DateTimePicker();
            panel_knihy.SuspendLayout();
            panel_addAuthor.SuspendLayout();
            panel_addBook.SuspendLayout();
            panel_addCustomer.SuspendLayout();
            panel_Order.SuspendLayout();
            panel_returnBook.SuspendLayout();
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
            panel_knihy.Controls.Add(label2);
            panel_knihy.Location = new Point(253, 12);
            panel_knihy.Name = "panel_knihy";
            panel_knihy.Size = new Size(955, 653);
            panel_knihy.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 15);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
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
            btn_addAuthor.Location = new Point(259, 265);
            btn_addAuthor.Name = "btn_addAuthor";
            btn_addAuthor.Size = new Size(454, 57);
            btn_addAuthor.TabIndex = 5;
            btn_addAuthor.Text = "Přidat autora";
            btn_addAuthor.UseVisualStyleBackColor = true;
            // 
            // cbox_Nationality
            // 
            cbox_Nationality.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbox_Nationality.FormattingEnabled = true;
            cbox_Nationality.Location = new Point(259, 186);
            cbox_Nationality.Name = "cbox_Nationality";
            cbox_Nationality.Size = new Size(554, 39);
            cbox_Nationality.TabIndex = 4;
            // 
            // txt_AuthorName
            // 
            txt_AuthorName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txt_AuthorName.Location = new Point(259, 126);
            txt_AuthorName.Name = "txt_AuthorName";
            txt_AuthorName.Size = new Size(554, 38);
            txt_AuthorName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(104, 190);
            label5.Name = "label5";
            label5.Size = new Size(127, 31);
            label5.TabIndex = 2;
            label5.Text = "Národnost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(83, 129);
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
            panel_addBook.Controls.Add(label7);
            panel_addBook.Location = new Point(251, 12);
            panel_addBook.Name = "panel_addBook";
            panel_addBook.Size = new Size(957, 653);
            panel_addBook.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 110);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 8;
            label7.Text = "add book";
            // 
            // panel_addCustomer
            // 
            panel_addCustomer.BackColor = SystemColors.ControlLightLight;
            panel_addCustomer.Controls.Add(dateTimePicker_customer);
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
            // panel_Order
            // 
            panel_Order.BackColor = SystemColors.ControlLightLight;
            panel_Order.Controls.Add(label8);
            panel_Order.Location = new Point(251, 12);
            panel_Order.Name = "panel_Order";
            panel_Order.Size = new Size(957, 653);
            panel_Order.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(306, 150);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 0;
            label8.Text = "pridat objdenavku";
            // 
            // panel_returnBook
            // 
            panel_returnBook.BackColor = SystemColors.ControlLightLight;
            panel_returnBook.Controls.Add(label9);
            panel_returnBook.Location = new Point(250, 12);
            panel_returnBook.Name = "panel_returnBook";
            panel_returnBook.Size = new Size(957, 653);
            panel_returnBook.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(306, 150);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 0;
            label9.Text = "vratit knihu";
            // 
            // btn_addCustomer
            // 
            btn_addCustomer.Location = new Point(272, 342);
            btn_addCustomer.Name = "btn_addCustomer";
            btn_addCustomer.Size = new Size(454, 57);
            btn_addCustomer.TabIndex = 11;
            btn_addCustomer.Text = "Přidat zákazníka";
            btn_addCustomer.UseVisualStyleBackColor = true;
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
            label10.Location = new Point(74, 266);
            label10.Name = "label10";
            label10.Size = new Size(181, 31);
            label10.TabIndex = 8;
            label10.Text = "Datum narození:";
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
            // dateTimePicker_customer
            // 
            dateTimePicker_customer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateTimePicker_customer.Location = new Point(272, 263);
            dateTimePicker_customer.Name = "dateTimePicker_customer";
            dateTimePicker_customer.Size = new Size(554, 38);
            dateTimePicker_customer.TabIndex = 12;
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
            Controls.Add(panel_addCustomer);
            Controls.Add(panel_addBook);
            Controls.Add(panel_addAuthor);
            Controls.Add(panel_knihy);
            Controls.Add(panel_returnBook);
            Controls.Add(panel_Order);
            Name = "Form1";
            Text = "Books Management";
            panel_knihy.ResumeLayout(false);
            panel_knihy.PerformLayout();
            panel_addAuthor.ResumeLayout(false);
            panel_addAuthor.PerformLayout();
            panel_addBook.ResumeLayout(false);
            panel_addBook.PerformLayout();
            panel_addCustomer.ResumeLayout(false);
            panel_addCustomer.PerformLayout();
            panel_Order.ResumeLayout(false);
            panel_Order.PerformLayout();
            panel_returnBook.ResumeLayout(false);
            panel_returnBook.PerformLayout();
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
        private DateTimePicker dateTimePicker_customer;
        private Button btn_addCustomer;
        private TextBox txt_customerName;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}

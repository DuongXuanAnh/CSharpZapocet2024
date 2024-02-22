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
            MainPanel = new Panel();
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
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonHighlight;
            MainPanel.Location = new Point(252, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(956, 653);
            MainPanel.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 677);
            Controls.Add(MainPanel);
            Controls.Add(label1);
            Controls.Add(btn_menu_returnBook);
            Controls.Add(btn_menu_order);
            Controls.Add(btn_menu_addCustomer);
            Controls.Add(btn_menu_addBook);
            Controls.Add(btn_menu_addAuthor);
            Controls.Add(btn_menu_knihy);
            Name = "Form1";
            Text = "Books Management";
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
        private Panel MainPanel;
    }
}

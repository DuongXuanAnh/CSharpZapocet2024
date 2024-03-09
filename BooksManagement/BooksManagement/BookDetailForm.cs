using System;
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
            this.bookID = bookID;
        }

        
    }
}

using BooksManagement.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement
{
    internal class Order
    {
        Dictionary<int, int> bookInOrder;

        public Order(Dictionary<int, int> bookInOrder)
        {
            this.bookInOrder = bookInOrder;
        }

        public void Sell()
        {
            foreach (var item in bookInOrder)
            {
                int bookId = item.Key;
                int quantityToSubtract = item.Value;

                // SQL příkaz pro odečtení množství
                string query = "UPDATE kniha SET amount = amount - @quantityToSubtract WHERE id = @bookId";

                // Slovník pro parametry
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@quantityToSubtract", quantityToSubtract);
                parameters.Add("@bookId", bookId);

                try
                {
                    // Vykonání příkazu
                    DataProvider.Instance.ExecuteModifiedQuery(query, parameters);
                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
            }
        }

        public void Borrow()
        {

        }


        public static void DeleteBookFromFIle(string ID)
        {
            var filePath = "OrderBook.txt";
            var tempFile = Path.GetTempFileName(); 

            using (var sr = new StreamReader(filePath))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.StartsWith(ID + "_"))
                    {
                        sw.WriteLine(line); 
                    }
                }
            }
       
            File.Delete(filePath);
            File.Move(tempFile, filePath); 
        }

       
    }

    
}

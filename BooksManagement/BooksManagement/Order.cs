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
            TakeBookFromDB();
        }

        public void Borrow(int customerId, DateTime returnDate)
        {
            string insertDokladQuery = "INSERT INTO `doklad` (`datumTo`) VALUES (@ReturnDate);"; // Assuming `id` is auto-incremented

                Dictionary<string, object> dokladParameters = new Dictionary<string, object>
                {
                    { "@ReturnDate", returnDate }
                };

                DataProvider dataProvider = DataProvider.Instance;
                int dokladId = dataProvider.ExecuteModifiedQueryWithID(insertDokladQuery, dokladParameters);

                // Check if the insertion was successful
                if (dokladId != -1)
                {

                try
                {
                    string insertDokladZakaznikQuery = "INSERT INTO `doklad_zakaznik`(`id_doklad`, `id_zakaznik`) VALUES (@DokladId, @CustomerId);";

                    Dictionary<string, object> dokladZakaznikParameters = new Dictionary<string, object>
                    {
                        { "@DokladId", dokladId },
                        { "@CustomerId", customerId }
                    };
                    dataProvider.ExecuteModifiedQuery(insertDokladZakaznikQuery, dokladZakaznikParameters);

                    foreach (var item in bookInOrder)
                    {
                        string insertDokladKnihaQuery = "INSERT INTO `doklad_kniha`(`id_doklad`, `id_kniha`, `amount`) VALUES (@DokladId, @IdKniha, @Amount);";

                        Dictionary<string, object> dokladKnihaParameters = new Dictionary<string, object>
                        {
                            { "@DokladId", dokladId },
                            { "@IdKniha", item.Key },
                            { "@Amount", item.Value }
                        };
                        dataProvider.ExecuteModifiedQuery(insertDokladKnihaQuery, dokladKnihaParameters);

                    }
                    TakeBookFromDB();
                } catch
                    {
                    throw new Exception();
                    }                
                }
                else
                {
                throw new Exception();
                }
        }

        private void TakeBookFromDB()
        {
            foreach (var item in bookInOrder)
            {
                int bookId = item.Key;
                int quantityToSubtract = item.Value;

                string query = "UPDATE kniha SET amount = amount - @quantityToSubtract WHERE id = @bookId";

                var parameters = new Dictionary<string, object>
                    {
                        { "@quantityToSubtract", quantityToSubtract },
                        { "@bookId", bookId }
                    };

                try
                {
                    DataProvider.Instance.ExecuteModifiedQuery(query, parameters);
                }
                catch
                {
                    throw new Exception();
                }
            }
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

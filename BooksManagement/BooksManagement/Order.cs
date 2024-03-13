using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement
{
    internal class Order
    {


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

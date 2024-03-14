using BooksManagement.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement
{
    internal class ReturnBook
    {
        int customerID;

        public ReturnBook(int customerID)
        {
            this.customerID = customerID;
        }


        public DataTable GetCustomOrderInfo()
        {
            string query = "SELECT `dokladID`, `nazev`, `datum`, `datumTo`, `amount`, `bookID` FROM `document`";
            DataTable data = DataProvider.Instance.ExecuteSelectQuery(query);

            return data;
        }

        public DataTable GetCustomOrderInfo(string startDate, string endDate)
        {
            // SQL dotaz s parametry pro filtraci podle data
            string query = @"SELECT `dokladID`, `nazev`, `datum`, `datumTo`, `amount`, `jmeno`, `zakaznikID`, `bookID` 
                     FROM `document`
                     WHERE `datum` >= @startDate AND `datumTo` <= @endDate";

            var parameters = new Dictionary<string, object>
            {
                { "@startDate", startDate },
                { "@endDate", endDate }
            };

            DataTable data = DataProvider.Instance.ExecuteSelectQueryWithParameter(query, parameters);



            return data;
        }

    }
}

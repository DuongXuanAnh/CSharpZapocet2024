using BooksManagement.Config;
using Mysqlx.Crud;
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
            string query = "SELECT `dokladID`, `nazev`, `datum`, `datumTo`, `amount`, `bookID`, `zakaznikID` FROM `document` WHERE zakaznikID = @customerID";
            var parameters = new Dictionary<string, object>
            {
                { "@customerID", customerID }
            };
            DataTable data = DataProvider.Instance.ExecuteSelectQueryWithParameter(query, parameters);

            return data;
        }

        public DataTable GetCustomOrderInfo(string startDate, string endDate)
        {
            string query = @"SELECT `dokladID`, `nazev`, `datum`, `datumTo`, `amount`, `jmeno`, `zakaznikID`, `bookID` 
                     FROM `document`
                     WHERE `datum` >= @startDate AND `datumTo` <= @endDate AND zakaznikID = @customerID";

            var parameters = new Dictionary<string, object>
            {
                { "@startDate", startDate },
                { "@endDate", endDate },
                { "@customerID", customerID }
            };

            DataTable data = DataProvider.Instance.ExecuteSelectQueryWithParameter(query, parameters);

            return data;
        }

        public void ReturnSeletedBook(int dokladID, int bookID)
        {
            string countDokladID_Query = "SELECT dokladID FROM `document` WHERE dokladID = @dokladID";
            var parameters_countDokladID = new Dictionary<string, object>
            {
                { "@dokladID", dokladID }
            };

            DataTable data = DataProvider.Instance.ExecuteSelectQueryWithParameter(countDokladID_Query, parameters_countDokladID);

            if ( data.Rows.Count > 1)
            {
                DeleteSelectedBookFromOrder(dokladID, bookID);
            }
            else
            {
                DeleteAllSelectedOrder(dokladID);
            }
        }

        private void DeleteSelectedBookFromOrder(int dokladID, int bookID)
        {
            string deleteQuery = "DELETE FROM `doklad_kniha` WHERE id_doklad = @dokladID AND id_kniha = @bookID";

            var parameters = new Dictionary<string, object>
                {
                    { "@dokladID", dokladID },
                    { "@bookID", bookID }
                };

            try
            {
                DataProvider.Instance.ExecuteModifiedQuery(deleteQuery, parameters);
            }
            catch
            {
                throw new Exception();
            }



        }

        private void DeleteAllSelectedOrder(int dokladID)
        {

        }
    }
}

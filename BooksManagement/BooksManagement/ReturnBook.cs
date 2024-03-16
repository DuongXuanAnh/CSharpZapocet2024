using BooksManagement.Config;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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

        public void ReturnSeletedBook(int dokladID, int bookID, DateTime returnDate)
        {
            double penalty = PenalizationForDelay(returnDate);

            if (penalty > 0)
            {
                DialogResult result = MessageBox.Show($"Penalizace za zpoždění je {penalty} Kč. Chcete pokračovat?", "Penalizace", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }


            string countDokladID_Query = "SELECT dokladID FROM `document` WHERE dokladID = @dokladID";
            var parameters_countDokladID = new Dictionary<string, object>
            {
                { "@dokladID", dokladID }
            };

            DataTable data = DataProvider.Instance.ExecuteSelectQueryWithParameter(countDokladID_Query, parameters_countDokladID);

            if (data.Rows.Count > 1)
            {
                UpdateBookAmount(dokladID, bookID);
                DeleteSelectedBookFromOrder(dokladID, bookID);
            }
            else
            {
                UpdateBookAmount(dokladID, bookID);
                DeleteAllSelectedOrder(dokladID);
            }

            MessageBox.Show("Kniha byla úspěšně vrácena!");

        }

        private double PenalizationForDelay(DateTime returnDate)
        {
            DateTime today = DateTime.Today;

            if (returnDate < today)
            {
                int daysLate = (today - returnDate).Days;

                return daysLate * 5;
            }

            return 0;
        }

        private void UpdateBookAmount(int dokladID, int bookID)
        {
            string getAmount_Query = "SELECT amount FROM `doklad_kniha` WHERE id_doklad = @dokladID AND id_kniha = @bookID";
            var parameters = new Dictionary<string, object>
                {
                    { "@dokladID", dokladID },
                    { "@bookID", bookID }
                };

            try
            {
                DataTable data = DataProvider.Instance.ExecuteSelectQueryWithParameter(getAmount_Query,parameters);

                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    int amount = Convert.ToInt32(row["amount"]);

                    string updateBooks_Query = "UPDATE `kniha` SET `amount` = `amount` + @newAmount WHERE `id` = @bookID";

                    var updateParameters = new Dictionary<string, object>
                        {
                            { "@newAmount", amount }, 
                            { "@bookID", bookID } 
                        };

                    try
                    {
                        DataProvider.Instance.ExecuteModifiedQueryWithID(updateBooks_Query, updateParameters);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Chyba při aktualizaci množství knihy.", ex);
                    }
                }
                else
                {
                    // Řádek nebyl nalezen
                    throw new Exception("Žádná data nebyla nalezena pro zadané ID dokladu a ID knihy.");
                }

            }
            catch
            {
                throw new Exception();
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
            string deleteDoklad_query = "DELETE FROM `doklad` WHERE id = @dokladID";
            string deleteDokladKniha_query = "DELETE FROM `doklad_kniha` WHERE id_doklad = @dokladID";
            string deleteDokladZakaznik_query = "DELETE FROM `doklad_zakaznik` WHERE id_doklad = @dokladID";
            var parameters = new Dictionary<string, object>
                {
                    { "@dokladID", dokladID },
            };

           
            try
            {
                DataProvider.Instance.ExecuteModifiedQuery(deleteDoklad_query, parameters);
                DataProvider.Instance.ExecuteModifiedQuery(deleteDokladKniha_query, parameters);
                DataProvider.Instance.ExecuteModifiedQuery(deleteDokladZakaznik_query, parameters);
            }
            catch
            {
                throw new Exception();
            }
            
        }
    }
}

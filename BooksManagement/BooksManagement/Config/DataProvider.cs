using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BooksManagement.Config
{
    public class DataProvider
    {
        private static DataProvider instance;


        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        public DataProvider() { }

        string connectionString = "Server=localhost;Database=book_store_manage;User ID=root;Password=;";


        public DataTable ExecuteSelectQuery(string query)
        {
            DataTable data = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při vykonávání dotazu: " + ex.Message);
            }

            return data;
        }

        public void ExecuteModifiedQuery(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Přidání parametrů do příkazu, pokud existují
                    if (parameters != null)
                    {
                        foreach (var pair in parameters)
                        {
                            command.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    }

                    connection.Open();

                    // Pro INSERT, UPDATE, DELETE použijte ExecuteNonQuery
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                // Zpracování chyb specifických pro MySQL
                MessageBox.Show($"MySQL chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Zpracování ostatních chyb
                MessageBox.Show($"Obecná chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}

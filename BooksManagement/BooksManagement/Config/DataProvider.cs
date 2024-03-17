using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

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

        string connectionString = "Server=localhost;Database=book_store_manager;User ID=root;Password=;";


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

        public DataTable ExecuteSelectQueryWithParameter(string query, Dictionary<string, object> parameters = null)
        {
            DataTable data = new DataTable();

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


        public object ExecuteScalarQuery(string query, Dictionary<string, object> parameters = null)
        {
            object result = null;

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

                    // Vykonání dotazu a vrácení prvního řádku prvního sloupce v sadě výsledků
                    result = command.ExecuteScalar();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Obecná chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
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
                MessageBox.Show($"MySQL chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Obecná chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        public int ExecuteModifiedQueryWithID(string query, Dictionary<string, object> parameters = null)
        {
            int insertedId = -1; // Pokud se nepodaří vložit záznam, vrátíme -1

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

                    // Získání ID nově vloženého záznamu
                    command.CommandText = "SELECT LAST_INSERT_ID();";
                    insertedId = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Obecná chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return insertedId;
        }


    }
}

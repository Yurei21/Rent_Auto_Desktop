using MySql.Data.MySqlClient;
using System;
using System.Data;

public class DatabaseHelper
{
    private string connectionString = "server=localhost;port=3306;database=carsdb;uid=root;pwd=;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public bool ExecuteQuery(string query, MySqlParameter[] parameters)
    {
        try
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Database Error: " + ex.Message);
            return false;
        }
    }
}

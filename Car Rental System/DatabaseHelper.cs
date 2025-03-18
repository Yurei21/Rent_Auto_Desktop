using MySql.Data.MySqlClient;
using System;
using System.Data;

public class DatabaseHelper
{
    private string connectionString = "server=localhost;port=3307;database=carsdb;uid=root;pwd=;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public int ExecuteScalarQuery(string query, MySqlParameter[] parameters)
    {
        int result = 0;
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                object scalarResult = cmd.ExecuteScalar();
                if (scalarResult != null && int.TryParse(scalarResult.ToString(), out int count))
                {
                    result = count;
                }
            }
        }
        return result;
    }

    public string ExecuteScalar(string query, MySqlParameter[] parameters)
    {
        string result = null;
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                object scalarResult = cmd.ExecuteScalar();
                if (scalarResult != null)
                {
                    result = scalarResult.ToString(); 
                }
            }
        }
        return result;
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

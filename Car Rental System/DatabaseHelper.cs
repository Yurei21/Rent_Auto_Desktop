using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Transactions;
using System.Windows.Forms; 

public class DatabaseHelper
{
    private string connectionString = "server=localhost;port=3307;database=carsdb;uid=root;pwd=;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public object ExecuteScalar(string query, MySqlParameter[] parameters = null)
    {
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    System.Diagnostics.Debug.WriteLine("Executing Query: " + query);
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            System.Diagnostics.Debug.WriteLine($"Param: {param.ParameterName} = '{param.Value}'");
                        }
                    }

                    object result = cmd.ExecuteScalar();

                    System.Diagnostics.Debug.WriteLine("Query Result: " + (result != null ? result.ToString() : "NULL"));

                    return result;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Database Error: " + ex.Message);
            System.Diagnostics.Debug.WriteLine("Database Exception: " + ex.ToString());
            return null;
        }
    }
    public MySqlDataReader ExecuteReader(string query, MySqlParameter[] parameters = null)
    {
        MySqlConnection conn = GetConnection();
        MySqlCommand cmd = new MySqlCommand(query, conn);

        if (parameters != null)
        {
            cmd.Parameters.AddRange(parameters);
        }

        conn.Open();
        MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

        return reader;
    }



    public bool ExecuteQuery(string query, MySqlParameter[] parameters = null)
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

    public void ExecuteNonQuery(string query, MySqlParameter[] parameters, MySqlConnection conn, MySqlTransaction transaction)
    {
        using (var cmd = new MySqlCommand(query, conn, transaction))
        {
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            cmd.ExecuteNonQuery();
        }
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

    public int GetLastInsertedId(MySqlConnection conn)
    {
        try
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn))
            {
                cmd.Transaction = conn.BeginTransaction(); 
                object result = cmd.ExecuteScalar();
                int lastId = (result != null && int.TryParse(result.ToString(), out int id)) ? id : -1;

                MessageBox.Show($"DEBUG: Last Inserted ID = {lastId}");
                return lastId;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error retrieving last inserted ID: " + ex.Message);
            return -1;
        }
    }


    public int GetVehicleIdFromDatabase(string model, string brand)
    {
        string query = "SELECT vehicle_id FROM Vehicles WHERE model = @model AND brand = @brand LIMIT 1";
            MySqlParameter[] parameters = {
            new MySqlParameter("@model", model),
            new MySqlParameter("@brand", brand)
        };

        object result = ExecuteScalar(query, parameters); 

        return (result != null) ? Convert.ToInt32(result) : -1;
    }

    public DataTable ExecuteQueryWithDataTable(string query, MySqlParameter[] parameters = null)
    {
        DataTable dataTable = new DataTable();
        try
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dataTable;
    }


}

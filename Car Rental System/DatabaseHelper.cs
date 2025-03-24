using MySql.Data.MySqlClient;
using System;
using System.Data;
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

    public void ExecuteNonQuery(string query, MySqlParameter[] parameters)
    {
        using (var conn = GetConnection())
        {
            conn.Open();
            using (var cmd = new MySqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
            }
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
        using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn))
        {
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }

    public int GetVehicleIdFromDatabase(string model, string brand)
    {
        int vehicleId = -1;
        string query = "SELECT vehicle_id FROM Vehicles WHERE model = @model AND brand = @brand LIMIT 1";

        MySqlParameter[] parameters = {
                new MySqlParameter("@model", model),
                new MySqlParameter("@brand", brand)
            };

        DatabaseHelper db = new DatabaseHelper();
        object result = db.ExecuteScalar(query, parameters);

        if (result != null)
        {
            vehicleId = Convert.ToInt32(result);
        }

        return vehicleId;
    }
}

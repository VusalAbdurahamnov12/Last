using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Ado_Net
{
    public class Sql
    {
        private static string connectionString = @"Server=DESKTOP-I1I30DH\SQLEXPRESS;Database=cinema;Trusted_Connection=True;";
        public static void Select(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string columnNames = "";
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        columnNames += dt.Columns[i].ColumnName + " ";
                    }
                    Console.WriteLine(columnNames);
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        string result = "";
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            result += dataRow[i] + " ";
                        }
                        Console.WriteLine(result);
                    }
                }
            }
        }
        public static void Execute(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(query, conn))
                {
                    try
                    {
                        if (comm.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("Done");
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
    }
}
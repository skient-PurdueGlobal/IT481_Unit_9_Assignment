using Microsoft.Data.SqlClient;
using System;
using System.Data;

using System.Diagnostics;

namespace IT481_Unit_3_Assignment.DAL
{
    class DBAccessLayer
    {
        //Variables
        string connString;

        //Constructors
        public DBAccessLayer() { }
        public DBAccessLayer(string connSt)
        {
            connString = connSt;
        }

        //Methods
        public DataTable Get_Customers()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex) { Debug.WriteLine("Customers: " + connString + " / " + ex.Message); }

            return dt;
        }
        public DataTable Get_Employees()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM Employees";
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex) { Debug.WriteLine("Employees: " + ex.Message); }

            return dt;
        }
        public DataTable Get_Orders()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM Orders";
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex) { Debug.WriteLine("Orders: " + ex.Message); }

            return dt;
        }
    }
}

using System;
using System.Data;

using System.Diagnostics;

namespace IT481_Unit_3_Assignment.BAL
{
    class BusinessLayer
    {
        //Variables
        public static string connString;//@"Data Source=dellG3;Initial Catalog=Northwind;User Id=User_HR;Password=123456;TrustServerCertificate=true";

        //Class Initialization
        DAL.DBAccessLayer dbAccess;

        //Constructors
        public BusinessLayer() { }
        public BusinessLayer(string user, string password, string server, string database)
        {
            connString += @"Data Source=" + server + ";Initial Catalog=" + database + ";User Id=" + user + ";Password=" + password + ";TrustServerCertificate=true";
            Debug.WriteLine(Environment.NewLine + "************ " + connString + Environment.NewLine);

            dbAccess = new DAL.DBAccessLayer(connString);
        }

        //Data Objects
        DataTable customerData = new DataTable();
        DataTable employeeData = new DataTable();
        DataTable orderData = new DataTable();

        //Methods
        public string Load_Data()
        {
            string status = "";

            try
            {
                customerData = dbAccess.Get_Customers();
                employeeData = dbAccess.Get_Employees();
                orderData = dbAccess.Get_Orders();

//                if (customerData.Rows.Count == 0 && employeeData.Rows.Count == 0 && orderData.Rows.Count == 0)
//                    status += "Invalid Login Credentials..." + Environment.NewLine + "Failed To Load Data...";
//                else
                    status += "Connection Established Successfully..." + Environment.NewLine + "Data Loaded Successfully...";
            }
            catch (Exception ex)
            {
                status = "Error:  " + ex.Message;
            }

            return status;
        }
        public DataTable Populate_DataGrid(int table)
        {
            DataTable dt = new DataTable();

            switch (table)
            {
                case 0:
                    dt = customerData;
                    break;
                case 1: 
                    dt =  employeeData;
                    break;
                case 2:
                    dt =  orderData;
                    break;
            }

            return dt;
        }
        public int Count_Records(int table)
        {
            int numRec = 0;

            switch (table)
            {
                case 0:
                    numRec = customerData.Rows.Count;
                    break;
                case 1:
                    numRec = employeeData.Rows.Count;
                    break;
                case 2:
                    numRec = orderData.Rows.Count;
                    break;
            }

            return numRec;
        }
    }
}

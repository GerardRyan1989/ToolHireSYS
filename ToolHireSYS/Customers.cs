using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace ToolHireSYS
{
    class Customers
    {
        //instance variables
        private int CustID;
        private string Title;
        private String Forename;
        private String Surname;
        private String DOB;
        private String Email;
        private String AddressLine1;
        private String AddressLine2;
        private String County;
        private double Balance;
        private String credit;
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        public Customers()
        {
            CustID = 0;
            Title = "unknown";
            Forename = "unknown";
            Surname = "unknown";
            DOB = "unknown";
            Email = "unknown";
            AddressLine1 = "unknown";
            AddressLine2 = "unknowmn";
            County = "unknown";
            Balance = 0.0;
        }

        public static int nextCustID()
        {
            // variable to hold value to be returned
            int intNextCustID;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to get MAX Stock_No used
            String strSQl = "SELECT MAX(CustID) FROM Customers";

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextCustID = 1;
            }
            else
            {
                intNextCustID = Convert.ToInt16(dr.GetValue(0)) + 1;
            }

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return intNextCustID;



        }

        public static DataSet getTitle()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();

            //define sql query
            string strSql = "SELECT * FROM Titles ";

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "Titles");

            //close the database
            conn.Close();

            return ds;
        }

        public static DataSet getCounty()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();

            //define sql query
            string strSql = "SELECT * FROM Counties ";

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "Counties");

            //close the database
            conn.Close();

            return ds;
        }


        public static DataSet getCustomer(string surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();

            //define sql query
            string strSql = "SELECT * FROM Customers WHERE Surname like '%" + surname + "%' AND STATUS != 'R' ";

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "Customer");

            //close the database
            conn.Close();

            return ds;
        }

        public static DataSet getCustomer(string surname, string county, string status)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();

            if (status == "Available")
            {
                status = "A";
            }
            else
            {
                status = "R";
            }

            //define sql query
            string strSql = "SELECT * FROM Customers WHERE Surname like '%" + surname + "%' AND County Like '%" + county + "%' AND STATUS = '" + status + "'";

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "Customer");

            //close the database
            conn.Close();

            return ds;
        }

        public static DataSet getCustomer(string surname, string County)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();

            //define sql query
            string strSql = "SELECT * FROM Customers WHERE Surname like '%" + surname + "%' AND COUNTY = '%" + County + "%' AND STATUS != 'R'";

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "Customer");

            //close the database
            conn.Close();

            return ds;
        }

        public void regCustomer()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to INSERT Customer record
            String strSQl = "INSERT INTO Customers VALUES(" + this.CustID +
                ",'" + this.Title.ToUpper() + "','" + this.Forename + "','" +
                this.Surname + "','" + this.DOB + "','" + this.Email + "','" + this.AddressLine1 + "','" +
                this.AddressLine2 + "','" + this.County + "'," + this.Balance + ",'"  + this.credit + "','A')";

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();

            

            // Close DB connection
           myConn.Close();
        }

        public void updateCustomer(int Custid)
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to INSERT Customer record
            String strSQl = "UPDATE Customers SET TITLE = '" + this.Title.ToUpper() +
                "', FORENAME ='" + this.Forename + "', SURNAME = '" + this.Surname + "', DOB ='" +
                this.DOB + "', EMAIL = '" + this.Email + "', ADDRESSLINE1 = '" + this.AddressLine1 + "', ADDRESSLINE2 = '" + this.AddressLine2 + "', COUNTY ='" +
                this.County + "', CREDITDEBIT = '" + this.credit + "' WHERE CUSTID  = " + Custid ;

            

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Customer: " + this.Title + " " + this.Forename + " " + this.Surname + " updated successfully");
            // Close DB connection
            myConn.Close();
        }

        public void removeCustomer(int CustId)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query to update Tool Status 
            string strSQL = "UPDATE CUSTOMERS SET STATUS =  'R' WHERE CUSTID = " + CustId;

            //Execute the Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Removed successfully");
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.StackTrace);
            }
            //Close Connection
            myConn.Close();
        }



        public void setCustID(int CustID)
        {
            this.CustID = CustID;
        }

        public void setTitle(String Title)
        {
            this.Title = Title;
        }

        public void setForename(String forename)
        {
            this.Forename = forename;
        }

        public void setSurname(String surname)
        {
            this.Surname = surname;
        }

        public void setDOB(String dob)
        {
            this.DOB = dob;
        }

        public void setEmail(String email)
        {
            this.Email = email;
        }

        public void setAddressLine1(String addressline1)
        {
            this.AddressLine1 = addressline1;
        }

        public void setAddressLine2(String addressline2)
        {
            this.AddressLine2 = addressline2;
        }

        public void setCounty(String county)
        {
            this.County = county;
        }

        public void setCredit(String credit)
        {
            this.credit = credit;
        }

        public void setBalance()
        {
            this.Balance = 0.00;
        }
    }
}

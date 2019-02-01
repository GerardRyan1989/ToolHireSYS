using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Collections;

namespace ToolHireSYS
{
    class Rentals
    {

        private int rentalID;
        private int custID;
        private int toolID;
        private double cost;
        private char status;
        private string dateReturned;
        private string hireDate;
        private string dueReturnDate;

        public static int nextRentID()
        {
            // variable to hold value to be returned
            int intNextRentID;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to get MAX Stock_No used
            String strSQl = "SELECT MAX(RentID) FROM Rentals";

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextRentID = 1;
            }
            else
            {
                intNextRentID = Convert.ToInt16(dr.GetValue(0)) + 1;
            }

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return intNextRentID;
        }

        


        public void addToRentalItems(ArrayList ToolList, ArrayList DueReturnDate)
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            for (int i = 0; i < ToolList.Count; i++)
            {
                toolID = (int)ToolList[i];
                dueReturnDate = String.Format("{0:dd-MMM-yy}", DueReturnDate[i]);
                // Define SQL query to INSERT Customer record
                String strSQl = "INSERT INTO RentalItems VALUES(" + this.rentalID + "," + this.toolID +
                                        ",'" + this.dueReturnDate + "','" + this.dateReturned + "','" + this.status + "')";

                // Execute the command
                OracleCommand cmd = new OracleCommand(strSQl, myConn);
                cmd.ExecuteNonQuery();
            }
            // Close DB connection
            myConn.Close();
        }
        
        public void addToRentals()
        {
            //Connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            hireDate = String.Format("{0:dd-MMM-yy}", DateTime.Now);
            //Define SQL query to INSERT Customer record
            String strSQl = "INSERT INTO Rentals VALUES(" + this.rentalID + "," + this.custID +
                                    ",'" + this.hireDate + "','" + this.cost + "')";

          //Execute the command
           OracleCommand cmd = new OracleCommand(strSQl, myConn);
           cmd.ExecuteNonQuery();


           //Close DB connection
            myConn.Close();
        }

        public static DataSet getLateReturns()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();
            string dateNow = String.Format("{0:dd-MMM-yy}", DateTime.Now);
            //define sql query
            string strSql = "SELECT RI.RentId, R.CustID, RI.Toolid, RI.dueReturnDate, RI.DateReturned  From Rentals R, RentalItems RI where R.RentId = RI.RentId And RI.Datereturned > RI.DueReturnDate OR '" +  dateNow +"' > RI.DueReturnDate AND RI.DateReturned IS NULL";

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "lateReturns");

            //close the database
            conn.Close();

            return ds;
        }

        public void returnTool(int toolId)
        {
            //Connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            dateReturned = String.Format("{0:dd-MMM-yy}", DateTime.Now);
            //Define SQL query to INSERT Customer record
            String strSQl = "UPDATE RentalItems SET DateReturned = '" + this.dateReturned + "', Rentstatus = 'R'  WHERE TOOLID = " + toolId + "AND RentStatus = 'U' ";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            //Close DB connection
            myConn.Close();
        }


        public void setCost(double cost)
        {
            this.cost = cost;
        }
        public int getCustID()
        {
            return custID;
        }

        public void setCustID(int custID)
        {
            this.custID = custID;
        }


        public int getRentalID()
        {
            return rentalID;
        }

        public void setRentalID(int rentalID)
        {
            this.rentalID = rentalID;
        }

        public int getToolID()
        {
            return toolID;
        }

        public void setToolID(int toolID)
        {
            this.toolID = toolID;
        }

        public char getStatus()
        {
            return status;
        }

        public void setStatus(char status)
        {
            this.status = status;
        }

        public string getDateReturned()
        {
            return dateReturned;
        }

        public void setDateReturned(string dateReturned)
        {
            this.dateReturned = dateReturned;
        }

        public string getDueReturnDate()
        {
            return dueReturnDate;
        }

       

    }
}

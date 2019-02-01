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
    class Tools
    {
        //instance variables

        private int toolID;
        private int category;
        private int manufacturer;
        private string model;
        private string description;
        private double price;
        private char status = 'A';


        public Tools()
        {
            toolID = 0;
            category = 0;
            manufacturer = 0;
            model = "unknown";
            description = "unknown";
            price = 0.00;
        }
        public static DataSet getToolMakes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();

            //define sql query
            string strSql = "SELECT * FROM Makes";

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "Makes");

            //close the database
            conn.Close();

            return ds;
        }
        public static DataSet getToolCategorys()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();

            //define sql query
            string strSql = "SELECT * FROM Categorys";

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "Categorys");

            //close the database
            conn.Close();

            return ds;
        }

        public static DataSet getTools(int category, int manufacturer)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();

            //define sql query
            string strSql = "SELECT * FROM Tools WHERE CatId like '%" + category + "%' AND MakeID Like" + "'%" + manufacturer + "%' AND TOOLSTATUS != 'R' ";

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "getTools");

            //close the database
            conn.Close();

            return ds;
        }

        public static DataSet getTools(int category, int manufacturer, string sort, string order)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //connect to the database
            conn.Open();

            string strSql = "";
            //define sql query
            if (order == "Ascending")
            {
                strSql = "SELECT * FROM Tools WHERE CatId like '%" + category + "%' AND MakeID Like" + "'%" + manufacturer + "%' AND TOOLSTATUS != 'R' ORDER BY " + sort;
            }
            else
            {
                strSql = "SELECT * FROM Tools WHERE CatId like '%" + category + "%' AND MakeID Like" + "'%" + manufacturer + "%' AND TOOLSTATUS != 'R' ORDER BY " + sort + " DESC";
            }

            //execute the query
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //get the data onto the form
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            //uses a data adapter to fill the dataset
            da.Fill(ds, "ss");

            //close the database
            conn.Close();

            return ds;
        }

        public static int nextToolID()
        {
            // variable to hold value to be returned
            int intNextToolID;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to get MAX Stock_No used
            String strSQl = "SELECT MAX(toolID) FROM Tools";

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextToolID = 1;
            }
            else
            {
                intNextToolID = Convert.ToInt16(dr.GetValue(0)) + 1;
            }

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return intNextToolID;

        }

        public void removeTool(int ToolId)
        {
            //Connect to db
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query to update Tool Status 
            string strSQL = "UPDATE TOOLS SET TOOLSTATUS =  'R' WHERE TOOLID = " + ToolId;

            //Execute the Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.StackTrace);
            }
            //Close Connection
            myConn.Close();
        }

        public void updateTool(int ToolId)
        {
            //Connect to db
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query to update stock record
            string strSQL = "UPDATE TOOLS SET CATID = '" + this.category + "', MAKEID = '" + this.manufacturer + "', MODEL = '" + this.model + "', DESCRIPTION = '" + this.description + "', PRICE = " + this.price + " WHERE TOOLID = " + ToolId;

            //Execute the Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.StackTrace);
            }
            //Close Connection
            myConn.Close();
        }

        public void regTool()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to INSERT Customer record
            String strSQl = "INSERT INTO Tools VALUES(" + this.toolID + ",'" + this.category +
                                    "','" + this.manufacturer + "','" + this.model + "','" + this.description +
                                    "'," + this.price + ",'" + status + "')";

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public static double getPrice(int toolID)
        {
            // variable to hold value to be returned
            double cost = 0;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to get MAX Stock_No used
            String strSQl = "SELECT Price FROM Tools Where ToolID =" + toolID;

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();
           
            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();
            cost = Convert.ToDouble(dr.GetValue(0));

            myConn.Close();

            // Return next price
            return cost;
        }

        public void setToolID(int toolID)
        {
            this.toolID = toolID;
        }

        public void setCategory(int category)
        {
            this.category = category;
        }

        public void setManufacturer(int manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getToolID()
        {
            return toolID;
        }

        public int getCategory()
        {
            return category;
        }

        public int getManufacturer()
        {
            return manufacturer;
        }

        public string getModel()
        {
            return model;
        }

        public string getDescription()
        {
            return description;
        }

        public char getStatus()
        {
            return status;
        }
    }
}

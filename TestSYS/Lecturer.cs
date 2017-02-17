using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace TestSYS
{
    class Lecturer
    {
        private int lecId;
        private String passwd;        
        private String sName;
        private String fName;
        
        public Lecturer() {
            lecId = 0;
            passwd = "";            
            sName = "";
            fName = "";
        }
     
        public Lecturer(int id, String pword, String sn, String fn)
        {
            lecId = id;
            passwd = pword;
            sName = sn;           
            fName = fn;
        }

        // Accessors
        public int getLecId()
        {
            return lecId;
        }
        public String getPasswd()
        {
            return passwd;
        }
        public String getSName()
        {
            return sName;
        }
        public String getFName()
        {
            return fName;
        }


        //mutators
        public void setLecId(int id)
        {
            lecId = id;
        }
        public void setPasswd(String pword)
        {
            passwd = pword;
        }
         public void setSName(String name)
        {
            sName = name;
        }
        public void setFName(String name)
        {
            fName = name;
        }

        // CHECK LECTURER LOGIN IS VALID
        public Boolean validLecLogin(int id, String psw)
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            String strSQL = "SELECT *  FROM Lecturers WHERE LecId = " + id + " AND Passwd = '" + psw + "'";

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Check if there is anything to read in dr
            if (dr.Read())
            {
                myConn.Close();
                return true;
            }
            else
            {
                myConn.Close();
                return false;
            }
        }

        //GET LECTURER DETAILS
        public void getLecDetails(int id)
        {

            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            String strSQL = "SELECT LecId, FName  FROM Lecturers WHERE LecId = " + id;

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the record in dr
            dr.Read();

            //Set variables
            this.setLecId(Convert.ToInt32(dr.GetValue(0)));
            this.setFName(dr.GetString(1));

            //Close DB connection
            myConn.Close();
        }
    }
}

using System;
using System.Data.OracleClient;

namespace TestSYS
{
    class Lecturer
    {
        private int lecId;
        private string passwd;        
        private string sName;
        private string fName;
        
        public Lecturer() {
        }
     
        public Lecturer(int id, string pword, string sn, string fn)
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
        public string getPasswd()
        {
            return passwd;
        }
        public string getSName()
        {
            return sName;
        }
        public string getFName()
        {
            return fName;
        }


        //mutators
        public void setLecId(int id)
        {
            lecId = id;
        }
        public void setPasswd(string pword)
        {
            passwd = pword;
        }
         public void setSName(string name)
        {
            sName = name;
        }
        public void setFName(string name)
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
            setLecId(Convert.ToInt32(dr.GetValue(0)));
            setFName(dr.GetString(1));

            //Close DB connection
            myConn.Close();
        }
    }
}

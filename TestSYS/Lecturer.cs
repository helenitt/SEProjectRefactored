using System;
using System.Data.SQLite;

namespace TestSYS
{
    class Lecturer
    {
        private int lecId;
        private string passwd;        
        private string sName;
        private string fName;
        
        public Lecturer() {
            lecId = 0;
            passwd = "";            
            sName = "";
            fName = "";
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
        public bool validLecLogin(int id, string psw)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            string strSQL = "SELECT *  FROM Lecturers WHERE LecId = " + id + " AND Passwd = '" + psw + "'";

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            //Check if there is anything to read in dataReader
            if (dataReader.Read())
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
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which retrieves MAX StudId in Students
            string strSQL = "SELECT LecId, FName  FROM Lecturers WHERE LecId = " + id;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            //Read the record in dataReader
            dataReader.Read();

            //Set variables
            setLecId(Convert.ToInt32(dataReader.GetValue(0)));
            setFName(dataReader.GetString(1));

            //Close DB connection
            myConn.Close();
        }
    }
}

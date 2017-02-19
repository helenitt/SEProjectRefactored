using System;
using System.Data.SQLite;

namespace TestSYS
{
    class Lecturer
    {
        private int lecturerId;
        private string passwd;        
        private string surname;
        private string forename;
        
        public Lecturer() {
            lecturerId = 0;
            passwd = "";            
            surname = "";
            forename = "";
        }
     
        public Lecturer(int id, string pword, string sname, string fname)
        {
            lecturerId = id;
            passwd = pword;
            surname = sname;           
            forename = fname;
        }

        // Accessors
        public int getLecId() { return lecturerId; }
        public string getPasswd() { return passwd; }
        public string getSName() { return surname; }
        public string getFName() { return forename; }

        // Mutators
        public void setLecId(int id) { lecturerId = id; }
        public void setPasswd(string pword) { passwd = pword; }
        public void setSName(string name) { surname = name; }
        public void setFName(string name) { forename = name; }

        // CHECK LECTURER LOGIN IS VALID
        public bool validLecLogin(int id, string psw)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

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

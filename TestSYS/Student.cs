using System;
using System.Data.SQLite;

namespace TestSYS
{
    class Student
    {
        private int studId;
        private string email;
        private string password;        
        private string sName;
        private string fName;
        private string dob;
        private string status;
        private string regDate;
        private string amdDate;
        private string expDate;
        
        public Student() {
            studId = 0;
            email = "";
            password = "";            
            sName = "";
            fName = "";
            dob = "";
            status = "r";
            regDate = "";
            amdDate = "";
            expDate = "";
        }
     
        public Student(int id, string mail, string pword, string sn, string fn, string dd, string rd, string ad, string ed)
        {
            studId = id;
            email = mail;
            password = pword;
            sName = sn;           
            fName = fn;
            dob = dd;
            status = "r";
            regDate = rd;
            amdDate = ad;
            expDate = ed;
        }

        // Accessors
        public int getStudId()
        {
            return studId;
        }
         public string getEmail()
        {
            return email;
        }
        public string getPassword()
        {
            return password;
        }
       public string getSName()
        {
            return sName;
        }
        public string getFName()
        {
            return fName;
        }
        public string getDOB()
        {
            return dob;
        }
        public string getStatus()
        {
            return status;
        }
        public string getRegDate()
        {
            return regDate;
        }
        public string getAmdDate()
        {
            return amdDate;
        }
        public string getExpDate()
        {
            return expDate;
        }


        //mutators
        public void setStudId(int id)
        {
            studId = id;
        }
        public void setEmail(string mail)
        {
            email = mail;
        }
        public void setPassword(string pword)
        {
            password = pword;
        }
         public void setSName(string name)
        {
            sName = name;
        }
        public void setFName(string name)
        {
            fName = name;
        }

        public void setDOB(string bd)
        {
            dob = bd;
        }
        public void setStatus(string stat)
        {
            status = stat;
        }
       public void setRegDate(string rDate)
        {
            regDate = rDate;
        }
       public void setAmdDate(string aDate)
       {
           amdDate = aDate;
       }
       public void setExpDate(string eDate)
       {
           expDate = eDate;
       }

        // GET NEXT STUDENT ID
        public int getNextStudId()
        {
            int intNextSId;

            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which retrieves MAX StudId in Students
            string strSQL = "SELECT MAX(StudId) FROM Students";

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            //Read the record in dr
            dataReader.Read();

            //Check if MAX StudId Null
            if (dataReader.IsDBNull(0))
                intNextSId = 1;
            else
                intNextSId = Convert.ToInt16(dataReader.GetValue(0)) + 1;

            //Close DB connection
            myConn.Close();

            //Return StudId
            return intNextSId;
        }

        // CHECK STUDENT LOGIN IS VALID
        public bool validStudLogin(int id, string psw)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which retrieves MAX StudId in Students
            string strSQL = "SELECT *  FROM Students WHERE StudId = " + id + " AND Passwd = '" + psw + "' AND Status = 'r'";

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            var dataReader = cmd.ExecuteReader();

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

        // INSERT STUDENT DETAILS
        public void insertStudent()
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which inserts the students details
            string strSQL = "INSERT INTO Students (StudId, Email, Passwd, Sname, FName, DOB, Status, RegDate, ExpDate) VALUES (" + studId + ", '" + email +
                            "', " + password + ", '" + sName + "', '" + fName + "', '" + string.Format("{0:dd-MMM-yy}", dob) +
                            "', '" + status + "', '" + string.Format("{0:dd-MMM-yy}", regDate) + "','" + expDate + "')";  

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            cmd.ExecuteNonQuery();  

            //Close DB connection
            myConn.Close();
        }


        // UPDATE STUDENT
        public void updateStudent()
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which updates the students details
            string strSQL = "UPDATE Students SET Email = '" + email + "', Passwd =  " + password + ", Sname = '" + sName + "', Fname = '" + fName + 
                            "', DOB = '" + string.Format("{0:dd-MMM-yy}", dob) + "', Status = '" + status + 
                            "', AmdDate = '" + string.Format("{0:dd-MMM-yy}", amdDate) + "' WHERE StudId = " + studId;  

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();

        }

        //GET STUDENT DETAILS
        public void getStudDetails(int studId)
        {

            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which retrieves MAX StudId in Students
            string strSQL = "SELECT *  FROM Students WHERE StudId = " + studId;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            //Read the record in dr
            dataReader.Read();

            //Set variables
            setStudId(Convert.ToInt32(dataReader.GetValue(0)));  //Doesn't make sense to reset
            setEmail(dataReader.GetString(1));
            setPassword(dataReader.GetString(2));
            setSName(dataReader.GetString(3));
            setFName(dataReader.GetString(4));
            setDOB(string.Format("{0:dd-MMM-yy}",(dataReader.GetDateTime(5))));

            if (!dataReader.IsDBNull(8))
                setAmdDate(string.Format("{0:dd-MMM-yy}",dataReader.GetDateTime(8)));


            if (!dataReader.IsDBNull(9))
                setExpDate(string.Format("{0:dd-MMM-yy}",dataReader.GetDateTime(9)));

            //Close DB connection
            myConn.Close();
        }

        //DELETE STUDENT
        public void deleteStudent(int studId)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which inserts the students details
            string strSQL = "UPDATE Students SET Status = 'd', AmdDate = '" + string.Format("{0:dd-MMM-yy}", amdDate) + "' WHERE StudId = " + studId;  

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }
    }
}

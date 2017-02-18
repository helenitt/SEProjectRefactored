using System;
using System.Data.SQLite;

namespace TestSYS
{
    class Student
    {
        private int studentId;
        private string email;
        private string passwd;        
        private string surname;
        private string forname;
        private string dob;
        private string status;
        private string regDate;
        private string amendDate;
        private string expiryDate;
        
        public Student() {
            studentId = 0;
            email = "";
            passwd = "";            
            surname = "";
            forname = "";
            dob = "";
            status = "r";
            regDate = "";
            amendDate = "";
            expiryDate = "";
        }
     
        public Student(int id, string mail, string pword, string surname, string forename, string bDate, string rDate, string aDate, string eDate)
        {
            studentId = id;
            email = mail;
            passwd = pword;
            this.surname = surname;           
            forname = forename;
            dob = bDate;
            status = "r";
            regDate = rDate;
            amendDate = aDate;
            expiryDate = eDate;
        }
        
        public int getStudId() { return studentId; }
        public string getEmail() { return email; }
        public string getPassword() { return passwd; }
        public string getSName() { return surname; }
        public string getFName() { return forname; }
        public string getDOB() { return dob; }
        public string getStatus() { return status; }
        public string getRegDate() { return regDate; }
        public string getAmdDate() { return amendDate; }
        public string getExpDate() { return expiryDate; }

        public void setStudId(int id) { studentId = id; }
        public void setEmail(string mail) { email = mail; }
        public void setPassword(string pword) { passwd = pword; }
        public void setSName(string name) { surname = name; }
        public void setFName(string name) { forname = name; }
        public void setDOB(string bd) { dob = bd; }
        public void setStatus(string stat) { status = stat; }
        public void setRegDate(string rDate) { regDate = rDate; }
        public void setAmdDate(string aDate) { amendDate = aDate; }
        public void setExpDate(string eDate) { expiryDate = eDate; }

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

            //Read the record in dataReader
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

            // IS THIS NOT THE SAME AS
            //myConn.Close();
            //return dataReader.Read();

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
            string strSQL = "INSERT INTO Students (StudId, Email, Passwd, Sname, FName, DOB, Status, RegDate, ExpDate) VALUES (" + studentId + ", '" + email +
                            "', " + passwd + ", '" + surname + "', '" + forname + "', '" + string.Format("{0:dd-MMM-yy}", dob) +
                            "', '" + status + "', '" + string.Format("{0:dd-MMM-yy}", regDate) + "','" + expiryDate + "')";  

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
            string strSQL = "UPDATE Students SET Email = '" + email + "', Passwd =  " + passwd + ", Sname = '" + surname + "', Fname = '" + forname + 
                            "', DOB = '" + string.Format("{0:dd-MMM-yy}", dob) + "', Status = '" + status + 
                            "', AmdDate = '" + string.Format("{0:dd-MMM-yy}", amendDate) + "' WHERE StudId = " + studentId;  

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
            var myConn = new SQLiteConnection(Db.ConnectionString);

            string strSQL = "SELECT *  FROM Students WHERE StudId = " + studId;

            var cmd = new SQLiteCommand(strSQL, myConn);
            myConn.Open();
            SQLiteDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();

            //Set variables
            setStudId(Convert.ToInt32(dataReader.GetValue(0)));  //Doesn't make sense to reset
            setEmail(dataReader.GetString(1));
            setPassword(dataReader.GetString(2));
            setSName(dataReader.GetString(3));
            setFName(dataReader.GetString(4));
            setDOB(dataReader.GetString(5));

            if (!dataReader.IsDBNull(8))
                setAmdDate(dataReader.GetString(8));

            if (!dataReader.IsDBNull(9))
                setExpDate(dataReader.GetString(9));

            //Close DB connection
            myConn.Close();
        }

        //DELETE STUDENT
        public void deleteStudent(int studId)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which inserts the students details
            string strSQL = "UPDATE Students SET Status = 'd', AmdDate = '" + string.Format("{0:dd-MMM-yy}", amendDate) + "' WHERE StudId = " + studId;  

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

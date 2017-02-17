using System;
using System.Data.OracleClient;

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
        }
     
        public Student(int id, String mail, String pword, String sn, String fn, String dd, String rd, String ad, String ed)
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
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            String strSQL = "SELECT MAX(StudId) FROM Students";

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the record in dr
            dr.Read();

            //Check if MAX StudId Null
            if (dr.IsDBNull(0))
                intNextSId = 1;
            else
                intNextSId = Convert.ToInt16(dr.GetValue(0)) + 1;

            //Close DB connection
            myConn.Close();

            //Return StudId
            return intNextSId;
        }

        // CHECK STUDENT LOGIN IS VALID
        public Boolean validStudLogin(int id, string psw)
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            String strSQL = "SELECT *  FROM Students WHERE StudId = " + id + " AND Passwd = '" + psw + "' AND Status = 'r'";

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


        // INSERT STUDENT DETAILS
        public void insertStudent()
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which inserts the students details
            String strSQL = "INSERT INTO Students (StudId,Email,Passwd,Sname,FName,DOB,Status,RegDate,ExpDate) VALUES (" + studId + ", '" + email +
                            "', " + password + ", '" + sName + "', '" + fName + "', '" + String.Format("{0:dd-MMM-yy}", dob) +
                            "', '" + status + "', '" + String.Format("{0:dd-MMM-yy}", regDate) + "','" + expDate + "')";  

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

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
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which updates the students details
            String strSQL = "UPDATE Students SET Email = '" + email + "', Passwd =  " + password + ", Sname = '" + sName + "', Fname = '" + fName + 
                            "', DOB = '" + String.Format("{0:dd-MMM-yy}", dob) + "', Status = '" + status + 
                            "', AmdDate = '" + String.Format("{0:dd-MMM-yy}", amdDate) + "' WHERE StudId = " + studId;  

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

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
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            String strSQL = "SELECT *  FROM Students WHERE StudId = " + studId;

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the record in dr
            dr.Read();

            //Set variables
            setStudId(Convert.ToInt32(dr.GetValue(0)));  //Doesn't make sense to reset
            setEmail(dr.GetString(1));
            setPassword(dr.GetString(2));
            setSName(dr.GetString(3));
            setFName(dr.GetString(4));
            setDOB(String.Format("{0:dd-MMM-yy}",(dr.GetDateTime(5))));

            if (!dr.IsDBNull(8))
                setAmdDate(String.Format("{0:dd-MMM-yy}",dr.GetDateTime(8)));


            if (!dr.IsDBNull(9))
                setExpDate(String.Format("{0:dd-MMM-yy}",dr.GetDateTime(9)));

            //Close DB connection
            myConn.Close();
        }

        //DELETE STUDENT
        public void deleteStudent(int studId)
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which inserts the students details
            String strSQL = "UPDATE Students SET Status = 'd', AmdDate = '" + String.Format("{0:dd-MMM-yy}", amdDate) + "' WHERE StudId = " + studId;  

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }
    }
}

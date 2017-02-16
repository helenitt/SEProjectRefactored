using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace TestSYS
{
    class Student
    {
        private int studId;
        private String email;
        private String password;        
        private String sName;
        private String fName;
        private String dob;
        private String status;
        private String regDate;
        private String amdDate;
        private String expDate;
        
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
         public String getEmail()
        {
            return email;
        }
        public String getPassword()
        {
            return password;
        }
       public String getSName()
        {
            return sName;
        }
        public String getFName()
        {
            return fName;
        }
        public String getDOB()
        {
            return dob;
        }
        public String getStatus()
        {
            return status;
        }
        public String getRegDate()
        {
            return regDate;
        }
        public String getAmdDate()
        {
            return amdDate;
        }
        public String getExpDate()
        {
            return expDate;
        }


        //mutators
        public void setStudId(int id)
        {
            studId = id;
        }
        public void setEmail(String mail)
        {
            email = mail;
        }
        public void setPassword(String pword)
        {
            password = pword;
        }
         public void setSName(String name)
        {
            sName = name;
        }
        public void setFName(String name)
        {
            fName = name;
        }

        //Find out how to get date from system
        //public DateTime Date { get; } ???

        public void setDOB(String bd)
        {
            dob = bd;
        }
        public void setStatus(String stat)
        {
            status = stat;
        }
       public void setRegDate(String rDate)
        {
            regDate = rDate;
        }
       public void setAmdDate(String aDate)
       {
           amdDate = aDate;
       }
       public void setExpDate(String eDate)
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
        public Boolean validStudLogin(int id, String psw)
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            String strSQL = "SELECT *  FROM Students WHERE StudId = " + id + " AND Passwd = '" + psw + "'";

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

        // INSERT STUDENT DETAILS
        public void insertStudent()
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which inserts the students details
            String strSQL = "INSERT INTO Students (StudId,Email,Passwd,Sname,FName,DOB,Status,RegDate) VALUES (" + this.studId + ", '" + this.email +
                            "', " + this.password + ", '" + this.sName + "', '" + this.fName + "', '" + String.Format("{0:dd-MMM-yy}", this.dob) +
                            "', '" + this.status + "', '" + String.Format("{0:dd-MMM-yy}", this.regDate) + "')"; 
  
           
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
            String strSQL = "UPDATE Students SET Email = '" + this.email + "', Passwd =  " + this.password + ", Sname = '" + this.sName + "', Fname = '" + this.fName + 
                            "', DOB = '" + String.Format("{0:dd-MMM-yy}", this.dob) + "', Status = '" + this.status + 
                            "', AmdDate = '" + String.Format("{0:dd-MMM-yy}", this.amdDate) + "' WHERE StudId = " + this.studId;  

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
            this.setStudId(Convert.ToInt32(dr.GetValue(0)));  //Doesn't make sense to reset
            this.setEmail(dr.GetString(1));
            this.setPassword(dr.GetString(2));
            this.setSName(dr.GetString(3));
            this.setFName(dr.GetString(4));
            this.setDOB(String.Format("{0:dd-MMM-yy}",(dr.GetDateTime(5))));
            //ONLY RESET WHAT YOU NEED!!
            //this.setStatus(dr.GetString(6));
            //this.setRegDate(String.Format("{0:dd-MMM-yy}",dr.GetDateTime(7)));
            //this.setAmdDate(String.Format("{0:dd-MMM-yy}",dr.GetDateTime(8)));

            if (!dr.IsDBNull(8))
                this.setAmdDate(String.Format("{0:dd-MMM-yy}",dr.GetDateTime(8)));


            if (!dr.IsDBNull(9))
                this.setExpDate(String.Format("{0:dd-MMM-yy}",dr.GetDateTime(9)));

            //Close DB connection
            myConn.Close();
        }

        public void getStudDetails(String sName)
        {

            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            String strSQL = "SELECT *  FROM Students WHERE Sname = " + sName;

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the record in dr
            dr.Read();

            //Set variables
            this.setStudId(Convert.ToInt32(dr.GetValue(0)));  //Doesn't make sense to reset
            this.setEmail(dr.GetString(1));
            this.setPassword(dr.GetString(2));
            this.setSName(dr.GetString(3));
            this.setFName(dr.GetString(4));
            this.setDOB(String.Format("{0:dd-MMM-yy}", (dr.GetDateTime(5))));
            //ONLY RESET WHAT YOU NEED!!
            //this.setStatus(dr.GetString(6));
            //this.setRegDate(String.Format("{0:dd-MMM-yy}",dr.GetDateTime(7)));
            //this.setAmdDate(String.Format("{0:dd-MMM-yy}",dr.GetDateTime(8)));

            if (!dr.IsDBNull(8))
                this.setAmdDate(String.Format("{0:dd-MMM-yy}", dr.GetDateTime(8)));


            if (!dr.IsDBNull(9))
                this.setExpDate(String.Format("{0:dd-MMM-yy}", dr.GetDateTime(9)));

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
            String strSQL = "UPDATE Students SET Status = 'd', AmdDate = '" + String.Format("{0:dd-MMM-yy}", this.amdDate) + "' WHERE StudId = " + studId;  

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

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
        private string forename;
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
            forename = "";
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
            this.forename = forename;
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
        public string getFName() { return forename; }
        public string getDOB() { return dob; }
        public string getStatus() { return status; }
        public string getRegDate() { return regDate; }
        public string getAmdDate() { return amendDate; }
        public string getExpDate() { return expiryDate; }

        public void setStudId(int id) { studentId = id; }
        public void setEmail(string mail) { email = mail; }
        public void setPassword(string pword) { passwd = pword; }
        public void setSName(string name) { surname = name; }
        public void setFName(string name) { forename = name; }
        public void setDOB(string bd) { dob = bd; }
        public void setStatus(string stat) { status = stat; }
        public void setRegDate(string rDate) { regDate = rDate; }
        public void setAmdDate(string aDate) { amendDate = aDate; }
        public void setExpDate(string eDate) { expiryDate = eDate; }

        public int getNextStudId()
        {
            int intNextSId;
            string strSQL = "SELECT MAX(StudId) FROM Students";

            var dataReader = DbConnect.ConnectDbReader(strSQL);
            
            if (dataReader.IsDBNull(0))
                intNextSId = 1;
            else
                intNextSId = Convert.ToInt16(dataReader.GetValue(0)) + 1;

            DbConnect.CloseDb();
            return intNextSId;
        }
        
        public bool validStudentLogin(int id, string psw)
        {
            string strSQL = "SELECT * FROM Students WHERE StudId = " + id + " AND Passwd = '" + psw + "' AND Status = 'r'";

            var dataReader = DbConnect.ConnectDbReader(strSQL);

            // IS THIS NOT THE SAME AS
            //DbConnect.CloseDb();
            //return dataReader.Read();

            //Check if there is anything to read in dataReader
            if (dataReader.Read())
            {
                DbConnect.CloseDb();
                return true;
            }
            else
            {
                DbConnect.CloseDb();
                return false;
            }            
        }
        
        public void insertStudent()
        {
            string strSQL = "INSERT INTO Students (StudId, Email, Passwd, Sname, FName, DOB, Status, RegDate, ExpDate) VALUES (" + studentId + ", '" + email +
                            "', " + passwd + ", '" + surname + "', '" + forename + "', '" + string.Format("{0:dd-MMM-yy}", dob) +
                            "', '" + status + "', '" + string.Format("{0:dd-MMM-yy}", regDate) + "','" + expiryDate + "')";

            DbConnect.ConnectDbNonQuery(strSQL);
            DbConnect.CloseDb();
        }
        
        public void updateStudent()
        {
            string strSQL = "UPDATE Students SET Email = '" + email + "', Passwd =  " + passwd + ", Sname = '" + surname + "', Fname = '" + forename + 
                            "', DOB = '" + string.Format("{0:dd-MMM-yy}", dob) + "', Status = '" + status + 
                            "', AmdDate = '" + string.Format("{0:dd-MMM-yy}", amendDate) + "' WHERE StudId = " + studentId;

            DbConnect.ConnectDbNonQuery(strSQL);
            DbConnect.CloseDb();
        }
        
        public void getStudDetails(int studId)
        {
            string strSQL = "SELECT *  FROM Students WHERE StudId = " + studId;

            var dataReader = DbConnect.ConnectDbReader(strSQL);
            
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

            DbConnect.CloseDb();
        }

        public void deleteStudent(int studId)
        {
            string strSQL = "UPDATE Students SET Status = 'd', AmdDate = '" + string.Format("{0:dd-MMM-yy}", amendDate) + "' WHERE StudId = " + studId;

            DbConnect.ConnectDbNonQuery(strSQL);
            DbConnect.CloseDb();
        }
    }
}

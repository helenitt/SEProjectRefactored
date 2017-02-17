using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace TestSYS
{
    class Test
    {
        private int testId;
        private String dateTaken;
        private int testScore;
        private int studId;
        private String tLevel;

        public Test()
        {
            testId = 0;
            dateTaken = "";
            testScore = 0;
            studId = 0;
            tLevel = "";
        }

        public Test(int tId, String dTaken, int tScore, int sId, String tLvl)
        {
            testId = tId;
            dateTaken = dTaken;
            testScore = tScore;
            studId = sId;
            tLevel = tLvl;
        }

        public int getTestId()
        {
            return testId;
        }

        public String getDateTaken()
        {
            return dateTaken;
        }

        public int getTestScore()
        {
            return testScore;
        }

        public int getStudId()
        {
            return studId;
        }

        public String getTLevel()
        {
            return tLevel;
        }

        public void setTestId(int tId)
        {
            testId = tId;
        }

        public void setDateTaken(String dTaken)
        {
            dateTaken = dTaken;
        }

        public void setTestScore(int tScore)
        {
            testScore = tScore;
        }

        public void setStudId(int sId)
        {
            studId = sId;
        }

        public void setTLevel(String tLvl)
        {
            tLevel = tLvl;
        }


        //GET NEXT TEST ID
        public int getNextTestId()
        {
            int intNextTId;

            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX QuestId in Questions
            String strSQL = "SELECT MAX(TestId) FROM Tests";

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the record in dr
            dr.Read();

            //Check if MAX QuestId Null
            if (dr.IsDBNull(0))
                intNextTId = 1;
            else
                intNextTId = Convert.ToInt32(dr.GetValue(0)) + 1;

            //Close DB connection
            myConn.Close();

            //Return QuestId
            return intNextTId;
        }

        public void saveTest()
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which inserts the question in to the database
            String strSQL = "INSERT INTO Tests (TestId,TestDate,Score,StudId,LevelCode) VALUES (" + this.testId + ", '" + String.Format("{0:dd-MMM-yy}", this.dateTaken) +
                            "', '" + this.testScore + "', '" + this.studId + "', '" + this.tLevel + "')";

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

using System;
using System.Data.SQLite;

namespace TestSYS
{
    class Test
    {
        private int testId;
        private string dateTaken;
        private int testScore;
        private int studId;
        private string tLevel;

        public Test()
        {
            testId = 0;
            dateTaken = "";
            testScore = 0;
            studId = 0;
            tLevel = "";
        }

        public Test(int tId, string dTaken, int tScore, int sId, string tLvl)
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

        public string getDateTaken()
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

        public string getTLevel()
        {
            return tLevel;
        }

        public void setTestId(int tId)
        {
            testId = tId;
        }

        public void setDateTaken(string dTaken)
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

        public void setTLevel(string tLvl)
        {
            tLevel = tLvl;
        }


        //GET NEXT TEST ID
        public int getNextTestId()
        {
            int intNextTId;

            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which retrieves MAX QuestId in Questions
            string strSQL = "SELECT MAX(TestId) FROM Tests";

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            //Read the record in dr
            dataReader.Read();

            //Check if MAX QuestId Null
            if (dataReader.IsDBNull(0))
                intNextTId = 1;
            else
                intNextTId = Convert.ToInt32(dataReader.GetValue(0)) + 1;

            //Close DB connection
            myConn.Close();

            //Return QuestId
            return intNextTId;
        }

        public void saveTest()
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which inserts the question in to the database
            string strSQL = "INSERT INTO Tests (TestId, TestDate, Score, StudId, LevelCode) VALUES (" + testId + ", '" + string.Format("{0:dd-MMM-yy}", dateTaken) +
                            "', '" + testScore + "', '" + studId + "', '" + tLevel + "')";

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

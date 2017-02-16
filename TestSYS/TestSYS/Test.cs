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

        public Test()
        {
            testId = 0;
            dateTaken = "";
            testScore = 0;
            studId = 0;
        }

        public Test(int tId, String dTaken, int tScore, int sId)
        {
            testId = tId;
            dateTaken = dTaken;
            testScore = tScore;
            studId = sId;
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
        
        //GET ALL QUESTION IDS OF QUESTIONS FOR THAT LEVEL
        public int[] getLevelQuestIds(String level)
        {
            Question quest = new Question();

            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX QuestId in Questions
            String strSQL = "SELECT QuestId  FROM Questions WHERE LevelCode = '" + level + "'";  // TO BE ADDED "' AND Status = 'a'"

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Find out how many questions in required level then 
            //create array to hold questions ids of the selected level
            int count = quest.getQuestCount(level);
            int[] questIds = new int[count];

            int i = 0;

            while(dr.Read())
            {
                questIds[i] = dr.GetInt32(0);
                i++;
            }

            //Close DB connection
            myConn.Close();

            return questIds;
        }
    }
}

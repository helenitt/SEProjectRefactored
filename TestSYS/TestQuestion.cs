using System;
using System.Data.SQLite;

namespace TestSYS
{
    class TestQuestion
    {
        private int testId;
        private int[] questId = new int[4];
        private int[] answerGiven = new int[4];

        public TestQuestion()
        {
            testId = 0;
            questId[0] = 0;
            questId[1] = 0;
            questId[2] = 0;
            questId[3] = 0;
            answerGiven[0] = 0;
            answerGiven[1] = 0;
            answerGiven[2] = 0;
            answerGiven[3] = 0;
        }

        public TestQuestion(int tId, int[] qId, int[] ansGiven)
        {
            testId = tId;
            questId = qId;
            answerGiven = ansGiven;
        }

        public int getTestId() { return testId; }
        public int[] getQuestId() { return questId; }
        public int[] getAnsGiven() { return answerGiven; }

        public void setTestId(int tId) { testId = tId; }
        public void setQuestId(int[] qId) { questId = qId; }
        public void setAnsGiven(int[] aGiven) { answerGiven = aGiven; }

        // CRETE AN ARRAY TO HOLD 4 QUESTIONS FOR THE TEST 
        // GENERATE RANDOM NUMBER BETWEEN 0 AND NUM OF QUESTIONS IN THAT LEVEL
        public int[] getTestQuestions(int[] ids)
        {
            int[] testQuestions = new int[4];

            for (int i = 0; i < testQuestions.Length; i++)
            {
                var rnd = new Random();
                int ranNum = rnd.Next(0, ids.Length);
                testQuestions[i] = ids[ranNum];

                while (testQuestions[1] == testQuestions[0])
                {
                    ranNum = rnd.Next(0, ids.Length);
                    testQuestions[1] = ids[ranNum];
                }
                while (testQuestions[2] == testQuestions[0] || testQuestions[2] == testQuestions[1])
                {
                    ranNum = rnd.Next(0, ids.Length);
                    testQuestions[2] = ids[ranNum];
                }
                while (testQuestions[3] == testQuestions[0] || testQuestions[3] == testQuestions[1] || testQuestions[3] == testQuestions[2])
                {
                    ranNum = rnd.Next(0, ids.Length);
                    testQuestions[3] = ids[ranNum];
                }
            }
            return testQuestions;
        }

        public void saveTestQuest()
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            for(int i=0; i < 4; i++) 
            {
                //Define SDQL query which inserts the question in to the database
                string strSQL = "INSERT INTO TestQuestions (TestId, QuestId, AnsGiven) VALUES (" + testId + ", '" +  questId[i] + "', '" + answerGiven[i] + "')";

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
}

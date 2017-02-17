﻿using System;
using System.Data.OracleClient;

namespace TestSYS
{
    class TestQuestion
    {
        private int testId;
        private int[] questId = new int[4];
        private int[] ansGiven = new int[4];

        public TestQuestion()
        {
        }

        public TestQuestion(int tId, int[] qId, int[] ansGiven)
        {
            testId = tId;
            questId = qId;
            this.ansGiven = ansGiven;
        }

        public int getTestId()
        {
            return testId;
        }
        public int[] getQuestId()
        {
            return questId;
        }
        public int[] getAnsGiven()
        {
            return ansGiven;
        }

        public void setTestId(int tId)
        {
            testId = tId;
        }
        public void setQuestId(int[] qId)
        {
            questId = qId;
        }
        public void setAnsGiven(int[] aGiven)
        {
            ansGiven = aGiven;
        }

        // CRETE AN ARRAY TO HOLD 4 QUESTIONS FOR THE TEST 
        //GENERATE RANDOM NUMBER BETWEEN 0 AND NUM OF QUESTIONS IN THAT LEVEL
        public int[] getTestQuestions(int[] ids)
        {
            int[] testQuestions = new int[4];

            for (int i = 0; i < testQuestions.Length; i++)
            {
                Random rnd = new Random();
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
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            for(int i=0; i<4; i++) 
            {
                //Define SDQL query which inserts the question in to the database
                String strSQL = "INSERT INTO TestQuestions (TestId,QuestId,AnsGiven) VALUES (" + this.testId + ", '" +  this.questId[i] + "', '" + this.ansGiven[i] + "')";

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
}
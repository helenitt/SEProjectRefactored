using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace TestSYS
{
    class Question
    {
        private int questId;
        private String qLevel;
        private String qText;
        private String ans1;
        private String ans2;
        private String ans3;
        private String ans4;
        private int correctAns;
        private String qAdd;
        private String qAmd;
        private String status;

        public Question()
        {
            questId = 0;
            qLevel = "";
            qText = "";
            ans1 = "";
            ans2 = "";
            ans3 = "";
            ans4 = "";
            correctAns = 0;
            qAdd = "";
            qAmd = "";
            status = "";
        }

        public Question(int id, String lvl, String txt, String a1, String a2, String a3, String a4, int corAns, String qAdd, String qAmd, String stat)
        {
            questId = id;
            qLevel = lvl;
            qText = txt;
            ans1 = a1;
            ans2 = a2;
            ans3 = a3;
            ans4 = a4;
            correctAns = corAns;
            this.qAdd = qAdd;
            this.qAmd = qAmd;
            status = stat;
        }

        // Accessors

        public int getQuestId()
        {
            return questId;
        }
        public String getQLevel()
        {
            return qLevel;
        }
        public String getQText()
        {
            return qText;       
        }
        public String getAns1()
        {
            return ans1;
        }
        public String getAns2()
        {
            return ans2;
        }
        public String getAns3()
        {
            return ans3;
        }
        public String getAns4()
        {
            return ans4;
        }
        public int getCorrectAns()
        {
            return correctAns;
        }
        public String getQAdd()
        {
            return qAdd;
        }
        public String getQAmd()
        {
            return qAmd;
        }
        public String getStatus()
        {
            return status;
        }

        // Mutators
        public void setQuestId(int id)
        {
            questId = id;
        }
        public void setQLevel(String lvl)
        {
            qLevel = lvl;
        }
        public void setQText(String qTxt)
        {
            qText = qTxt;
        }
        public void setAns1(String a1)
        {
            ans1 = a1;
        }
        public void setAns2(String a2)
        {
            ans2 = a2;
        }
        public void setAns3(String a3)
        {
            ans3 = a3;
        }
        public void setAns4(String a4)
        {
            ans4 = a4;
        }
        public void setCorrectAns(int corrAns)
        {
            correctAns = corrAns;
        }
        public void setQAdd(String qAdd)
        {
            this.qAdd = qAdd;
        }
        public void setQAmd(String qAmd)
        {
            this.qAmd = qAmd;
        }
        public void setStatus(String stat)
        {
            status = stat;
        }


        // GET NEXT QUESTION ID
        public int getNextQuestId()
        {
            int intNextQId;

            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX QuestId in Questions
            String strSQL = "SELECT MAX(QuestId) FROM Questions";

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
                intNextQId = 1;
            else
                intNextQId = Convert.ToInt32(dr.GetValue(0)) + 1;

            //Close DB connection
            myConn.Close();

            //Return QuestId
            return intNextQId;
        }


        // INSERT QUESTION IN TO DATABASE
        public void insertQuestion()
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which inserts the question in to the database
            String strSQL = "INSERT INTO Questions (QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,Status) VALUES (" + this.questId +
                            ", '" + this.qLevel + "', '" + this.qText + "', '" + this.ans1 + "', '" + this.ans2 + "', '" + this.ans3 + "', '" + this.ans4 +
                            "', " + this.correctAns + ", '" + String.Format("{0:dd-MMM-yy}", this.qAdd) + "', '" + this.status + "')";


            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }


        // GET QUESTION DETAILS
        public void getQuestionDetails(int qId)
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            String strSQL = "SELECT *  FROM Questions WHERE QuestId = " + qId;

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the record in dr
            dr.Read();

            //Set variables
            this.setQuestId(Convert.ToInt32(dr.GetValue(0)));  
            this.setQLevel(dr.GetString(1));
            this.setQText(dr.GetString(2));
            this.setAns1(dr.GetString(3));
            this.setAns2(dr.GetString(4));
            this.setAns3(dr.GetString(5));
            this.setAns4(dr.GetString(6));
            this.setCorrectAns(Convert.ToInt32(dr.GetValue(7)));  
            
            myConn.Close();
        }

        public void updateQuestion()
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which updates the students details
            String strSQL = "UPDATE Questions SET LevelCode = '" + this.qLevel + "', Text =  '" + this.qText + "', Ans1 = '" + this.ans1 + 
                            "', Ans2 = '" + this.ans2 + "', Ans3 = '" + this.ans3 + "', Ans4 = '" + this.ans4 +
                            "', QAmd = '" + String.Format("{0:dd-MMM-yy}", this.qAmd) + "', Status = 'a' WHERE QuestId = " + this.questId;

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }

        public void deleteQuestion(int questId)
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which updates the students details
            String strSQL = "UPDATE Questions SET Status = 'd', QAmd = '" + String.Format("{0:dd-MMM-yy}", this.qAmd) + "' WHERE QuestId = " + this.questId;

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }

        //METHOD FOR AMEND QUESTION
        // RETURNS tOTAL NUMBER OF QUESTIONS
        public int getQuestCount()
        {
            int countQuest;
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SQL query which retrieves number of questions in level
            String strSQL = "SELECT COUNT(*)  FROM Questions";

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
                countQuest = 0;
            else
                countQuest = Convert.ToInt32(dr.GetValue(0));

            //Close DB connection
            myConn.Close();

            return countQuest;
        }
      
        // METHODS FOR TAKE TEST
        // RETURNS NUMBER OF QUESTIONS IN SELECTED LEVEL 
        public int getQuestCount(String level)
        {
            int countQuest;
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SQL query which retrieves number of questions in level
            String strSQL = "SELECT COUNT(*)  FROM Questions WHERE LevelCode = '" + level + "' AND Status = 'a'";
            
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
                countQuest = 0;
            else
                countQuest = Convert.ToInt32(dr.GetValue(0));

            //Close DB connection
            myConn.Close();

            return countQuest;
        }

        //GET ALL QUESTION IDS OF QUESTIONS FOR SELECTED LEVEL
        public int[] getLevelQuestIds(String level)
        {
            Question quest = new Question();

            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX QuestId in Questions
            String strSQL = "SELECT QuestId  FROM Questions WHERE LevelCode = '" + level + "' AND Status = 'a'";  //"' AND Status = 'a'"

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

            while (dr.Read())
            {
                questIds[i] = dr.GetInt32(0);
                i++;
            }

            //Close DB connection
            myConn.Close();

            return questIds;
        }

        //PASSES IN THE ARRAY OF TEST QUESTIONS AND GETS NEXT QUESTION
        public void displayQuestion(int[] ids, int i)
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            String strSQL = "SELECT *  FROM Questions WHERE QuestId = " + ids[i];

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the record in dr
            dr.Read();

            //Set variables
            this.setQuestId(Convert.ToInt32(dr.GetValue(0)));
            this.setQLevel(dr.GetString(1));
            this.setQText(dr.GetString(2));
            this.setAns1(dr.GetString(3));
            this.setAns2(dr.GetString(4));
            this.setAns3(dr.GetString(5));
            this.setAns4(dr.GetString(6));
            this.setCorrectAns(Convert.ToInt32(dr.GetValue(7)));
            
            //Close DB connection
            myConn.Close();
        }
    }
}

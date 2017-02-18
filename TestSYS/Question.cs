using System;
using System.Data.SQLite;

namespace TestSYS
{
    class Question
    {
        private int questId;
        private string qLevel;
        private string qText;
        private string ans1;
        private string ans2;
        private string ans3;
        private string ans4;
        private int correctAns;
        private string qAdd;
        private string qAmd;
        private string status;

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

        public Question(int id, string lvl, string txt, string a1, string a2, string a3, string a4, int corAns, string qAdd, string qAmd, string stat)
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
        public string getQLevel()
        {
            return qLevel;
        }
        public string getQText()
        {
            return qText;       
        }
        public string getAns1()
        {
            return ans1;
        }
        public string getAns2()
        {
            return ans2;
        }
        public string getAns3()
        {
            return ans3;
        }
        public string getAns4()
        {
            return ans4;
        }
        public int getCorrectAns()
        {
            return correctAns;
        }
        public string getQAdd()
        {
            return qAdd;
        }
        public string getQAmd()
        {
            return qAmd;
        }
        public string getStatus()
        {
            return status;
        }

        // Mutators
        public void setQuestId(int id)
        {
            questId = id;
        }
        public void setQLevel(string lvl)
        {
            qLevel = lvl;
        }
        public void setQText(string qTxt)
        {
            qText = qTxt;
        }
        public void setAns1(string a1)
        {
            ans1 = a1;
        }
        public void setAns2(string a2)
        {
            ans2 = a2;
        }
        public void setAns3(string a3)
        {
            ans3 = a3;
        }
        public void setAns4(string a4)
        {
            ans4 = a4;
        }
        public void setCorrectAns(int corrAns)
        {
            correctAns = corrAns;
        }
        public void setQAdd(string qAdd)
        {
            this.qAdd = qAdd;
        }
        public void setQAmd(string qAmd)
        {
            this.qAmd = qAmd;
        }
        public void setStatus(string stat)
        {
            status = stat;
        }


        // GET NEXT QUESTION ID
        public int getNextQuestId()
        {
            int intNextQId;

            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX QuestId in Questions
            string strSQL = "SELECT MAX(QuestId) FROM Questions";

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            var dr = cmd.ExecuteReader();

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
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which inserts the question in to the database
            string strSQL = "INSERT INTO Questions (QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,Status) VALUES (" + this.questId +
                            ", '" + this.qLevel + "', '" + this.qText + "', '" + this.ans1 + "', '" + this.ans2 + "', '" + this.ans3 + "', '" + this.ans4 +
                            "', " + this.correctAns + ", '" + string.Format("{0:dd-MMM-yy}", this.qAdd) + "', '" + this.status + "')";


            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

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
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            string strSQL = "SELECT *  FROM Questions WHERE QuestId = " + qId;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            var dr = cmd.ExecuteReader();

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
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which updates the students details
            string strSQL = "UPDATE Questions SET LevelCode = '" + this.qLevel + "', Text =  '" + this.qText + "', Ans1 = '" + this.ans1 + 
                            "', Ans2 = '" + this.ans2 + "', Ans3 = '" + this.ans3 + "', Ans4 = '" + this.ans4 +
                            "', QAmd = '" + string.Format("{0:dd-MMM-yy}", this.qAmd) + "', Status = 'a' WHERE QuestId = " + this.questId;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

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
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which updates the students details
            string strSQL = "UPDATE Questions SET Status = 'd', QAmd = '" + string.Format("{0:dd-MMM-yy}", this.qAmd) + "' WHERE QuestId = " + this.questId;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

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
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SQL query which retrieves number of questions in level
            string strSQL = "SELECT COUNT(*)  FROM Questions";

            //Define Oracle Command
            SQLiteCommand cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            var dr = cmd.ExecuteReader();

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
        public int getQuestCount(string level)
        {
            int countQuest;
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SQL query which retrieves number of questions in level
            string strSQL = "SELECT COUNT(*)  FROM Questions WHERE LevelCode = '" + level + "' AND Status = 'a'";
            
            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            var dr = cmd.ExecuteReader();

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
        public int[] getLevelQuestIds(string level)
        {
            Question quest = new Question();

            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX QuestId in Questions
            string strSQL = "SELECT QuestId  FROM Questions WHERE LevelCode = '" + level + "' AND Status = 'a'";  //"' AND Status = 'a'"

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            var dr = cmd.ExecuteReader();

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
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
            string strSQL = "SELECT *  FROM Questions WHERE QuestId = " + ids[i];

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            var dr = cmd.ExecuteReader();

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

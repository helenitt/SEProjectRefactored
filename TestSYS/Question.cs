using System;
using System.Data.SQLite;

namespace TestSYS
{
    class Question
    {
        private int questionId;
        private string questionLevel;
        private string questionText;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;
        private int correctAns;
        private string questionAdd;
        private string questAmend;
        private string status;

        public Question()
        {
            questionId = 0;
            questionLevel = "";
            questionText = "";
            answer1 = "";
            answer2 = "";
            answer3 = "";
            answer4 = "";
            correctAns = 0;
            questionAdd = "";
            questAmend = "";
            status = "";
        }

        public Question(int id, string lvl, string txt, string a1, string a2, string a3, string a4, int corAns, string qAdd, string qAmd, string stat)
        {
            questionId = id;
            questionLevel = lvl;
            questionText = txt;
            answer1 = a1;
            answer2 = a2;
            answer3 = a3;
            answer4 = a4;
            correctAns = corAns;
            questionAdd = qAdd;
            questAmend = qAmd;
            status = stat;
        }
        
        public int getQuestId() { return questionId; }
        public string getQLevel() { return questionLevel; }
        public string getQText() { return questionText; }
        public string getAns1() { return answer1; }
        public string getAns2() { return answer2; }
        public string getAns3() { return answer3; }
        public string getAns4() { return answer4; }
        public int getCorrectAns() { return correctAns; }
        public string getQAdd() { return questionAdd; }
        public string getQAmd() { return questAmend; }
        public string getStatus() { return status; }

        public void setQuestId(int id) { questionId = id; }
        public void setQLevel(string lvl) { questionLevel = lvl; }
        public void setQText(string qTxt) { questionText = qTxt; }
        public void setAns1(string a1) { answer1 = a1; }
        public void setAns2(string a2) { answer2 = a2; }
        public void setAns3(string a3) { answer3 = a3; }
        public void setAns4(string a4) { answer4 = a4; }
        public void setCorrectAns(int corrAns) { correctAns = corrAns; }
        public void setQAdd(string qAdd) {questionAdd = qAdd; }
        public void setQAmd(string qAmd) { questAmend = qAmd; }
        public void setStatus(string stat) { status = stat; }
        
        public int getNextQuestId()
        {
            int NextQuestionId;
            string strSQL = "SELECT MAX(QuestId) FROM Questions";

            var dataReader = DbConnect.ConnectDbReader(strSQL);

            if (dataReader.IsDBNull(0))
                NextQuestionId = 1;
            else
                NextQuestionId = Convert.ToInt32(dataReader.GetValue(0)) + 1;

            DbConnect.CloseDb();
            return NextQuestionId;
        }
        
        public void insertQuestion()
        {
            string strSQL = "INSERT INTO Questions (QuestId, LevelCode, Text, Ans1, Ans2, Ans3, Ans4, CorrectAns, QAdd, Status) VALUES (" + questionId +
                            ", '" + questionLevel + "', '" + questionText + "', '" + answer1 + "', '" + answer2 + "', '" + answer3 + "', '" + answer4 +
                            "', " + correctAns + ", '" + string.Format("{0:dd-MMM-yy}", questionAdd) + "', '" + status + "')";

            DbConnect.ConnectDbNonQuery(strSQL);
            DbConnect.CloseDb();
        }

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
            setQuestId(Convert.ToInt32(dr.GetValue(0)));  
            setQLevel(dr.GetString(1));
            setQText(dr.GetString(2));
            setAns1(dr.GetString(3));
            setAns2(dr.GetString(4));
            setAns3(dr.GetString(5));
            setAns4(dr.GetString(6));
            setCorrectAns(Convert.ToInt32(dr.GetValue(7)));

            DbConnect.CloseDb();
        }

        public void updateQuestion()
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which updates the students details
            string strSQL = "UPDATE Questions SET LevelCode = '" + questionLevel + "', Text =  '" + questionText + "', Ans1 = '" + answer1 + 
                            "', Ans2 = '" + answer2 + "', Ans3 = '" + answer3 + "', Ans4 = '" + answer4 +
                            "', QAmd = '" + string.Format("{0:dd-MMM-yy}", questAmend) + "', Status = 'a' WHERE QuestId = " + questionId;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            cmd.ExecuteNonQuery();

            DbConnect.CloseDb();
        }

        public void deleteQuestion(int questId)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which updates the students details
            string strSQL = "UPDATE Questions SET Status = 'd', QAmd = '" + string.Format("{0:dd-MMM-yy}", questAmend) + "' WHERE QuestId = " + questId;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            cmd.ExecuteNonQuery();

            DbConnect.CloseDb();
        }

        // METHOD FOR AMEND QUESTION
        // RETURNS TOTAL NUMBER OF QUESTIONS
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
            var dataReader = cmd.ExecuteReader();

            //Read the record in dr
            dataReader.Read();


            //Check if MAX QuestId Null
            if (dataReader.IsDBNull(0))
                countQuest = 0;
            else
                countQuest = Convert.ToInt32(dataReader.GetValue(0));

            DbConnect.CloseDb();

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

            DbConnect.CloseDb();

            return countQuest;
        }

        //GET ALL QUESTION IDS OF QUESTIONS FOR SELECTED LEVEL
        public int[] getLevelQuestIds(string level)
        {
            var quest = new Question();

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
            var dataReader = cmd.ExecuteReader();

            //Find out how many questions in required level then 
            //create array to hold questions ids of the selected level
            int count = quest.getQuestCount(level);
            int[] questIds = new int[count];

            int i = 0;

            while (dataReader.Read())
            {
                questIds[i] = dataReader.GetInt32(0);
                i++;
            }

            DbConnect.CloseDb();

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
            var dataReader = cmd.ExecuteReader();

            //Read the record in dr
            dataReader.Read();

            //Set variables
            setQuestId(Convert.ToInt32(dataReader.GetValue(0)));
            setQLevel(dataReader.GetString(1));
            setQText(dataReader.GetString(2));
            setAns1(dataReader.GetString(3));
            setAns2(dataReader.GetString(4));
            setAns3(dataReader.GetString(5));
            setAns4(dataReader.GetString(6));
            setCorrectAns(Convert.ToInt32(dataReader.GetValue(7)));

            DbConnect.CloseDb();
        }
    }
}

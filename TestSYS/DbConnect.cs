using System.Data.SQLite;

namespace TestSYS
{
    class DbConnect
    {
        public static SQLiteConnection myConn;

        // string         dataReader        2
        // string         Execute reader    1
        // int, string    dataReader        2
        // int            dataReader        3
        //                dataReader        2
        //                ExecuteNonQuery   4
        // int            ExecuteNonQuery   2

        public static SQLiteDataReader ConnectDbReader(string strSQL)
        {
            myConn = new SQLiteConnection(Db.ConnectionString);
            var cmd = new SQLiteCommand(strSQL, myConn);
            myConn.Open();
            SQLiteDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            return dataReader;
        }

        public static void ConnectDbNonQuery(string strSQL)
        {
            myConn = new SQLiteConnection(Db.ConnectionString);
            var cmd = new SQLiteCommand(strSQL, myConn);
            myConn.Open();
            cmd.ExecuteNonQuery();
        }

        public static void CloseDb()
        {
            myConn.Close();
        }
    }
}

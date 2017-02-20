using System.Data.SQLite;

namespace TestSYS
{
    public static class LoadLevels
    {
        public static SQLiteDataReader LevelsLoad()
        {
            string strSQL = "SELECT * FROM Levels";
            var dataReader = DbConnect.ConnectDbReader(strSQL);
            return dataReader;
        }
    }
}

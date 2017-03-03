using System.Data.SQLite;
using System.IO;

namespace TestSYS
{
    public static class DbSetup
    {
        private static readonly string dbFile = "TestSYS.sqlite";
        public static string ConnectionString { get; private set; } 

        public static void SetUpDb()
        {
            ConnectionString = string.Format("Data Source={0};Version=3;", dbFile);
            CreateDbFile();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                CreateDbObjects(connection);
                FillDb(connection);
            }
        }

        private static void CreateDbFile()
        {
            if (File.Exists(dbFile))
            {
                File.Delete(dbFile);
            }
            SQLiteConnection.CreateFile(dbFile);
        }

        private static void CreateDbObjects(SQLiteConnection connection)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "db\\CreateTestSYS.sql");
            var sql = File.ReadAllText(path);

            var command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        private static void FillDb(SQLiteConnection connection)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "db\\FillTestSYS.sql");
            var sql = File.ReadAllText(path);

            var command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}

using System.Data.SQLite;
using System.IO;

namespace PdvProject.Database
{
    public static class DbHelper
    {
        private static string dbPath = "dbPdv.db";
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            if (!File.Exists(dbPath))
                CriarBanco();

            return new SQLiteConnection(connectionString);
        }

        private static void CriarBanco()
        {
            SQLiteConnection.CreateFile(dbPath);
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sqlProdutos = @"
                    CREATE TABLE IF NOT EXISTS Produtos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Codigo TEXT NOT NULL UNIQUE,
                        Nome TEXT NOT NULL,
                        Preco REAL NOT NULL
                    );";

                string sqlVendas = @"
                    CREATE TABLE IF NOT EXISTS Vendas (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Data TEXT NOT NULL,
                        Total REAL NOT NULL
                    );";

                using (var cmd = new SQLiteCommand(sqlProdutos, con))
                    cmd.ExecuteNonQuery();

                using (var cmd = new SQLiteCommand(sqlVendas, con))
                    cmd.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}
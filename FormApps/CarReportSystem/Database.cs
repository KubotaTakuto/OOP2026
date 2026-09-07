using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;

public static class Database {
    private static readonly string DatabasePath =
        Path.Combine(AppContext.BaseDirectory, "carreports.db");

    private static readonly string ConnectionString =
        $"Data Source={DatabasePath}";

    public static SqliteConnection GetConnection()
        => new SqliteConnection(ConnectionString);

    public static void Initialize() {
        //接続オブジェクトを生成する
        using var connection = GetConnection();
        connection.Open();

        //Productsテーブルを作るSQLB
        //IF NOT EXSISTS により、既にテーブルがあってもエラーにならない
        using var command = connection.CreateCommand();
        command.CommandText =
            """
            CREATE TABLE IF NOT EXISTS Carreports(
            Id          INTEGER PRIMARY KEY AUTOINCREMENT,
            Date        TEXT    MOT MULL,
            Author      TEXT    NOT NULL,
            Maker       INTEGER NOT NULL,
            CarName     TEXT    NOT NULL,
            Report      TEXT    NOT NULL,
            Picture     BLOB
            );
            """;

        command.ExecuteNonQuery();
    }
}

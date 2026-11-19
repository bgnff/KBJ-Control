using MySqlConnector;
using System;

public class ConexaoBD
{
    private static string server = "127.0.0.1";
    private static string database = "kbj_control";
    private static string user = "root";
    private static string password = Environment.GetEnvironmentVariable("KBJ_DB_PASSWORD") ?? "";
    private static string connectionString = $"Server={server};Database={database};Uid={user};Pwd={password}";

    public static MySqlConnection ObterConexao()
    {
        return new MySqlConnection(connectionString);
    }
}

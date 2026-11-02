using MySqlConnector;
using System;

public class ConexaoBD
{
    private static string server = "localhost";
    private static string database = "kbj_control";
    private static string user = "root";
    private static string password = "hellsingH0@";
    private static string connectionString = $"Server={server};Database={database};Uid={user};Pwd={password}";

    public static MySqlConnection ObterConexao()
    {
        return new MySqlConnection(connectionString);
    }
}
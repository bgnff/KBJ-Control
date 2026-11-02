using MySqlConnector;
using System;

public class UsuarioRepository
{
    public bool AutentificarUsuario(string usuarioInput, string senhaInput)
    {
        string query = "SELECT senha_hash FROM usuarios WHERE nome_usuario = @nome_usuario";
        
        using (MySqlConnection conexao = ConexaoBD.ObterConexao())
        {
            try
            {
                conexao.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome_usuario", usuarioInput);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string senhaHashBanco = result.ToString();

                        bool senhaValida = BCrypt.Net.BCrypt.Verify(senhaInput, senhaHashBanco);

                        return senhaValida;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar o Banco de Dados. " + ex.Message);
            }
        }
        return false;
    }
}

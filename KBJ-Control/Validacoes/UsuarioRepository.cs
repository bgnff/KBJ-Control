using MySqlConnector;
using System;
public class UsuarioRepository
{
    public bool AutentificarUsuario(
        string usuarioInput,
        string senhaInput,
        out uint usuarioId)
    {
        usuarioId = 0;

        const string query = """
            SELECT usuario_id, senha_hash
            FROM usuarios
            WHERE nome_usuario = @nome_usuario
              AND status_ativo = 'ATIVA'
            """;

        using (MySqlConnection conexao = ConexaoBD.ObterConexao())
        {
            conexao.Open();

            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@nome_usuario", usuarioInput);

                using (MySqlDataReader leitor = cmd.ExecuteReader())
                {
                    if (!leitor.Read())
                        return false;

                    string senhaHashBanco = leitor.GetString("senha_hash");

                    if (!BCrypt.Net.BCrypt.Verify(senhaInput, senhaHashBanco))
                        return false;

                    usuarioId = leitor.GetUInt32("usuario_id");
                    return true;
                }
            }
        }
    }
}
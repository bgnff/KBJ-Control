using MySqlConnector;
using System;
public class UsuarioRepository
{
    public (bool PossuiFuncionario, string NomeExibicao, string NomeUsuario) ObterPerfil(uint usuarioId)
    {
        const string query = """
            SELECT f.funcionario_id IS NOT NULL AS possui_funcionario,
                   CONCAT_WS(' ', f.nome, f.sobrenome) AS nome_exibicao,
                   u.nome_usuario
            FROM usuarios u
            LEFT JOIN funcionarios f ON f.funcionario_id = u.funcionario_id
            WHERE u.usuario_id = @usuario_id
            """;

        using MySqlConnection conexao = ConexaoBD.ObterConexao();
        conexao.Open();
        using MySqlCommand cmd = new(query, conexao);
        cmd.Parameters.AddWithValue("@usuario_id", usuarioId);
        using MySqlDataReader leitor = cmd.ExecuteReader();

        return leitor.Read()
            ? (leitor.GetBoolean("possui_funcionario"), leitor.GetString("nome_exibicao"), leitor.GetString("nome_usuario"))
            : (false, "", "");
    }

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
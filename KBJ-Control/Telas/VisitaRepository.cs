using System.Data;
using MySqlConnector;

public class VisitaRepository
{
    public DataTable Listar(string pesquisa = "", DateTime? inicio = null, DateTime? fim = null, string? situacao = null)
    {
        const string sql = """
            SELECT vi.visita_id, CONCAT_WS(' ', v.nome, v.sobrenome) AS visitante,
                   v.codigo_legal AS documento, vi.empresa_origem, vi.destino,
                   vi.data_entrada, vi.data_saida, vi.motivo_visita, vi.observacoes,
                   CASE WHEN vi.data_saida IS NULL THEN 'Em andamento' ELSE 'Encerrada' END AS situacao
            FROM visitas vi JOIN visitantes v ON v.visitante_id = vi.visitante_id
            WHERE (@busca = '' OR CONCAT_WS(' ', v.nome, v.sobrenome) LIKE @termo OR v.codigo_legal LIKE @termo)
              AND (@inicio IS NULL OR vi.data_entrada >= @inicio)
              AND (@fim IS NULL OR vi.data_entrada < @fim)
              AND (@situacao IS NULL OR vi.status_visita = @situacao)
            ORDER BY vi.data_entrada DESC, vi.visita_id DESC
            """;
        using var conexao = ConexaoBD.ObterConexao();
        using var comando = new MySqlCommand(sql, conexao);
        comando.Parameters.AddWithValue("@busca", pesquisa.Trim());
        comando.Parameters.AddWithValue("@termo", "%" + pesquisa.Trim() + "%");
        comando.Parameters.AddWithValue("@inicio", inicio.HasValue ? inicio.Value.Date : DBNull.Value);
        comando.Parameters.AddWithValue("@fim", fim.HasValue ? fim.Value.Date.AddDays(1) : DBNull.Value);
        comando.Parameters.AddWithValue("@situacao", situacao is null ? DBNull.Value : situacao);
        conexao.Open();
        using var leitor = comando.ExecuteReader();
        var dados = new DataTable();
        dados.Load(leitor);
        return dados;
    }

    public bool RegistrarSaida(uint visitaId, uint usuarioId)
    {
        using var conexao = ConexaoBD.ObterConexao();
        using var comando = conexao.CreateCommand();
        comando.CommandText = "UPDATE visitas SET data_saida = NOW(), usuario_saida_id = @usuario, status_visita = 'ENCERRADA' WHERE visita_id = @id AND status_visita = 'EM ANDAMENTO' AND data_saida IS NULL";
        comando.Parameters.AddWithValue("@id", visitaId);
        comando.Parameters.AddWithValue("@usuario", usuarioId);
        conexao.Open();
        return comando.ExecuteNonQuery() == 1;
    }
}

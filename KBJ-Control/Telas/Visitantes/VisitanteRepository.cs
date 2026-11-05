using MySqlConnector;
using System.Data;

public class VisitanteRepository
{
    public DataTable Listar(string pesquisa = "")
    {
        const string sql = """
            SELECT
                v.visitante_id,
                CONCAT_WS(' ', v.nome, v.sobrenome) AS nome_completo,
                v.codigo_legal AS documento,
                (
                    SELECT vi.empresa_origem
                    FROM visitas vi
                    WHERE vi.visitante_id = v.visitante_id
                    ORDER BY vi.data_entrada DESC, vi.visita_id DESC
                    LIMIT 1
                ) AS empresa_origem
            FROM visitantes v
            WHERE @pesquisa = ''
               OR CONCAT_WS(' ', v.nome, v.sobrenome) LIKE @termo
               OR v.codigo_legal LIKE @termo
            ORDER BY v.nome, v.sobrenome, v.visitante_id;
            """;

        using var conexao = ConexaoBD.ObterConexao();
        using var comando = new MySqlCommand(sql, conexao);

        comando.Parameters.AddWithValue("@pesquisa", pesquisa.Trim());
        comando.Parameters.AddWithValue("@termo", "%" + pesquisa.Trim() + "%");

        conexao.Open();

        using var leitor = comando.ExecuteReader();

        var tabela = new DataTable();
        tabela.Load(leitor);

        return tabela;
    }
}
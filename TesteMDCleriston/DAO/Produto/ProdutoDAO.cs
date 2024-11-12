using Npgsql;
using TesteMDCleriston.ConexaoBD;

namespace TesteMDCleriston.DAO.Produto
{
    public class ProdutoDAO
    {
        private readonly string connectionString = ConexaoBancoDados.conn_;

        // Chamada do metodo contrutor aqui
        public ProdutoDAO(string connectionString)
        {

        }

        public List<Produto> ObterProduto()
        {
            List<Produto> produtos = new List<Produto>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT ID_PRODUTO, NOME_PROD, DESCRICAO, PRECO, ESTOQUE FROM TB_PRODUTOS";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    connection.Open();
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idProduto = Convert.ToInt32(reader["ID_PRODUTO"]);
                            string nomeProd = reader["NOME_PROD"].ToString();
                            string descricao = reader["DESCRICAO"].ToString();
                            decimal preco = Convert.ToDecimal(reader["PRECO"]);
                            decimal estoque = Convert.ToDecimal(reader["ESTOQUE"]);

                            Produto prod = new Produto(idProduto, nomeProd, descricao, preco, estoque);
                            produtos.Add(prod);
                        }
                    }
                }
            }
            return produtos;
        }
    }
}

using Npgsql;
using System.Transactions;
using TesteMDCleriston.ConexaoBD;
using TesteMDCleriston.DAO.Cliente;

namespace TesteMDCleriston.Forms
{
    public partial class ExcluirProduto : Form
    {
        public ExcluirProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            // Verifica se o campo de pesquisa do email esta certo
            if (string.IsNullOrWhiteSpace(txtCodProd.Text))
            {
                MessageBox.Show("Por favor informe o código do produto para atualizar os dados", "ATENÇÃO!!");
            }

            string connectionString = ConexaoBancoDados.conn_;

            int codProduto;

            if (!int.TryParse(txtCodProd.Text, out codProduto))
            {
                MessageBox.Show("O código do produto é inválido. Insira um valor de moeda com virgula.", "Erro de validação");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string queryCheckProdutos = "SELECT COUNT(*) FROM TB_PRODUTOS WHERE ID_PRODUTO = @IdProduto";
                        using (NpgsqlCommand commandCheckProdutos = new NpgsqlCommand(queryCheckProdutos, connection))
                        {
                            commandCheckProdutos.Parameters.AddWithValue("@IdProduto", codProduto);
                            int produtoCount = Convert.ToInt32(commandCheckProdutos.ExecuteScalar());

                            if (produtoCount == 1)
                            {
                                string queryProdutos = "SELECT P.NOME_PROD, P.DESCRICAO, P.PRECO, P.ESTOQUE FROM TB_PRODUTOS P WHERE P.ID_PRODUTO = @IdProduto ";

                                using (NpgsqlCommand command = new NpgsqlCommand(queryProdutos, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@IdProduto", codProduto);
                                    using (NpgsqlDataReader reader = command.ExecuteReader())
                                    {

                                        if (reader.Read())
                                        {
                                            txtNome.Text = reader["NOME_PROD"].ToString();
                                            txtDescricao.Text = reader["DESCRICAO"].ToString();
                                            txtPreco.Text = reader["PRECO"].ToString();
                                            txtQtdEstoque.Text = reader["ESTOQUE"].ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("O Código do produto informado não existe no sistema!", "PRODUTO INEXISTENTE");
                                        }
                                    }
                                }

                                transaction.Commit();
                            }
                            else
                            {
                                MessageBox.Show("O Código do produto informado não existe no sistema!", "PRODUTO INEXISTENTE");
                                transaction.Rollback();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Erro ao atualizar dados: {ex.Message}", "Erro");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }

            else if (string.IsNullOrWhiteSpace(txtCodProd.Text))
            {
                MessageBox.Show("Por favor informe o código do produto para excluir o cliente", "ATENÇÃO!!");

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int codProduto;

                    if (!int.TryParse(txtCodProd.Text, out codProduto))
                    {
                        MessageBox.Show("O código do produto é inválido. Insira um valor de moeda com virgula.", "Erro de validação");
                        return;
                    }

                    string connectionString = ConexaoBancoDados.conn_;
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        try
                        {

                            // Verifica se o produto possui registros de vendas antes de iniciar a transação de exclusão
                            string queryVendas = "SELECT COUNT(*) FROM TB_VENDAS WHERE ID_PRODUTO = @IdProduto";

                            using (NpgsqlCommand commandVendasProduto = new NpgsqlCommand(queryVendas, connection))
                            {
                                commandVendasProduto.Parameters.AddWithValue("@IdProduto", codProduto);

                                long registroVendas = (long)commandVendasProduto.ExecuteScalar();

                                if (registroVendas > 0)
                                {
                                    MessageBox.Show("Produto não pode ser excluído pois existe o histórico de vendas associado!", "ERRO!");
                                    return;
                                }
                            }

                            // Se não existir exclui o produto
                            using (var transaction = connection.BeginTransaction())
                            {
                                string deleteQuery = "DELETE FROM TB_PRODUTOS WHERE ID_PRODUTO = @IdProduto ";

                                using (NpgsqlCommand commandDelete = new NpgsqlCommand(deleteQuery, connection, transaction))
                                {
                                    commandDelete.Parameters.AddWithValue("@IdProduto", codProduto);

                                    commandDelete.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageBox.Show("Os dados foram excluídos com sucesso!");
                                LimparCampos();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir dados: {ex.Message}", "Erro");
                        }                   
                    }
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtQtdEstoque.Text = "";
            txtCodProd.Text = "";

            txtCodProd.Focus();
        }

        private void btnFecharProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

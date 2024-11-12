using Npgsql;
using TesteMDCleriston.ConexaoBD;

namespace TesteMDCleriston.Forms
{
    public partial class AlterarDadosProduto : Form
    {
        public AlterarDadosProduto()
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

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text) || string.IsNullOrWhiteSpace(txtQtdEstoque.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "CAMPOS NÃO PREENCHIDOS!");
                return;
            }
            else
            {
                string connectionString = ConexaoBancoDados.conn_;

                string nome = txtNome.Text;
                string descricao = txtDescricao.Text;

                decimal preco;

                if (!decimal.TryParse(txtPreco.Text, out preco))
                {
                    MessageBox.Show("O valor do preço é inválido. Insira um valor de moeda com virgula.", "Erro de validação");
                    return;
                }

                decimal qtdEstoque;

                if (!decimal.TryParse(txtQtdEstoque.Text, out qtdEstoque))
                {
                    MessageBox.Show("A quantidade informada para o estoque é invalida. Insira um valor de moeda com virgula.", "Erro de validação");
                    return;
                }

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
                            string updateQuery = "UPDATE TB_PRODUTOS SET NOME_PROD = @NomeProd, " +
                                                          "DESCRICAO = @Descricao, " +
                                                          "PRECO = @Preco, " +
                                                          "ESTOQUE = @Estoque " +
                                                          "WHERE ID_PRODUTO = @IdProduto ";

                            using (NpgsqlCommand commandUpdate = new NpgsqlCommand(updateQuery, connection, transaction))
                            {
                                commandUpdate.Parameters.AddWithValue("@NomeProd", nome);
                                commandUpdate.Parameters.AddWithValue("@Descricao", descricao);
                                commandUpdate.Parameters.AddWithValue("@Preco", preco);
                                commandUpdate.Parameters.AddWithValue("@Estoque", qtdEstoque);
                                commandUpdate.Parameters.AddWithValue("@IdProduto", codProduto);

                                commandUpdate.ExecuteNonQuery();
                                transaction.Commit();
                            }

                            MessageBox.Show("Os dados foram atualizados com sucesso!");
                            LimparCampos();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Erro ao atualizar dados: {ex.Message}", "Erro");
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

        private void btnFecharProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

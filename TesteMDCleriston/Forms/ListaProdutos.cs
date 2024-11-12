using Npgsql;
using System.Data;
using TesteMDCleriston.ConexaoBD;

namespace TesteMDCleriston.Forms
{
    public partial class ListaProdutos : Form
    {
        public ListaProdutos()
        {
            InitializeComponent();
            CarregarTodosProdutos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }

            int? codProduto = null;

            if (!string.IsNullOrWhiteSpace(txtCodProd.Text))
            {
                if (int.TryParse(txtCodProd.Text, out int codProd))
                {
                    codProduto = codProd;
                }
                else
                {
                    MessageBox.Show("O código do produto é inválido. Insira um valor de moeda com virgula.", "Erro de validação");
                    return;
                }
            }

            PesquisarProdutos(codProduto);
            
        }

        private void PesquisarProdutos(int? codProduto = null)
        {
            string connectionString = ConexaoBancoDados.conn_;

            string queryCheckProdutos = "SELECT P.ID_PRODUTO AS \"CODIGO DO PRODUTO\", P.NOME_PROD AS \"NOME DO PRODUTO\", P.DESCRICAO AS \"DESCRIÇÃO\", " +
                                        "P.PRECO AS \"PREÇO\", P.ESTOQUE AS \"QUANTIDADE ESTOQUE\" " +
                                        "FROM TB_PRODUTOS P WHERE 1=1";

            // Adiciona condições à consulta se os parâmetros forem fornecidos

            if (codProduto != null)
            {
                queryCheckProdutos += " AND ID_PRODUTO = @idProduto";
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(queryCheckProdutos, connection))
                    {
                        if (codProduto != null)
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@idProduto", codProduto);
                        }

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewProdutos.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro");
                }
            }
        }

        private void CarregarTodosProdutos()
        {
            // Chama o método de pesquisa sem parâmetros para carregar todos os produtos
            PesquisarProdutos();
        }

    }
}

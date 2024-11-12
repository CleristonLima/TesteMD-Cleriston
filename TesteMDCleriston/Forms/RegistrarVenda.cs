using Npgsql;
using System.Data.Common;
using System.Diagnostics;
using System.Transactions;
using TesteMDCleriston.ConexaoBD;
using TesteMDCleriston.DAO.Cliente;
using TesteMDCleriston.DAO.Produto;

namespace TesteMDCleriston.Forms
{
    public partial class RegistrarVenda : Form
    {
        public RegistrarVenda()
        {
            InitializeComponent();

            PreencherComboxCliente();

            PreencherComboxProduto();

            MostrarPrecoTotal();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedItem is Cliente selectedCliente)
            {

                int selectedClienteId = selectedCliente.IdCliente;
            }
        }

        private void PreencherComboxCliente()
        {
            string connectionString = ConexaoBancoDados.conn_;

            ClienteDAO clienteDAO = new ClienteDAO(connectionString);
            List<Cliente> clientes = clienteDAO.ObterClientes();

            List<Cliente> clienteComPrompt = new List<Cliente>
            {
                new Cliente { IdCliente = 0, Nome = "--Selecione" }
            };

            clienteComPrompt.AddRange(clientes);

            cbxCliente.DataSource = clienteComPrompt;
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.ValueMember = "IdCliente";

            cbxCliente.SelectedIndex = 0;
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProduto.SelectedItem is Produto selectedProduto)
            {

                int selectedProdutoId = selectedProduto.IdProduto;
            }
        }

        private void PreencherComboxProduto()
        {
            string connectionString = ConexaoBancoDados.conn_;

            ProdutoDAO produtoDAO = new ProdutoDAO(connectionString);
            List<Produto> produtos = produtoDAO.ObterProduto();

            List<Produto> produtoComPrompt = new List<Produto>
            {
                new Produto { IdProduto = 0, Descricao = "--Selecione" }
            };

            produtoComPrompt.AddRange(produtos);

            cbxProduto.DataSource = produtoComPrompt;
            cbxProduto.DisplayMember = "Descricao";
            cbxProduto.ValueMember = "IdProduto";

            cbxProduto.SelectedIndex = 0;
        }

        // Método para atualizar o preço total e inserir a quantidade

        private void MostrarPrecoTotal()
        {
            if (cbxProduto.SelectedIndex == 0 || string.IsNullOrWhiteSpace(txtQtd.Text))
            {
                txtPrecoTotal.Text = "0.00";
                return;
            }

            int idProduto = (int)cbxProduto.SelectedValue;

            decimal quantidade;

            if (!decimal.TryParse(txtQtd.Text, out quantidade))
            {
                MessageBox.Show("O valor da quantidade é inválido. Insira um valor de moeda com virgula.", "Erro de validação");
                return;
            }

            decimal precoTotal;

            decimal precoProd;

            string connectionString = ConexaoBancoDados.conn_;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string queryPrecoUnitario = "SELECT PRECO FROM TB_PRODUTOS WHERE ID_PRODUTO = @IdProduto";

                using (NpgsqlCommand commandSelect = new NpgsqlCommand(queryPrecoUnitario, connection))
                {
                    commandSelect.Parameters.AddWithValue("@IdProduto", idProduto);

                    object result = commandSelect.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out precoProd))
                    {
                        // Faz o calculo do valor total do produto de acordo com a quantidade

                        precoTotal = precoProd * quantidade;

                        // Ira mostrar o preco na tela

                        txtPrecoTotal.Text = precoTotal.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar o preço do produto.", "Erro");
                        txtPrecoTotal.Text = "0.00";
                        return;
                    }

                }
            }
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            MostrarPrecoTotal();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtQtd.Text) || cbxProduto.SelectedIndex == 0 || cbxCliente.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "CAMPOS NÃO PREENCHIDOS!");
                return;
            }

            int idCliente = (int)cbxCliente.SelectedValue;

            int idProduto = (int)cbxProduto.SelectedValue;

            decimal quantidade = decimal.Parse(txtQtd.Text);

            decimal precoTotal = decimal.Parse(txtPrecoTotal.Text);

            decimal qtyAtualizadaEstoque;

            string connectionString = ConexaoBancoDados.conn_;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    string queryInsert = "INSERT INTO TB_VENDAS (ID_CLIENTE, ID_PRODUTO, QTY_ITEM, PRECO_TOTAL) " +
                                           "VALUES (@IdCliente, @IdProduto, @Qty, @precoTotal)";

                    using (NpgsqlCommand commandInsert = new NpgsqlCommand(queryInsert, connection, transaction))
                    {
                        try
                        {
                            commandInsert.Parameters.AddWithValue("@IdCliente", idCliente);
                            commandInsert.Parameters.AddWithValue("@IdProduto", idProduto);
                            commandInsert.Parameters.AddWithValue("@Qty", quantidade);
                            commandInsert.Parameters.AddWithValue("@precoTotal", precoTotal);

                            commandInsert.ExecuteNonQuery();

                            string queryQtyEstoque = "SELECT ESTOQUE FROM TB_PRODUTOS WHERE ID_PRODUTO = @IdProduto";

                            using (NpgsqlCommand commandSelect = new NpgsqlCommand(queryQtyEstoque, connection))
                            {
                                commandSelect.Parameters.AddWithValue("@IdProduto", idProduto);

                                decimal qtyEstoque = (decimal)commandSelect.ExecuteScalar();

                                qtyAtualizadaEstoque = qtyEstoque - quantidade;

                                string updateEstoque = "UPDATE TB_PRODUTOS SET ESTOQUE = @Estoque WHERE ID_PRODUTO = @IdProduto";

                                using (NpgsqlCommand commandUpdate = new NpgsqlCommand(updateEstoque, connection))
                                {
                                    commandUpdate.Parameters.AddWithValue("@IdProduto", idProduto);
                                    commandUpdate.Parameters.AddWithValue("@Estoque", qtyAtualizadaEstoque);

                                    commandUpdate.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageBox.Show("Os dados foram salvos com sucesso!");
                                LimparCampos();
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Erro ao registrar compra: {ex.Message}", "Erro");
                        }

                    }
                }
            }
        }

        private void LimparCampos()
        {
            txtQtd.Text = "";
            txtPrecoTotal.Text = "";
        }

        private void btnFecharVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMDCleriston.ConexaoBD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TesteMDCleriston.Forms
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            string connectionString = ConexaoBancoDados.conn_;

            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text) || string.IsNullOrWhiteSpace(txtQtdEstoque.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "CAMPOS NÃO PREENCHIDOS!");
                    return;
                }

                string nomeProd = txtNome.Text;
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

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        string queryInsert = "INSERT INTO TB_PRODUTOS (NOME_PROD, DESCRICAO, PRECO, ESTOQUE) " +
                                                 "VALUES (@NomeProd, @Descricao, @Preco, @Estoque)";

                        using (NpgsqlCommand commandInsert = new NpgsqlCommand(queryInsert, connection, transaction))
                        {
                            try
                            {
                                commandInsert.Parameters.AddWithValue("@NomeProd", nomeProd);
                                commandInsert.Parameters.AddWithValue("@Descricao", descricao);
                                commandInsert.Parameters.AddWithValue("@Preco", preco);
                                commandInsert.Parameters.AddWithValue("@Estoque", qtdEstoque);

                                commandInsert.ExecuteNonQuery();
                                transaction.Commit();

                                string querySelect = "SELECT MAX(ID_PRODUTO) FROM TB_PRODUTOS";

                                using (NpgsqlCommand commandSelect = new NpgsqlCommand(querySelect, connection, transaction))
                                {
                                    int idGeradoProd = (int)commandSelect.ExecuteScalar();
                                    MessageBox.Show("Os dados foram salvos com sucesso!");

                                    txtCodProd.Text = idGeradoProd.ToString();
                                    LimparCampos();
                                }

                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"Erro ao inserir dados: {ex.Message}", "Erro");
                            }
                        }
                    }
                }

            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";

            txtNome.Focus();
        }

        private void btnFecharProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMDCleriston.ConexaoBD;

namespace TesteMDCleriston.Forms
{
    public partial class ExcluirDadosCliente : Form
    {
        public ExcluirDadosCliente()
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
            if (string.IsNullOrWhiteSpace(txtEmailConsulta.Text))
            {
                MessageBox.Show("Por favor informe o e-mail para atualizar os dados", "ATENÇÃO!!");
            }

            string connectionString = ConexaoBancoDados.conn_;

            string emailConsulta = txtEmailConsulta.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string queryCheckEmail = "SELECT COUNT(*) FROM TB_CLIENTE WHERE EMAIL = @Email";
                        using (NpgsqlCommand commandCheckEmail = new NpgsqlCommand(queryCheckEmail, connection))
                        {
                            commandCheckEmail.Parameters.AddWithValue("@Email", emailConsulta);
                            int emailCount = Convert.ToInt32(commandCheckEmail.ExecuteScalar());

                            if (emailCount == 1)
                            {
                                string queryCliente = "SELECT C.NOME, C.ENDERECO, C.TELEFONE, C.EMAIL FROM TB_CLIENTE C WHERE C.EMAIL = @Email ";

                                using (NpgsqlCommand command = new NpgsqlCommand(queryCliente, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Email", emailConsulta);
                                    using (NpgsqlDataReader reader = command.ExecuteReader())
                                    {

                                        if (reader.Read())
                                        {
                                            txtNome.Text = reader["NOME"].ToString();
                                            txtEnd.Text = reader["ENDERECO"].ToString();
                                            txtTelefone.Text = reader["TELEFONE"].ToString();
                                            txtEmailDel.Text = reader["EMAIL"].ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("O E-mail informado não existe no sistema!", "E-MAIL INEXISTENTE");
                                        }
                                    }
                                }

                                transaction.Commit();
                            }
                            else
                            {
                                MessageBox.Show("O E-mail informado não existe no sistema!", "E-MAIL INEXISTENTE");
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

            else if (string.IsNullOrWhiteSpace(txtEmailConsulta.Text))
            {
                MessageBox.Show("Por favor informe o Email para excluir o cliente", "ATENÇÃO!!");

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string emailConsulta = txtEmailConsulta.Text;

                    int IdCliente = 0;
                    string connectionString = ConexaoBancoDados.conn_;

                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        try
                        {
                            // Query para pegar o ID do cliente
                            string queryGetId = "SELECT ID_CLIENTE FROM TB_CLIENTE WHERE EMAIL = @Email";
                            using (NpgsqlCommand commandGetId = new NpgsqlCommand(queryGetId, connection))
                            {
                                commandGetId.Parameters.AddWithValue("@Email", emailConsulta);

                                object idResult = commandGetId.ExecuteScalar();

                                if (idResult != null)
                                {
                                    IdCliente = (int)idResult;
                                }
                                else
                                {
                                    MessageBox.Show("Cliente não encontrado!", "ERRO!!");
                                    return;
                                }
                            }

                            // Verifica se o cliente possui registros de vendas antes de iniciar a transação de exclusão
                            string queryVendas = "SELECT COUNT(*) FROM TB_VENDAS WHERE ID_CLIENTE = @IdCliente";
                            using (NpgsqlCommand commandVendasCliente = new NpgsqlCommand(queryVendas, connection))
                            {
                                commandVendasCliente.Parameters.AddWithValue("@IdCliente", IdCliente);

                                long registroVendas = (long)commandVendasCliente.ExecuteScalar();

                                if (registroVendas > 0)
                                {
                                    MessageBox.Show("Cliente não pode ser excluído pois existe o histórico de vendas associado!", "ERRO!");
                                    return;
                                }
                            }

                            // Inicia a transação para a exclusão do cliente caso não tenha registro
                            using (var transaction = connection.BeginTransaction())
                            {
                                string deleteQuery = "DELETE FROM TB_CLIENTE WHERE ID_CLIENTE = @IdCliente";
                                using (NpgsqlCommand commandDelete = new NpgsqlCommand(deleteQuery, connection, transaction))
                                {
                                    commandDelete.Parameters.AddWithValue("@IdCliente", IdCliente);
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
            txtEnd.Text = "";
            txtTelefone.Text = "";
            txtEmailDel.Text = "";
            txtEmailConsulta.Text = "";

            txtEmailConsulta.Focus();
        }

        private void btnFechar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
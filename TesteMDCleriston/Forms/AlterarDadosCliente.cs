using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMDCleriston.ConexaoBD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TesteMDCleriston.Forms
{
    public partial class AlterarDadosCliente : Form
    {
        public AlterarDadosCliente()
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
                                            txtEmailAlterar.Text = reader["EMAIL"].ToString();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEnd.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) || string.IsNullOrWhiteSpace(txtEmailAlterar.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "CAMPOS NÃO PREENCHIDOS!");
                return;
            }
            else
            {
                string nome = txtNome.Text;
                string endereco = txtEnd.Text;
                string telefone = txtTelefone.Text;
                string email = txtEmailAlterar.Text;
                string emailConsulta = txtEmailConsulta.Text;

                int IdCliente = 0;
                string connectionString = ConexaoBancoDados.conn_;

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Query para pegar o ID
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

                                string updateQuery = "UPDATE TB_CLIENTE SET NOME = @Nome, " +
                                                    "ENDERECO = @Endereco, " +
                                                    "TELEFONE = @Telefone, " +
                                                    "Email = @Email " +
                                                    "WHERE ID_CLIENTE = @IdCliente ";

                                using (NpgsqlCommand commandUpdate = new NpgsqlCommand(updateQuery, connection, transaction))
                                {
                                    commandUpdate.Parameters.AddWithValue("@Nome", nome);
                                    commandUpdate.Parameters.AddWithValue("@Endereco", endereco);
                                    commandUpdate.Parameters.AddWithValue("@Telefone", telefone);
                                    commandUpdate.Parameters.AddWithValue("@Email", email);
                                    commandUpdate.Parameters.AddWithValue("@IdCliente", IdCliente);

                                    commandUpdate.ExecuteNonQuery();
                                    transaction.Commit();
                                }

                                MessageBox.Show("Os dados foram atualizados com sucesso!");
                                LimparCampos();
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
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtTelefone.Text = "";
            txtEmailAlterar.Text = "";
            txtEmailConsulta.Text = "";

            txtEmailConsulta.Focus();
        }

        private void btnFechar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

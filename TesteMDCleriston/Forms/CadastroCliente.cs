using System;
using System.Windows.Forms;
using TesteMDCleriston.ConexaoBD;
using Npgsql;
using System.Data.SqlClient;
using System.Transactions;


namespace TesteMDCleriston.Forms
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string connectionString = ConexaoBancoDados.conn_;

            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEnd.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "CAMPOS NÃO PREENCHIDOS!");
                    return;
                }

                string nome = txtNome.Text;
                string endereco = txtEnd.Text;
                string telefone = txtTelefone.Text;
                string email = txtEmail.Text;

                if (!email.Contains("@"))
                {
                    MessageBox.Show("Por favor informe um email valido com o '@'.", "EMAIL INVÁLIDO");
                    return;
                }

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Verificar se o e-mail já existe no banco de dados
                            string queryCheckEmail = "SELECT COUNT(*) FROM TB_CLIENTE WHERE EMAIL = @Email";
                            using (NpgsqlCommand commandCheckEmail = new NpgsqlCommand(queryCheckEmail, connection))
                            {
                                commandCheckEmail.Parameters.AddWithValue("@Email", email);
                                int emailCount = Convert.ToInt32(commandCheckEmail.ExecuteScalar());

                                if (emailCount > 0)
                                {
                                    MessageBox.Show("O Email informado já está cadastrado no sistema.", "E-MAIL EXISTENTE!!");
                                    return;
                                }
                            }

                            // Inserir o novo cliente, pois o e-mail não foi encontrado
                            string queryInsert = "INSERT INTO TB_CLIENTE (NOME, ENDERECO, TELEFONE, EMAIL) " +
                                                 "VALUES (@Nome, @Endereco, @Telefone, @Email)";
                            using (NpgsqlCommand commandInsert = new NpgsqlCommand(queryInsert, connection, transaction))
                            {
                                commandInsert.Parameters.AddWithValue("@Nome", nome);
                                commandInsert.Parameters.AddWithValue("@Endereco", endereco);
                                commandInsert.Parameters.AddWithValue("@Telefone", telefone);
                                commandInsert.Parameters.AddWithValue("@Email", email);

                                commandInsert.ExecuteNonQuery();
                                transaction.Commit();
                            }

                            MessageBox.Show("Os dados foram salvos com sucesso!");
                            LimparCampos();
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

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";

            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

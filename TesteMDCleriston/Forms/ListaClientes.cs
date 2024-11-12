using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using TesteMDCleriston.ConexaoBD;

namespace TesteMDCleriston.Forms
{
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();

            CarregarTodosClientes();
        }

        private void PesquisarClientes(string email = null)
        {
            string connectionString = ConexaoBancoDados.conn_;

            string queryCheckClientes = "SELECT C.NOME, C.ENDERECO, C.TELEFONE, C.EMAIL " +
                                        "FROM TB_CLIENTE C WHERE 1=1";

            // Adiciona condições à consulta se os parâmetros forem fornecidos

            if (!string.IsNullOrEmpty(email))
            {
                queryCheckClientes += " AND EMAIL = @email";
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(queryCheckClientes, connection))
                    {
                        if (!string.IsNullOrEmpty(email))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@Email", email);
                        }

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro");
                }
            }
        }

        private void CarregarTodosClientes()
        {
            // Chama o método de pesquisa sem parâmetros para carregar todos os produtos
            PesquisarClientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                string email = txtEmail.Text;

                PesquisarClientes(email);
            }
        }
    }
}

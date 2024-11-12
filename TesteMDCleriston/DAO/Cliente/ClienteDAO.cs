using Npgsql;
using TesteMDCleriston.ConexaoBD;

namespace TesteMDCleriston.DAO.Cliente
{
    public class ClienteDAO
    {
        private readonly string connectionString = ConexaoBancoDados.conn_;

        // Chamada do metodo contrutor aqui
        public ClienteDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Cliente> ObterClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT ID_CLIENTE, NOME, ENDERECO, TELEFONE, EMAIL FROM TB_CLIENTE";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    connection.Open();
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idCliente = Convert.ToInt32(reader["ID_CLIENTE"]);
                            string nome = reader["NOME"].ToString();
                            string endereco = reader["ENDERECO"].ToString();
                            string telefone = reader["TELEFONE"].ToString();
                            string email = reader["EMAIL"].ToString();

                            Cliente cli = new Cliente(idCliente, nome, endereco, telefone, email);
                            clientes.Add(cli);
                        }
                    }
                }
            }

            return clientes;
        }
    }
}

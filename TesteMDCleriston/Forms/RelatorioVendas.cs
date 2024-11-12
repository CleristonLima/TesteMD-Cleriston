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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TesteMDCleriston.Forms
{
    public partial class RelatorioVendas : Form
    {
        public RelatorioVendas()
        {
            InitializeComponent();

            CarregarTodasVendas();
        }

        private void RelatorioVendasTotal()
        {
            string connectionString = ConexaoBancoDados.conn_;

            string queryCheckVendas = "SELECT C.NOME AS \"NOME DO CLIENTE\"," +
                                           "P.DESCRICAO AS \"PRODUTO\"," +
                                           "V.QTY_ITEM AS \"QUANTIDADE VENDIDA\"," +
                                           "P.PRECO AS \"PREÇO UNITARIO\"," +
                                           "V.PRECO_TOTAL AS \"PREÇO TOTAL\"" +
                                    "FROM TB_VENDAS V " +
                                    "INNER JOIN TB_CLIENTE C ON C.ID_CLIENTE = V.ID_CLIENTE " +
                                    "INNER JOIN TB_PRODUTOS P ON P.ID_PRODUTO = V.ID_PRODUTO " +
                                    "WHERE 1 = 1 " +
                                    "ORDER BY ID_VENDA ";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(queryCheckVendas, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewRelatorioVendas.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro");
                }
            }
        }

        private void CarregarTodasVendas()
        {
            // Chama o método de pesquisa sem parâmetros para carregar todos os produtos
            RelatorioVendasTotal();
        }

        private void dataGridViewRelatorioVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conexão com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
        }
    }
}

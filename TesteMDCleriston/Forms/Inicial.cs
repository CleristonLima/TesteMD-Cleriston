using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TesteMDCleriston
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void cadastrarNovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var cadastroCliente = new TesteMDCleriston.Forms.CadastroCliente();
                cadastroCliente.Show();

            }
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var listaDeClientes = new TesteMDCleriston.Forms.ListaClientes();
                listaDeClientes.Show();

            }
        }

        private void alterarDadosDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var alterarClientes = new TesteMDCleriston.Forms.AlterarDadosCliente();
                alterarClientes.Show();

            }
        }

        private void excluirCadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var excluirClientes = new TesteMDCleriston.Forms.ExcluirDadosCliente();
                excluirClientes.Show();

            }
        }

        private void cadastrarNovoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var cadastroProdutos = new TesteMDCleriston.Forms.CadastroProduto();
                cadastroProdutos.Show();

            }
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var listaDeProdutos = new TesteMDCleriston.Forms.ListaProdutos();
                listaDeProdutos.Show();

            }
        }

        private void alterarDadosDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var alterarProdutos = new TesteMDCleriston.Forms.AlterarDadosProduto();
                alterarProdutos.Show();

            }
        }

        private void excluirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var excluirProdutos = new TesteMDCleriston.Forms.ExcluirProduto();
                excluirProdutos.Show();

            }
        }

        private void registrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var registrarVenda = new TesteMDCleriston.Forms.RegistrarVenda();
                registrarVenda.Show();

            }
        }

        private void relat�rioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConexaoInternet.ConexaoInternet.VerificarConexao())
            {
                MessageBox.Show("Sem Conex�o com a internet!!", "SEM ACESSO A REDE!");
                return;
            }
            else
            {
                // Exibe o formul�rio de inicializa��o do sistema
                var relatorioVenda = new TesteMDCleriston.Forms.RelatorioVendas();
                relatorioVenda.Show();

            }
        }
    }
}
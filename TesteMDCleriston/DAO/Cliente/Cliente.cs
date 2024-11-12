using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMDCleriston.DAO.Cliente
{
    public class Cliente
    {
            public int IdCliente { get; set; }
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }

            public Cliente() { }

            public Cliente(int idCliente, string nome, string endereco, string telefone, string email)
            {
                IdCliente = idCliente;
                Nome = nome;
                Endereco = endereco;
                Telefone = telefone;
                Email = email;
            }
     }
}

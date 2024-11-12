using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMDCleriston.DAO.Produto
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProd { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Estoque { get; set; }

        public Produto() { }

        public Produto(int idProduto, string nomeProd, string descricao, decimal preco, decimal estoque)
        {
            IdProduto = idProduto;
            NomeProd = nomeProd;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
        }
    }
}

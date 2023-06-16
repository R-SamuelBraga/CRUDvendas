using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Produto
/// </summary>
/// 
namespace ExemploVendas.BLL
{
    public class Produto
    {
        private Int64 id;
        private string nome;
        private string descricao;
        private string quantidadeEstoque;
        private string unidadeMedida;
        private double precoUnitario;
        private string imgProduto;
        public long Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string QuantidadeEstoque { get => quantidadeEstoque; set => quantidadeEstoque = value; }
        public string UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }
        public string ImgProduto { get => imgProduto; set => imgProduto = value; }
        public Produto()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }


    }
}

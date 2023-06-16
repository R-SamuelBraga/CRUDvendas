using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ItemPedido
/// </summary>
/// 
namespace ExemploVendas.BLL
{
    public class ItemPedido
    {
        private Int64 produtoId;
        private Int64 pedidoId;
        private Int64 quantidadePedido;
        private double precoUnitario;

        public long ProdutoId { get => produtoId; set => produtoId = value; }
        public long PedidoId { get => pedidoId; set => pedidoId = value; }
        public long QuantidadePedido { get => quantidadePedido; set => quantidadePedido = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }
        public ItemPedido()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }


    }
}

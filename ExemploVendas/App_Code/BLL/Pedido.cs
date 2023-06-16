using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pedido
/// </summary>
/// 
namespace ExemploVendas.BLL
{
    public class Pedido
    {
        private Int64 id;
        private Int64 funcionarioId;
        private Int64 clienteId;
        private DateTime dataPedido;
        private double valorTotal;

        public long Id { get => id; set => id = value; }
        public long FuncionarioId { get => funcionarioId; set => funcionarioId = value; }
        public long ClienteId { get => clienteId; set => clienteId = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public Pedido()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }


    }
}

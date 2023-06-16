using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Cliente
/// </summary>
/// 
namespace ExemploVendas.BLL
{
    public class Cliente
    {
        private Int64 id;
        private string nome;
        private string cpf_cnpj;
        private string email;
        private string telefone;
        private string endereco;

        public long Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public Cliente()
        {


            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }


    }
}

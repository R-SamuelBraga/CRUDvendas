using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Funcoes
/// </summary>
/// 
namespace ExemploVendas.BLL
{
    public class Funcoes
    {
        private static string connString  = "Initial Catalog=BDVENDASTN;Data Source=T20017303068926\\SQLEXPRESS2019;user id=userBdVendasTN;password=senha;";
        public static string ConnString { get => connString; set => connString = value; }
        public Funcoes()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }


    }
}

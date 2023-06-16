using prjAdoNet.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Funcionario
/// </summary>
/// 
namespace ExemploVendas.BLL
{
    public class Funcionario
    {
        private static string connString = Funcoes.ConnString;
        private Int64 id;
        private string nome;
        private string cpf;
        private string email;
        private string cargo;
        private string salario;
        private DateTime dataAdmissao;

        public long Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Salario { get => salario; set => salario = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }

        // Inserir - Usando ADO.NET --> SQL tradicional
        public void Inserir()
        {
            string meuSQL = "INSERT INTO tbFuncionario(nome, cpf, email, cargo, salario) VALUES" + 
                "('" + nome.Trim() + "', '" + cpf.Trim() + "', '" + email.Trim() + "', '" + cargo.Trim() + "', '" + salario.Trim() + "')";
            SqlHelper.ExecuteDataSet(connString, CommandType.Text, meuSQL);

        }

        public void Alterar(long idFuncionario)
        {
            string meuSQL = "UPDATE tbFuncionario SET" +
                            "nome = '"+Nome.Trim()+"'," +
                            "cpf =  '"+Cpf.Trim()+"'," +
                            "email = '"+Email.Trim()+",'" +
                            "cargo = '"+Cargo.Trim()+"," +
                            "salario = '"+Salario.Trim()+"'," +
                            "dataAdmisso = '"+dataAdmissao+"," +
                            "WHERE id = '"+idFuncionario+"'";
            SqlHelper.ExecuteDataSet(connString, CommandType.Text, meuSQL);
        }

        public void Excluir(long idFuncionario)
        {
            string meuSql = "DElETE tbFuncionario WHERE id = '"+idFuncionario+"'";
            SqlHelper.ExecuteDataSet(connString, CommandType.Text, meuSql);
        }
        public static DataSet ListaTodosFuncionarios()
        {
            string meuSql = "SELECT * FROM tbFuncinario ";
            DataSet ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, meuSql);
            return ds;
        }
        public Funcionario()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }


    }
}

using ExemploVendas.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CVendedor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void cmdConfirmar_Click(object sender, EventArgs e)
    {
        AdicionarFuncionario();
    }
    private void AdicionarFuncionario()
    {
        Funcionario funcionario = new Funcionario();
        funcionario.Cpf = txtCPF.Text;
        funcionario.Nome = txtNomeVendedor.Text;
        funcionario.Email = txtEmail.Text;
        funcionario.Cargo = txtCargo.Text;
        funcionario.Salario= txtSalario.Text;

        if (cmdConfirmar.Text == "Incluir")
        {
            funcionario.Inserir();
        }
        else
        {
            funcionario.Alterar(1);
        }
    }

    protected void cmdExcluir_Click(object sender, EventArgs e)
    {

    }

    protected void cmdLimpar_Click(object sender, EventArgs e)
    {

    }

    protected void cmdSair_Click(object sender, EventArgs e)
    {

    }
}
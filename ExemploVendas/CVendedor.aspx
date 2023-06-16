<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.master" AutoEventWireup="true" CodeFile="CVendedor.aspx.cs" Inherits="CVendedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="card efeito_Panel_2">
        <div class="card-header bg-dark text-white">
            Cadastro de Vendedores
        </div>
        <div class="card-body">
            <div class="form-group">
                <div>
                    <asp:Label ID="lblCPF" runat="server" Text="CPF"></asp:Label>
                    <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblNome" runat="server" Text="Nome do Vendedor"></asp:Label>
                    <asp:TextBox ID="txtNomeVendedor" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div>
                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblCargo" runat="server" Text="Cargo"></asp:Label>
                    <asp:TextBox ID="txtCargo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblSalario" runat="server" Text="Salario"></asp:Label>
                    <asp:TextBox ID="txtSalario" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

            </div>
        </div>
        <div class="card-footer">
            <div class="form-group row">
                <div class="col-md-3">
                    <asp:Button ID="cmdConfirmar" CssClass="btn btn-info" Width="100%" runat="server" Text="Incluir" Font-Bold="True" OnClick="cmdConfirmar_Click" />
                </div>
                <div class="col-md-3">
                    <asp:Button ID="cmdExcluir" CssClass="btn btn-info" Width="100%" runat="server" Text="Excluir" Font-Bold="True" OnClick="cmdExcluir_Click" />
                </div>
                <div class="col-md-3">
                    <asp:Button ID="cmdLimpar" CssClass="btn btn-info" Width="100%" runat="server" Text="Limpar" Font-Bold="True" OnClick="cmdLimpar_Click" />
                </div>
                <div class="col-md-3">
                    <asp:Button ID="cmdSair" CssClass="btn btn-info" Width="100%" runat="server" Text="Sair" Font-Bold="True" OnClick="cmdSair_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>


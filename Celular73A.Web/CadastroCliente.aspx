<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="Celular73A.Web.CadastroCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <%@ Import Namespace="Celular73A.Model.Entidades" %> 
    
    <style type="text/css">
        
        .auto-style5 {
            height: 21px;
            width: 9px;
        }
        .auto-style7 {
            width: 9px;
        }
        table, th, td {
   border: 1px solid black;
}
        .auto-style8 {
            width: 14px;
        }
    </style>
        <div>
            <table width="90%">
                <tr>
                    Cadastro de Clientes
                </tr>
                <tr>
                    <td class="auto-style7">
                        <strong>Nome:</strong></td>
                    <td class="auto-style8">
                        <asp:textbox runat="server" name="txtNome" id="txtNome"></asp:textbox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <strong>Email:</strong></td>
                    <td class="auto-style8">
                      <asp:textbox runat="server" name="txtEmail" id="txtEmail" Width="219px"></asp:textbox>                       
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <strong>Senha:</strong></td>
                    <td class="auto-style8">
                      <asp:textbox runat="server" name="txtSenha" id="txtSenha" Width="219px"></asp:textbox>                       
                    </td>
                </tr>
               
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">
                        <asp:button id="btnComprar" runat="server" text="Comprar"
                            onclick="btnComprar_Click" />
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>

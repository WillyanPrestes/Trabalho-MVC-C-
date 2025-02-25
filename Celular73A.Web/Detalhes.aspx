<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Celular73A.Web.Detalhes" %>
<%@ Import Namespace="Celular73A.Model.Entidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

        <table width="90%">
            <tr>
                <td style="width: 91px; height: 20px">
                    <strong>Fabricante:</strong></td>
                <td style="width: 155px; height: 20px">
                    <%=aparelho.Fabricante.Nome %></td>
            </tr>
            <tr>
                <td style="width: 91px; height: 20px">
                    <strong>Clientes:</strong></td>
                <td style="width: 155px; height: 20px">
                    <asp:DropDownList ID="cmbClientes" runat="server"></asp:DropDownList>
            </tr>
            <tr>
                <td style="width: 91px">
                    <strong>Modelo:</strong></td>
                <td style="width: 155px">
                    <%=aparelho.Modelo %></td>
            </tr>
            <tr>
                <td style="width: 91px; height: 21px">
                    <strong>Dimensões:</strong></td>
                <td style="width: 155px; height: 21px">
                    <%=aparelho.Largura + "x" +aparelho.Altura + "x" +aparelho.Espessura %>&nbsp;cm</td>
            </tr>
            <tr>
                <td style="width: 91px">
                    <strong>Peso:</strong></td>
                <td style="width: 155px">
                    <%=aparelho.Peso %>&nbsp;g</td>
            </tr>
            <tr>
                <td style="width: 91px">
                    <strong>Quantidade:</strong></td>
                <td style="width: 155px">
                    <%=aparelho.Quantidade %>&nbsp;em estoque</td>
            </tr>
            <tr>
                <td style="width: 91px">
                    <strong>Preço (R$):</strong></td>
                <td style="width: 155px">
                    <%=aparelho.Preco %></td>
            </tr>
            <tr>
                <td style="width: 91px">
                    <strong>Desconto:</strong></td>
                <td style="width: 155px">
                    <%=aparelho.Desconto %>&nbsp;à vista</td>
            </tr>
            <tr>
                <td style="width: 91px"></td>
                <td style="width: 155px">
                    <asp:Button ID="btnComprar" runat="server"
                        Text="Comprar" OnClick="btnComprar_Click" /></td>
            </tr>
        </table>
    </div>


</asp:Content>

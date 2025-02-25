<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Celular73A.Web._Default" %>
<%@ Import Namespace="Celular73A.Model.Entidades" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       <table width="70%">
        <% foreach(Aparelho a in lstAparelho) { %>
            <tr>
                <td style="width:260px">
                    <img src="Imagens/ImagemCelular.jpeg" />                    
                </td>
                <td align="left" style="font-size:0.75em;line-height:1.4em;">
                    <b><%=a.Fabricante.Nome + " " + a.Modelo %></b><br />
                    R$ <%=a.Preco %><br />
                    <i><%=a.Quantidade %> em estoque</i><br />
                    <a href="detalhes.aspx?aparelho=<%=a.Id_Aparelho %>">
                    Mais detalhes</a>
                </td>
            </tr>
        <% } %>
        </table>
     </div>

</asp:Content>

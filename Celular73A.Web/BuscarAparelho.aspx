<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarAparelho.aspx.cs" Inherits="Celular73A.Web.BuscarAparelho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%@ Import Namespace="Celular73A.Model.Entidades" %> 
    
    <style type="text/css">
        
        table, th, td {
   border: 1px solid black;
}
    </style>
        <div>
             &nbsp;
                   <h2> &nbsp; &nbsp;Buscar Aparelho por modelo</h2>
            <br />
                   &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label runat="server" Font-Size="X-Large" >|?|</asp:Label>
                        <asp:textbox runat="server" name="txtPesquisa" id="txtPesquisa" Width="162px"></asp:textbox>                     
                
                    <asp:Label runat="server" ID="Label1" Font-Size="X-Large" >|?|</asp:Label>
             
                    <br /><br />
                          &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:button id="btnComprar" runat="server" text="Buscar" onclick="btnComprar_Click" />
                    <br />    <br />
            <hr />
            <table width="70%">
       
            <tr>
                <td style="width:260px">
                    <img src="Imagens/ImagemCelular.jpeg" />                    
                </td>
                <td align="left" style="font-size:0.75em;line-height:1.4em;">
                    <b><asp:label runat="server" name="txtDesconto" id="txtFabricanteNome" Width="50px"></asp:label>&nbsp;&nbsp;&nbsp;
                        <asp:label runat="server" name="txtDesconto" id="txtModelo" Width="70px"></asp:label>
                    </b><br />
                    <b>R$ <asp:label runat="server" name="txtDesconto" id="txtPreco" Width="100px"></asp:label></b><br />
                    <i><asp:label runat="server" name="txtDesconto" id="txtQuantidade" Width="20px"></asp:label> em estoque</i><br />
                    
                </td>
            </tr>
       
        </table>
        
        </div>
</asp:Content>

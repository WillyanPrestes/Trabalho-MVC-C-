<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarAparelho.aspx.cs" Inherits="Celular73A.Web.CadastrarAparelho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%@ Import Namespace="Celular73A.Model.Entidades" %> 
    
    <style type="text/css">
        
        .auto-style2 {
            width: 155px;
            height: 60px;
        }
        .auto-style3 {
            height: 20px;
            width: 9px;
        }
        .auto-style5 {
            height: 21px;
            width: 9px;
        }
        .auto-style6 {
            width: 9px;
            height: 60px;
        }
        .auto-style7 {
            width: 9px;
        }
        table, th, td {
   border: 1px solid black;
}
    </style>
        <div>
            <table width="90%">
                <tr>
                    <td class="auto-style3">
                        <strong>Fabricante:</strong></td>
                    <td style="width: 155px; height: 20px">
            
                        <asp:DropDownList ID="cmbFabricantes" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <strong>Modelo:</strong></td>
                    <td style="width: 155px">
                        <asp:textbox runat="server" name="txtModelo" id="txtModelo"></asp:textbox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <strong>Dimensões:</strong></td>
                    <td style="width: 155px; height: 21px">
                       Largura:(cm)<asp:textbox runat="server" name="txtLargura" id="txtLargura"></asp:textbox>
                      <br /> Altura:(cm)<asp:textbox runat="server" name="txtAltura" id="txtAltura"></asp:textbox>
                        <br /> Espessura:(cm)<asp:textbox runat="server" name="txtEspessura" id="txtEspessura" Width="124px"></asp:textbox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <strong>Peso:</strong></td>
                    <td class="auto-style2">
                        <asp:textbox runat="server" name="txtPeso" id="txtPeso"></asp:textbox>&nbsp;g</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <strong>Quantidade:</strong></td>
                    <td style="width: 170px">
                       <asp:textbox runat="server" name="txtQuantidade" id="txtQuantidade" Width="118px"></asp:textbox>estoque</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <strong>Preço (R$):</strong></td>
                    <td style="width: 155px">
                          <asp:textbox runat="server" name="txtPreco" id="txtPreco" Width="118px"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <strong>Desconto:</strong></td>
                    <td style="width: 155px">
                       <asp:textbox runat="server" name="txtDesconto" id="txtDesconto" Width="113px"></asp:textbox>&nbsp;à vista</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td style="width: 155px">
                        <asp:button id="btnComprar" runat="server" text="Comprar"
                            onclick="btnComprar_Click" />
                    </td>
                </tr>
            </table>
        </div>

</asp:Content>

<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="NovoAparelho.aspx.cs" Inherits="Celular73A.Web.NovoAparelho" %>

<%@ Import Namespace="Celular73A.Model.Entidades" %>
<head>
    <style type="text/css">
        .auto-style1 {
            width: 91px;
            height: 24px;
        }
        .auto-style2 {
            width: 155px;
            height: 24px;
        }
    </style>
</head>
<form id="form1" runat="server">
<table width="90%">
    <tr>
        <td style="width: 91px; height: 20px">
            <strong>Fabricante:</strong></td>
        <td style="width: 155px; height: 20px">
            
            <asp:DropDownList ID="cmbFabricantes" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 91px">
            <strong>Modelo:</strong></td>
        <td style="width: 155px">
            <asp:textbox runat="server" name="txtModelo" id="txtModelo"></asp:textbox>
            </td>
    </tr>
    <tr>
        <td style="width: 91px; height: 21px">
            <strong>Dimensões:</strong></td>
        <td style="width: 155px; height: 21px">
           Largura:(cm)<asp:textbox runat="server" name="txtLargura" id="txtLargura"></asp:textbox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Altura:(cm)<asp:textbox runat="server" name="txtAltura" id="txtAltura"></asp:textbox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Espessura:(cm)<asp:textbox runat="server" name="txtEspessura" id="txtEspessura" Width="124px"></asp:textbox>
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <strong>Peso:</strong></td>
        <td class="auto-style2">
            <asp:textbox runat="server" name="txtPeso" id="txtPeso"></asp:textbox>&nbsp;g</td>
    </tr>
    <tr>
        <td style="width: 91px">
            <strong>Quantidade:</strong></td>
        <td style="width: 170px">
           <asp:textbox runat="server" name="txtQuantidade" id="txtQuantidade" Width="118px"></asp:textbox>estoque</td>
    </tr>
    <tr>
        <td style="width: 91px">
            <strong>Preço (R$):</strong></td>
        <td style="width: 155px">
              <asp:textbox runat="server" name="txtPreco" id="txtPreco" Width="118px"></asp:textbox></td>
    </tr>
    <tr>
        <td style="width: 91px">
            <strong>Desconto:</strong></td>
        <td style="width: 155px">
           <asp:textbox runat="server" name="txtDesconto" id="txtDesconto" Width="113px"></asp:textbox>&nbsp;à vista</td>
    </tr>
    <tr>
        <td style="width: 91px"></td>
        <td style="width: 155px">
            <asp:button id="btnComprar" runat="server" text="Comprar"
                onclick="btnComprar_Click" />
        </td>
    </tr>
</table>
</form>


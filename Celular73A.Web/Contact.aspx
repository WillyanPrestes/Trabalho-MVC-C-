<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Celular73A.Web.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        CTi Unesp - Av. Nações Unidas, 58-50<br />
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100&nbsp;&nbsp;&nbsp;&nbsp; Nome do Aluno:
        <asp:TextBox ID="TextBox1" runat="server" Width="204px"></asp:TextBox>
    </address>
    <address>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="96px" />
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>

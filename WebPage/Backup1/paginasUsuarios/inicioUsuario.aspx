<%@ Page Language="C#" MasterPageFile="~/usuarios.Master" AutoEventWireup="true" CodeBehind="inicioUsuario.aspx.cs" Inherits="WebApplication1.paginasUsuarios.inicioUsuario" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        PÁGINA DE INICIO D<asp:Label ID="lblTitulo" runat="server" BackColor="Yellow" 
            Font-Size="XX-Large" Text="TIENDA DE REPUESTOS"></asp:Label>
        E PERSONAL</p>
<p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:Label ID="Label2" runat="server" BackColor="Yellow" Font-Size="X-Large" 
            Text="Página de inicio para usuarios."></asp:Label>
    </p>
</asp:Content>

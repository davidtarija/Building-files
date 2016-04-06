<%@ Page Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="eliminarUsuario.aspx.cs" Inherits="WebApplication1.paginasAdmin.eliminarUsuario" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Label ID="Label2" runat="server" BackColor="Yellow" Font-Size="Large">No. 
        CARNET DE IDENTIDAD</asp:Label>
    <br />
</p>
<p style="margin-left: 120px">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ListBox ID="lstUsuarios" runat="server" Height="273px" 
        onselectedindexchanged="lstUsuarios_SelectedIndexChanged" Width="223px">
    </asp:ListBox>
</p>
<p style="margin-left: 120px">
    <asp:Label ID="Label1" runat="server" BackColor="Yellow" Font-Size="Large"></asp:Label>
</p>
<p style="margin-left: 120px">
    <asp:Button ID="btnEliminar" runat="server" onclick="btnEliminar_Click" 
        Text="Eliminar" Width="195px" />
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>

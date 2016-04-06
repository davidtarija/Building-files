<%@ Page Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="nuevoUsuario.aspx.cs" Inherits="WebApplication1.paginasAdmin.nuevoUsuario" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
<p style="margin-left: 160px">
        <asp:Label ID="Label10" runat="server" BackColor="Yellow"></asp:Label>
    <br />
</p>
<p style="margin-left: 40px">
    <asp:Label ID="Label1" runat="server" Text="CI" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCi" runat="server"></asp:TextBox>
</p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label2" runat="server" Text="NOMBRES" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
</p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label3" runat="server" Text="AP. PATERNO" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPaterno" runat="server"></asp:TextBox>
</p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label4" runat="server" Text="AP. MATERNO" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMaterno" runat="server"></asp:TextBox>
</p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label5" runat="server" Text="FECHA NAC." BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="dtmFechaNac" runat="server" BackColor="Yellow"></asp:Calendar>
</p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label6" runat="server" Text="TELÉFONO" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
</p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label7" runat="server" Text="DIRECCIÓN" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
</p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label8" runat="server" Text="USUARIO" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
</p>
<p style="margin-left: 40px">
        <asp:Label ID="Label9" runat="server" Text="CONTRASEÑA" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
</p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label11" runat="server" Text="TIPO" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="131px">
            <asp:ListItem>administrador</asp:ListItem>
            <asp:ListItem>usuario</asp:ListItem>
            <asp:ListItem>público</asp:ListItem>
        </asp:DropDownList>
</p>
    <p style="margin-left: 160px">
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" Width="204px" 
            onclick="btnInsertar_Click" />
</p>
</asp:Content>

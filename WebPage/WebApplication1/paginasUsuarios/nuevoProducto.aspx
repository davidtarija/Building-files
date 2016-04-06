<%@ Page Language="C#" MasterPageFile="~/usuarios.Master" AutoEventWireup="true" CodeBehind="nuevoProducto.aspx.cs" Inherits="WebApplication.Escuela.Presentation.paginasUsuarios.nuevoProducto" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Label ID="Label2" runat="server" BackColor="Yellow">CODIGO PRODUCTO</asp:Label>
    <br />
</p>
<p>
    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtCodigo" ErrorMessage="Ingrese un código"></asp:RequiredFieldValidator>
</p>
    <p>
    <asp:Label ID="Label3" runat="server" BackColor="#FFCC00">DESCRIPCION DEL PRODUCTO</asp:Label>
</p>
<p>
    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtDescripcion" ErrorMessage="Ingrese una descripción"></asp:RequiredFieldValidator>
</p>
    <p>
    <asp:Label ID="Label4" runat="server" BackColor="Yellow">MARCA</asp:Label>
</p>
<p>
    <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="txtMarca" ErrorMessage="Ingrese marca"></asp:RequiredFieldValidator>
</p>
    <p>
    <asp:Label ID="Label5" runat="server" BackColor="Yellow">INDUSTRIA</asp:Label>
</p>
<p>
    <asp:TextBox ID="txtIndustria" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="txtIndustria" ErrorMessage="Ingrese industria"></asp:RequiredFieldValidator>
</p>
    <p>
    <asp:Label ID="Label6" runat="server" BackColor="Yellow">PRECIO</asp:Label>
</p>
<p>
    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label7" runat="server" BackColor="Yellow">IMAGEN</asp:Label>
</p>
<p>
    <asp:FileUpload ID="fileUpImag" runat="server" Width="235px" />
</p>
<p>
    <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
        Text="Agregar" Width="188px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" BackColor="Yellow"></asp:Label>
</p>
</asp:Content>

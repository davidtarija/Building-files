<%@ Page Language="C#" MasterPageFile="~/usuarios.Master" AutoEventWireup="true" CodeBehind="modificarProducto.aspx.cs" Inherits="WebApplication.Escuela.Presentation.paginasUsuarios.modificarProducto" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstProductos" runat="server" Height="213px" 
            onselectedindexchanged="lstProductos_SelectedIndexChanged" Width="230px" 
            AutoPostBack="True">
        </asp:ListBox>
    </p>
<p>
        <br />
    <asp:Label ID="Label7" runat="server" BackColor="Yellow">CODIGO DEL PRODUCTO</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtCodigo" ErrorMessage="Ingrese un código"></asp:RequiredFieldValidator>
    </p>
    <p>
    <asp:Label ID="Label3" runat="server" BackColor="Yellow">DESCRIPCION DEL PRODUCTO</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtDescripcion" ErrorMessage="Ingrese una descripción"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="Label4" runat="server" BackColor="Yellow">MARCA</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="txtMarca" ErrorMessage="Ingrese marca"></asp:RequiredFieldValidator>
</p>
    <p>
    <asp:Label ID="Label5" runat="server" BackColor="Yellow">INDUSTRIA</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtIndustria" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="txtIndustria" ErrorMessage="Ingrese industria"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="Label6" runat="server" BackColor="Yellow">PRECIO</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="txtPrecio" ErrorMessage="Ingrese precio" 
        ValidationExpression="\d{3}"></asp:RegularExpressionValidator>
</p>
<p>
    <asp:Label ID="Label8" runat="server" BackColor="Yellow">IMAGEN</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image1" runat="server" Height="140px" Width="128px" />
&nbsp;
    <asp:TextBox ID="txtUrl" runat="server" Visible="False"></asp:TextBox>
</p>
<p style="margin-left: 120px">
    <asp:Button ID="btnModificar" runat="server" onclick="btnModificar_Click" 
        Text="Modificar" Width="188px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" BackColor="Yellow"></asp:Label>
</p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="listaVentas.aspx.cs" Inherits="WebApplication1.paginasAdmin.listaVentas" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style3
    {
        width: 88px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <table style="width:100%;">
        <tr>
            <td rowspan="2">
                <asp:RadioButtonList ID="rdoOpciones" runat="server" BackColor="Yellow">
                    <asp:ListItem> Por Código de Venta</asp:ListItem>
                    <asp:ListItem> Por Monto</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:DropDownList ID="cmbCodigo" runat="server" Height="16px" Width="299px">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtMonto" runat="server" Width="210px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnListar" runat="server" onclick="btnListar_Click" 
                    Text="Listar" Width="209px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</p>
<p>
    <table style="width:100%;">
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Size="X-Large" 
                    Text="LISTADO DE VENTAS" BackColor="Yellow"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:GridView ID="grdVentas" runat="server" BackColor="Yellow" Height="132px" 
                    Width="464px">
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server" BackColor="Yellow"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
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

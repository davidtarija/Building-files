<%@ Page Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="modificarUsuario.aspx.cs" Inherits="WebApplication.Escuela.Presentation.paginasAdmin.modificarUsuario" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 197px;
        }
        .style4
        {
            width: 247px;
        }
        .style5
        {
            width: 253px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style3">
        <asp:Label ID="Label11" runat="server" Font-Size="XX-Large" 
            Text="LISTA DE USUARIOS" BackColor="Yellow"></asp:Label>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
                
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:ListBox ID="lstUsuarios" runat="server" Height="257px" Width="172px" 
            onselectedindexchanged="lstUsuarios_SelectedIndexChanged" 
            AutoPostBack="True">
        </asp:ListBox>
            </td>
            <td class="style4">
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFechaNac" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;</p>
    <p style="margin-left: 40px">
        <asp:Calendar ID="dtmFechaNac" runat="server" BackColor="White" 
            BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
            Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
            Width="200px">
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <WeekendDayStyle BackColor="#FFFFCC" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
        </asp:Calendar>
</p>
            </td>
            <td class="style5">
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
        <asp:Label ID="Label12" runat="server" Text="TIPO" BackColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="158px">
            <asp:ListItem>administrador</asp:ListItem>
            <asp:ListItem>público</asp:ListItem>
            <asp:ListItem>usuario</asp:ListItem>
        </asp:DropDownList>
</p>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
        <asp:Label ID="Label10" runat="server" BackColor="Yellow"></asp:Label>
            </td>
            <td class="style5">
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" Width="204px" 
            onclick="btnModificar_Click" />
            </td>
                
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style5">
                &nbsp;</td>
                
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="style3">&nbsp;</td>
            <td class="style4">&nbsp;</td>
            <td class="style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/publico.Master" AutoEventWireup="true" CodeBehind="registrarVenta.aspx.cs" Inherits="WebApplication.Escuela.Presentation.paginasPublico.registrarVenta" Title="Untitled Page" %>

<script runat="server">

    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            width: 439px;
        }
        .style5
        {
            width: 124px;
        }
        .style6
        {
            width: 235px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table style="width: 100%; height: 191px;">
            <tr>
                <td>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblTitulo" runat="server" BackColor="Yellow" 
                        Font-Size="XX-Large" Text="TIENDA DE REPUESTOS"></asp:Label>
                    <br />
                                                        </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <table style="width: 100%; height: 630px;">
                        <tr>
                            <td class="style4">
                    <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" 
                        RepeatColumns="3" RepeatDirection="Horizontal" 
                        onitemcommand="DataList1_ItemCommand" Width="478px">
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <AlternatingItemStyle BackColor="White" />
                        <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <ItemTemplate>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Image ID="Prod" runat="server" Height="80px" 
                                ImageUrl='<%# Eval("imagen") %>' Width="104px" />
                            <br />
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblIdRepuesto" runat="server" Text='<%# Eval("id_repuesto") %>' 
                                            Visible="False"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label3" runat="server" Font-Size="Smaller" Text="CÓDIGO"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblCodigo" runat="server" Text='<%# Eval("codigo") %>'></asp:Label>
                                        <br />
                                        <asp:Label ID="Label1" runat="server" Font-Size="Smaller" Text="DESCRIPCION"></asp:Label>
                                        &nbsp;<asp:Label ID="lblNombre" runat="server" 
                                            Text='<%# Eval("descripcion") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Font-Size="Smaller" Text="PRECIO"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Label ID="lblPrecio" runat="server" Text='<%# Eval("precio") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                                Text="Comprar"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:DataList>
                            </td>
                            <td>
                                <table style="width: 100%; height: 323px;">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" BackColor="Yellow" Text="CÓDIGO"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:TextBox ID="txtCódigo" runat="server" Width="212px"></asp:TextBox>
&nbsp;
                                            <br />
                                            <br />
                                            <asp:Label ID="Label4" runat="server" BackColor="Yellow" Text="DESCRIPCION"></asp:Label>
&nbsp;&nbsp;&nbsp;
                                            <asp:TextBox ID="txtDescripcion" runat="server" Width="337px"></asp:TextBox>
                                            <br />
                                            <br />
                                            <asp:Label ID="Label5" runat="server" BackColor="Yellow" Text="PRECIO"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                                            <br />
                                            <br />
                                            <asp:Label ID="Label6" runat="server" BackColor="Yellow" Text="CANTIDAD"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                                            <br />
                                            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
                                                Text="Agregar" Width="134px" />
                                            <asp:TextBox ID="txtIdRepuesto" runat="server" 
                                                ontextchanged="txtIdRepuesto_TextChanged" style="margin-left: 0px" 
                                                Visible="False" Width="68px"></asp:TextBox>
                                            <asp:Label ID="Label7" runat="server" BackColor="Yellow"></asp:Label>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:GridView ID="grdDetalleVenta" runat="server" AutoGenerateColumns="False" 
                                                AutoGenerateDeleteButton="True" BackColor="Yellow" 
                                                onrowdeleting="grdDetalleVenta_RowDeleting" Width="541px">
                                                <Columns>
                                                    <asp:BoundField DataField="id_repuesto" HeaderText="ID" />
                                                    <asp:BoundField DataField="codigo" HeaderText="CÓDIGO" />
                                                    <asp:BoundField DataField="descripcion" HeaderText="DESCRIPCION" />
                                                    <asp:BoundField DataField="precio" HeaderText="PRECIO" />
                                                    <asp:BoundField DataField="cantidad" HeaderText="CANTIDAD" />
                                                    <asp:BoundField DataField="subtotal" HeaderText="SUBTOTAL" />
                                                </Columns>
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                                <br />
                                <br />
                                <asp:TextBox ID="txtTotal" runat="server" Font-Size="X-Large"></asp:TextBox>
                                <br />
                                <br />
                                <table style="width:100%;">
                                    <tr>
                                        <td class="style5">
                                            &nbsp;</td>
                                        <td bgcolor="Yellow" class="style6">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FECHA DE LA VENTA</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style5">
                                            &nbsp;</td>
                                        <td class="style6">
                                            <asp:Calendar ID="dtmFecha" runat="server" BackColor="Yellow" 
                                                NextPrevFormat="ShortMonth" ShowGridLines="True"></asp:Calendar>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                                <br />
                                <br />
                                <asp:Button ID="btnComprar" runat="server" onclick="btnComprar_Click" 
                                    Text="Comprar" Width="134px" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <br />
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

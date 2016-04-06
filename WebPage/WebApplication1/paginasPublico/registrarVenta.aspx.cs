using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using ClasesDAL;

namespace WebApplication.Escuela.Presentation.paginasPublico
{
    public partial class registrarVenta : System.Web.UI.Page
    {
        proyectoTableAdapters.repuesto rep = new WebApplication.Escuela.Presentation.proyectoTableAdapters.repuesto();
        proyectoTableAdapters.tablaObjetoTableAdapter obj = new WebApplication.Escuela.Presentation.proyectoTableAdapters.tablaObjetoTableAdapter();
        proyectoTableAdapters.ventaTableAdapter venta = new WebApplication.Escuela.Presentation.proyectoTableAdapters.ventaTableAdapter();
        proyectoTableAdapters.detalleventaTableAdapter detalleventa = new WebApplication.Escuela.Presentation.proyectoTableAdapters.detalleventaTableAdapter();
        proyectoTableAdapters.usuarioTableAdapter usuar = new WebApplication.Escuela.Presentation.proyectoTableAdapters.usuarioTableAdapter();
        
        decimal montoX = 0; int k = 0; decimal precioX=0;
        objetoDAL objDAL = new objetoDAL();
        List<objetoDAL> listaDetalles = new List<objetoDAL>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //grdDetalleVenta.DataSource = listaDetalles;
                Session["lista"] = listaDetalles;
                txtTotal.Text = "0";
                Session["suma"] = txtTotal;
                ActualizarDatos();
            }
        }
        private void ActualizarDatos()
        {
            DataList1.DataSource = rep.selectTodosRep();
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            DataListItem item = (DataListItem)e.Item;
            txtIdRepuesto.Text = ((Label)item.FindControl("lblIdRepuesto")).Text;
            txtCódigo.Text = ((Label)item.FindControl("lblCodigo")).Text;
            txtDescripcion.Text =  ((Label)item.FindControl("lblNombre")).Text;
            txtPrecio.Text = ((Label)item.FindControl("lblPrecio")).Text;
            //precioX = Convert.ToDecimal(((Label)item.FindControl("lblPrecio")).Text);
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox t = (TextBox)Session["suma"];
                listaDetalles = (List<objetoDAL>)Session["lista"];
                decimal subtot1 = Convert.ToDecimal(txtCantidad.Text);
                decimal subtot2 = Convert.ToDecimal(txtPrecio.Text);
                decimal subtotal = subtot1 * subtot2;
                //txtTotal.Text = subtotal.ToString();
                decimal suma = Convert.ToDecimal(t.Text) + subtotal;
                txtTotal.Text = suma.ToString();
                Session["suma"] = txtTotal;

                txtTotal.Text = suma.ToString();

                objDAL.ID_REPUESTO = Convert.ToInt32(txtIdRepuesto.Text);
                objDAL.CODIGO = txtCódigo.Text;
                objDAL.DESCRIPCION = txtDescripcion.Text;
                objDAL.PRECIO = Convert.ToDecimal(txtPrecio.Text);
                objDAL.CANTIDAD = Convert.ToInt32(txtCantidad.Text);
                objDAL.SUBTOTAL = Convert.ToDecimal(subtotal.ToString());
                obj.insertarObjeto(Convert.ToInt32(txtIdRepuesto.Text), txtCódigo.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text), subtotal);

                listaDetalles.Add(objDAL);
                grdDetalleVenta.DataSource = listaDetalles;
                grdDetalleVenta.DataBind();
                Session["lista"] = listaDetalles;

                txtDescripcion.Text = ""; txtCantidad.Text = ""; txtPrecio.Text = "";
                txtCódigo.Text = "";
            }
            catch
            {
                Label7.Text = "INGRESE LA CANTIDAD";
            }
            //for (int i = k; i < grdDetalleVenta.Rows.Count; i++)
            //{
                //int g = Convert.ToInt32(grdDetalleVenta.Rows[i].Cells[0].ToString());
                //int g = ((GridView)item.FindControl("grdDetalleVenta".Inde)).Text;
                //decimal suma = Convert.ToDecimal(grdDetalleVenta.Rows[i].Cells[5].ToString());
                //montoX = montoX + suma;
            //}
            //decimal suma = subtotal;
            //montoX = Convert.ToDecimal(t);
            //montoX = montoX + suma;
            k = grdDetalleVenta.Rows.Count;
            //txtTotal.Text = montoX.ToString(); 
        //SALIR:
            //if (Global.seleccionRepuestoVenta == false)
                //MessageBox.Show("Para insertar seleccione un ítem de la lista");
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                int c = 0;
                listaDetalles = (List<objetoDAL>)Session["lista"];
                DataTable data = (DataTable)Session["usu"];
                DataTable dataper = (DataTable)Session["per"];
                string ci = dataper.Rows[0]["ci"].ToString();
                string usuario = data.Rows[0]["usuario"].ToString();
                string contraseña = data.Rows[0]["contraseña"].ToString();
                string codigoventa = usuario + " " + ci + dtmFecha.SelectedDate.ToString();
                DataTable dataUsuario = usuar.getIdByUsuario(usuario, contraseña);
                int id = Convert.ToInt32(dataUsuario.Rows[0]["id_personal"].ToString());
                venta.insertarVenta(codigoventa, dtmFecha.SelectedDate, Convert.ToDecimal(txtTotal.Text), id);
                DataTable dataVenta = venta.maxIdVenta();
                int id_ventaX = Convert.ToInt32(dataVenta.Rows[0]["id_venta"].ToString());
                foreach (objetoDAL objeto in listaDetalles)
                {
                    int id_repuesto = Convert.ToInt32(listaDetalles[c].ID_REPUESTO);
                    int cantidad = Convert.ToInt32(listaDetalles[c].CANTIDAD);
                    string codigo = listaDetalles[c].CODIGO;
                    string descripcion = listaDetalles[c].DESCRIPCION;
                    //string marca = listaDetalles[c].marca;
                    //string industria = listaDetalles[c].ind;
                    decimal precio = Convert.ToDecimal(listaDetalles[c].PRECIO);
                    c++;
                    decimal subt = precio * cantidad;
                    detalleventa.insertarDetalleVenta(id_ventaX, id_repuesto, subt, cantidad, codigoventa);
                }
                Label7.Text = "COMPRA REALIZADA";
            }
            catch
            {
                Label7.Text = "COMPLETE LOS DATOS CORRECTAMENTE";
            }
        }

        protected void txtIdRepuesto_TextChanged(object sender, EventArgs e)
        {

        }

        protected void grdDetalleVenta_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            decimal subtotal = 0; decimal suma = 0;
            TextBox t = (TextBox)Session["suma"];
            listaDetalles = (List<objetoDAL>)Session["lista"];
            int index = e.RowIndex;
            GridViewRow fil = grdDetalleVenta.Rows[index];
            try
            {
                txtIdRepuesto.Text = fil.Cells[1].Text;
                obj.eliminatObjeto(Convert.ToInt32(txtIdRepuesto.Text));
                subtotal = Convert.ToDecimal(fil.Cells[6].Text);
                suma = Convert.ToDecimal(t.Text) - subtotal;
                txtTotal.Text = suma.ToString();
                Session["suma"] = txtTotal;
                txtTotal.Text = suma.ToString();
                listaDetalles.RemoveAt(index);
                Session["lista"] = listaDetalles;
                Actualizar();
            }
            catch
            {

            }
        }
        public void Actualizar()
        {
            listaDetalles = (List<objetoDAL>)Session["lista"];
            grdDetalleVenta.DataSource = listaDetalles;
            grdDetalleVenta.DataBind();
        }
    }
}

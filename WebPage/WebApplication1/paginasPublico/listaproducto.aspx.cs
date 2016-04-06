using System;
using System.Collections;
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

namespace WebApplication.Escuela.Presentation
{
    public partial class listaproducto : System.Web.UI.Page
    {
        proyectoTableAdapters.repuesto rep = new WebApplication.Escuela.Presentation.proyectoTableAdapters.repuesto();
        int b = 0; int c = 0; int index = 0;
        proyectoTableAdapters.repuesto1TableAdapter rep1 = new WebApplication.Escuela.Presentation.proyectoTableAdapters.repuesto1TableAdapter();
        proyectoTableAdapters.repuesto2TableAdapter rep2 = new WebApplication.Escuela.Presentation.proyectoTableAdapters.repuesto2TableAdapter();
        proyectoTableAdapters.repuesto3TableAdapter rep3 = new WebApplication.Escuela.Presentation.proyectoTableAdapters.repuesto3TableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.PageIndex = e.NewPageIndex;
            if (!IsPostBack)
            {
                b = 0; c = 0;
                cmbIndustria.DataSource = rep.getIndustria();
                cmbIndustria.DataTextField = "industria";
                cmbIndustria.DataValueField = "industria";
                cmbIndustria.DataBind();

                cmbMarca.DataSource = rep.getMarca();
                cmbMarca.DataTextField = "marca";
                cmbMarca.DataValueField = "marca";
                cmbMarca.DataBind();

                ActualizarDatos();
            }
        }

        ////protected void btnListar_Click(object sender, EventArgs e)
        ////{
        ////    try
        ////    {
        ////        GridView2.DataSource = rep.seleccionarPrecio(Convert.ToDecimal(txtPrecio.Text));
        ////        GridView2.DataBind();
        ////    }
        ////    catch //////////////////////////ESTE CODIGO SIRVE
        ////    {
        ////        Label1.Text = "Ingrese un dato numérico";
        ////    }
        ////}

        private void ActualizarDatos()
        {
            GridView1.DataSource = rep.selectTodosRep();
            GridView1.DataBind();
            //Session["industr"] = cmbIndustria;
            //Session["marc"] = cmbMarca;
        }

        //protected void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    rep1.insertarProducto(txtCodigo.Text, txtDescripcion.Text, txtMarca.Text, txtIndustria.Text, Convert.ToDecimal(txtPrecio.Text), "~/paginasPublico/imag/" + fileUpImag.FileName);
        //    fileUpImag.SaveAs(Server.MapPath("~/paginasPublico/imag/" + fileUpImag.FileName));
        //    ActualizarDatos();
        //    Label1.Text = "PRODUCTO REGISTRADO";
        //    txtCodigo.Text = ""; txtDescripcion.Text = ""; txtMarca.Text = "";
        //    txtIndustria.Text = ""; txtPrecio.Text = "";
        //}
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            ActualizarDatos();
        }

        //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    GridViewRow fila = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())];
        //    Label1.Text = "";
        //    txtId.Text = fila.Cells[1].Text;
        //    txtCodigo.Text = fila.Cells[2].Text;
        //    txtDescripcion.Text = fila.Cells[3].Text;
        //    txtMarca.Text = fila.Cells[4].Text;
        //    txtIndustria.Text = fila.Cells[5].Text;
        //    txtPrecio.Text = fila.Cells[6].Text;
        //    string urlimage = fila.Cells[8].Text;
        //    imgRepuesto.ImageUrl = urlimage;
        //}

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //DropDownList cmbMarcas = (DropDownList)Session["marc"];
            //DropDownList cmbIndustrias = (DropDownList)Session["industr"];
            try
            {
                string param = "%" + txtParam.Text + "%";
                string industria = cmbIndustria.SelectedValue;
                string marca = cmbMarca.SelectedValue;
                if (RadioButtonList1.Items[0].Selected) { GridView1.DataSource = rep.seleccionarCodigo(param); }
                if (RadioButtonList1.Items[1].Selected) { GridView1.DataSource = rep.seleccionarDescrip(param); }
                if (RadioButtonList1.Items[2].Selected) { GridView1.DataSource = rep.seleccionarPrecio(Convert.ToDecimal(txtParam.Text)); }
                if (RadioButtonList1.Items[3].Selected) { ActualizarDatos(); }
                if (b == 1) { GridView1.DataSource = rep.seleccionarIndustria(industria); }
                if (c == 1) { GridView1.DataSource = rep.seleccionarMarca(marca); }
                GridView1.DataBind();
            }
            catch
            {

            }
        }

        protected void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = 1;
        }

        protected void cmbIndustria_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = 1;
        }

        //protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    int index = e.RowIndex;
        //    GridViewRow fil = GridView1.Rows[index];
        //    try
        //    {
        //        txtId.Text = fil.Cells[1].Text;
        //        rep.eliminarRepuesto(Convert.ToInt32(txtId.Text));
        //        Label1.Text = "DATOS DE REPUESTO ELIMINADO";
        //        ActualizarDatos();
        //    }
        //    catch
        //    {
        //        Label1.Text = "SELECCIONE UNA FILA";
        //    }
        //}

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            index = e.NewEditIndex;    
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridView1.PageIndex = e.NewSelectedIndex;
            ActualizarDatos();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //protected void btnModificar_Click(object sender, EventArgs e)
        //{
        //    GridViewRow fil = GridView1.Rows[index];
        //    try
        //    {
        //        rep3.modificarRepuesto(txtCodigo.Text, txtDescripcion.Text, txtMarca.Text, txtIndustria.Text, Convert.ToDecimal(txtPrecio.Text), "~/paginasPublico/imag/" + fileUpImag.FileName, Convert.ToInt32(txtId.Text));
        //        Label1.Text = "DATOS DE REPUESTO MODIFICADO";
        //        imgRepuesto.ImageUrl = "~/paginasPublico/imag/" + fileUpImag.FileName;
        //        ActualizarDatos();
        //    }
        //    catch
        //    {
        //        Label1.Text = "SELECCIONE UNA FILA";
        //    }
        //}


    }
}

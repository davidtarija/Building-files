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

namespace WebApplication.Escuela.Presentation.paginasUsuarios
{
    public partial class nuevoProducto : System.Web.UI.Page
    {
        proyectoTableAdapters.repuesto1TableAdapter rep = new WebApplication.Escuela.Presentation.proyectoTableAdapters.repuesto1TableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            rep.insertarProducto(txtCodigo.Text, txtDescripcion.Text, txtMarca.Text, txtIndustria.Text, Convert.ToDecimal(txtPrecio.Text), "~/paginasPublico/imag/" + fileUpImag.FileName);
            fileUpImag.SaveAs(Server.MapPath("~/paginasPublico/imag/" + fileUpImag.FileName));
            Label1.Text = "Producto Agregado";
        }
    }
}

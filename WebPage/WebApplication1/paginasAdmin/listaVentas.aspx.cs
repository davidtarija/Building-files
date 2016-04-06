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

namespace WebApplication.Escuela.Presentation.paginasAdmin
{
    public partial class listaVentas : System.Web.UI.Page
    {
        proyectoTableAdapters.ventaTableAdapter venta = new WebApplication.Escuela.Presentation.proyectoTableAdapters.ventaTableAdapter();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rdoOpciones.Items[0].Selected = true;
                cmbCodigo.DataSource = venta.getCodigoVentas();
                cmbCodigo.DataTextField = "codigoventa";
                cmbCodigo.DataValueField = "codigoventa";
                cmbCodigo.DataBind();
            }
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            if (rdoOpciones.Items[0].Selected) 
            {
                string codigo = cmbCodigo.SelectedValue.ToString();
                grdVentas.DataSource = venta.getVentaByCodigo(codigo);
                grdVentas.DataBind();
            }
            if(rdoOpciones.Items[1].Selected)
            {
                try
                {
                    grdVentas.DataSource = venta.getVentasByMonto(Convert.ToDecimal(txtMonto.Text));
                    grdVentas.DataBind();
                }
                catch
                {
                    Label2.Text = "INGRESE EL MONTO";
                }
            }
        }
    }
}

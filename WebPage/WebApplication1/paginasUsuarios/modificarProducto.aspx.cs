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
    public partial class modificarProducto : System.Web.UI.Page
    {
        proyectoTableAdapters.repuesto2TableAdapter repTodosProd = new WebApplication.Escuela.Presentation.proyectoTableAdapters.repuesto2TableAdapter();
        proyectoTableAdapters.repuesto3TableAdapter repModificar = new WebApplication.Escuela.Presentation.proyectoTableAdapters.repuesto3TableAdapter();
        ListBox list = new ListBox();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                list = (ListBox)FindControl("lstProductos");
            }
            if (!IsPostBack)
            {
                lstProductos.DataSource = repTodosProd.cargarProductos();
                lstProductos.DataTextField = "descripcion";
                lstProductos.DataValueField = "id_repuesto";
                lstProductos.DataBind();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            repModificar.modificarRepuesto(txtCodigo.Text,txtDescripcion.Text,txtMarca.Text,txtIndustria.Text,Convert.ToDecimal(txtPrecio.Text),txtUrl.Text,Convert.ToInt32(lstProductos.SelectedValue.ToString()));
            Label1.Text = "Producto Modificado";
        }

        protected void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < list.Items.Count; i++)
            //{
            //    lstProductos.Items.Add(list.Items[i]);
            //}
            int id_repuesto = Convert.ToInt32(lstProductos.SelectedValue.ToString());
            DataTable dat = repTodosProd.GetProductoById(id_repuesto);

            txtCodigo.Text = dat.Rows[0]["codigo"].ToString();
            txtDescripcion.Text = dat.Rows[0]["descripcion"].ToString();
            txtMarca.Text = dat.Rows[0]["marca"].ToString();
            txtIndustria.Text = dat.Rows[0]["industria"].ToString();
            txtPrecio.Text = dat.Rows[0]["precio"].ToString();
            txtUrl.Text = dat.Rows[0]["imagen"].ToString();
            Image1.ImageUrl = txtUrl.Text;
        }
    }
}

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
    public partial class eliminarUsuario : System.Web.UI.Page
    {
        proyectoTableAdapters.personaTableAdapter persona = new WebApplication.Escuela.Presentation.proyectoTableAdapters.personaTableAdapter();
        int id_persona = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstUsuarios.DataSource = persona.GetTodoPersonas();
                lstUsuarios.DataTextField = "ci";
                lstUsuarios.DataValueField = "id_persona";
                lstUsuarios.DataBind();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            persona.eliminarPersona(id_persona);
            Label1.Text = "USUARIO ELIMINADO";
        }

        protected void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_persona = Convert.ToInt32(lstUsuarios.SelectedValue.ToString());
        }
    }
}

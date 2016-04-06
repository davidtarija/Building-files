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
    public partial class modificarUsuario : System.Web.UI.Page
    {
        proyectoTableAdapters.personaTableAdapter persona = new WebApplication.Escuela.Presentation.proyectoTableAdapters.personaTableAdapter();
        proyectoTableAdapters.personalTableAdapter personal = new WebApplication.Escuela.Presentation.proyectoTableAdapters.personalTableAdapter();

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
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int id_persona = Convert.ToInt32(lstUsuarios.SelectedValue.ToString());
            persona.modificarPersona(txtCi.Text,txtNombre.Text,txtPaterno.Text,txtMaterno.Text,dtmFechaNac.SelectedDate,txtTelefono.Text,txtDireccion.Text,id_persona); 
            personal.modificarPersonal(txtUsuario.Text,txtContraseña.Text,DropDownList1.SelectedItem.ToString(),id_persona);
            Label10.Text = "DATOS DE USUARIO MODIFICADO";
        }

        protected void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_persona = Convert.ToInt32(lstUsuarios.SelectedValue.ToString());
            DataTable dat = persona.GetPersonaById(id_persona);

            txtCi.Text = dat.Rows[0]["ci"].ToString();
            txtNombre.Text = dat.Rows[0]["nombre"].ToString();
            txtPaterno.Text = dat.Rows[0]["paterno"].ToString();
            txtMaterno.Text = dat.Rows[0]["materno"].ToString();
            txtFechaNac.Text = dat.Rows[0]["fechanac"].ToString();
            txtTelefono.Text = dat.Rows[0]["telefono"].ToString();
            txtDireccion.Text = dat.Rows[0]["direccion"].ToString();
            txtUsuario.Text = dat.Rows[0]["usuario"].ToString();
            txtContraseña.Text = dat.Rows[0]["contraseña"].ToString();
            txtTipo.Text = dat.Rows[0]["tipo"].ToString();
        }
    }
}

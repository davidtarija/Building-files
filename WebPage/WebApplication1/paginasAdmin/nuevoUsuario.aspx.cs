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
    public partial class nuevoUsuario : System.Web.UI.Page
    {
        proyectoTableAdapters.personaTableAdapter persona = new WebApplication.Escuela.Presentation.proyectoTableAdapters.personaTableAdapter();
        proyectoTableAdapters.personalTableAdapter personal = new WebApplication.Escuela.Presentation.proyectoTableAdapters.personalTableAdapter();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            persona.insertarPersona(txtCi.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, dtmFechaNac.SelectedDate, txtTelefono.Text, txtDireccion.Text);
            DataTable dat = persona.GetIdPersona();
            int id_persona = Convert.ToInt32(dat.Rows[0]["id_persona"].ToString());
            personal.insertarPersonal(id_persona,txtUsuario.Text,txtContraseña.Text,DropDownList1.SelectedItem.ToString());
            Label10.Text = "USUARIO REGISTRADO";
        }
    }
}

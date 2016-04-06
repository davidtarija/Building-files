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

namespace WebApplication1
{
    public partial class inicio : System.Web.UI.Page
    {
        proyectoTableAdapters.usuarioTableAdapter usuarios = new WebApplication1.proyectoTableAdapters.usuarioTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click1(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                Label3.Text = "INGRESE NOMBRE DE USUARIO";
            }
            else
            {
                if (txtContraseña.Text.Equals(""))
                {
                    Label3.Text = "INGRESE CONTRASEÑA";
                }
                else
                {
                    string tipo = cmbTipo.SelectedItem.ToString();
                    string usuario = ""; string contraseña = "";
                    DataTable data = usuarios.logueoUsuario(txtUsuario.Text, txtContraseña.Text, tipo);
                    try
                    {
                        usuario = data.Rows[0]["usuario"].ToString();
                        contraseña = data.Rows[0]["contraseña"].ToString();
                        DataTable dataPersona = usuarios.getCiUsuario(usuario);
                        Session["per"] = dataPersona;
                    }
                    catch
                    {
                        Label3.Text = "USUARIO INEXISTENTE";
                    }


                    if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
                    {
                        Session["usu"] = data;
                        if (tipo.Equals("público"))
                        {
                            Response.Redirect("/paginasPublico/inicioPublic.aspx");
                        }
                    }
                    if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
                    {
                        Session["usu"] = data;
                        if (tipo.Equals("administrador"))
                        {
                            Response.Redirect("/paginasAdmin/inicioAdm.aspx");
                        }
                    }
                    if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
                    {
                        Session["usu"] = data;
                        if (tipo.Equals("usuario"))
                        {
                            Response.Redirect("/paginasUsuarios/inicioUsuario.aspx");
                        }
                    }       
                }
            }
        }
    }
}

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
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace WebApplication.Escuela.Presentation.paginasAdmin
{
    public partial class listarUsuarios : System.Web.UI.Page
    {
        proyectoTableAdapters.personaTableAdapter persona = new WebApplication.Escuela.Presentation.proyectoTableAdapters.personaTableAdapter();
        proyectoTableAdapters.personalTableAdapter personal = new WebApplication.Escuela.Presentation.proyectoTableAdapters.personalTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                actualizarDataGrid();
            }
        }
        private void actualizarDataGrid()
        {
            grdUsuarios.DataSource = persona.GetTodoPersonas();
            grdUsuarios.DataBind();
        }

        protected void grdUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow fila = grdUsuarios.Rows[Convert.ToInt32(grdUsuarios.SelectedIndex.ToString())];
            Label1.Text = "";
            txtId.Text = fila.Cells[1].Text;
            txtCi.Text = fila.Cells[2].Text;
            txtNombre.Text = fila.Cells[3].Text;
            txtPaterno.Text = fila.Cells[4].Text;
            txtMaterno.Text = fila.Cells[5].Text;
            txtFechaNac.Text = fila.Cells[6].Text;
            txtTelefono.Text = fila.Cells[7].Text;
            txtDireccion.Text = fila.Cells[8].Text;
            txtUsuario.Text = fila.Cells[9].Text;
            txtContraseña.Text = fila.Cells[10].Text;
            txtTipo.Text = fila.Cells[11].Text;
        }

        protected void grdUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int index = e.NewEditIndex;
            GridViewRow fil = grdUsuarios.Rows[index];
            try
            {
                //txtId.Text = fil.Cells[1].Text;
                //txtCi.Text = fil.Cells[2].Text;
                //txtNombre.Text = fil.Cells[3].Text;
                //txtPaterno.Text = fil.Cells[4].Text;
                //txtMaterno.Text = fil.Cells[5].Text;
                //txtFechaNac.Text = fil.Cells[6].Text;
                //txtTelefono.Text = fil.Cells[7].Text;
                //txtDireccion.Text = fil.Cells[8].Text;
                //txtUsuario.Text = fil.Cells[9].Text;
                //txtContraseña.Text = fil.Cells[10].Text;

                persona.modificarPersona(txtCi.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, Convert.ToDateTime(txtFechaNac.Text), txtTelefono.Text, txtDireccion.Text, Convert.ToInt32(txtId.Text));
                personal.modificarPersonal(txtUsuario.Text, txtContraseña.Text,txtTipo.Text, Convert.ToInt32(txtId.Text));
                Label1.Text = "DATOS DE USUARIO MODIFICADO";
                actualizarDataGrid();
            }
            catch 
            {
                Label1.Text = "SELECCIONE UNA FILA";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            //persona.modificarPersona(txtCi.Text,txtNombre.Text,txtPaterno.Text,txtMaterno.Text,Convert.ToDateTime(txtFechaNac.Text),txtTelefono.Text,txtDireccion.Text,Convert.ToInt32(txtId.Text));
            //personal.modificarPersonal(txtUsuario.Text,txtContraseña.Text,Convert.ToInt32(txtId.Text));
            //Label1.Text = "DATOS DE USUARIO MODIFICADO";
            //actualizarDataGrid();
        }

        protected void grdUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;
            GridViewRow fil = grdUsuarios.Rows[index];
            try
            {
                txtId.Text = fil.Cells[1].Text;
                persona.eliminarPersona(Convert.ToInt32(txtId.Text));
                Label1.Text = "DATOS DE USUARIO ELIMINADO";
                actualizarDataGrid();
            }
            catch
            {
                Label1.Text = "SELECCIONE UNA FILA";
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string par = "%" + txtPar.Text + "%";
            if (rdoListPar.Items[0].Selected)
            {
                grdUsuarios.DataSource = persona.getUsuarioByCi(par);
                grdUsuarios.DataBind();
            }
            if (rdoListPar.Items[1].Selected)
            {
                grdUsuarios.DataSource = persona.getUsuarioByNombre(par);
                grdUsuarios.DataBind();
            }
            if (rdoListPar.Items[2].Selected)
            {
                grdUsuarios.DataSource = persona.getUsuariosByPaterno(par);
                grdUsuarios.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCi.Text = ""; txtNombre.Text = ""; txtPaterno.Text = ""; txtMaterno.Text = "";
            txtFechaNac.Text = ""; txtTelefono.Text = ""; txtDireccion.Text = "";
            txtUsuario.Text = ""; txtContraseña.Text = "";
            txtCi.Focus(); btnGuardar.Visible = true;
        }

        protected void txtPar_TextChanged(object sender, EventArgs e)
        {
            if (txtPar.Text=="") { actualizarDataGrid(); }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
                persona.insertarPersona(txtCi.Text,txtNombre.Text,txtPaterno.Text,txtMaterno.Text,Convert.ToDateTime(txtFechaNac.Text),txtTelefono.Text,txtDireccion.Text);
                DataTable dat = persona.GetIdPersona();
                int id_persona = Convert.ToInt32(dat.Rows[0]["id_persona"].ToString());
                personal.insertarPersonal(id_persona,txtUsuario.Text,txtContraseña.Text,txtTipo.Text);
                Label1.Text = "DATOS DE USUARIO REGISTRADO";
                actualizarDataGrid(); btnGuardar.Visible = false;
        }

        protected void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}

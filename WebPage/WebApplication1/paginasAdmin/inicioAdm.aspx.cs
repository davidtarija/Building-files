﻿using System;
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
    public partial class inicioAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable data = (DataTable)Session["usu"];
                string usuario = data.Rows[0]["usuario"].ToString();
                Label1.Text = "BIENVENIDO " + usuario;
        }
    }
}

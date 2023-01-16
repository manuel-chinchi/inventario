using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntitiesLayer;
using BusinessLayer;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Usuario objUsuario = UsuarioBL.getInstance().AccesoSistema(txtUser.Text, txtPasword.Text);

        if (objUsuario != null)
        {
            Response.Write("<script>alert('Acceso exitoso!!!')</script>");
        }
        else
        {
            Response.Write("<script>alert('Error!!!')</script>");
        }
    }
}
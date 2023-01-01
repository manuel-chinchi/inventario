using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    private Tuple<string, string> defaultUser = Tuple.Create<string, string>("admin", "1234");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string user = txtUser.Text;
        string password = txtPasword.Text;

        if (user.Equals(defaultUser.Item1) && password.Equals(defaultUser.Item2))
        {
            Response.Write("<script>alert('Ingreso exitoso!')</script>");
        }
        else
        {
            Response.Write("<script>alert('Error de ingreso!')</script>");
        }
    }
}
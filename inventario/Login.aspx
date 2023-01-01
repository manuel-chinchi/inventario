<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Acceso al sistema de Inventario</title>

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <link href="css/styles.css" rel="stylesheet" type="text/css" />
    <link href="css/temp.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <%--TODO--%>
    <%--Componentes de Bootstrap -> https://getbootstrap.com/docs/4.0/components/ --%>
    <div class="container-fluid bg-danger">
        <div class="row px-2 py-3 bg-white container-form">
            <div class="col"></div>
            <div class="col py-3 border">
                <form class="form-box" runat="server">
                    <div class="header-box">
                        <h3>Iniciar sesión</h3>
                    </div>
                    <br />
                    <div class="form-group">
                        <label>Usuario</label>
                        <asp:TextBox ID="txtUser" CssClass="form-control" AutoCompleteType="Email" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Constraseña</label>
                        <asp:TextBox ID="txtPasword" CssClass="form-control" MaxLength="16" runat="server" />
                    </div>
                    <br />
                    <br />
                    <div class="btn-box">
                        <asp:Button ID="btnLogin" Text="Ingresar" CssClass="btn btn-primary btn-block" runat="server" OnClick="btnLogin_Click"/>
                    </div>
                </form>
            </div>
            <div class="col"></div>
        </div>



    </div>
</body>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
</html>

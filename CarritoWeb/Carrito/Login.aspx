<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Carrito.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <div align="center" class="container jumbotron bg-light boxshadow" style="width: 35%">
            <form>
                <div class="card-header-pills bg-dark text-white">
                    <h2>Carrito_WEB Login</h2>
                </div>
                <div class="form-group" style="width: 80%">
                    <label class="text-dark" for="emailLabel">Direccion de correo</label>
                    <div class="input-group mb-2">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="text-dark" for="passLabel">Contraseña</label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password" Width="80%"></asp:TextBox>
                </div>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-primary" />
            </form>
        </div>
    </form>
</body>
</html>

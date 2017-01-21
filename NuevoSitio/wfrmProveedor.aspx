<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wfrmProveedor.aspx.cs" Inherits="wfrmProveedor" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
            <br />
            <br />
            <div class="panel panel-warning ">
                <div class="panel-heading">
                    Panel de Proveedor</div>
                <div class="panel-body">
                    <!--renglon para guardar imagen--->
                    <div class="col-lg-2">
                    </div>
                    <div class="col-lg-9">
                        <img src="img/crayon-1294842_960_720.png" class="img-rounded" alt="Cinque Terre"
                            width="304" height="236" />
                        <div class="col-lg-3">
                        </div>
                        <div class="row">
                            <div class="row">
                                <div class="col-lg-2">
                                </div>
                                <div class="col-lg-8">
                                    <div class="form-group">
                                        <asp:Label ID="Label1" runat="server" Text="id"></asp:Label>
                                        <asp:TextBox ID="txtid" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                                        <asp:TextBox ID="txtNombre" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label6" runat="server" Text="Telefono"></asp:Label>
                                        <asp:TextBox ID="txtTelefono" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label5" runat="server" Text="Correo"></asp:Label>
                                        <asp:TextBox ID="txtCorreo" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
                                        <asp:TextBox ID="txtDireccion" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <asp:Button ID="btnAgregar" CssClass="btn btn-warning " runat="server" Text="Agregar"
                                        OnClick="btnAgregar_Click" />
                                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"
                                        CssClass="btn btn-danger" />
                                    <asp:Button ID="btnModificar" runat="server" Text="Actualizar" OnClick="btnModificar_Click"
                                        CssClass="btn btn-warning " />
                                    <br />
                                    <br />
                                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <div class="col-lg-2">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="panel panel-warning ">
                    <div class="panel-heading ">
                        Consulta</div>
                    <div class="panel-body ">
                        <asp:Button ID="btnConsultar" CssClass="btn btn-warning " runat="server" Text="Cargar"
                            OnClick="btnConsultar_Click" />
                        <br />
                        <asp:GridView ID="GvDatos" runat="server">
                        </asp:GridView>
                    </div>
                </div>
                <br />
            </div>
        </div>
    </form>
</body>
</html>

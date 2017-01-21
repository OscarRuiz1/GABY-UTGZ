<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wfrmEmpleado.aspx.cs" Inherits="wfrmEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type"content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div class="container">
                <br />
                <br />

                <div class="panel panel-primary">
                    <div class="panel-heading">Panel de Empleados</div>

                    <div class="panel-body">
 
                                              <!--renglon para guardar imagen--->
                            <div class="col-lg-2">
                            </div>

                            <div class="col-lg-9">
                                <img src="img/crayon-1294842_960_720.png" class="img-rounded" alt="Cinque Terre" width="304" height="236" />
                              
                         

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
                                 <%-- <div class="form-group">

                                    <asp:Label ID="Label9" runat="server" Text="id"></asp:Label>
                                    <asp:TextBox ID="Txtid_puesto" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>--%>

                                <div class="form-group">

                                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                                    <asp:TextBox ID="TxtNombre" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>

                                   <div class="form-group">
                                    <asp:Label ID="Label6" runat="server" Text="Apellido Paterno"></asp:Label>
                                    <asp:TextBox ID="TxtApepat" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>


                                <div class="form-group">
                                    <asp:Label ID="Label5" runat="server" Text="Apellido Materno"></asp:Label>
                                    <asp:TextBox ID="TxtApemat" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                   <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
                                    <asp:TextBox ID="TxtDireccion" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
                                    <asp:TextBox ID="TxtTelefono" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label8" runat="server" Text="Correo Electrónico"></asp:Label>
                                    <asp:TextBox ID="TxtCorreo" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                             
                                <asp:Label ID="Label7" runat="server" Text="Puesto"></asp:Label>
                                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                                <br />

                                <br />

                                <asp:Button ID="btnAgregar" CssClass="btn btn-primary " runat="server" Text="Agregar" OnClick="btnAgregar_Click" Height="37px" Width="100px" />
                                <asp:Button ID="btnModificar" runat="server" Text="Actualizar" OnClick="btnModificar_Click" CssClass="btn btn-primary " Height="37px" Width="113px"/>

                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger" Height="39px" Width="100px"/>

                                <br />

                                <br />
                             <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                            </div>
                        </div>

                        <div class="col-lg-2">
                        </div>

                    </div>
                </div>
                <br />
             

                </div>
<br />
                <div class="panel panel-primary ">
                <div class="panel-heading">Consulta</div>


                    <div class="panel-body">
                        <asp:Button ID="btnConsultar" CssClass="btn btn-primary " runat="server" Text="Cargar" OnClick="btnConsultar_Click" />
                        <br />
                        <asp:GridView ID="GvDatos" runat="server"></asp:GridView>
                     
                    </div>
                    </div>
                </div>
          </div>
            </div>
   
    </form>
</body>
</html>

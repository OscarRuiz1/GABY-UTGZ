<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel ="stylesheet" type ="text/css" href ="css/bootstrap.min.css"  />
   
</head>
<body>
    <form id="form1" runat="server">
   <br />
        <br />

         <div>
    
         <div class="row">
                <div class="col-lg-4">
                </div>

                <div class="col-lg-4">

                    <div class="jumbotron">
                        <div class="row">
                            <!--renglon para guardar imagen--->
                            <div class="col-lg-2">
                            </div>

                            <div class="col-lg-8">
                                <img src="img/46390.png" class="img-rounded" alt="Cinque Terre" width="304" height="236" />
                            </div>


                            <div class="col-lg-2">
                            </div>
                        </div>

                        <div class="row">
                            <!---renglon para contener los texbox label y botones--->


                            <div class="col-lg-2">
                            </div>

                            <div class="col-lg-8">
                                <div class="form-group">

                                    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtUsuario" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtPass" Width="100%" TextMode="Password" runat="server"> </asp:TextBox>

                                </div>
                            </div>
                            <div class="col-lg-2">
                            </div>

                            <div class="col-lg-4">
                            </div>

                            <div class="col-lg-6">
                                <asp:Button ID="btnPulsar" CssClass ="btn btn-info " runat="server" OnClick="btnPulsar_Click" Text="pulsar" />
                                <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
                                <br />
                         
                            </div>

                            <div class="col-lg-2">
                            </div>

                        </div>

                    </div>
        </div>
                <div class="col-lg-4">
                </div>
            </div>
    </div>

    </form>
</body>
</html>

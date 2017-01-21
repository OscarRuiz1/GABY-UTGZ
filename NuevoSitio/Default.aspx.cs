using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 
    protected void btnPulsar_Click(object sender, EventArgs e)
    {
      if (txtUsuario.Text.Equals("admin"))
        {
            if (txtPass.Text.Equals("ratoncito"))
            {
                Response.Redirect("wfrmInicio.aspx");
            }
            else
            {
                LblMensaje.Text = "La contraseña es incorrecta";

            }
        }
        else
        {
            LblMensaje.Text = "Nombre de usuario incorrecto";
    }
    }
}

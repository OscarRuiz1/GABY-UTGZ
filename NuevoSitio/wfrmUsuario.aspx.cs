using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class wfrmUsuario : System.Web.UI.Page
{
    string cadena = "Data Source=LEONEL\\MSSQLSERVER2012; initial catalog=Cosmeticos; user=sa; password=12345";


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection cn = new SqlConnection(cadena);
            SqlCommand cmdDdlE = new SqlCommand("select * from Empleado", cn);
            cmdDdlE.CommandType = CommandType.Text;
            DataTable dtE = new DataTable();
            SqlCommand cmdDdlC = new SqlCommand("select * from Cliente", cn);
            cmdDdlC.CommandType = CommandType.Text;
            DataTable dtC = new DataTable();
            SqlCommand cmdDdlP = new SqlCommand("select * from Permiso", cn);
            cmdDdlP.CommandType = CommandType.Text;
            DataTable dtP = new DataTable();
            cn.Open();
            dtE.Load(cmdDdlE.ExecuteReader());
            dtC.Load(cmdDdlC.ExecuteReader()); 
            dtP.Load(cmdDdlP.ExecuteReader());
            cn.Close();

            ddlEmpleado.DataSource = dtE;
            ddlEmpleado.DataTextField = "Nombre";
            ddlEmpleado.DataValueField = "id";
            ddlEmpleado.DataBind();

            ddlCliente.DataSource = dtC;
            ddlCliente.DataTextField = "Nombre";
            ddlCliente.DataValueField = "id";
            ddlCliente.DataBind();

            ddlPermiso.DataSource = dtP;
            ddlPermiso.DataTextField = "Nombre";
            ddlPermiso.DataValueField = "id";
            ddlPermiso.DataBind();
        }
    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(cadena); try
        {

            string id = txtid.Text;
            int IdPermiso = int.Parse(ddlPermiso.SelectedValue.ToString());
            int IdEmpleado = int.Parse(ddlEmpleado.SelectedValue.ToString());
            int IdCliente = int.Parse(ddlCliente.SelectedValue.ToString());
            string Nombre = txtNombre.Text;
            string Contraseña = txtContraseña.Text;
            string comando = "insert into Usuario values('" + IdPermiso + "','" + IdEmpleado + "','" + IdCliente + "','" + Nombre + "','" + Contraseña + "');";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = comando;
            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text; cn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblMensaje.Text = "Usario Registrado";
                cn.Close();
                txtid.Text = "";
                ddlPermiso.SelectedIndex = 0;
                ddlEmpleado.SelectedIndex = 0;
                ddlCliente.SelectedIndex = 0;
                txtNombre.Text = "";
                txtContraseña.Text = "";

            }
        }
        catch (Exception ex) { lblMensaje.Text = ex.ToString(); }


    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(cadena);
        int id = int.Parse(txtid.Text); //sacamos el valor del campo eliminar 
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "delete from Usuario where id=" + id + ";";
        cmd.CommandType = CommandType.Text; cn.Open();
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblMensaje.Text = "Eliminación realizada";
                cn.Close();
            }
        }
        catch (Exception ex) { lblMensaje.Text = ex.ToString(); }
    }
    protected void btnModificar_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(cadena);
        SqlCommand cmd = new SqlCommand();

        string id = txtid.Text;
        int IdPermiso = int.Parse(ddlPermiso.SelectedValue.ToString());
        int IdEmpleado = int.Parse(ddlEmpleado.SelectedValue.ToString());
        int IdCliente = int.Parse(ddlCliente.SelectedValue.ToString());
        string Nombre = txtNombre.Text;
        string Contraseña = txtContraseña.Text;

        cmd.CommandText = "update Usuario set id_permiso='" + IdPermiso + "', Id_Empleado='" + IdEmpleado + "'," + "Id_Cliente='" + IdCliente + "'," + "NombreU='" + Nombre + "', Contraseña='" + Contraseña + "' where id=" + id;
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        cn.Open();
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblMensaje.Text = "registro modificado con exito";
                cn.Close();
            }

        }

        catch (Exception ex)
        {
            lblMensaje.Text = ex.ToString();
            cn.Close();
        }
    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {

        SqlConnection cn = new SqlConnection(cadena);
        try
        {
            SqlCommand cmd = new SqlCommand("select * from Usuario", cn);
            cmd.CommandType = CommandType.Text;
            cn.Open();
            DataTable da = new DataTable();
            da.Load(cmd.ExecuteReader());
            cn.Close();
            GvDatos.DataSource = da;
            GvDatos.DataBind();
        }
        catch (Exception ex) { lblMensaje.Text = ex.ToString(); }
    }

}



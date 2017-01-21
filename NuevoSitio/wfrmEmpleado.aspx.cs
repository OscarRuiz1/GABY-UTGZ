using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class wfrmEmpleados : System.Web.UI.Page
{


    string cadena = "Data Source=LEONEL\\MSSQLSERVER2012; initial catalog=Cosmeticos; user=sa; password=12345";


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection cn = new SqlConnection(cadena);
            SqlCommand cmdDdl = new SqlCommand("select * from Puesto", cn);
            cmdDdl.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            cn.Open();
            dt.Load(cmdDdl.ExecuteReader());
            cn.Close();

            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "Nombre";
            DropDownList2.DataValueField = "id";
            DropDownList2.DataBind();
        }
    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(cadena); try
        {

            string id = txtid.Text;
            //string id_puesto = Txtid_puesto.Text;
            string Nombre = TxtNombre.Text;
            string Apepat = TxtApepat.Text;
            string Apemat = TxtApemat.Text;
            string Direccion = TxtDireccion.Text;
            string Telefono = TxtTelefono.Text;
            string Correo = TxtCorreo.Text;
            int Id = int.Parse(DropDownList2.SelectedValue.ToString());
            //string comando = "insert into Empleado value('" + id + "','" + id_puesto + "','" + Nombre + "','" + Apepat + "','" + Apemat + "','" + Direccion + "','" + Telefono + "','" + Correo + "');";
            string comando = "insert into Empleado values('" + Id + "','" + Nombre + "','" + Apepat + "','" + Apemat + "','" + Direccion + "','" + Telefono + "','" + Correo + "');";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = comando;
            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text; cn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblMensaje.Text = "Empleado Registrado";
                cn.Close();
                txtid.Text = "";
                TxtNombre.Text="";
                TxtApepat.Text="";
                TxtApemat.Text="";
                TxtDireccion.Text="";
                TxtTelefono.Text="";
                TxtCorreo.Text="";
                DropDownList2.SelectedIndex=0;

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
        cmd.CommandText = "delete from Empleado where id=" + id + ";";
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
        string Nombre = TxtNombre.Text;
        string Apepat = TxtApepat.Text;
        string Apemat = TxtApemat.Text;
        string Direccion = TxtDireccion.Text;
        string Telefono = TxtTelefono.Text;
        string Correo = TxtCorreo.Text;
        int Id = int.Parse(DropDownList2.SelectedValue.ToString());

        cmd.CommandText = "update Empleado set id_puesto='" +Id+ "', Nombre='" + Nombre + "'," + "Apepat='" + Apepat + "'," + "Apemat='" + Apemat + "', Direccion='" + Direccion + "',"+"Telefono='" + Telefono + "',"+"Correo='" + Correo + "'  where id=" + id;
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
            SqlCommand cmd = new SqlCommand("select * from Empleado", cn);
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



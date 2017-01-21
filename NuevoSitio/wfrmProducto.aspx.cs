using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class wfrmProducto : System.Web.UI.Page
{
    string cadena = "Data Source=LEONEL\\MSSQLSERVER2012; initial catalog=Cosmeticos; user=sa; password=12345";


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection cn = new SqlConnection(cadena);
            SqlCommand cmdDdlL = new SqlCommand("select * from Linea", cn);
            cmdDdlL.CommandType = CommandType.Text;
            DataTable dtL = new DataTable();
            SqlCommand cmdDdlC = new SqlCommand("select * from Cliente", cn);
            cmdDdlC.CommandType = CommandType.Text;
            DataTable dtC = new DataTable();
            SqlCommand cmdDdlP = new SqlCommand("select * from Proveedor", cn);
            cmdDdlP.CommandType = CommandType.Text;
            DataTable dtP = new DataTable();
            cn.Open();
            dtL.Load(cmdDdlL.ExecuteReader());
            dtC.Load(cmdDdlC.ExecuteReader());
            dtP.Load(cmdDdlP.ExecuteReader());
            cn.Close();

            ddlLinea.DataSource = dtL;
            ddlLinea.DataTextField = "Nombre";
            ddlLinea.DataValueField = "id";
            ddlLinea.DataBind();

            ddlCliente.DataSource = dtC;
            ddlCliente.DataTextField = "Nombre";
            ddlCliente.DataValueField = "id";
            ddlCliente.DataBind();

            ddlProveedor.DataSource = dtP;
            ddlProveedor.DataTextField = "Nombre";
            ddlProveedor.DataValueField = "id";
            ddlProveedor.DataBind();
        }
    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(cadena); try
        {

            string id = txtId.Text;
            int IdLinea = int.Parse(ddlLinea.SelectedValue.ToString());
            int IdCliente = int.Parse(ddlCliente.SelectedValue.ToString());
            int IdProveedor = int.Parse(ddlProveedor.SelectedValue.ToString());
            string Nombre = txtNombre.Text;
            string Marca = txtMarca.Text;
            string Descripcion = txtDescripcion.Text;
            int Precio = Convert.ToInt32(TxtPrecio.Text);
            string comando = "insert into Producto values('" + IdLinea + "','" + IdCliente + "','" + IdProveedor + "','" + Nombre + "','" + Marca + "','" + Descripcion + "','" + Precio + "');";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = comando;
            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text; cn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblMensaje.Text = "Producto Registrado";
                cn.Close();
                txtId.Text = "";
                ddlLinea.SelectedIndex = 0;
                ddlCliente.SelectedIndex = 0;
                ddlProveedor.SelectedIndex = 0;
                txtNombre.Text = "";
                txtMarca.Text = "";
                txtDescripcion.Text = "";
                TxtPrecio.Text = "";

            }
        }
        catch (Exception ex) { lblMensaje.Text = ex.ToString(); }


    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(cadena);
        int id = int.Parse(txtId.Text); //sacamos el valor del campo eliminar 
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "delete from Producto where id=" + id + ";";
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

        string id = txtId.Text;
        int IdLinea = int.Parse(ddlLinea.SelectedValue.ToString());
        int IdCliente = int.Parse(ddlCliente.SelectedValue.ToString());
        int IdProveedor = int.Parse(ddlProveedor.SelectedValue.ToString());
        string Nombre = txtNombre.Text;
        string Marca = txtMarca.Text;
        string Descripcion = txtDescripcion.Text;
        int Precio = Convert.ToInt32(TxtPrecio.Text);

        cmd.CommandText = "update Producto set id_linea='" + IdLinea + "', Id_cliente='" + IdCliente + "'," + "Id_proveedor='" + IdProveedor + "'," + "Nombre='" + Nombre + "', Marca='" + Marca + "', Descripcion='" + Descripcion + "', Precio='" + Precio + "'  where id=" + id;
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
            SqlCommand cmd = new SqlCommand("select * from Producto", cn);
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



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class WfrmLinea : System.Web.UI.Page
{
    string cadena = "Data Source=LEONEL\\MSSQLSERVER2012; initial catalog=Cosmeticos; user=sa; password=12345";
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
   SqlConnection cn = new SqlConnection(cadena); 
        try
        {

            string id = txtid.Text;
            string Nombre = txtNombre.Text;
            string comando = "insert into Linea values('" + Nombre + "');";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = comando;
            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text; cn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblMensaje.Text = "Línea Registrada";
                cn.Close();
                txtid.Text = "";
                txtNombre.Text = "";

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
        cmd.CommandText = "delete from Linea where id=" + id + ";";
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
        string Nombre = txtNombre.Text;

        cmd.CommandText = "update Linea set Nombre='" + Nombre + "'  where id=" + id;
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
            SqlCommand cmd = new SqlCommand("select * from Linea", cn);
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
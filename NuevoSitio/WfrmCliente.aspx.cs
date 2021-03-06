﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class WfrmCliente : System.Web.UI.Page
{
    string cadena = "Data Source=LEONEL\\MSSQLSERVER2012; initial catalog=Cosmeticos; user=sa; password=12345";


    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(cadena); try
        {

            string id = txtid.Text;
            string Nombre = txtNombre.Text;
            string Apepat = txtApepat.Text;
            string Direccion = TxtDireccion.Text;
            string Telefono = TxtTelefono.Text;
            string Sexo = TxtSexo.Text;
            string Correo = TxtCorreo.Text;
            string comando = "insert into Cliente values('" + Nombre + "','" + Apepat + "','" + Direccion + "','" + Telefono + "','" + Sexo + "','" + Correo + "');";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = comando;
            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text; cn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblMensaje.Text = "Cliente Registrado";
                cn.Close();
                txtid.Text = "";
                txtNombre.Text = "";
                txtApepat.Text = "";
                TxtDireccion.Text = "";
                TxtTelefono.Text = "";
                TxtSexo.Text = "";
                TxtCorreo.Text = "";

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
        cmd.CommandText = "delete from Cliente where id=" + id + ";";
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
        string Apepat = txtApepat.Text;
        string Direccion = TxtDireccion.Text;
        string Telefono = TxtTelefono.Text;
        string Sexo = TxtSexo.Text;
        string Correo = TxtCorreo.Text;

        cmd.CommandText = "update Cliente set Nombre='" + Nombre + "'," + "Apepat='" + Apepat + "'," + " Direccion='" + Direccion + "'," + "Telefono='" + Telefono + "'," + "Sexo='" + Sexo + "'," + "Correo='" + Correo + "'  where id=" + id;
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
            SqlCommand cmd = new SqlCommand("select * from Cliente", cn);
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



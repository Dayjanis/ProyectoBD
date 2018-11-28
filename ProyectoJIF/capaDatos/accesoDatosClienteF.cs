using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosClienteF
    {
        SqlConnection cnx;
        ClienteF cl = new ClienteF();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<ClienteF> listaClien = null;

        public int insertarClienteF(ClienteF cl)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoClienteF", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idCliente", "");
                cm.Parameters.AddWithValue("@nombre", cl.nombre);
                cm.Parameters.AddWithValue("@apellido", cl.apellido);
                cm.Parameters.AddWithValue("@telefono", cl.telefono);
              

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally { cm.Connection.Close(); }
            return indicador;
        }
        public List<ClienteF> ListarClientes()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoClienteF", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idCliente", "");
                cm.Parameters.AddWithValue("@nombre", "");
                cm.Parameters.AddWithValue("@apellido", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClien = new List<ClienteF>();
                while (dr.Read())
                {
                    ClienteF c = new ClienteF();
                    c.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    c.nombre = dr["nombre"].ToString();
                    c.apellido = dr["apellido"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    listaClien.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaClien = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaClien;
        }


        public int EliminarCliente(int idCliente)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoClienteF", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idCliente", idCliente);
                cm.Parameters.AddWithValue("@nombre", "");
                cm.Parameters.AddWithValue("@apellido", "");
                cm.Parameters.AddWithValue("@telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            { cm.Connection.Close(); }
            return indicador;
        }

        public int EditarCliente(ClienteF cl)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoClienteF", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idCliente", cl.idCliente);
                cm.Parameters.AddWithValue("@nombre", cl.nombre);
                cm.Parameters.AddWithValue("@apellido", cl.apellido);
                cm.Parameters.AddWithValue("@telefono", cl.telefono);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally { cm.Connection.Close(); }
            return indicador;
        }

        public ClienteF BuscarClienteXcodigo(int idclien)
        {
            ClienteF cl = new ClienteF();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoClienteF", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idCliente", idclien);
                cm.Parameters.AddWithValue("@nombre", "");
                cm.Parameters.AddWithValue("@apellido", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();

                cl.idCliente = Convert.ToInt32(dr["idcliente"].ToString());
                cl.nombre = dr["nombre"].ToString();
                cl.apellido = dr["apellido"].ToString();
                cl.telefono = dr["telefono"].ToString();
            }
            catch (Exception e)
            {
                e.Message.ToString();
                cl = null;
            }
            finally
            {
                cm.Connection.Close();

            }
            return cl;
        }
        public List<ClienteF> BuscaClienteDatos(String dato)
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoClienteF", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@idCliente", "");
                cm.Parameters.AddWithValue("@nombre", dato);
                cm.Parameters.AddWithValue("@apellido", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClien = new List<ClienteF>();
                while (dr.Read())
                {
                    ClienteF c = new ClienteF();
                    c.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    c.nombre = dr["nombre"].ToString();
                    c.apellido = dr["apellido"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    listaClien.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaClien = null;
            }
            finally { cm.Connection.Close(); }
            return listaClien;
        }
    }
}

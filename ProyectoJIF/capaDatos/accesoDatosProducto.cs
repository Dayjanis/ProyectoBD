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
    public class accesoDatosProducto
    {
        SqlConnection cnx;
        Producto pr = new Producto();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Producto> listaProd = null;


        public int insertarProducto(Producto pro)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@id_producto", "");
                cm.Parameters.AddWithValue("@nombre", pro.nombre);
                cm.Parameters.AddWithValue("@marca", pro.marca);
                cm.Parameters.AddWithValue("@precio", pro.precio);

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
        public List<Producto> ListarProductos()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@id_producto", "");
                cm.Parameters.AddWithValue("@nombre", "");
                cm.Parameters.AddWithValue("@marca", "");
                cm.Parameters.AddWithValue("@precio", 0);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProd = new List<Producto>();
                while (dr.Read())
                {
                    Producto pr = new Producto();
                    pr.id_producto = Convert.ToInt32(dr["id_producto"].ToString());
                    pr.nombre = dr["nombre"].ToString();
                    pr.marca = dr["marca"].ToString();
                    pr.precio = double.Parse(dr["precio"].ToString());

                    listaProd.Add(pr);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProd = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaProd;
        }

        public int EliminarProducto(int id_producto)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@id_producto", id_producto);
                cm.Parameters.AddWithValue("@nombre", "");
                cm.Parameters.AddWithValue("@marca", "");
                cm.Parameters.AddWithValue("@precio", 0);


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

        public int EditarProducto(Producto pd)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@id_producto", pd.id_producto);
                cm.Parameters.AddWithValue("@nombre", pd.nombre);
                cm.Parameters.AddWithValue("@marca", pd.marca);
                cm.Parameters.AddWithValue("@precio", pd.precio);


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

        public Producto BuscarProductoXCodigo(int idProd)
        {
            Producto pr = new Producto();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@id_producto", idProd);
                cm.Parameters.AddWithValue("@nombre", "");
                cm.Parameters.AddWithValue("@marca", "");
                cm.Parameters.AddWithValue("@precio", 0);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();

                pr.id_producto = Convert.ToInt32(dr["id_producto"].ToString());
                pr.nombre = dr["nombre"].ToString();
                pr.marca = dr["marca"].ToString();
                pr.precio = double.Parse(dr["precio"].ToString());

            }
            catch (Exception e)
            {
                e.Message.ToString();
                pr = null;
            }
            finally
            {
                cm.Connection.Close();

            }
            return pr;
        }

        public List<Producto> BuscaProductoDatos(String dato)
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@id_producto", "");
                cm.Parameters.AddWithValue("@nombre", dato);
                cm.Parameters.AddWithValue("@marca", "");
                cm.Parameters.AddWithValue("@precio", 0);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProd = new List<Producto>();
                while (dr.Read())
                {
                    Producto pr = new Producto();
                    pr.id_producto = Convert.ToInt32(dr["id_producto"].ToString());
                    pr.nombre = dr["nombre"].ToString();
                    pr.marca = dr["marca"].ToString();
                    pr.precio = double.Parse(dr["precio"].ToString());
                    listaProd.Add(pr);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProd = null;
            }
            finally { cm.Connection.Close(); }
            return listaProd;
        }
    }
}

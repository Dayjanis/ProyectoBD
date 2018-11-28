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
   public  class AccesoDatoProducto
    {
        SqlConnection cnx; //conexion
        Producto pro = new Producto(); //capa de entidad
        Conexion cn = new Conexion();//para la cobexion
        SqlCommand pr = null; //para los comando sql
        int indicador = 0; //variablae k indica si el metodo se ejecuto
        SqlDataReader dr = null;
        List<Producto> listaprod = null;

        #region metodo insertar
        public int insertarProducto(Producto prod)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //conexion
                pr = new SqlCommand("nuevoProducto", cnx);

                pr.Parameters.AddWithValue("@b", 1);
                pr.Parameters.AddWithValue("@id_producto", "");
                pr.Parameters.AddWithValue("@descripcion", pro.descripcion);
         

                pr.CommandType = CommandType.StoredProcedure; //PARA EL PROCEDIMIENTO ALMACENADO
                cnx.Open();
                pr.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally { pr.Connection.Close(); }
            return indicador;
    }

        public int insertarProducto(compra prod)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region metodoListar
        public List<Producto> listarProduc()
        {
            try
            {
                SqlConnection cnx = cn.conectar();//conexion
                pr = new SqlCommand("nuevoProducto", cnx);
                pr.Parameters.AddWithValue("@b", 2);
                pr.Parameters.AddWithValue("@idProducto", "");
                pr.Parameters.AddWithValue("@Descripcion", "");
              
                pr.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = pr.ExecuteReader();
                listaprod = new List<Producto>();
                while (dr.Read()) 

                {
                    Producto p = new Producto();
                    p.id_producto = Convert.ToInt32(dr["id_producto"].ToString());
                    p.descripcion = dr["descripcion"].ToString();
       
                    listaprod.Add(pro);

                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaprod = null;
                throw;
            }
            finally
            {
                pr.Connection.Close();

            }
            return listaprod;
        }
        #endregion

        #region metodo eliminar
        public int EliminarProducto(int idproducto)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //conexion
                pr = new SqlCommand("nuevoProveedor", cnx);
                pr.Parameters.AddWithValue("@b", 4);
                pr.Parameters.AddWithValue("@idProducto", idproducto);
                pr.Parameters.AddWithValue("@descripcion", "");
              

                pr.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                pr.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
                throw;
            }
            finally
            { pr.Connection.Close(); }
            return indicador;
        }
        #endregion

        #region metodo editar
        public int EditarProducto(Producto pro)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); // conexion

                pr = new SqlCommand("nuevoProducto", cnx);
                pr.Parameters.AddWithValue("@b", 3);
                pr.Parameters.AddWithValue("@idproducto", pro.id_producto);
                pr.Parameters.AddWithValue("@descripcion", pro.descripcion);
                
                pr.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                pr.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
                throw;
            }
            finally { pr.Connection.Close(); }
            return indicador;

        }
        #endregion     

        #region metodo Buscar Producto por codigo
        public  Producto BuscarProductorXcodigo(int idprod)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                pr = new SqlCommand("nuevoProveedor", cnx);
                pr.Parameters.AddWithValue("@b", 5);
                pr.Parameters.AddWithValue("@idProducto", idprod);
                pr.Parameters.AddWithValue("@descripcion", "");
               
                cnx.Open();
                dr = pr.ExecuteReader();
                dr.Read();
                pro.id_producto = Convert.ToInt32(dr["idProducto"].ToString());
                pro.descripcion = dr["descripcion"].ToString();
               
   

            }
            catch (Exception e)
            {
                e.Message.ToString();
                pro = null;
                throw;
            }
            finally
            { pr.Connection.Close(); }
            return pro;
        }
        #endregion

    }

}

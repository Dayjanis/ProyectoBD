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
   public class accesoDatoProd_Prove
    {
        SqlConnection cnx; 
        prod_prove pro= new prod_prove(); 
        Conexion cn = new Conexion();
        SqlCommand prop = null; 
        int indicador = 0;
        SqlDataReader dr = null;
        List<prod_prove> listaprod_prov = null;

#region metodo insertar
        public int insertarProd_Prove(prod_prove pp)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                prop = new SqlCommand("nuevo pro_prove", cnx);
                // cm.Parameters.AddWithValue("@b", 1);
                prop.Parameters.AddWithValue("@idpp", "");
                prop.Parameters.AddWithValue("@precio", pp.Precio);
                prop.Parameters.AddWithValue("@cantidad", pp.cantidad);
                prop.Parameters.AddWithValue("@id_producto", pro.idproducto);
                prop.Parameters.AddWithValue("@idcodigoP", pro.idcodigoP);


                prop.CommandType = CommandType.StoredProcedure; //PARA EL PROCEDIMIENTO ALMACENADO
                cnx.Open();
                prop.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally { prop.Connection.Close(); }
            return indicador;
        }
#endregion
             #region metodoListar
        public List<proeveedore> ListarProd_pro()
        {
            try
            {
                SqlConnection cnx = cn.conectar();//conexion
                prop = new SqlCommand("nuevoProduct_Proveedor", cnx);
                prop.Parameters.AddWithValue("@b", 2);
                prop.Parameters.AddWithValue("@idPP", "");
                prop.Parameters.AddWithValue("@precio", "");
                prop.Parameters.AddWithValue("@cantidad", "");
                prop.Parameters.AddWithValue("@idProducto", "");
                prop.Parameters.AddWithValue("@idcodigoP", "");
                prop.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = prop.ExecuteReader();
                listaprod_prov = new List<prod_prove>();
                while (dr.Read())

                {
                    prod_prove p = new prod_prove();
                    p.idPP = Convert.ToInt32(dr["idPP"].ToString());
                    p.Precio = dr["precio"].ToString();
                    p.cantidad = dr["cantidad"].ToString();
                    p.idproducto = dr["idProducto"].ToString();
                    p.idcodigoP = dr["idcodigoP"].ToString();
                    listaprod_prov.Add(p);
                
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaprod_prov = null;
                throw;
            }
         finally 
            {
                prop.Connection.Close();
            
            }
            return Listaprod_prov;
        }
        #endregion

        #region metodo eliminar
        public int EliminarProd_Prove(int idprod_p)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //conexion
                prop = new SqlCommand("nuevoProveedor", cnx);
                prop.Parameters.AddWithValue("@b", 4);
                prop.Parameters.AddWithValue("@idPP", idprod_p);
                prop.Parameters.AddWithValue("@Precio", "");
                prop.Parameters.AddWithValue("@cantidad", "");
                prop.Parameters.AddWithValue("@id_producto", "");
                prop.Parameters.AddWithValue("@idcodigoP", "");

                prop.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                prop.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
                throw;
            }
            finally
            { prop.Connection.Close(); }
            return indicador;
        }
        #endregion

        #region metodo editar
        public int EditarProd_prov(prod_prove pdPv)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); // conexion

                prop = new SqlCommand("nuevoProveedor", cnx);
                prop.Parameters.AddWithValue("@b", 3);
                prop.Parameters.AddWithValue("@idPP", pdPv.idPP);
                prop.Parameters.AddWithValue("@precio", pdPv.Precio);
                prop.Parameters.AddWithValue("@cantidad", pdPv.cantidad);
                prop.Parameters.AddWithValue("@id_producto",pdPv.idproducto);
                prop.Parameters.AddWithValue("@idcodigoP", pdPv.idcodigoP);

                prop.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                prop.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
                throw;
            }
            finally { prop.Connection.Close(); }
            return indicador;

        }
        #endregion     

        #region metodo Buscar Proveedor por codigo
        public proeveedore BuscarProdPveedorXcodigo(int idpro)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                prop = new SqlCommand("nuevoproductoProveedor", cnx);
                prop.Parameters.AddWithValue("@b", 5);
                prop.Parameters.AddWithValue("@idPP", idpro);
                prop.Parameters.AddWithValue("@Precio", "");
                prop.Parameters.AddWithValue("@Cantidad", "");
                prop.Parameters.AddWithValue("@idproducto", "");
                prop.Parameters.AddWithValue("@idcodigoP", "");
                prop.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = prop.ExecuteReader();
                dr.Read();
                pro.idPP = Convert.ToInt32(dr["idPP"].ToString());
                pro.Precio = dr["precio"].ToString();
                pro.cantidad = dr["cantidad"].ToString();
                pro.idcodigoP = dr["idcodigoP"].ToString();

            }
            catch (Exception e)
            {
                e.Message.ToString();
                pro = null;
                throw;
            }
            finally
            { prop.Connection.Close(); }
            return pro;
        }
        #endregion

        public List<proeveedore> Listaprod_prov { get; set; }
    }
}

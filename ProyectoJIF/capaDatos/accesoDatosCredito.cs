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
    public class accesoDatosCredito
    {
        SqlConnection cnx;
        Credito cr = new Credito();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Credito> listaCredito = null;

        public int insertarCredito(Credito cr)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoCredito", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@id_credito", "");
                cm.Parameters.AddWithValue("@Fecha_inicio", cr.Fecha_inicio);
                cm.Parameters.AddWithValue("@Fecha_cancelacion", cr.Fecha_cancelacion);
                cm.Parameters.AddWithValue("@monto_total", cr.monto_total);
                cm.Parameters.AddWithValue("@estado", cr.estado);
                cm.Parameters.AddWithValue("@idCliente", cr.idCliente);

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

        public List<Credito> ListarCreditos()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoCredito", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@id_credito", "");
                cm.Parameters.AddWithValue("@Fecha_inicio", "");
                cm.Parameters.AddWithValue("@Fecha_cancelacion", "");
                cm.Parameters.AddWithValue("@monto_total", 0);
                cm.Parameters.AddWithValue("@estado", "");
                cm.Parameters.AddWithValue("@idCliente", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCredito = new List<Credito>();
                while (dr.Read())
                {
                    Credito c = new Credito();
                    c.id_credito = Convert.ToInt32(dr["id_credito"].ToString());
                    c.Fecha_inicio = dr["Fecha_inicio"].ToString();
                    c.Fecha_cancelacion = dr["Fecha_cancelacion"].ToString();
                    c.monto_total = double.Parse(dr["monto_total"].ToString());
                    c.estado = dr["estado"].ToString();
                    c.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    listaCredito.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCredito = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCredito;
        }


        public int EliminarCredito(int id_credito)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoCredito", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@id_credito", id_credito);
                cm.Parameters.AddWithValue("@Fecha_inicio", "");
                cm.Parameters.AddWithValue("@Fecha_cancelacion", "");
                cm.Parameters.AddWithValue("@monto_total", 0);
                cm.Parameters.AddWithValue("@estado", "");
                cm.Parameters.AddWithValue("@idCliente","");

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

        public int EditarCredito(Credito cr)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoCredito", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@id_credito", cr.id_credito);
                cm.Parameters.AddWithValue("@Fecha_inicio", cr.Fecha_inicio);
                cm.Parameters.AddWithValue("@Fecha_cancelacion", cr.Fecha_cancelacion);
                cm.Parameters.AddWithValue("@monto_total", cr.monto_total);
                cm.Parameters.AddWithValue("@estado", cr.estado);
                cm.Parameters.AddWithValue("@idCliente", cr.idCliente);

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

         public Credito BuscarCreditoXcodigo(int idcred)
        {
            Credito cre = new Credito();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoCredito", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@id_credito", idcred);
                cm.Parameters.AddWithValue("@Fecha_inicio", "");
                cm.Parameters.AddWithValue("@Fecha_cancelacion", "");
                cm.Parameters.AddWithValue("@monto_total", 0);
                cm.Parameters.AddWithValue("@estado", "");
                cm.Parameters.AddWithValue("@idCliente","");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();

                cr.id_credito = Convert.ToInt32(dr["id_credito"].ToString());
                cr.Fecha_inicio = dr["Fecha_inicio"].ToString();
                cr.Fecha_cancelacion = dr["Fecha_cancelacion"].ToString();
                cr.monto_total = double.Parse(dr["monto_total"].ToString());
                cr.estado =dr["estado"].ToString();
                cr.idCliente = Convert.ToInt32(dr["idCliente"].ToString());


            }
            catch (Exception e)
            {
                e.Message.ToString();
                cre = null;
            }
            finally
            {
                cm.Connection.Close();

            }
            return cre;
        }
         public List<Credito> BuscaCreditoDatos(String dato)
         {

             try
             {
                 SqlConnection cnx = cn.conectar();
                 cm = new SqlCommand("nuevoCredito", cnx);
                 cm.Parameters.AddWithValue("@b", 6);
                 cm.Parameters.AddWithValue("@id_credito", "");
                 cm.Parameters.AddWithValue("@Fecha_inicio", "");
                 cm.Parameters.AddWithValue("@Fecha_cancelacion", "");
                 cm.Parameters.AddWithValue("@monto_total", 0);
                 cm.Parameters.AddWithValue("@estado", dato);
                 cm.Parameters.AddWithValue("@idCliente","");
                 cm.CommandType = CommandType.StoredProcedure;
                 cnx.Open();
                 dr = cm.ExecuteReader();
                 listaCredito = new List<Credito>();
                 while (dr.Read())
                 {
                     Credito cr = new Credito();
                     cr.id_credito = Convert.ToInt32(dr["id_credito"].ToString());
                     cr.Fecha_inicio = dr["Fecha_inicio"].ToString();
                     cr.Fecha_cancelacion = dr["Fecha_cancelacion"].ToString();
                     cr.monto_total = double.Parse(dr["monto_total"].ToString());
                     cr.estado = dr["estado"].ToString();
                     cr.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                     listaCredito.Add(cr);
                 }

             }
             catch (Exception e)
             {
                 e.Message.ToString();
                 listaCredito = null;
             }
             finally { cm.Connection.Close(); }
             return listaCredito;
         }
    }
}

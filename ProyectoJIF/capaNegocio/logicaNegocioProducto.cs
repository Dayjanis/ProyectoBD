using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioProducto
    {
        accesoDatosProducto adp = new accesoDatosProducto();
        public int insertarProducto(Producto pro)
        {
            return adp.insertarProducto(pro);
        }
        public List<Producto> ListarProductos()
        {
            return adp.ListarProductos();
        }
        public int EditarProducto(Producto pr)
        {
            return adp.EditarProducto(pr);
        }
        public int EliminarProducto(int id_producto)
        {
            return adp.EliminarProducto(id_producto);
        }
        public Producto BuscarProductoXCodigo(int idProd)
        {
            return adp.BuscarProductoXCodigo (idProd);
        }
        public List<Producto> BuscaProductoDatos(String dato)
        {
            return adp.BuscaProductoDatos(dato);
        }
    }
}

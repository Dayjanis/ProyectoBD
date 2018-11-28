using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioProd_prove
    {
        accesoDatosProd_prove app = new accesoDatosProd_prove();
        public int insertarProd_prove(prod_prove pp)
        {
            return app.insertarProd_prove(pp);
        }

        public List<prod_prove> ListarProd_prove()
        {
            return app.ListarProd_prove();
        }
        public int EditarProd_prove(prod_prove pp)
        {
            return app.EditarProd_prove(pp);
        }
        public int EliminarProd_prove(int id_pp)
        {
            return app.EliminarProd_prove(id_pp);
        }
        public prod_prove BuscarProd_proveXcodigo(int idpp)
        {
            return app.BuscarProd_proveXcodigo(idpp);
        }
        public List<prod_prove> BuscaProd_proveDatos(String dato)
        {
            return app.BuscaProd_proveDatos(dato);
        }
    }
}
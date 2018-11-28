using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class CapaNegocioProd_Prove
    {
        
        accesoDatoProd_Prove pro_pro = new accesoDatoProd_Prove();
        public int insertarProd_Prove(prod_prove pp)
        {
            return prod_prove.insertarprod_Prove(pp);
        }

        public List<prod_prove> ListarProd_pro()
        {
            return pro_pro.ListarProd_pro();
        }

        public int EditarProd_prov(prod_prove pdPv)
        {
            return pro_pro.EditarProd_prov(pdPv);
        }

        public int EliminarProd_Prove(int idprod_p)
        {
            return pro_pro.EliminarProd_Prove(idprod_p);
        }

        public prod_prove BuscarProdPveedorXcodigo(int idpro)
        {
            return pro_pro.BuscarProdPveedorXcodigo(idpro);
        }
    }
}

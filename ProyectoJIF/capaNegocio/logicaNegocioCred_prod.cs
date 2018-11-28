using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioCred_prod
    {
        accesoDatosCred_Prod acp = new accesoDatosCred_Prod();

        public int insertarCred_Prod(Cred_Prod cp)
        {
            return acp.insertarCred_Prod(cp);
        }
        public List<Cred_Prod> ListarCred_Prod()
        {
            return acp.ListarCred_Prod();
        }
        public int EditarCred_prod(Cred_Prod cp)
        {
            return acp.EditarCred_Prod(cp);
        }
        public int EliminarCred_Prod(int id_cp)
        {
            return acp.EliminarCred_prod(id_cp);
        }
        public Cred_Prod BuscarCred_prodXcodigo(int idcp)
        {
            return acp.BuscarCred_prodXcodigo(idcp);
        }
        public List<Cred_Prod> BuscaCred_prodDatos(string dato)
        {
            return acp.BuscaCred_prodDatos(dato);
        }
    }
}

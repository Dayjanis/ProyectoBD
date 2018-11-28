using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Credito
    {
        public int id_credito { get; set; }
        public String Fecha_inicio { get; set; }
        public String Fecha_cancelacion { get; set; }
        public double monto_total { get; set; }        
        public String estado { get; set; }
        public int idCliente { get; set; }
        
    }
}

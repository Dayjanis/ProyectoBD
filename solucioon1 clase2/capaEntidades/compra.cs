using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace capaEntidades
{
    public class Compra
    {
        public int idcompra{ get; set; }
        public string fecha { get; set; }
        public Double precioC { get; set; }
        public int cantidad { get; set; }
        public int id_producto { get; set; }
        public int idcodigoC { get; set; }
    }
}

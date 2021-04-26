using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class PuntosDeInteres
    {

            public int Id { get; set; }
            public decimal Latitud { get; set; }
            public decimal Longitud { get; set; }
            public string Descripcion { get; set; }
            public decimal Venta { get; set; }
            public Nullable<int> Idzona { get; set; }
            public string Zona { get; set; }

    }
}

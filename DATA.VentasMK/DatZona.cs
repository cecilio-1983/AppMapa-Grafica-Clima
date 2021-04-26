using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace DATA.VentasMK
{
    public class DatZona
    {
        public List<Zonas> GetAll() 
        {
            try
            {
                using (VentasMkEntities db = new VentasMkEntities()) 
                {
                    return db.Zonas.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<Ventas> GetVentasPorZona()
        {
            try
            {
                using (VentasMkEntities db = new VentasMkEntities())
                {
                    var result = from zo in db.Zonas
                                 join pi in db.puntos_de_interes
                                 on zo.Id equals pi.Idzona
                                 select new { zo.Id, zo.Descripcion, pi.Venta } into ve
                                 group ve by new { ve.Id } into to
                                 select new Ventas
                                 {
                                     Descripcion = to.Select(d => d.Descripcion).Max(),
                                     VentasTotales = to.Select(x => x.Venta).Sum()
                                 };

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

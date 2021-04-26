using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using DATA.VentasMK;

namespace BUSINESS.VentasMK
{
    public class BusZonas
    {
        private DatZona dat = new DatZona();

        public List<Zonas> GetAll()
        {
            try
            {
                return dat.GetAll();
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
                return dat.GetVentasPorZona();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}

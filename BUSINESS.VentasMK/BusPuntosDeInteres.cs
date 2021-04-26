using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using DATA.VentasMK;

namespace BUSINESS.VentasMK
{
    public class BusPuntosDeInteres
    {
        private DatPuntosDeInteres dat = new DatPuntosDeInteres();

      
        public List<puntos_de_interes> GetAll()
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
        public puntos_de_interes GetById(int Id)
        {
            try
            {

               return dat.GetById(Id);
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public int AddOrUpdate(puntos_de_interes item)
        {
            try
            {
                    return dat.AddOrUpdate(item);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public int Delete(puntos_de_interes item)
        {
            try
            {
                
                  return  dat.Delete(item);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

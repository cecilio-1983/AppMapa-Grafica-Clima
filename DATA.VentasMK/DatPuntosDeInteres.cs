using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace DATA.VentasMK
{
    public class DatPuntosDeInteres
    {

        public List<puntos_de_interes>  GetAll()
        {
            try
            {
                using (VentasMkEntities db = new VentasMkEntities())
                {

                    

                  return db.puntos_de_interes.ToList();

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public  puntos_de_interes GetById(int Id) 
        {
            try
            {
                using (VentasMkEntities db = new VentasMkEntities()) 
                {
                    return db.puntos_de_interes.Where(pi => pi.Id.Equals(Id)).FirstOrDefault();
                }
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
                using (VentasMkEntities db = new VentasMkEntities()) 
                {
                    //En caso de que la propiedad Id sea 0 creara un nuevo Registro
                    //en caso contrario actualizara el registro
                    db.Entry(item).State = item.Id == 0 ? EntityState.Added: EntityState.Modified ;
                    
                    return db.SaveChanges();
                }
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
                using (VentasMkEntities db = new VentasMkEntities()) 
                {
                    var puntoDeInteres = db.puntos_de_interes.Where(p => p.Id.Equals(item.Id)).FirstOrDefault();

                    if (!(puntoDeInteres == null)) db.puntos_de_interes.Remove(puntoDeInteres);

                    db.puntos_de_interes.Remove(puntoDeInteres);
                    return db.SaveChanges();
                }
            }
            catch (Exception ex )
            {

                throw;
            }
        }
    }
}

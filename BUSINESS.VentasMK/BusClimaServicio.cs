using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using DATA.VentasMK;
using Newtonsoft.Json;

namespace BUSINESS.VentasMK
{
    public class BusClimaServicio
    {
        private DatClimaServicio dat = new DatClimaServicio();
        public CurrentWeather GetCurrentWeather(string ciudad, string key)
        {
            CurrentWeather result = new CurrentWeather();
            try
            {
               result = JsonConvert.DeserializeObject<CurrentWeather>(dat.GetCurrentWeather());
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Cors;
using BUSINESS.VentasMK;
using ENTITIES;

namespace UI2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClimaController : ApiController
    {
        private Log logger = new Log(HostingEnvironment.ApplicationPhysicalPath + "Logs/Log_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log");
        private BusClimaServicio bus = new BusClimaServicio();

        [HttpGet]
        public ResultProcessObject<ENTITIES.CurrentWeather> Get(string ciudad,string key)
        {
            var _response = new ResultProcessObject<ENTITIES.CurrentWeather>();
            try
            {
                _response.Entity = bus.GetCurrentWeather(ciudad , key);
                return _response;
            }
            catch (Exception ex)
            {

                logger.EscribirLog(ex);
                _response.Success = false;
                _response.Entity = null;
                _response.Message = "No fue posible obtener la información del clima";
                return _response;
            }
        }
    }
}

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
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class PuntoDeInteresController : ApiController
    {
        private Log logger = new Log(HostingEnvironment.ApplicationPhysicalPath + "Logs/Log_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log");
        private BusPuntosDeInteres bus = new BusPuntosDeInteres();
        [Route("api/PuntosDeInteres/GetAll")]
        [HttpGet]
        public ResultProcessObject<IEnumerable<puntos_de_interes>> GetAll()
        {
           
           var _response = new ResultProcessObject<IEnumerable<puntos_de_interes>>();
            try
            {
                _response.Entity = bus.GetAll();
                return _response;
            }
            catch (Exception ex)
            {

                logger.EscribirLog(ex);
                _response.Success = false;
                _response.Entity = null;
                _response.Message = "No fue posible obtener los Puntos de Interes";
                return _response;
            }
        }
    }
}

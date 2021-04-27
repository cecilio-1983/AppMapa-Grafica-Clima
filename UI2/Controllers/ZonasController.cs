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
    public class ZonasController : ApiController
    {
        private Log logger = new Log(HostingEnvironment.ApplicationPhysicalPath + "Logs/Log_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log");
        private BusZonas bus = new BusZonas();

        [Route("api/Zonas/GetAll")]
        [HttpGet]
        public ResultProcessObject<IEnumerable<Zonas>> GetAll()
        {
            var _response = new ResultProcessObject<IEnumerable<Zonas>>();
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
                _response.Message = "No fue posible obtener el listado de Zonas";
                return _response;
            }
        }
        [Route("api/Zonas/GetVentas")]
        [HttpGet]
        public ResultProcessObject<IEnumerable<Ventas>> GetVentasPorZona()
        {
            var _response = new ResultProcessObject<IEnumerable<Ventas>>();
            try
            {
                _response.Entity = bus.GetVentasPorZona();
                return _response;
            }
            catch (Exception ex)
            {
                logger.EscribirLog(ex);
                _response.Success = false;
                _response.Entity = null;
                _response.Message = "No fue posible obtener las ventas por Zonas";
                return _response;
            }
        }
    }
}

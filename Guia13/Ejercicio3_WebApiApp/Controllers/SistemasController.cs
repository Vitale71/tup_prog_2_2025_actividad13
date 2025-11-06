using Ejercicio1_Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio3_WebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemasController : ControllerBase
    {
        [HttpPost("DescargarCamion")]
        public ActionResult PostDescargarCamion(IFormFile manifiesto)
        {
            Stream s = manifiesto.OpenReadStream();
            sistema.Descargar(s);
            return Ok();
        }

        Sistema sistema = new Sistema();
        // GET: api/<SistemasController>
        [HttpGet("CamionesCargados")]
        public ActionResult<string[]> GetCamionesCargados()
        {
            string[] camiones = sistema.CamionesCargados();
            if (camiones == null || camiones.Length == 0)
            {
                return NotFound("No hay camiones cargados.");
            }
            return Ok(camiones);
        }
        [HttpGet("ListaPaquetes")]
        public ActionResult<List<Paquete>> GetListaPaquetes()
        {
            return Ok(sistema.ListaPaquetes);
        }

        [HttpGet("AgregarPaqueteDelCamion/{posicion}")]
        public ActionResult<List<Paquete>> getAgregarPaqueteDelCamion(int pos)
        {
            Paquete paquete = null;
            for (int i = 0; i <sistema.ListaPaquetes.Count && paquete == null; i++)
            {
                if (sistema.ListaPaquetes[i].ZonaDestino == "3")
                {
                    paquete = sistema.ListaPaquetes [i];
                }
            }
            for (int i = 0; i < sistema.ListaPaquetes.Count && paquete == null; i++)
            {
                if (sistema.ListaPaquetes[i].ZonaDestino == "2")
                {
                    paquete = sistema.ListaPaquetes[i];
                }
            }
            for (int i = 0; i < sistema.ListaPaquetes.Count && paquete == null; i++)
            {
                if (sistema.ListaPaquetes[i].ZonaDestino == "1")
                {
                    paquete = sistema.ListaPaquetes[i];
                }
            }

            return Ok(sistema.ListaPaquetes);
        }
    }
}

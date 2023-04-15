using Microsoft.AspNetCore.Mvc;
using WebMVC_PWA.Data;
using WebMVC_PWA.Models;

namespace WebMVC_PWA.Controllers
{
    public class equipoController : Controller
    {
        private readonly EquipoContext _equipoContext;

        public equipoController(EquipoContext equipoContext)
        {
            _equipoContext = equipoContext;
        }

        public IActionResult Index()
        {
            ViewBag.listadoEquipos = listadoTipoEquipos();
            ViewBag.listadoMarcas = listadoMarcas();

            return View();
        }

        // METODO PARA OBTENER VALORES}
        public List<TipoEquipos> listadoTipoEquipos()
        {
            List<TipoEquipos> listadoTipoEquipo = _equipoContext.tipo_equipo.Where(x => x.estado == "A").ToList();

            return listadoTipoEquipo;
        }

        public List<marcas> listadoMarcas()
        {
            List<marcas> listadoMarcas = _equipoContext.marcas.Where(x => x.estados == "A").ToList();

            return listadoMarcas;
        }
    }
}

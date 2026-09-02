using DTOs.DataTransferObjects.DTOAutor;
using Libreria.LogicaAplicacion.ICasosUso.ICUAutor;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaWebAppMVC.Controllers
{
    public class AutorController : Controller
    {
        private ICUObtenerAutores _CuObtenerAutores;

        public AutorController(ICUObtenerAutores CuObtenerAutores)
        {
            _CuObtenerAutores = CuObtenerAutores;
        }
        public IActionResult Index()
        {
            List<DTOAutor> autores = _CuObtenerAutores.Ejecutar();
            return View(autores);
        }
    }
}

using Libreria.LogicaAplicaion.CasosUso.CUPais;
using Libreria.LogicaNegocio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaWebAppMVC.Controllers
{
    public class PaisController : Controller
    {
        private CUAltaPais cUAltaPais = new CUAltaPais();

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(Pais p)
        {
            cUAltaPais.Ejecutar(p);
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using DTOs.DataTransferObjects.DTOPais;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaWebAppMVC.Controllers
{
    public class PaisController : Controller
    {
        private ICUAltaPais _CuAltaPais;
        private ICUObtenerPaises _CuObtenerPaises;
        private ICUObtenerPaisXCodigo _CuObtenerPaisXCodigo;

        public PaisController(ICUAltaPais cUAltaPais,
                              ICUObtenerPaises cUObtenerPaises,
                              ICUObtenerPaisXCodigo cUObtenerPaisXCodigo)
        {
            _CuAltaPais = cUAltaPais;
            _CuObtenerPaises = cUObtenerPaises;
            _CuObtenerPaisXCodigo = cUObtenerPaisXCodigo;
        }

        public IActionResult Details(string codigo)
        {
            Pais Buscado = _CuObtenerPaisXCodigo.Ejecutar(codigo);
            return View(Buscado);
        }

        public IActionResult Index()
        {
            List<DTOPais> TodosLosPaises = _CuObtenerPaises.Ejecutar();
            return View(TodosLosPaises);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DTOAltaPais p)
        {
            try
            {
                _CuAltaPais.Ejecutar(p);
                ViewBag.msg = "País agregado correctamente.";
            }
            catch (Exception)
            {
                ViewBag.msg = "Error al agregar el país.";
            }
            return View();
        }
    }
}
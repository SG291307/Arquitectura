using DTOs.DataTransferObjects.DTOPais;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.CustomExceptions.Genericas;
using Libreria.LogicaNegocio.CustomExceptions.PaisException;
using Libreria.LogicaNegocio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
            catch (LargoCodigoInvalidoException e)
            {
                ViewBag.msg = "El código del país debe tener 3 caracteres.";
            }
            catch (DatoVacioException e)
            {
                ViewBag.msg = "Todos los campos son obligatorios y no pueden estar vacios.";
            }
            catch (Exception e)
            {
                ViewBag.msg = "Error inesperado";
            }
            return View();
        }
    }
}
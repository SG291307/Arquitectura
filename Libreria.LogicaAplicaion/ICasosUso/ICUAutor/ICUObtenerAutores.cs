using DTOs.DataTransferObjects.DTOAutor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.ICasosUso.ICUAutor
{
    public interface ICUObtenerAutores
    {
        List<DTOAutor> Ejecutar();
    }
}

using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.ICasosUso.ICUPais
{
    public interface ICUObtenerPaisXCodigo
    {
        DTOAltaPais Ejecutar(string codigo);
    }
}

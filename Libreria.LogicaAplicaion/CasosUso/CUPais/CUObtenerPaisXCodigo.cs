using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.CasosUso.CUPais
{
    public class CUObtenerPaisXCodigo: ICUObtenerPaisXCodigo
    {
        private IRepositorioPais _repoPais;

        public CUObtenerPaisXCodigo(IRepositorioPais repoPais)
        {
            _repoPais = repoPais;
        }
        public DTOAltaPais Ejecutar(string codigo)
        {
            return _repoPais.FindByCodigo(codigo);
        }
    }
}

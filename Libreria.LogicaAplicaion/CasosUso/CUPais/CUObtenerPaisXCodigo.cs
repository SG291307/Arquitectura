using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.CasosUso.CUPais
{
    public class CUObtenerPaisXCodigo
    {
        private RepositorioPais _repoPais = new RepositorioPais();
        public Pais Ejecutar(string codigo)
        {
            return _repoPais.FindByCodigo(codigo);
        }
    }
}

using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.CasosUso.CUPais
{
    public class CUObtenerPaises : ICUObtenerPaises
    {
        private IRepositorioPais _repoPais;

        public CUObtenerPaises(IRepositorioPais repoPais)
        {
            _repoPais = repoPais;
        }

        public List<Pais> Ejecutar()
        {
            return _repoPais.FindAll();
        }

    }
}

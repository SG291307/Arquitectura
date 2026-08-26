using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.CasosUso.CUPais
{
    public class CUObtenerPaises
    {
        private RepositorioPais _repoPais = new RepositorioPais();

        public List<Pais> Ejecutar()
        {
            return _repoPais.FindAll();
        }

    }
}

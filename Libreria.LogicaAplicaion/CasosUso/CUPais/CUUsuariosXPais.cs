using DTOs.DataTransferObjects.DTOPais;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.CasosUso.CUPais
{
    internal class CUUsuariosXPais : ICUUsuariosXPais
    {
        private IRepositorioPais _repoPais;

        public CUUsuariosXPais(IRepositorioPais repoPais)
        {
            _repoPais = repoPais;
        }
        public List<DTOUsuariosXPais> Ejecutar()
        {
            // 1- Salgo a buscar los paises
            List<Pais> todoslosPaises = _repoPais.FindAll();
        }
    }
}

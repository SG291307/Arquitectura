using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.CasosUso.CUPais
{
    public class CUAltaPais : ICUAltaPais
    {

        private IRepositorioPais _repoPais;

        public CUAltaPais(IRepositorioPais repoPais)
        {
            _repoPais = repoPais;
        }

        public void Ejecutar(Pais p)
        {
            //Lo valida
            _repoPais.Add(p);
        }
    }
}

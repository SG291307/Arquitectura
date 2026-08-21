using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicaion.CasosUso.CUPais
{
    public class CUAltaPais
    {

        private RepositorioPais _repoPais = new RepositorioPais();

        public void Ejecutar(Pais p)
        {
            //Lo valida
            _repoPais.Add(p);
        }
    }
}

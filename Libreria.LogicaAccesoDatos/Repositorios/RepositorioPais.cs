using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioPais
    {
        private static  List<Pais> paises = new List<Pais>();

        public void Add(Pais p) 
        {
            paises.Add(p);
        }
    }
}

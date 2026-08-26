using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioPais
    {
        private static  List<Pais> paises = new List<Pais>() 
        {
            new Pais { Id = 1, Codigo = "AR", Nombre = "Argentina", Continente = "America"},
            new Pais { Id = 2, Codigo = "BR", Nombre = "Brasil", Continente = "America"},
            new Pais { Id = 3, Codigo = "ES", Nombre = "España", Continente = "Europa" },
        };

        public void Add(Pais p) 
        {
            paises.Add(p);
        }

        public List<Pais>FindAll()
        {
            return paises.ToList();
        }

        public Pais FindByCodigo(string codigo)
        {
            Pais buscado = paises.Where(p => p.Codigo == codigo).SingleOrDefault();
            return buscado;
        }

        public List<Pais> FindByContinente(string continente)
        {
            List<Pais> ret = paises.Where(p => p.Continente == continente).ToList();
            return ret;

        }
    }
}

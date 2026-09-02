using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioPais : IRepositorioPais
    {
        public static List<Pais> paises = new List<Pais>()
        {
            new Pais( "AR", "Argentina", "America"),
            new Pais( "BR", "Brasil", "America"),
            new Pais( "ES", "España", "Europa" ),
        };

        public void Add(Pais p)
        {
            paises.Add(p);
        }

        public List<Pais> FindAll()
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

        public Pais FindById(int id)
        {
            Pais buscado = paises.Where(p => p.Id == id).SingleOrDefault();
            return buscado;
        }

        public void Remove(Pais ToEliminar)
        {
            throw new NotImplementedException();
        }

        public void Update(Pais ToEditar)
        {
            throw new NotImplementedException();
        }
    }
}
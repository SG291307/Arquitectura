using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioPais : IRepositorioPais
    {
        private ApplicationDbContext _context;

        public RepositorioPais(ApplicationDbContext context)
        {
            _context = context;
        }


        public void Add(Pais p)
        {
            _context.Paises.Add(p);
            _context.SaveChanges();
        }

        public List<Pais> FindAll()
        {
            return _context.Paises.ToList();
        }

        public Pais FindByCodigo(string codigo)
        {
            Pais buscado = _context.Paises.Where(p => p.Codigo == codigo).SingleOrDefault();
            return buscado;
        }

        public List<Pais> FindByContinente(string continente)
        {
            List<Pais> ret = _context.Paises.Where(p => p.Continente == continente).ToList();
            return ret;
        }

        public Pais FindById(int id)
        {
            Pais buscado = _context.Paises.Where(p => p.Id == id).SingleOrDefault();
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
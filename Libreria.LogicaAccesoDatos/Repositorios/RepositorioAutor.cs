using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioAutor : IRepositorioAutor
    {
        private static List<Autor> autores = new List<Autor>()
        {
        new Autor { Id = 1, Nombre = "Gabriel", Apellido = "García Márquez", Pais = RepositorioPais.paises[3] }
        };

        public void Add(Autor nuevo)
        {
            autores.Add(nuevo);
        }

        public List<Autor> FindAll()
        {
            return autores;
        }

        public Autor FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Autor ToEliminar)
        {
            throw new NotImplementedException();
        }

        public void Update(Autor ToEditar)
        {
            throw new NotImplementedException();
        }
    }
}

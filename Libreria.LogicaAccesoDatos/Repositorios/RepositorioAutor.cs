using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using Libreria.LogicaNegocio.ValueObjects.ValueAutor;
using System;
using System.Collections.Generic;

namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioAutor : IRepositorioAutor
    {
        private IRepositorioPais _repoPais;
        private static List<Autor> autores;

        public RepositorioAutor(IRepositorioPais repoPais)
        {
            _repoPais = repoPais;

            if (autores == null)
            {
                autores = new List<Autor>()
                {
                    new Autor
                    {
                        Id = 1,
                        NombreCompleto = new AutorNombreCompleto { Nombre = "Gabriel", Apellido = "García Márquez" },
                        Pais = _repoPais.FindByCodigo("ES")
                    }
                };
            }
        }

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
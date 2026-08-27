using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaNegocio.IRepositorios
{
    public interface IRepositorioPais
    {
        void Add(Pais p);
        List<Pais> FindAll();

        Pais FindById(int id);

        Pais FindByCodigo(string codigo);
    }
}

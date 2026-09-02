using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaNegocio.IRepositorios
{
    public interface IRepositorios<T> where T : class
    {
        void Add(T nuevo);
        List<T> FindAll();

        T FindById(int id);

        void Remove(T ToEliminar);

        void Update(T ToEditar);
    }
}

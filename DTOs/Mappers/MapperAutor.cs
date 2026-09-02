using DTOs.DataTransferObjects.DTOAutor;
using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs.Mappers
{
    public class MapperAutor
    {
        public static DTOAutor ToDTOAutor(Autor a)
        {
            DTOAutor dto = new DTOAutor();
            {
                dto.Id = a.Id;
                dto.Nombre = a.NombreCompleto;
                dto.Apellido = a.Apellido;
                dto.PaisNombre = a.Pais.Nombre;
                dto.PaisCodigo = a.Pais.Codigo;
                return dto;
            };
        }

        public static List<DTOAutor> ToDTOAutor(List<Autor> autores)
        {
            List<DTOAutor> ret = new List<DTOAutor>();
            foreach (Autor a in autores)
            {
                ret.Add(ToDTOAutor(a));
            }
            return ret;
        }
    }
}


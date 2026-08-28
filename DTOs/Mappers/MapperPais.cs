using DTOs.DataTransferObjects.DTOPais;
using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs.Mappers
{
    public class MapperPais
    {
        public static Pais ToPais(DTOAltaPais dto)
        {
            Pais nuevo = new Pais();
            nuevo.Nombre = dto.Nombre;
            nuevo.Codigo = dto.Codigo;
            nuevo.Continente = dto.Continente;
            return nuevo;
        }
    }
}

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

        public static DTOPais ToDtoPais(Pais p)
        {
            DTOPais dto = new DTOPais();
            dto.Id = p.Id;
            dto.Nombre = p.Nombre;
            dto.Codigo = p.Codigo;
            dto.Continente = p.Continente;
            dto.TodosMisDatos = $"{p.Nombre} - {p.Codigo} - {p.Continente}";
            return dto;
        }

        public static List<DTOPais> ToDtoPaisList(List<Pais> paises)
        {
            List<DTOPais> dtoList = new List<DTOPais>();
            foreach (Pais p in paises)
            {
                DTOPais pp = ToDtoPais(p);
                dtoList.Add(pp);
            }
            return dtoList;
        }
    }
}

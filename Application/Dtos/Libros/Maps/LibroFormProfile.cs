using Application.Dtos.Editoriales;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Libros.Maps
{
    public class LibroFormProfile : Profile
    {
        public LibroFormProfile()
        {
            CreateMap<LibroFormDto, Libro>();
        }
    }
}

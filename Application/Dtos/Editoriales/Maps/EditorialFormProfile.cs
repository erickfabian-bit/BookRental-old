using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Editoriales.Maps
{
    public class EditorialFormProfile : Profile
    {
        public EditorialFormProfile() 
        {
            CreateMap<EditorialFormDto, Editorial>();
        }
    }
}

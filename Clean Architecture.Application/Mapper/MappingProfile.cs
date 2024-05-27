using AutoMapper;
using Clean_Architecture.Application.DTOs;
using Clean_Architecture.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.Application.Mapper
{
    public class MappingProfile:Profile
    {

        public MappingProfile() {

            CreateMap<addProductDTO, product>();
        }
     
         
    }
}

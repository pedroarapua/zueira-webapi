using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zueira.Domain.Entities;
using Zueira.WebAPI.Models;

namespace Zueira.WebAPI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMapping";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AssuntoModel, Assunto>();
            Mapper.CreateMap<TagModel, Tag>();
            Mapper.CreateMap<ConteudoModel, Conteudo>();
        }
    }
}

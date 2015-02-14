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
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMapping";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Assunto, AssuntoModel>();
            Mapper.CreateMap<Tag, TagModel>();
            Mapper.CreateMap<Conteudo, ConteudoModel>();
        }
    }
}

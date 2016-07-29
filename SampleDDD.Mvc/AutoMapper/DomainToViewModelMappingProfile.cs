using System;
using AutoMapper;
using SampleDDD.Mvc.ViewModels;
using SampleDDD.Domain.Entities;

namespace SampleDDD.Mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}

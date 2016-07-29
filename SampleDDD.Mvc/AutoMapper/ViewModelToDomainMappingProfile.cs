using AutoMapper;
using SampleDDD.Domain.Entities;
using SampleDDD.Mvc.ViewModels;

namespace SampleDDD.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
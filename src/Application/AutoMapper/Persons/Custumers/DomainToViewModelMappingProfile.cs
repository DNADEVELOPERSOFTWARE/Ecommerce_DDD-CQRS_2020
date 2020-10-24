using Application.ViewModels.Persons.Custumers;
using AutoMapper;
using Domain.Models.Persons.Custumers;

namespace Application.AutoMapper.Persons.Custumers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}

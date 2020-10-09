using Application.ViewModels;
using AutoMapper;
using Domain.Models;

namespace Application.AutMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}

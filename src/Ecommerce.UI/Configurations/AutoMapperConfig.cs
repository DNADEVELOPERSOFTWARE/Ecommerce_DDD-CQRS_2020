using System;
using AutoMapper;
using Application.AutoMapper.Persons.Custumers;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.UI.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }
    }
}

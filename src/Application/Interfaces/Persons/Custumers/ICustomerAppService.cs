using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.EventSourcedNormalizers.Persons.Custumers;
using Application.ViewModels.Persons.Custumers;
using FluentValidation.Results;

namespace Application.Interfaces.Persons.Custumers
{
    public interface ICustomerAppService : IDisposable
    {
        Task<IEnumerable<CustomerViewModel>> GetAll();
        Task<CustomerViewModel> GetById(Guid id);

        Task<ValidationResult> Register(CustomerViewModel customerViewModel);
        Task<ValidationResult> Update(CustomerViewModel customerViewModel);
        Task<ValidationResult> Remove(Guid id);

        Task<IList<CustomerHistoryData>> GetAllHistory(Guid id);
    }
}

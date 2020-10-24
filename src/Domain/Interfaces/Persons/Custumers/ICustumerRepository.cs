using Domain.Models.Persons.Custumers;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Persons.Custumers
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        //Métodos para pesquisas
        Task<Customer> GetById(Guid id);
        Task<Customer> GetByEmail(string email);
        Task<IEnumerable<Customer>> GetAll();

        //Mértodos CRUD
        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(Customer customer);
    }
}

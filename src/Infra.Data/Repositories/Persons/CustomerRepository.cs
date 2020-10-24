using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces.Persons.Custumers;
using Domain.Models.Persons.Custumers;
using Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;

namespace Infra.Data.Repositories.Persons
{
    public class CustomerRepository : ICustomerRepository
    {
        protected readonly ContextBase Db;
        protected readonly DbSet<Customer> DbSet;

        public CustomerRepository(ContextBase context)
        {
            Db = context;
            DbSet = Db.Set<Customer>();
        }

        public IUnitOfWork UnitOfWork => Db;

        //Métodos de pesquisa
        public async Task<Customer> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<Customer> GetByEmail(string email)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Email == email);
        }

        //Métodos CRUD
        public void Add(Customer customer)
        {
            DbSet.Add(customer);
        }

        public void Update(Customer customer)
        {
            DbSet.Update(customer);
        }

        public void Remove(Customer customer)
        {
            DbSet.Remove(customer);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
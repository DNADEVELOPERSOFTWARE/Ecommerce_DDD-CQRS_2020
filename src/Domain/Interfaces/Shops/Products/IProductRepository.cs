using Domain.Models.Shops.Products;
using NetDevPack.Data;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Domain.Interfaces.Shops.Products
{
    public interface IProductRepository : IRepository<Product>
    {

        //Métodos para pesquisas
        Task<Product> GetById(Guid id);
        Task<Product> GetByName(string nome);
        Task<IEnumerable<Product>> GetAll();

        //Mértodos CRUD
        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
    }
}

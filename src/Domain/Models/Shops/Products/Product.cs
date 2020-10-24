 using NetDevPack.Domain;
using System;

namespace Domain.Models.Shops.Products
{
    public class Product : Entity, IAggregateRoot
    {
        public Product(Guid id, string name, string description, string note, decimal price, int stockQuantity, DateTime validateDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Note = note;
            Price = price;
            StockQuantity = stockQuantity;
            ValidateDate = validateDate;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Note { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public DateTime ValidateDate { get; private set; }

        public bool Status { get; set; }

    }
}

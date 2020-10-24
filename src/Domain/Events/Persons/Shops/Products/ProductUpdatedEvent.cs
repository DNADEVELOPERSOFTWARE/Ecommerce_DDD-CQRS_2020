using NetDevPack.Messaging;
using System;

namespace Domain.Events.Persons.Shops.Products
{
    public class ProductUpdatedEvent : Event
    {
        public ProductUpdatedEvent(Guid id, string name, string description, string note, decimal price, int stockQuantity, DateTime validateDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Note = note;
            Price = price;
            StockQuantity = stockQuantity;
            ValidateDate = validateDate;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Note { get; set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public DateTime ValidateDate { get; set; }
    }
}

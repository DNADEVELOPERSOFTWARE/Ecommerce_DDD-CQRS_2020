using NetDevPack.Messaging;
using System;

namespace Domain.Events.Persons.Shops.Products
{
    public class ProductRemovedEvent :Event
    {
        public ProductRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
        public Guid Id { get; set; }
    }
}

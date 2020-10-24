using NetDevPack.Messaging;
using System;

namespace Domain.Commands.Shopx.Products
{
    public class ProductCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string Note { get; protected set; }
        public decimal Price { get; protected set; }
        public int StockQuantity { get; protected set; }
        public DateTime ValidateDate { get; protected set; }
    }
}

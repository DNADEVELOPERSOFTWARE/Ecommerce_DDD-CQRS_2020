using Domain.Commands.Validations.Shops.Products;
using System;

namespace Domain.Commands.Shopx.Products
{
    public class UpdateProductCommand : ProductCommand
    {
        public UpdateProductCommand(Guid id, string name, string description, string note, decimal price, int stockQuantity, DateTime validateDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Note = note;
            Price = price;
            StockQuantity = stockQuantity;
            ValidateDate = validateDate;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateProductCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}

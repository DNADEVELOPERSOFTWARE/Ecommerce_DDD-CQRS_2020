using Domain.Commands.Shopx.Products;
using FluentValidation;
using System;

namespace Domain.Commands.Validations.Shops.Products
{
    public class ProductValidation<T> : AbstractValidator<T> where T : ProductCommand
    {
        protected void ValidateName()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }

        protected void ValidateDate()
        {
            RuleFor(p => p.ValidateDate)
                .NotEmpty();
        }

        protected void ValidateDescription()
        {
            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("Discption is requierd")
              .Length(1, 255).WithMessage("Description cannot be longer than 255 characters");
        }

        protected void ValidatePrice()
        {
            RuleFor(p => p.Price).NotEmpty().WithMessage("Price is required")
                .GreaterThan(0.0M).WithMessage("Product price must be higher than zero");
        }

        protected void ValidationStockQuantity()
        {
            RuleFor(p => p.Price).NotEmpty().WithMessage("The stock quantity is required")
                .GreaterThan(0.0M).WithMessage("The stock quantity must be higher than zero");
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}

using Domain.Commands.Shopx.Products;
using Domain.Events.Persons.Shops.Products;
using Domain.Interfaces.Shops.Products;
using Domain.Models.Shops.Products;
using FluentValidation.Results;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Commands.CommandsHandlers.Shops.Products
{
    public class ProductCommandHandler : CommandHandler,
       IRequestHandler<RegisterNewProductCommand, ValidationResult>,
       IRequestHandler<UpdateProductCommand, ValidationResult>,
       IRequestHandler<RemoveProductCommand, ValidationResult>
    {
        private readonly IProductRepository _productRepository;
        public ProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewProductCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var product = new Product(Guid.NewGuid(), message.Name, message.Description, message.Note, message.Price, message.StockQuantity,message.ValidateDate);

            if (await _productRepository.GetByName(product.Name) != null)
            {
                AddError("The product name has already been taken.");
                return ValidationResult;
            }

            product.AddDomainEvent(new ProductRegisteredEvent(product.Id, product.Name, product.Note, product.Price, product.StockQuantity, product.StockQuantity, product.ValidateDate));

            _productRepository.Add(product);

            return await Commit(_productRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateProductCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var product = new Product(message.Id, message.Name, message.Description, message.Note, message.Price, message.StockQuantity, message.ValidateDate);
            var existingProduct = await _productRepository.GetByName(product.Name);

            if (existingProduct != null && existingProduct.Id != product.Id)
            { 
                if (!existingProduct.Equals(product))
                {
                    AddError("The product name has already been taken.");
                    return ValidationResult;
                }
            }

            product.AddDomainEvent(new ProductUpdatedEvent(product.Id, product.Name, product.Description, product.Note, product.Price, product.StockQuantity, product.ValidateDate));

            _productRepository.Update(product);

            return await Commit(_productRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveProductCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var product = await _productRepository.GetById(message.Id);

            if (product is null)
            {
                AddError("The product doesn't exists.");
                return ValidationResult;
            }

            product.AddDomainEvent(new ProductRemovedEvent(message.Id));

            _productRepository.Remove(product);

            return await Commit(_productRepository.UnitOfWork);
        }
    }
}

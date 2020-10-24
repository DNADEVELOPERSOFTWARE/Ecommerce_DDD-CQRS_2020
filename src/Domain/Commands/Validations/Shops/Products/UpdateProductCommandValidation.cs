using Domain.Commands.Shopx.Products;

namespace Domain.Commands.Validations.Shops.Products
{
    public class UpdateProductCommandValidation : ProductValidation<UpdateProductCommand>
    {
        public UpdateProductCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateDescription();
            ValidatePrice();
            ValidationStockQuantity();
            ValidateDate();
        }
    }
}

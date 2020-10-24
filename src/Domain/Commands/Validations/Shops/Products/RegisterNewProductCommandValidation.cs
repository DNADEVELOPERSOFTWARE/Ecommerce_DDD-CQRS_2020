using Domain.Commands.Shopx.Products;

namespace Domain.Commands.Validations.Shops.Products
{
    public class RegisterNewProductCommandValidation : ProductValidation<RegisterNewProductCommand>
    {
        public RegisterNewProductCommandValidation()
        {
            ValidateName();
            ValidateDescription();
            ValidationPrice();
        }
    }
}

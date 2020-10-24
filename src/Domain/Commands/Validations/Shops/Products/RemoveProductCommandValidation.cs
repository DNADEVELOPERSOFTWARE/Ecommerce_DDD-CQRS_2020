using Domain.Commands.Shopx.Products;

namespace Domain.Commands.Validations.Shops.Products
{
    public class RemoveProductCommandValidation : ProductValidation<RemoveProductCommand>
    {
        public RemoveProductCommandValidation()
        {
            ValidateId();
        }
    }
}

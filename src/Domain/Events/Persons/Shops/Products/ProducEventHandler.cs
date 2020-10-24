using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Events.Persons.Shops.Products
{
    public class ProducEventHandler :
       INotificationHandler<ProductRegisteredEvent>,
       INotificationHandler<ProductRemovedEvent>,
       INotificationHandler<ProductUpdatedEvent>
    {
        public Task Handle(ProductRegisteredEvent message , CancellationToken cancellationToken)
        {
            
            return Task.CompletedTask;
        }

        public Task Handle(ProductRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ProductUpdatedEvent message, CancellationToken cancellationToken)
        {
            
            return Task.CompletedTask;
        }
    }
}

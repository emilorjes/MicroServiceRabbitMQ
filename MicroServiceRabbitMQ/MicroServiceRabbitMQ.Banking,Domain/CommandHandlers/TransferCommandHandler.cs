using MediatR;
using MicroServiceRabbitMQ.Banking_Domain.Commands;
using MicroServiceRabbitMQ.Banking_Domain.Events;
using MicroServiceRabbitMQ.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Banking_Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {

            _eventBus.Pubslish(new TransferCreatedEvent(request.Source, request.Destination, request.Amount));
            return Task.FromResult(true);
        }
    }
}

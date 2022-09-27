using MicroServiceRabbitMQ.Domain.Core.Bus;
using MicroServiceRabbitMQ.Transfer.Domain.Events;
using MicroServiceRabbitMQ.Transfer.Domain.Interfaces;
using MicroServiceRabbitMQ.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog()
            {
                TransferAccountSource = @event.Source,
                TransferAccountDestination = @event.Destination,
                TransferAmount = @event.Amount
            });
            return Task.CompletedTask;
        }
    }
}

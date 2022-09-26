using MicroServiceRabbitMQ.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Banking_Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int Source { get; private set; }
        public int Destination { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCreatedEvent(int source, int destination, decimal amount)
        {
            Source = source;
            Destination = destination;
            Amount = amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Banking_Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int source, int destination, decimal amount)
        {
            Source = source;
            Destination = destination;
            Amount = amount;
        }
    }
}

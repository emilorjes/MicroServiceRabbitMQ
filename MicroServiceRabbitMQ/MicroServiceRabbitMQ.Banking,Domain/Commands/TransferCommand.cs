using MicroServiceRabbitMQ.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Banking_Domain.Commands
{
    public class TransferCommand: Command
    {
        public int Source { get; protected set; }
        public int Destination { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}

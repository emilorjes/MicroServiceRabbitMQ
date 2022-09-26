using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Banking.Application.DTOs
{
    public class AccountTransferDTO
    {
        public int AccountSource { get; set; }
        public int AccountDestination { get; set; }
        public decimal TransferAmount { get; set; }
    }
}

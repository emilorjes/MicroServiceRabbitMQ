using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int TransferAccountSource { get; set; }
        public int TransferAccountDestination { get; set; }
        public decimal TransferAmount { get; set; }
    }
}

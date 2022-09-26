using MicroServiceRabbitMQ.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Transfer.Application.Interface
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTranferLogs();
    }
}

using MicroServiceRabbitMQ.Domain.Core.Bus;
using MicroServiceRabbitMQ.Transfer.Application.Interface;
using MicroServiceRabbitMQ.Transfer.Domain.Interfaces;
using MicroServiceRabbitMQ.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly IEventBus _eventBus;
        private readonly ITransferRepository _transferRepository;

        public TransferService(IEventBus eventBus, ITransferRepository transferRepository)
        {
            _eventBus = eventBus;
            _transferRepository = transferRepository;
        }

        public IEnumerable<TransferLog> GetTranferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}

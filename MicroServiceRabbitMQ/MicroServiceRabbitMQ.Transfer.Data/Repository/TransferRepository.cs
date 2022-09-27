using MicroServiceRabbitMQ.Transfer.Data.Context;
using MicroServiceRabbitMQ.Transfer.Domain.Interfaces;
using MicroServiceRabbitMQ.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public void Add(TransferLog transferLog)
        {
           _context.TransferLogs.Add(transferLog);
           _context.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
           return _context.TransferLogs;
        }
    }
}

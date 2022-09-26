using MicroServiceRabbitMQ.Banking.Application.DTOs;
using MicroServiceRabbitMQ.Banking.Application.Interfaces;
using MicroServiceRabbitMQ.Banking.Domain.Interfaces;
using MicroServiceRabbitMQ.Banking.Domain.Models;
using MicroServiceRabbitMQ.Banking_Domain.Commands;
using MicroServiceRabbitMQ.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
           return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransferDTO accountTransfer)
        {
            CreateTransferCommand createTransferCommand = new(
                accountTransfer.AccountSource,
                accountTransfer.AccountDestination,
                accountTransfer.TransferAmount
                );

            _eventBus.SendCommand(createTransferCommand);
        }
    }
}

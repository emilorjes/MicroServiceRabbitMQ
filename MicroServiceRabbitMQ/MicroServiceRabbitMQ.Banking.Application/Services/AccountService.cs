using MicroServiceRabbitMQ.Banking.Application.Interfaces;
using MicroServiceRabbitMQ.Banking.Domain.Interfaces;
using MicroServiceRabbitMQ.Banking.Domain.Models;
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

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
           return _accountRepository.GetAccounts();
        }
    }
}

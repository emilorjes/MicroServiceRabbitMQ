using MicroServiceRabbitMQ.Banking.Application.Interfaces;
using MicroServiceRabbitMQ.Banking.Application.Services;
using MicroServiceRabbitMQ.Banking.Data.Context;
using MicroServiceRabbitMQ.Banking.Data.Repository;
using MicroServiceRabbitMQ.Banking.Domain.Interfaces;
using MicroServiceRabbitMQ.Domain.Core.Bus;
using MicroServiceRabbitMQ.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbitMQ.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}

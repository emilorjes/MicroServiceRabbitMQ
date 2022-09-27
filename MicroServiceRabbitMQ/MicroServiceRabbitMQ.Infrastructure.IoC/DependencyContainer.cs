using MediatR;
using MicroServiceRabbitMQ.Banking.Application.Interfaces;
using MicroServiceRabbitMQ.Banking.Application.Services;
using MicroServiceRabbitMQ.Banking.Data.Context;
using MicroServiceRabbitMQ.Banking.Data.Repository;
using MicroServiceRabbitMQ.Banking.Domain.Interfaces;
using MicroServiceRabbitMQ.Banking_Domain.CommandHandlers;
using MicroServiceRabbitMQ.Banking_Domain.Commands;
using MicroServiceRabbitMQ.Domain.Core.Bus;
using MicroServiceRabbitMQ.Infrastructure.Bus;
using MicroServiceRabbitMQ.Transfer.Application.Interface;
using MicroServiceRabbitMQ.Transfer.Application.Services;
using MicroServiceRabbitMQ.Transfer.Data.Context;
using MicroServiceRabbitMQ.Transfer.Data.Repository;
using MicroServiceRabbitMQ.Transfer.Domain.Events;
using MicroServiceRabbitMQ.Transfer.Domain.Interfaces;
using MicroServiceRabbitMQ.Transfer.Domain.EventHandlers;
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
            // Domain EventBus
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            // Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            // Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}

using MicroServiceRabbitMQ.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroServiceRabbitMQ.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options) { }

        public System.Data.Entity.DbSet<Account> Accounts { get; set; }
    }
}

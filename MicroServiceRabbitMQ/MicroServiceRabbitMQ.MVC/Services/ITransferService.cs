using MicroServiceRabbitMQ.MVC.Models.DTOs;

namespace MicroServiceRabbitMQ.MVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDTO transferDTO);
    }
}

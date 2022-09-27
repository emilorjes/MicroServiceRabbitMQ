namespace MicroServiceRabbitMQ.MVC.Models.DTOs
{
    public class TransferDTO
    {
        public int AccountSource { get; set; }
        public int AccountDestination { get; set; }
        public decimal TransferAmount { get; set; }
    }
}

namespace MicroServiceRabbitMQ.MVC.Models
{
    public class TransferViewModel
    {
        public string TransferNotes { get; set; }
        public int SourceAccount { get; set; }
        public int DestinationAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}

using MicroServiceRabbitMQ.MVC.Models.DTOs;
using Newtonsoft.Json;

namespace MicroServiceRabbitMQ.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task Transfer(TransferDTO transferDTO)
        {
            string uri = "https://localhost:7051/api/Banking";
            StringContent transferContent = new(JsonConvert.SerializeObject(transferDTO),
                System.Text.Encoding.UTF8,
                "application/json");

            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}

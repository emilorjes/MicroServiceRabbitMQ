using MicroServiceRabbitMQ.MVC.Models;
using MicroServiceRabbitMQ.MVC.Models.DTOs;
using MicroServiceRabbitMQ.MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MicroServiceRabbitMQ.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransferService _transferService;

        public HomeController(ILogger<HomeController> logger, ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Transfer(TransferViewModel transferModel)
        {
            TransferDTO transferDTO = new()
            {
                AccountSource = transferModel.SourceAccount,
                AccountDestination = transferModel.DestinationAccount,
                TransferAmount = transferModel.TransferAmount
            };

            await _transferService.Transfer(transferDTO);
            return View("Index");
        }
    }
}
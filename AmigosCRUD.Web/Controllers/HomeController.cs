using AmigosCRUD.Domain.Interfaces;
using AmigosCRUD.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AmigosCRUD.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAmigoService _amigoService;
        public HomeController(ILogger<HomeController> logger, IAmigoService amigoService)
        {
            _logger = logger;
            _amigoService = amigoService;
        }
        [Authorize()]
        public IActionResult Index()
        {
            var listaAmigos = _amigoService.GetAll();
            return View(listaAmigos);
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
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UC05AT3lucianasilvaa.Models;

namespace UC05AT3lucianasilvaa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListaCadastro()
        {
            return View(Dados.AgendamentoAtual.mostrarLista());
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult DadosAgendamento()
        {
            return View();

        }

        [HttpPost]
        public IActionResult DadosAgendamento(DadosAgendamento novopet)
        {                      
            Dados.AgendamentoAtual.addLista(novopet);     
            return RedirectToAction("ListaCadastro");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

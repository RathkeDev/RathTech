using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projetoMVC.Models;

namespace projetoMVC.Controllers
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
        public IActionResult Categorias()
        {
            return View();
        }
        public IActionResult Entrada()
        {
            return View();
        }
         public IActionResult Quemsomos()
        {
            return View();
        }
         public IActionResult Login()
        {
            return View();
        }
        
         public IActionResult Cadastrar()
        {
            return View();
        }
        
         public IActionResult Confirmacao()
        {
            return View();
        }
         public IActionResult Intavançado()
        {
            return View();
        }
         public IActionResult Intermediario()
        {
            return View();
        }
        public IActionResult Toplinha()
        {
            return View();
        }
        public IActionResult Compra()
        {
            return View();
        }
         public IActionResult Carrinho()
        {
            return View();
        }
         [HttpPost]
    public IActionResult Cadastrar(Cadastro cadastro) {
            ListaCadastro.Incluir(cadastro);
            ViewBag.Mensagem = "Cadastro Concluido com sucesso! Clique aqui para ver Suas Informações de cadastro";
            return View();
        }
        
        public IActionResult Concluido() {
            List<Cadastro> cadastros = ListaCadastro.Listar();
            return View (cadastros);
        }
         

    }
}

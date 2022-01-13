using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { new Proyecto {
                Titulo = "Amazon",
                Descripcion = "E-commerce realizado en ASP.NET",
                Link = "https://amazon.com",
                ImagenURL = "/img/amazon.png"
            },new Proyecto {
                Titulo = "New York Times",
                Descripcion = "Página de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = "/img/nyt.png"
            },new Proyecto {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL = "/img/reddit.png"
            },new Proyecto {
                Titulo = "Steam",
                Descripcion = "E-commerce realizado en ASP.NET",
                Link = "https://store.steampowered.com",
                ImagenURL = "/img/steam.png"
            } };
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
using Microsoft.AspNetCore.Mvc;
using MyPortafolio.Models;
using System.Diagnostics;
using System.Net.Cache;

namespace MyPortafolio.Controllers
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
            var modelo = new HomeIndexDTO() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() {new ProyectoDTO
            {
                Titulo = "Amazon",
                Descripcion="E-Commerce en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/img/amazon.png"
            },
            new ProyectoDTO
            {
                Titulo = "New York Times",
                Descripcion="Página de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = "/img/nyt.png"
            },
            new ProyectoDTO
            {
                Titulo = "Reddit",
                Descripcion="Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL = "/img/reddit.png"
            },
            new ProyectoDTO
            {
                Titulo = "Steam",
                Descripcion="Tienda virtual para la compra de videojuegos",
                Link = "https://store.steampowered",
                ImagenURL = "/img/steam.png"
            },
            };
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
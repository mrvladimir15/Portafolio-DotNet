using MyPortafolio.Models;

namespace MyPortafolio.Services
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {


        public List<ProyectoDTO> ObtenerProyectos()
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
    }
}

using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
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
    }
}

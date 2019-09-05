using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();

            Playlist ingles =
                new Playlist();
            ingles.TituloPlay = "Ingles";
            ingles.Descripcion = "Peliculas en ingles para los bilingues";

            ingles.Peliculas.Add(
                new Pelicula("Perfect", 2015));
        }
    }
}

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
            ingles.Peliculas.Add(
                new Pelicula("What?", 2010));
            ingles.Peliculas.Add(
                new Pelicula("2me", 1975));
            ingles.Peliculas.Add(
                new Pelicula("Today", 2000));
            ingles.Peliculas.Add(
                new Pelicula("Impossible", 2019)); 
            ingles.Peliculas.Add(
                new Pelicula("Project Z", 1950));
            ingles.Peliculas.Add(
                new Pelicula("Zombies in the city", 1999));

            Playlist español =
                new Playlist();
            español.TituloPlay = "Español";
            español.Descripcion = "Peliculas en español latino";

            español.Peliculas.Add(
                new Pelicula("Bonita", 2011));
            español.Peliculas.Add(
                new Pelicula("El ahora", 1850));
            español.Peliculas.Add(
                new Pelicula("Como si fuera mañana", 1879));
            español.Peliculas.Add(
                new Pelicula("Antes de los 20", 1934));
            español.Peliculas.Add(
                new Pelicula("Regreso a la ciudad", 2017));
            español.Peliculas.Add(
                new Pelicula("Enfermedad", 1950));
            español.Peliculas.Add(
                new Pelicula("Descuido", 2006));

            playlists.Add(ingles);
            playlists.Add(español);

            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine("Playlist: ");
                Console.WriteLine("Titulo: " + 
                    playlist.TituloPlay);
                Console.WriteLine("Descripcion: " +
                    playlist.Descripcion);
                foreach (Pelicula pelicula in playlist.Peliculas)
                {
                    Console.WriteLine("-" +
                        pelicula.Titulo + ", " +
                        pelicula.AñoEstreno);
                }
            }

            Console.Read();
        }
    }
}

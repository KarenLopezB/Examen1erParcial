using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Playlist
    {
        public string TituloPlay { get; set; }
        public string Descripcion { get; set; }
        public List<Pelicula> Peliculas { get; set; }


        public Playlist()
        {
            TituloPlay = "Sin asignar";
            Descripcion = "Pendiente";
            Peliculas = new List<Pelicula>();
        }

        public Playlist(string tituloplay, string descripcion)
        {
            TituloPlay = tituloplay;
            Descripcion = descripcion;
            Peliculas = new List<Pelicula>();
        }
    }
}

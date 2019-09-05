using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Pelicula
    {
        public string Titulo { get; set; }
        private int _añoestreno;
        public int AñoEstreno
        {
            get
            {
                return _añoestreno;
            }
            set
            {
                if (value >=1800 && value <=2019)
                {
                    _añoestreno = value;
                }
                else
                {
                    throw new Exception("El año no corresponde al rango establecido");
                }
            }
        }

        public string Director { get; set; }
        public string Genero { get; set; }
        public string PaisOrigen { get; set; }
        private int _duracion;
        public int Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                if(value >0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("El numero debe ser mayor de 0");
                }
            }
        }

        private double _ratingimdb;
        public double RatingImdb
        {
            get
            {
                return _ratingimdb;
            }
            set
            {
                if(value >=0 && value <=10)
                {
                    _ratingimdb = value;
                }
                else
                {
                    throw new Exception("El numero no se encuentra entre el rango");
                }
            }
        }

        public string Sinopsis { get; set; }


        public Pelicula()
        {
            Titulo = "Pendiente";
            AñoEstreno = 0;
            Director = "Pendiente;
            Genero = "  Sin asignar";
            PaisOrigen = "Pendiente";
            Duracion = 0;
            RatingImdb = 0.00;
            Sinopsis = "Sing asignar";
        }

        public Pelicula(string titulo, int añoestreno)
        {
            Titulo = titulo;
            AñoEstreno = añoestreno;
            Director = director;
            Genero = genero;
            PaisOrigen = paisorigen;
            Duracion = duracion;
            RatingImdb = ratingimdb;
            Sinopsis = sinopsis;
        }
    }
}

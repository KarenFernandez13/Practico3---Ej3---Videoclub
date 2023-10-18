using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej3
{
    internal class Pelicula
    {
        protected int NumeroCopia;
        protected string Titulo;
        protected string Sinopsis;
        protected string Genero;
        protected string PaisOrigen;
        private List<Trailer> ColTrailer;

        public Pelicula() { }
        public Pelicula(int numeroCopia, string titulo, string sinopsis, string genero, string paisOrigen)
        {
            NumeroCopia = numeroCopia;
            Titulo = titulo;
            Sinopsis = sinopsis;
            Genero = genero;
            PaisOrigen = paisOrigen;
            this.ColTrailer = new List<Trailer>();           
        }
        public void AgregarTrailer(string url, short duracion)
        {
            Trailer miTrailer = new Trailer(url, duracion);
            ColTrailer.Add(miTrailer);
        }
        public int GetNumeroCopia() => this.NumeroCopia;
        public void SetNumeroCopia(int NumeroCopia) => this.NumeroCopia = NumeroCopia;
        public string GetTitulo() => this.Titulo;
        public void SetTitulo(string Titulo) => this.Titulo = Titulo;
        public string GetSinopsis() => this.Sinopsis;
        public void SetSinopsis(string Sinopsis) => this.Sinopsis = Sinopsis;
        public string GetGenero() => this.Genero;
        public void SetGenero(string Genero)=>this.Genero = Genero;
        public string GetPaisOrigen() => this.PaisOrigen;
        public void SetPaisOrigen(string PaisOrigen) => this.PaisOrigen = PaisOrigen;
        public List<Trailer> GetColTrailer() => this.ColTrailer;
        public void SetColTrailer(List<Trailer>ColTrailer)=> this.ColTrailer = ColTrailer;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> ColClientes = new List<Cliente>();
            Cliente Cliente1 = new Cliente("Maria", "Perez", "38966434", "Av.Artigas", "099878929");
            ColClientes.Add(Cliente1);
            Cliente Cliente2 = new Cliente("Mario", "Rodriguez", "26753441", "Calle 3", "091276961");
            ColClientes.Add(Cliente2);

            Pelicula Peli1 = new Pelicula(1, "Titanic", "Regular", "Drama", "EEUU");
            Peli1.AgregarTrailer("url1", 10);
            Peli1.AgregarTrailer("url2", 15);
            Pelicula Peli2 = new Pelicula(2, "El Rey Leon", "Muy Buena", "Animacion", "EEUU");
            Peli2.AgregarTrailer("url3", 5);
            Pelicula Peli3 = new Pelicula(3, "Terminator 2: Judgement Day", "Muy buena", "Ciencia Ficcion", "EEUU");
            Peli3.AgregarTrailer("url4", 7);
            Pelicula Peli4 = new Pelicula(4, "Star Wars: Episode IV - A New Hope", "Muy buena", "Ciencia Ficcion", "EEUU");
            Peli4.AgregarTrailer("url5", 1);
            Pelicula Peli5 = new Pelicula(5, "The Matrix", "Muy buena", "Ciencia Ficcion", "EEUU");
            Peli5.AgregarTrailer("url6", 15);
            Pelicula Peli6 = new Pelicula(6, "The NeverEnding Story", "Buena", "Fantasia", "EEUU");
            Peli6.AgregarTrailer("url7", 18);

            List<Pelicula> ColPeliculas = new List<Pelicula>();
            ColPeliculas.Add(Peli1);
            ColPeliculas.Add(Peli2);
            List<Pelicula> ColPeliculas2 = new List<Pelicula>();
            ColPeliculas2.Add(Peli3);
            ColPeliculas2.Add(Peli4);
            ColPeliculas.Add(Peli5);

            List<Alquiler> ColAlquileres = new List<Alquiler>();
            Alquiler NuevoAlq1 = new Alquiler(1, DateTime.Now, DateTime.Now.AddDays(1), 0, Cliente1, ColPeliculas);
            Alquiler NuevoAlq2 = new Alquiler(2, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), 0, Cliente2, ColPeliculas2);
            ColAlquileres.Add(NuevoAlq1);
            ColAlquileres.Add (NuevoAlq2);

            Videoclub Videoclub1 = new Videoclub(ColPeliculas, ColClientes, ColAlquileres);

            string documento = "11465478";
            string registro;
            bool ExisteCliente = Videoclub1.BuscarCliente(documento);
            if (ExisteCliente) { registro = "Está registrado"; }
            else { registro = "No está registrado"; }
            Console.WriteLine($"\n Punto c) 1: El documento {documento} {registro}");

            Alquiler alquiler = 
        }
    }
}

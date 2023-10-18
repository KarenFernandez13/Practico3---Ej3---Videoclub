using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej3
{
    internal class Videoclub
    {
        private List<Pelicula> ColPeliculas;
        private List<Cliente> ColClientes;
        private List<Alquiler> ColAlquileres;
        public Videoclub() { }
        public Videoclub(List<Pelicula> colPeliculas, List<Cliente> colClientes, List<Alquiler> colAlquileres)
        {
            this.ColPeliculas = colPeliculas;
            this.ColClientes = colClientes;
            this.ColAlquileres = colAlquileres;
        }
        public List<Pelicula> GetColPeliculas() => this.ColPeliculas;
        public void SetColPeliculas(List<Pelicula> ColPeliculas) => this.ColPeliculas = ColPeliculas;
        public List<Cliente>GetColClientes() => this.ColClientes;
        public void SetColClientes(List<Cliente> ColClientes)=> this.ColClientes= ColClientes;
        public List<Alquiler>GetColAlquileres() => this.ColAlquileres;
        public void SetColAlquileres(List<Alquiler> Alquileres)=>this.ColAlquileres= Alquileres;

        public bool BuscarCliente(string documento)
        {
            foreach (Cliente item in this.ColClientes) 
            {
                if(item.GetDocumento() == documento) return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej3
{
    internal class Alquiler
    {
        private const float CostoBase = 80;
        private int Numero;
        private DateTime FechaInicio;
        private DateTime FechaFinal;
        private float CostoTotal;
        private Cliente Cliente;
        private List<Pelicula> ColPeliculas;

        public Alquiler() { }

        public Alquiler(int Numero, DateTime FechaInicio, DateTime FechaFinal, float CostoTotal, Cliente Cliente, List<Pelicula> ColPeliculas) 
        { 
            this.Numero = Numero;
            this.FechaInicio = FechaInicio;
            this.FechaFinal = FechaFinal;
            this.CostoTotal = CostoTotal;
            this.Cliente = Cliente;
            this.ColPeliculas = ColPeliculas;
        }

        public void SetNumero(int Numero) => this.Numero = Numero;  
        public int GetNumero() => this.Numero;
        public void SetFechaInicio(DateTime FechaInicio) => this.FechaInicio = FechaInicio;
        public DateTime GetFechaInicio() => this.FechaInicio;
        public void SetFechaFinal(DateTime FechaFinal) => this.FechaFinal = FechaFinal;
        public DateTime GetFechaFinal() => this.FechaFinal;
        public void SetCostoTotal(float CostoTotal) => this.CostoTotal = CostoTotal;
        public float GetCostoTotal() => this.CostoTotal;
        public void SetCliente(Cliente Cliente) => this.Cliente = Cliente;
        public Cliente GetCliente()=> this.Cliente;
        public void SetColPeliculas(List<Pelicula> ColPeliculas) => this.ColPeliculas = ColPeliculas;
        public List<Pelicula> GetColPeliculas() => this.ColPeliculas;
    }
}

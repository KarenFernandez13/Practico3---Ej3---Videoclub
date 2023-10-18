using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej3
{
    internal class Trailer
    {
        protected string Url;
        protected short Duracion;

        public Trailer() { }
        public Trailer(string url, short duracion)
        {
            Url = url;
            Duracion = duracion;
        }
        public string GetUrl() => this.Url;
        public short GetDuracion()=> this.Duracion;
        public void SetUrl(string url)=>this.Url = url;
        public void SetDuracion(short duracion)=>this.Duracion = duracion;
    }
}

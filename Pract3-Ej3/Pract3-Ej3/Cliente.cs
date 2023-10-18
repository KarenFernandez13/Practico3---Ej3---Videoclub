using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej3
{
    internal class Cliente
    {
        protected string Nombre;
        protected string Apellido;
        protected string Documento;
        protected string Direccion;
        protected string Telefono;

        public Cliente() { }

        public Cliente(string nombre, string apellido, string documento, string direccion, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Direccion = direccion;
            Telefono = telefono;
        }
        public string GetNombre() => this.Nombre;
        public void SetNombre(string nombre)=>this.Nombre = nombre;
        public string GetApellido() => this.Apellido;
        public void SetApellido(string Apellido)=>this.Apellido = Apellido;
        public string GetDocumento() => this.Documento;
        public void SetDocumento(string documento)=>this.Documento = documento;
        public string GetTelefono() => this.Telefono;
        public void SetTelefono(string Telefono)=>this.Telefono = Telefono;

        public string DarNombreCompleto()
        {
            return this.Nombre +" " + this.Apellido;
        }
    }
}

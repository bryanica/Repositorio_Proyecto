using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Cliente:Persona
    {
        public Cliente() { }

        public string Direccion { get; set; }
        public Cliente(int id, string nombre, string email, string direccion) : base(id, nombre, email)
        {
            Direccion = direccion;
        }
        public override string ToString()
        {
            return $"{Id}; {Nombre}; {Email}; {Direccion}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario: Persona
    {
        public Usuario() { }

        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public Usuario(int id, string nombre, string email, string contrraseña, string rol) : base(id, nombre, email)
        {
            Contraseña= contrraseña; Rol= rol; 
        }
        public override string ToString()
        {
            return $"{Id}; {Nombre}; {Email}; {Contraseña};{Rol}";
        }
    }
}

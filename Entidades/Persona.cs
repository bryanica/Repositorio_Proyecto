using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public Persona()
        {


        }

        public Persona(int id, string nombre, string email)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
        }
    }
}

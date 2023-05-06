using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Producto_servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public Producto_servicio()
        {


        }

        public Producto_servicio(int id, string nombre, int precio)
        {
            Id = id;
            Nombre = nombre;
            Precio= precio;
        }
    }
}

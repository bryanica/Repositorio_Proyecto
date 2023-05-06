using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura: Producto_servicio
    {
        public DetalleFactura() { }

        public int Cantidad { get; set; }
        public DetalleFactura(int id, string nombre, int precio, int  cantidad) : base(id, nombre, precio) 
        {
            Cantidad = cantidad;
        }
        public override string ToString()
        {
            return $"{Id}; {Nombre}; {Precio}; {Cantidad}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Factura
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Total { get; set; }
        public Factura()
        {


        }

        public Factura(int id, DateTime fecha, int total)
        {
            Id = id;
            Fecha = fecha;
            Total = total;
        }
    }
}

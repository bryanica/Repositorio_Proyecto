using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivo
{
    public class Repositorio
    {
        List<Cliente> listarepositorio = new List<Cliente>();
        
        String RutaC = "Cliente.txt";
        public bool AddCliente(Cliente Persona)
        {
            StreamWriter SW = new StreamWriter(RutaC, true);
            SW.WriteLine(Persona.ToString());
            SW.Close();
            return true;
        }
        public Cliente Mapadeador(string valor)
        {
            var cliente = new Cliente();
            string[] aux = valor.Split(';');
            cliente.Id = int.Parse(aux[0]);
            cliente.Nombre = aux[1];
            cliente.Email = aux[2];
            cliente.Direccion = aux[3];
            return cliente;
        }
        public List<Cliente> All()
        {
            var Lista = new List<Cliente>();
            var sr = new StreamReader(RutaC);
            try
            {
                while (!sr.EndOfStream)
                {
                    Lista.Add(Mapadeador(sr.ReadLine()));
                }
                sr.Close();
                return Lista;
            }
            catch (Exception) { return null; }

        }
    }
}

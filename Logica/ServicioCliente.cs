using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Archivo;
using Entidades;

namespace Logica
{
    public class ServicioCliente : IGestion<Cliente>
    {
        List<Cliente> clientes;
        Repositorio repositorio = new Repositorio();
        public ServicioCliente()
        {
            clientes = new List<Cliente>();
        }
        public bool Add(Cliente Persona)
        {
            try
            {
                if (Persona == null) return false;
                repositorio.AddCliente(Persona);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Cliente Persona)
        {
            clientes.Remove(Persona);
            return true;
        }

        public bool Exist(Cliente Persona)
        {
            foreach (var item in clientes)
            {
                if (item.Id == Persona.Id) return true;
            }
            return false;
        }

        public List<Cliente> GetAll()
        {
            return clientes = repositorio.All();
        }

        public List<Cliente> GetByID(int id)
        {
            try
            {
                List<Cliente> listaFiltroName = new List<Cliente>();
                foreach (var item in clientes)
                {
                    if (item.Id == id)
                    {
                        listaFiltroName.Add(item);
                    }
                }
                return listaFiltroName;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Cliente> GetByName(string name)
        {
            try
            {
                List<Cliente> listaFiltroName = new List<Cliente>();
                foreach (var item in clientes)
                {
                    if (item.Nombre.StartsWith(name))
                    {
                        listaFiltroName.Add(item);
                    }
                }
                return listaFiltroName;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Update(Cliente Persona)
        {
            throw new NotImplementedException();
        }
    }
}

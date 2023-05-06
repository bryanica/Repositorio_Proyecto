using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IGestion<T>
    {
        bool Add(T Persona);
        bool Delete(T Persona);
        bool Exist(T Persona);
        String Update(T Persona);
        List<T> GetAll();
        List<T> GetByName(string name);
        List<T> GetByID(int Numer);
    }
}

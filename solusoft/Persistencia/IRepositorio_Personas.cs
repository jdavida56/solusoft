using System.Collections.Generic;
using Dominio;
namespace Persistencia
{
    public interface IRepositorio_Personas
    {
        IEnumerable<Personas> ListPersona();
        Personas addPersonas (Personas Personas );
        Personas updatePersonas(Personas Personas);
        void DeletePersonas(int id_Personas);
        Personas DetailPersona(int id_Personas);
       
    }
}
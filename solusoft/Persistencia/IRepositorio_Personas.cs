using System.Collections.Generic;
using Dominio;
namespace Persistencia
{
    public interface IRepositorio_Personas
    {
        IEnumerable<Personas> GetAllPersonas();
        
        Personas addPersonas (Personas Personas );
        
        Personas updatePersonas(Personas Personas);
        
        void DeletePersonas(int idPersonas);
        
        Personas GetPersonas(int idPersonas);
       
    }
}
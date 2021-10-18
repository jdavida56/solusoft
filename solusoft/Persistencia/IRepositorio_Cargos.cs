using System.Collections.Generic;
using Dominio;
namespace Persistencia
{
    public interface IRepositorio_Cargos
    {
        IEnumerable<Cargos> GetAllCargos();
        Cargos addCargos (Cargos Cargos );
        Cargos updateCargos(Cargos Cargos);
        void DeleteCargos(int idCargos);
        Cargos GetCargos(int idCargos);
       
    }
}
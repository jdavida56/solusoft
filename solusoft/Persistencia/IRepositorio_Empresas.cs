using System.Collections.Generic;
using Dominio;
namespace Persistencia
{
    public interface IRepositorio_Empresas
    {
        IEnumerable<Empresas> GetAllEmpresas();

        Empresas addEmpresas (Empresas Empresas);

        Empresas updateEmpresas(Empresas Empresas);

        void DeleteEmpresas(int idEmpresas);
        
        Empresas GetEmpresas(int idEmpresas);
       
    }
}
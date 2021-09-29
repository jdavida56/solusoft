using System.Collections.Generic;
using Dominio;
namespace Persistencia
{
    public interface IRepositorio_Clientes
    {
        IEnumerable<Clientes> GetAllClientes();

        Clientes addClientes (Clientes Clientes);

        Clientes updateClientes(Clientes Clientes);

        void DeleteClientes(int idClientes);
        
        Clientes GetClientes(int idClientes);
       
    }
}
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{

    public class Repositorio_Clientes : IRepositorio_Clientes
    {

        private readonly ApplicationDbContext _appContext;

            public Repositorio_Clientes(ApplicationDbContext appContext){
                _appContext = appContext;
            }   
        Clientes IRepositorio_Clientes.addClientes(Clientes Clientes)
        {
             var new_Clientes = _appContext.Clientes.Add(Clientes);
                _appContext.SaveChanges();
                return new_Clientes.Entity;
        }

        void IRepositorio_Clientes.DeleteClientes(int idClientes)
        {
            var PersonaEncontrada = _appContext.Clientes.FirstOrDefault(
                p => p.Id == idClientes
            );

            if (PersonaEncontrada == null)
            return;
            _appContext.Remove(PersonaEncontrada);
            _appContext.SaveChanges();
            
        }

        IEnumerable<Clientes> IRepositorio_Clientes.GetAllClientes()
        {
            return _appContext.Clientes;
        }

        Clientes IRepositorio_Clientes.GetClientes(int idClientes){
             return _appContext.Clientes.FirstOrDefault(
                cli => cli.Id == idClientes  
            );
        }    

        Clientes IRepositorio_Clientes.updateClientes(Clientes Clientes){
          var ClienteEncontrado = _appContext.Clientes.FirstOrDefault(
                cli => cli.Id == Clientes.Id
            ); 

            if(ClienteEncontrado != null){
                ClienteEncontrado.Telefono = ClienteEncontrado.Telefono;
                ClienteEncontrado.Id_Persona = ClienteEncontrado.Id_Persona;
                ClienteEncontrado.Id_Empresa = ClienteEncontrado.Id_Empresa;
                _appContext.SaveChanges();
            }
            return ClienteEncontrado;
        }
    }   
}
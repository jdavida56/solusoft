using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{

    public class Repositorio_Empresas : IRepositorio_Empresas
    {

        private readonly ApplicationDbContext _appContext;

            public Repositorio_Empresas(ApplicationDbContext appContext){
                _appContext = appContext;
            }

        public Empleados GetEmpresas(int idEmpresas)
        {
            throw new System.NotImplementedException();
        }

        Empresas IRepositorio_Empresas.addEmpresas(Empresas Empresas)
        {
             var new_Empresas = _appContext.Empresas.Add(Empresas);
                _appContext.SaveChanges();
                return new_Empresas.Entity;
        }

        void IRepositorio_Empresas.DeleteEmpresas(int idEmpresas)
        {
            var EmpresaEncontrada = _appContext.Empresas.FirstOrDefault(
                empr => empr.Id == idEmpresas
            );

            if (EmpresaEncontrada == null)
            return;
            _appContext.Remove(EmpresaEncontrada);
            _appContext.SaveChanges();
            
        }

        IEnumerable<Empresas> IRepositorio_Empresas.GetAllEmpresas()
        {
            return _appContext.Empresas;
        }

        Empresas IRepositorio_Empresas.GetEmpresas(int idEmpresas){
                return _appContext.Empresas.FirstOrDefault(
                empr => empr.Id == idEmpresas  
            );
        }    

        Empresas IRepositorio_Empresas.updateEmpresas(Empresas Empresas){
          var EmpresaEncontrada = _appContext.Empresas.FirstOrDefault(
                empr => empr.Id == Empresas.Id
            ); 

            if(EmpresaEncontrada != null){
                EmpresaEncontrada.Nit = Empresas.Nit;
                EmpresaEncontrada.Razon_Social = Empresas.Razon_Social;
                EmpresaEncontrada.Direccion = Empresas.Direccion;
                EmpresaEncontrada.Telefono = Empresas.Telefono;
                EmpresaEncontrada.Ciudad = Empresas.Ciudad;
                _appContext.SaveChanges();
            }
            return EmpresaEncontrada;
        }
    }   
}
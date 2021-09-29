using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{

    public class Repositorio_Cargos : IRepositorio_Cargos
    {

        private readonly ApplicationDbContext _appContext;

            public Repositorio_Cargos(ApplicationDbContext appContext){
                _appContext = appContext;
            }   
        Cargos IRepositorio_Cargos.addCargos(Cargos Cargos)
        {
             var new_Cargos = _appContext.Cargos.Add(Cargos);
                _appContext.SaveChanges();
                return new_Cargos.Entity;
        }

        void IRepositorio_Cargos.DeleteCargos(int idCargos)
        {
            var CargoEncontrado = _appContext.Cargos.FirstOrDefault(
                p => p.Id == idCargos
            );

            if (CargoEncontrado == null)
            return;
            _appContext.Remove(CargoEncontrado);
            _appContext.SaveChanges();
            
        }

        IEnumerable<Cargos> IRepositorio_Cargos.GetAllCargos()
        {
            return _appContext.Cargos;
        }

        Cargos IRepositorio_Cargos.GetCargos(int idCargos){
             return _appContext.Cargos.FirstOrDefault(
                p => p.Id == idCargos  
            );
        }    

        Cargos IRepositorio_Cargos.updateCargos(Cargos Cargos){
          var CargoEncontrado = _appContext.Cargos.FirstOrDefault(
                c => c.Id == Cargos.Id
            ); 

            if(CargoEncontrado != null){
                CargoEncontrado.Nombre = Cargos.Nombre;
                CargoEncontrado.Directivo = Cargos.Directivo;
                _appContext.SaveChanges();
            }
            return CargoEncontrado;
        }
    }   
}
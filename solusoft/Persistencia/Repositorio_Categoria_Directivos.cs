using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{

    public class Repositorio_Categoria_Directivos : IRepositorio_Categoria_Directivos
    {

        private readonly ApplicationDbContext _appContext;

            public Repositorio_Categoria_Directivos(ApplicationDbContext appContext){
                _appContext = appContext;
            }   
        Categorias_Directivos IRepositorio_Categoria_Directivos.addCategoria_Directivos(Categorias_Directivos Categorias_Directivos)
        {
             var new_Categoria_Directivos = _appContext.Categorias_Directivos.Add(Categorias_Directivos);
                _appContext.SaveChanges();
                return new_Categoria_Directivos.Entity;
        }

        void IRepositorio_Categoria_Directivos.DeleteCategoria_Directivos(int idCategoria_Directivos)
        {
            var Categoria_Encontrada = _appContext.Categorias_Directivos.FirstOrDefault(
                p => p.Id == idCategoria_Directivos
            );

            if (Categoria_Encontrada == null)
            return;
            _appContext.Remove(Categoria_Encontrada);
            _appContext.SaveChanges();
            
        }

        IEnumerable<Categorias_Directivos> IRepositorio_Categoria_Directivos.GetAllCategoria_Directivos()
        {
            return _appContext.Categorias_Directivos;
        }

        Categorias_Directivos IRepositorio_Categoria_Directivos.GetCategorias_Directivos(int idCategoria_Directivos){
             return _appContext.Categorias_Directivos.FirstOrDefault(
                cat => cat.Id == idCategoria_Directivos
            );
        }    

        Categorias_Directivos IRepositorio_Categoria_Directivos.updateCategoria_Directivos(Categorias_Directivos Categorias_Directivos){
          var Categoria_Encontrada = _appContext.Categorias_Directivos.FirstOrDefault(
                cat => cat.Id == Categorias_Directivos.Id
            ); 

            if(Categorias_Directivos != null){
                Categoria_Encontrada.Descripcion = Categorias_Directivos.Descripcion;
                _appContext.SaveChanges();
            }
            return Categoria_Encontrada;
        }
    }   
}
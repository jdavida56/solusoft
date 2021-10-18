using System.Collections.Generic;
using Dominio;
namespace Persistencia
{
    public interface IRepositorio_Categoria_Directivos
    {
        IEnumerable<Categorias_Directivos> GetAllCategoria_Directivos();
        Categorias_Directivos addCategoria_Directivos (Categorias_Directivos Categorias_Directivos );
        Categorias_Directivos updateCategoria_Directivos(Categorias_Directivos Categorias_Directivos);
        void DeleteCategoria_Directivos(int idCategoria_Directivos);
        Categorias_Directivos GetCategorias_Directivos(int idCategoria_Directivos);
       
    }
}
using System.Collections.Generic;
using Dominio;
namespace Persistencia
{
    public interface IRepositorio_Empleados
    {
        IEnumerable<Empleados> GetAllEmpleados();
        
        Empleados addEmpleados (Empleados Empleados);
        
        Empleados updateEmpleados(Empleados Empleados);
        
        void DeleteEmpleados(int idEmpleados);
        
        Empleados GetEmpleados(int idEmpleados);
       //hola
       
    }
}
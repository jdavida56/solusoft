using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{

    public class Repositorio_Empleados : IRepositorio_Empleados
    {

        private readonly ApplicationDbContext _appContext;

            public Repositorio_Empleados(ApplicationDbContext appContext){
                _appContext = appContext;
            }   
        Empleados IRepositorio_Empleados.addEmpleados(Empleados Empleados)
        {
             var new_Empleados = _appContext.Empleados.Add(Empleados);
                _appContext.SaveChanges();
                return new_Empleados.Entity;
        }

        void IRepositorio_Empleados.DeleteEmpleados(int idEmpleados)
        {
            var EmpleadoEncontrado = _appContext.Empleados.FirstOrDefault(
                emp => emp.Id == idEmpleados
            );

            if (EmpleadoEncontrado == null)
            return;
            _appContext.Remove(EmpleadoEncontrado);
            _appContext.SaveChanges();
            
        }

        IEnumerable<Empleados> IRepositorio_Empleados.GetAllEmpleados()
        {
            return _appContext.Empleados;
        }

        Empleados IRepositorio_Empleados.GetEmpleados(int idEmpleados){
             return _appContext.Empleados.FirstOrDefault(
                emp => emp.Id == idEmpleados 
            );
        }    

        Empleados IRepositorio_Empleados.updateEmpleados(Empleados Empleados){
          var EmpleadoEncontrado = _appContext.Empleados.FirstOrDefault(
                emp => emp.Id == Empleados.Id
            ); 

            if(EmpleadoEncontrado != null){
                EmpleadoEncontrado.Sueldo = Empleados.Sueldo;
                EmpleadoEncontrado.Id_Empleado_Jefe = Empleados.Id_Empleado_Jefe;
                EmpleadoEncontrado.Id_Cargo = Empleados.Id_Cargo;
                EmpleadoEncontrado.Id_Persona = Empleados.Id_Persona;
                EmpleadoEncontrado.Id_Categoria_Dr = Empleados.Id_Categoria_Dr;
                EmpleadoEncontrado.Id_Empresa = Empleados.Id_Empresa;
                _appContext.SaveChanges();
            }
            return EmpleadoEncontrado;
        }
    }   
}
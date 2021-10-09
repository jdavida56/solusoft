using System.Collections;
using System.Security.AccessControl;
using System;
using Dominio;
using Persistencia;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace 

{
    public class ListModel : PageModel
    {
        private readonly IRepositorio_Empleados _repo;

        public IEnumerable<Empleados> Empleado { get; set; }

        public ListModel(IRepositorio_Empleados Repositorio_Empleados)
        {
            _repo = Repositorio_Empleados;
        }
        public void OnGet()
        {
            Empleado = _repo.GetAllEmpleados();
        }
    }
}
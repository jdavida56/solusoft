using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorio_Personas _repo;

        public Personas Persona {get; set;}
        
        public CreateModel(IRepositorio_Personas repo)
        {
            _repo = repo;
        }
        
        public void OnGet()        
        {            
        }

        public void OnPost(Personas persona)
        {
            _repo.addPersonas(persona);
        }
    }
}

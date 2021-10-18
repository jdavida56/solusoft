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
    public class UpdateModel : PageModel
    {
        private readonly IRepositorio_Personas _repo;
    
        public Personas Persona {get; set;}
        public UpdateModel(IRepositorio_Personas repoPersona){
            _repo = repoPersona;
        }
        public void OnGet(int Id) 
        {
            Persona = _repo.DetailPersona(Id); 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            if (Persona.Id > 0)
            {
                Persona = _repo.updatePersonas(Persona);
            }            
            return RedirectToPage("./List");
        }
    }
}



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
  public class DetailsModel : PageModel
    {
        private readonly IRepositorio_Personas repositorioPersonas;

        public Personas personas { get; set; }

        public DetailsModel(IRepositorio_Personas repositorio_Personas){
            this.repositorioPersonas = repositorio_Personas;
        }
        public IActionResult OnGet(int Id)
        {
            personas = repositorioPersonas.DetailPersona(Id);
            if(personas==null){
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}

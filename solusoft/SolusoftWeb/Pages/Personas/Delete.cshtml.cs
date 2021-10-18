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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorio_Personas _repo;
        public Personas Personas{ get; set;}
        public DeleteModel(IRepositorio_Personas repo)
        {
            _repo = repo;
        }
        public void OnGet(int Id)
        {
            Personas = _repo.DetailPersona(Id);
        }

        public void OnPost(int Id)
        {
            _repo.DeletePersonas(Id);
        }

    }
}

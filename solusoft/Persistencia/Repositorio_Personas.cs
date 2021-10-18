using System.Collections.Generic;
using Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{

    public class Repositorio_Personas : IRepositorio_Personas
    {

        private readonly ApplicationDbContext _appContext;

        public Repositorio_Personas(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        Personas IRepositorio_Personas.addPersonas(Personas Personas)
        {
            var new_Personas = _appContext.Personas.Add(Personas);
            _appContext.SaveChanges();
            return new_Personas.Entity;
        }

        void IRepositorio_Personas.DeletePersonas(int idPersonas)
        {
            var PersonaEncontrada = _appContext.Personas.FirstOrDefault(
                p => p.Id == idPersonas
            );

            if (PersonaEncontrada == null)
                return;
            _appContext.Remove(PersonaEncontrada);
            _appContext.SaveChanges();

        }
        public Personas DetailPersona(int id_persona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == id_persona);
        }

        public IEnumerable<Personas> ListPersona()
        {
            return _appContext.Personas.AsNoTracking();
        }

        /*Personas IRepositorio_Personas.GetPersonas(int idPersonas)
        {
            return _appContext.Personas.FirstOrDefault(
               p => p.Id == idPersonas
           );
        }*/

        Personas IRepositorio_Personas.updatePersonas(Personas Personas)
        {
            var PersonaEncontrada = _appContext.Personas.FirstOrDefault(
                  p => p.Id == Personas.Id
              );

            if (PersonaEncontrada != null)
            {
                PersonaEncontrada.Nombres = Personas.Nombres;
                PersonaEncontrada.Identidad = Personas.Identidad;
                PersonaEncontrada.Sexo = Personas.Sexo;
                PersonaEncontrada.Edad = Personas.Edad;
                _appContext.SaveChanges();
            }
            return PersonaEncontrada;
        }
    }
}
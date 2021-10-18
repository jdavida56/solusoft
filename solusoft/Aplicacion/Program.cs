using System;
using Dominio;
using Persistencia;
using System.Threading;

namespace Aplicacion
{
    class Program
    {
        private static IRepositorio_Personas _repoPersona = new  Repositorio_Personas(new Persistencia.ApplicationDbContext());
        private static IRepositorio_Empresas _repoEmpresa = new  Repositorio_Empresas(new Persistencia.ApplicationDbContext());
        private static IRepositorio_Clientes _repoClientes = new  Repositorio_Clientes(new Persistencia.ApplicationDbContext());
        private static IRepositorio_Empleados _repoEmpleados = new  Repositorio_Empleados(new Persistencia.ApplicationDbContext());
        private static IRepositorio_Cargos _repoCargos = new  Repositorio_Cargos(new Persistencia.ApplicationDbContext());
        private static IRepositorio_Categoria_Directivos _repoDirectivos = new  Repositorio_Categoria_Directivos(new Persistencia.ApplicationDbContext());
        static void Main(string[] args)
        {            
            //*********Personas**********************
            //addPersonas();
            //Console.WriteLine("Persona Ingresada");
            //updatePersonas();
            //Console.WriteLine("Persona Actualizada");
            //deletePersonas();
            //Console.WriteLine("Persona Eliminada");
            //getAllPersonas();
            //getPersonas(3);

            //*********Empresas**********************
            //addEmpresas();
            //Console.WriteLine("Empresa Ingresada");
            //updateEmpresas();
            //Console.WriteLine("Empresa Actualizada");
            //DeleteEmpresas();
            //Console.WriteLine("Empresa Eliminada");
            //getAllEmpresas();
            //getEmpresas(1);

            //*********Clientes**********************
            //addClientes();
            //Console.WriteLine("Cliente Ingresado");
            //updateClientes();
            //Console.WriteLine("Cliente Actualizado");
            //deleteClientes();
            //Console.WriteLine("Cliente Eliminado");
            //getAllClientes();
            //getClientes(1);

            //*********Empleados**********************
            //addEmpleados();
            //Console.WriteLine("Empleado Ingresado");
            //updateEmpleados();
            //Console.WriteLine("Empleado Actualizado");
            //deleteEmpleados();
            //Console.WriteLine("Empleado Eliminado");
            //getAllEmpleados();
            //getEmpleados(1);

            //*********Cargos**********************
            //addCargos();
            //Console.WriteLine("Cargo Ingresado");
            //updateCargos();
            //Console.WriteLine("Cargo Actualizado");
            //deleteCargos();
            //Console.WriteLine("Cargo Eliminado");
            //getAllCargos();
            //getCargos(1);

            //*********Directivos**********************
            //addCategoria_Directivos();
            //Console.WriteLine("Categoria Ingresada");
            //updateCategorias_Directivos();
            //Console.WriteLine("Categoria Actualizada");
            //deleteCategoria_Directivos();
            //Console.WriteLine("Categoria Eliminada");
            //getAllCategoria_Directivos();
            //getCategoria_Directivos(1);

        }
         // *************************** CRUD PERSONA *************************************
         //**************************** INSERTAR PERSONA**********************************
        public static void addPersonas(){
            var Personas = new Personas{
                Nombres ="Andres",
                Identidad = "9354815415",
                Sexo = "Masculino",

                Edad = 35
            };
            _repoPersona.addPersonas(Personas);
        }
        //**************************** ACTUALIZAR PERSONA**********************************
        public static void updatePersonas(){
            var Personas = new Personas{
                Id = 1,
                Nombres ="",
                Identidad = "",
                Sexo = "",
                Edad = 35
            };
        _repoPersona.updatePersonas(Personas);
        } 
        //**************************** ELIMINAR PERSONA********************************** 
        public static void deletePersonas(int IdPersonas){
            _repoPersona.DeletePersonas(IdPersonas);
        }
        //**************************** LISTAR UNA PERSONAS*******************************

        public static void getPersonas(int IdPersonas){
            var Personas = _repoPersona.GetPersonas(IdPersonas);
            if (Personas==null)
            return;
            Console.WriteLine(Personas.Nombres);
        }
        //**************************** LISTAR TODAS LAS PERSONAS*************************
        public static void getAllPersonas(){
            var Personas = _repoPersona.GetAllPersonas();
            foreach(var Persona in Personas){
                Console.Write(Persona.Nombres);
            }
        }
        // *************************** CRUD EMPRESAS *************************************
        //**************************** INSERTAR EMPRESA*************************
        public static void addEmpresas(){
            var Empresas = new Empresas{
                Nit ="8900000000-6",
                Razon_Social = "Indigo",
                Direccion = "Guabinal",
                Telefono = "350418888",
                Ciudad = "Manizalez"
            };
            _repoEmpresa.addEmpresas(Empresas);
        }
        //**************************** ACTUALIZAR EMPRESA**********************************
        public static void updateEmpresas(){
            var Empresas = new Empresas{
                Id = 1,
                Nit ="890785680-9",
                Razon_Social = "Soluciones Integrales en Software solusoft",
                Direccion = "Aqua Pwer Center Local 548",
                Telefono = "350418850",
                Ciudad = "Ibague"
            };
        _repoEmpresa.updateEmpresas(Empresas);
        }
        //**************************** ELIMINAR EMPRESA**********************************
        private static void DeleteEmpresas(){
            _repoEmpresa.DeleteEmpresas(2);
        }
        //**************************** LISTAR UNA EMPRESA*******************************
        public static void getEmpresas(int IdEmpresas){
            var Empresas = _repoEmpresa.GetEmpresas(IdEmpresas);
            if (Empresas==null)
            return;
            Console.WriteLine(Empresas.Razon_Social);
        }
        //**************************** LISTAR TODAS LAS EMPRESAS*************************
        public static void getAllEmpresas(){
            var Empresas = _repoEmpresa.GetAllEmpresas();
            foreach(var Empresa in Empresas){
                Console.Write(Empresa.Razon_Social);
            }
        }
        // *************************** CRUD CLIENTES *************************************
         //**************************** INSERTAR CLIENTE**********************************
        public static void addClientes(){
            var Clientes = new Clientes{
                Telefono ="3153336651",
                Id_Persona= 12,
                Id_Empresa = 1,
            };
            _repoClientes.addClientes(Clientes);
        }
        //**************************** ACTUALIZAR CLIENTES**********************************
        public static void updateClientes(){
            var Clientes = new Clientes{
                Id = 1,
                Telefono ="3153336951",
                Id_Persona= 12,
                Id_Empresa = 2,
            };
        _repoClientes.updateClientes(Clientes);
        }
        //**************************** ELIMINAR CLIENTE**********************************
        private static void deleteClientes(){
            _repoClientes.DeleteClientes(3);
        }
        //**************************** LISTAR UN CLIENTE*******************************
        public static void getClientes(int IdClientes){
            var Clientes = _repoClientes.GetClientes(IdClientes);
            if (Clientes==null)
            return;
            Console.WriteLine(Clientes.Telefono);
        }
        //**************************** LISTAR TODAS LOS CLIENTES*************************
        public static void getAllClientes(){
            var Clientes = _repoClientes.GetAllClientes();
            foreach(var Cliente in Clientes){
                Console.Write(Cliente.Id);
            }
        }

        // *************************** CRUD EMPLEADOS *************************************
         //**************************** INSERTAR EMPLEADO**********************************
        public static void addEmpleados(){
            var Empleados = new Empleados{
                Sueldo =0,
                Id_Empleado_Jefe= 2,
                Id_Cargo = 2,
                Id_Persona = 12,
                Id_Categoria_Dr = 2,
                Id_Empresa = 1,
            };
            _repoEmpleados.addEmpleados(Empleados);
        }
        //**************************** ACTUALIZAR EMPLEADOS**********************************
        public static void updateEmpleados(){
            var Empleados = new Empleados{
                Id = 1,
                Sueldo =0,
                Id_Empleado_Jefe= 1,
                Id_Cargo = 1,
                Id_Persona = 12,
                Id_Categoria_Dr = 1,
                Id_Empresa = 1,
            };
        _repoEmpleados.updateEmpleados(Empleados);
        }
        //**************************** ELIMINAR EMPLEADO**********************************
        public static void deleteEmpleados(){
          _repoEmpleados.DeleteEmpleados(1);
        }
        //**************************** LISTAR UN EMPLEADO*******************************
        public static void getEmpleados(int IdEmpleados){
            var Empleados = _repoEmpleados.GetEmpleados(IdEmpleados);
            if (Empleados==null)
            return;
            Console.WriteLine(Empleados.Sueldo);
        }
        //**************************** LISTAR TODOS LOS EMPLEADOS*************************
        public static void getAllEmpleados(){
            var Empleados = _repoEmpleados.GetAllEmpleados();
            foreach(var Empleado in Empleados){
                Console.Write(Empleado.Id);
            }
        }
        // *************************** CRUD CARGOS *************************************
         //**************************** INSERTAR CARGO**********************************
        public static void addCargos(){
            var Cargos = new Cargos{
                Nombre = "Diseñador de Interfaces",
                Directivo = true,
            };
            _repoCargos.addCargos(Cargos);
        }
        //**************************** ACTUALIZAR CARGO**********************************
        public static void updateCargos(){
            var Cargos = new Cargos{
                Id = 1,
                Nombre = "Diseñador de Interfaz UI",
                Directivo = true,
            };
        _repoCargos.updateCargos(Cargos);
        }
        //**************************** ELIMINAR CARGO**********************************
        public static void deleteCargos(){
            _repoCargos.DeleteCargos(1);
        }
        //**************************** LISTAR UN CARGO*******************************
        public static void getCargos(int IdCargos){
            var Cargos = _repoCargos.GetCargos(IdCargos);
            if (Cargos==null)
            return;
            Console.WriteLine(Cargos.Nombre);
        }
        //**************************** LISTAR TODOS LOS CARGOS*************************
        public static void getAllCargos(){
            var Cargos = _repoCargos.GetAllCargos();
            foreach(var Cargo in Cargos){
                Console.Write(Cargo.Nombre);
            }
        }
        // *************************** CRUD DIRECTIVOS *************************************
         //**************************** INSERTAR DIRECTIVOS**********************************
        public static void addCategoria_Directivos(){
            var Categorias_Directivos = new Categorias_Directivos{
                Descripcion = "Gerente General",
            };
            _repoDirectivos.addCategoria_Directivos(Categorias_Directivos);
        }
        //**************************** ACTUALIZAR DIRECTIVOS**********************************
        public static void updateCategorias_Directivos(){
            var Categorias_Directivos = new Categorias_Directivos{
                Id = 1,
                Descripcion = "Gerente General",
            };
        _repoDirectivos.updateCategoria_Directivos(Categorias_Directivos);
        }
        //**************************** ELIMINAR DIRECTIVO**********************************
        public static void deleteCategoria_Directivos(){
            _repoDirectivos.DeleteCategoria_Directivos(2);
        }
        //**************************** LISTAR UN DIRECTIVO*******************************
        public static void getCategorias_Directivos(int IdCategoria_Directivos){
            var Categorias_Directivos = _repoDirectivos.GetCategorias_Directivos(IdCategoria_Directivos);
            if (Categorias_Directivos==null)
            return;
            Console.WriteLine(Categorias_Directivos.Descripcion);
        }
        //**************************** LISTAR TODOS LOS DIRECTIVOS*************************
        public static void getAllCategorias_Directivos(){
            var Categorias_Direcgivos = _repoDirectivos.GetAllCategoria_Directivos();
            foreach(var Categorias in Categorias_Direcgivos){
                Console.Write(Categorias.Descripcion);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;
namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            //INICIALIZAR TODO
            ControllerGuia.InicializarGuias();
            ControllerJefeMuseo.InicializarJefes();
            ControllerObraArte.InicializarObras();
            ControllerExposicion.InicializarExposiciones();
            ControllerGaleria.InicializarGalerias();

            //LOGIN Y TODO COMO ANTES

            

            //retornará "jefe", "guia", "incorrecto"
            String tipoUsuario = LoginUsuario();
            if (tipoUsuario == "jefe")
            {
                int opcion = MenuJefes();
                do
                {
                    switch (opcion)
                    {
                        case 1:
                            VerListadoGuias(ControllerGuia.ObtenerGuias());
                            break;
                        case 2:
                            VerListadoObras(ControllerObraArte.ObtenerObras());
                            break;
                        case 3:
                            VerListadoExposiciones(ControllerExposicion.ObtenerExposiciones());
                            break;
                        case 4:
                            VerListadoGalerias(ControllerGaleria.ObtenerGalerias());
                            break;
                        case 5:
                            /*Console.WriteLine("--- AGREGAR GALERÍA ---");
                            //Pedir datos
                            Console.WriteLine("Ingrese ID:");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese nombre:");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Seleccione exposición a agregar");
                            VerListadoExposiciones(listadoExposiciones);
                            //Debería ser un ciclo para agregar más de 1 galería al listado
                            Console.WriteLine("Ingrese ID de exposición:");
                            int exp = int.Parse(Console.ReadLine());
                            List<Exposicion> listaExpoAgregar = new List<Exposicion>();
                            //buscar expo a agregar por id y guardar el objeto en el listado
                            foreach (Exposicion exposicion in listadoExposiciones)
                            {
                                if (exposicion.Id == exp)
                                {
                                    listaExpoAgregar.Add(exposicion);
                                }
                            }
                            Galeria gal = new Galeria(id, nombre, listaExpoAgregar);
                            listadoGalerias.Add(gal);
                            Console.WriteLine("¡GALERIA AGREGADA!");
                            */
                            break;
                        case 6:
                            /*
                            Console.WriteLine("--- EDITAR GALERÍA ---");
                            //Agregar exposición
                            //1- MOSTRAR ID Y NOMBRE DE GALERIA PARA SELECCIONAR
                            //2- MOSTRAR ID Y NOMBRE DE EXPOSICIÓN DE GALERIA ACTUAL Y LAS DISPONIBLES
                            //3- SELECCIONAR EXPOSICIÓN Y AGREGAR A GALERIA
                            foreach (var gale in listadoGalerias)
                            {
                                Console.WriteLine($"ID: {gale.Id} | {gale.Nombre}");
                            }
                            Console.WriteLine("Selecciona galería:");
                            int galeria_seleccionada = int.Parse(Console.ReadLine());
                            //recorrer listado de galerias hasta encontrar galería por ID
                            foreach (var gale in listadoGalerias)
                            {
                                if (gale.Id == galeria_seleccionada)
                                {
                                    //mostrar exposiciones actuales
                                    Console.WriteLine("EXPOSICIONES ACTUALES EN GALERÍA:");
                                    foreach (var expo in gale.ListadoExposiciones)
                                    {
                                        Console.WriteLine($"ID: {expo.Id} | {expo.Nombre}");
                                    }
                                    //mostrar todas las exposiciones
                                    Console.WriteLine("TODAS LAS EXPOSICIONES:");
                                    foreach (var expo in listadoExposiciones)
                                    {
                                        Console.WriteLine($"ID: {expo.Id} | {expo.Nombre}");
                                    }
                                    Console.WriteLine("Selecciona exposición a agregar");
                                    int expo_IdSeleccionada = int.Parse(Console.ReadLine());
                                    //buscar el objeto
                                    Exposicion expoBuscada = BuscarExposicion(expo_IdSeleccionada, listadoExposiciones);
                                    if (expoBuscada != null)
                                    {
                                        bool existeExpo = false;
                                        //Verificar si exposición existe en galería
                                        foreach (var expo in gale.ListadoExposiciones)
                                        {
                                            if (expo.Id == expoBuscada.Id)
                                            {
                                                Console.WriteLine("Ya existe la exposición en esta galería");
                                                existeExpo = true;
                                                break;
                                            }
                                        }
                                        //si no se encuentra la exposición, agregar a la galería
                                        if (!existeExpo)
                                        {
                                            gale.ListadoExposiciones.Add(expoBuscada);
                                            Console.WriteLine("Exposición Agregada");
                                        }
                                    }

                                }
                            }
                            */
                            break;
                        case 0:
                            Console.WriteLine("Saliendo de la aplicación...");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;

                    }
                    opcion = MenuJefes();
                } while (opcion >= 0 && opcion <= 6);
                Console.ReadLine();
            }
            else if (tipoUsuario == "guia")
            {
                int opcion = MenuGuia();
                do
                {
                    switch (opcion)
                    {
                        case 1:
                            VerListadoGalerias(ControllerGaleria.ObtenerGalerias());
                            break;
                        case 0:
                            Console.WriteLine("Saliendo de la aplicación...");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                    }
                    opcion = MenuGuia();
                } while (opcion >= 0 && opcion <= 1);
                Console.ReadLine();
            }
            else { Console.WriteLine("Usuario o contraseña incorrectos. Inténtelo de nuevo."); }
        }

        static void VerListadoGuias(List<Guia> listadoGuias)
        {
            Console.WriteLine("--- LISTADO DE GUÍAS ---");
            foreach (var guia in listadoGuias)
            {
                Console.WriteLine($"Usuario: {guia.Usuario}");
                Console.WriteLine($"Nombre: {guia.Nombre} {guia.Apellido}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        static String LoginUsuario()
        {

            //------------------- INICIO DE SESIÓN -------------------//
            Console.WriteLine("Ingrese su usuario: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña: ");
            string contrasena = Console.ReadLine();

            foreach (JefeMuseo jefe in ControllerJefeMuseo.ObtenerJefesMuseo())
            {
                if (jefe.Usuario == usuario && jefe.Password == contrasena)
                {
                    return "jefe";
                }
            }

            foreach (Guia guia in ControllerGuia.ObtenerGuias())
            {
                if (guia.Usuario == usuario && guia.Password == contrasena)
                {
                    return "guia";
                }
            }
            return "incorrecto";
        }
        static int MenuJefes()
        {
            Console.WriteLine("-- Menú Jefe de Museo --:");
            Console.WriteLine("[1] Ver listado de Guías");
            Console.WriteLine("[2] Ver listado de Obras de arte");
            Console.WriteLine("[3] Ver listado de Exposiciones");
            Console.WriteLine("[4] Ver listado de Galerías");
            Console.WriteLine("[5] Agregar Galería");
            Console.WriteLine("[6] Editar Galería (Agregar exposición, verificar primero que no existe ya en la galería actual)");
            Console.WriteLine("[0] Salir");
            Console.WriteLine("Selecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        static int MenuGuia()
        {
            Console.WriteLine("-- Menú Guía");
            Console.WriteLine("[1] Ver listado de Galerías");
            Console.WriteLine("[0] Salir");
            Console.WriteLine("Selecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        static void VerListadoObras(List<ObraArte> listadoObras)
        {
            Console.WriteLine("--- LISTADO DE OBRAS DE ARTE ---");
            foreach (var obra in listadoObras)
            {
                Console.WriteLine($"--- ID: {obra.Id} | {obra.Nombre}");
                Console.WriteLine($"--- Autor: {obra.Autor} | Fecha: {obra.Fecha}");
                Console.WriteLine($"--- Descripción: {obra.Descripcion}");
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");
        }

        static void VerListadoExposiciones(List<Exposicion> listadoExposiciones)
        {
            Console.WriteLine("--- LISTADO DE EXPOSICIONES ---");
            foreach (var expo in listadoExposiciones)
            {
                Console.WriteLine($"-- ID: {expo.Id} | Nombre: {expo.Nombre}");
                Console.WriteLine($"-- Fechas: {expo.FechaInicio} - {expo.FechaTermino}");
                VerListadoObras(expo.ListadoObras);
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");

        }

        static void VerListadoGalerias(List<Galeria> listadoGalerias)
        {
            Console.WriteLine("--- LISTADO DE GALERÍAS ---");
            foreach (var galeria in listadoGalerias)
            {
                Console.WriteLine($"- ID: {galeria.Id} | {galeria.Nombre}");
                VerListadoExposiciones(galeria.ListadoExposiciones);
                Console.WriteLine();
            }
        }

        

    }
}

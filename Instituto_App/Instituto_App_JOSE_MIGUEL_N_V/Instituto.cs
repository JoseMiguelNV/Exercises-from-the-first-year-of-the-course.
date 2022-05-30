using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto_App_JOSE_MIGUEL_N_V
{
    class Instituto
    {
        tListaCursos listaCursos = new tListaCursos();
        tListaAlumnos listaAlumnos = new tListaAlumnos();
        tListaProfesores listaProfesores = new tListaProfesores();


        //MENÚ PRINCIPAL  
        public void Run()
        {
            int option;
            do
            {
                UserInterface.Menu();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        //CERRAR PROGRAMA
                        UserInterface.LanzarGestionDespedida();                      
                        break;
                    case 1:
                        //GESTIÓN DE CURSOS
                        LanzarGestionDeCursos();
                        break;
                    case 2:
                        //GESTIÓN DE ALUMNOS
                        LanzarGestionDeAlumnos();
                        break;
                    case 3:
                        //GESTIÓN DE PROFESORES
                        LanzarGestionDeProfesores();
                        break;
                    default:
                        if (option > 4 || option < 0)
                        {
                            Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                            Console.ReadLine();
                        }
                        break;
                }

            }
            while (option != 0);
        }


        //MENÚ GESTION DE CURSOS
        public void LanzarGestionDeCursos()
        {
            int option;
            do
            {
                UserInterface.GestionCursos();
                option = Convert.ToInt32(Console.ReadLine());
                {
                    switch (option)
                    {
                        case 0:
                            //VOLVER AL MENÚ PRINCIPAL
                            UserInterface.Menu(); 
                            break;
                        case 1:
                            //OPCIÓN AÑADIR CURSO  
                            UserInterface.MostrarInterfazAddCurso();                                                                                                                                     
                            listaCursos.AddCurso();
                            break;
                        case 2:
                            //OPCIÓN ELIMINAR CURSO
                            UserInterface.MostrarInterfazEliminarCurso();  
                            listaCursos.EliminarCurso();
                            break;
                        case 3:
                            //OPCIÓN IMPRIMIR CURSO
                            UserInterface.MostrarInterfazImprimirCursos();
                            listaCursos.imprimirCursos();  
                            break;
                        case 4:
                            //OPCIÓN IMPRIMIR LISTA DE ALUMNOS POR CURSO
                            UserInterface.MostrarInterfazImprimirAlumnosPorCurso();  
                            listaAlumnos.ImprimirAlumnosPorCurso();
                            break;
                        default:
                            if (option > 4 || option < 0)
                            {
                                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
            }
            while (option != 0);
        }


        //MENÚ GESTIÓN DE ALUMNOS
        public void LanzarGestionDeAlumnos()
        {
            int option;
            do
            {
                UserInterface.GestionAlumnos();
                option = Convert.ToInt32(Console.ReadLine());
                {
                    switch (option)
                    {
                        case 0:
                            //VOLVER AL MENÚ PRINCIPAL
                            UserInterface.Menu();   
                            break;
                        case 1:
                            //OPCIÓN AÑADIR ALUMNO
                            UserInterface.MostrarInterfazAddAlumno();   
                            listaAlumnos.AddAlumno(listaCursos);
                            break;
                        case 2:
                            //OPCIÓN ELIMINAR ALUMNO
                            UserInterface.MostrarEliminarAlumno();   
                            listaAlumnos.EliminarAlumno();
                            break;
                        case 3:
                            //OPCIÓN IMPRIMIR ALUMNOS
                            UserInterface.MostrarImprimirListaAlumnos();   
                            listaAlumnos.ImprimirListaAlumnos();
                            break;
                        case 4:
                            //OPCIÓN MOSTRAR ALUMNOS ORDENADOS ALFABÉTICAMENTE
                            UserInterface.MostrarInterfazOrdenarAlumnos();   
                            listaAlumnos.ordenarAlumnos();
                            break;
                        case 5:
                            //OPCIÓN MOSTRAR ALUMNO POR NOMBRE
                            UserInterface.MostrarInterfazNombreAlumno();   
                            listaAlumnos.ImprimirNombreAlumno();
                            break;
                        case 6:
                            //OPCIÓN MOSTRAR ALUMNOS PERTENECIENTES A UN CURSO
                            UserInterface.MostrarInterfazImprimirCursoAlumnos();   
                            listaAlumnos.ImprimirAlumnosPorCurso();
                            break;
                        case 7:
                            //OPCIÓN AÑADIR NOTAS A ALUMNOS
                            UserInterface.MostrarInterfazAddNotaAlumno();   
                            listaAlumnos.AddNotaAlumno();
                            break;
                        case 8:
                            //OPCIÓN ELIMINAR NOTAS DE ALUMNOS
                            UserInterface.MostrarInterfazEliminarNotaAlumno();   
                            listaAlumnos.EliminarNotaAlumno();
                            break;
                        case 9:
                            //OPCIÓN MOSTRAR ALUMNOS APROBADOS POR NOTA MEDIA
                            UserInterface.MostrarInterfazImprimirNotaMediaAprobados();   
                            listaAlumnos.ImprimirNotaMediaAprobados();
                            break;
                        case 10:
                            //OPCIÓN MOSTRAR ALUMNOS SUSPENDIDOS POR NOTA MEDIA
                            UserInterface.MostrarInterfazImprimirNotaMediaSuspensos();   
                            listaAlumnos.ImprimirNotaMediaSuspensos();
                            break;
                        default:
                            if (option > 10 || option < 0)
                            {
                                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
            }
            while (option != 0);
        }


        //MENÚ GESTIÓN DE PROFESORES
        public void LanzarGestionDeProfesores()
        {
            int option;
            do
            {
                UserInterface.GestionProfesores();
                option = Convert.ToInt32(Console.ReadLine());
                {
                    switch (option)
                    {
                        case 0:
                            //VOLVER AL MENÚ PRINCIPAL
                            UserInterface.Menu();  
                            break;
                        case 1:
                            //OPCIÓN AÑADIR PROFESOR
                            UserInterface.MostrarInterfazAddProfesor();    
                            listaProfesores.AddAProfesor();
                            break;
                        case 2:
                            //OPCIÓN ELIMINAR PROFESOR
                            UserInterface.MostrarInterfazEliminarProfesor();    
                            listaProfesores.EliminarProfesor();
                            break;
                        case 3:
                            //OPCIÓN MOSTRAR LISTA DE PROFESORES
                            UserInterface.MostrarinterfazImprimirProfesores();    
                            listaProfesores.ImprimirListaProfesores();
                            break;
                        case 4:
                            //OPCIÓN ORDENAR ALFABÉTICAMENTE LA LISTA DE PROFESORES
                            UserInterface.MostrarInterfazOrdenarProfesores();    
                            listaProfesores.ordenarListaProfesores();
                            break;
                        case 5:
                            //OPCIÓN MOSTRAR PROFESORES POR NOMBRE
                            UserInterface.MostrarInterfazImprimirDatosProfesores();    
                            listaProfesores.ImprimirNombreProfesor();
                            break;
                        case 6:
                            //OPCIÓN AÑADIR ASIGNATURAS A PROFESORES
                            UserInterface.MostrarInterfazAddAsignaturaProfesor();    
                            listaProfesores.AñadirAsignatura();
                            break;
                        case 7:
                            //OPCIÓN ELIMINAR ASIGNATURAS A PROFESORES
                            UserInterface.MostrarinterfazEliminarAsignaturaProfesor();    
                            listaProfesores.EliminarAsignatura();
                            break;
                        case 8:
                            //OPCIÓN MOSTRAR PROFESORES POR ASIGNATRURA
                            UserInterface.MostrarInterfazImprimirProfesorConAsignatura();    
                            listaProfesores.MostrarProfesoresPorAsignatura();
                            break;
                        default:
                            if (option > 8 || option < 0)
                            {
                                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
            }
            while (option != 0);
        }
    }
}

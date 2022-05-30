using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto_App_JOSE_MIGUEL_N_V
{
    class UserInterface
    {
        //MENÚ PRINCIPAL
        public static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("---------- I.E.S. MARE NOSTRUM ----------");
            Console.WriteLine("-----------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 1) GESTIÓN DE CURSOS ");
            Console.WriteLine(" 2) GESTIÓN DE ALUMNOS");
            Console.WriteLine(" 3) GESTIÓN DE PROFESORES");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 0) SALIR");
            Console.ResetColor();
            Console.WriteLine();
        }


        //-------------------------------- C U R S O S --------------------------------//


        //MENÚ GESTIÓN DE CURSOS
        public static void GestionCursos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("----------------- GESTIÓN DE CURSOS -------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 1) AÑADIR CURSO");
            Console.WriteLine(" 2) ELIMINAR CURSO");
            Console.WriteLine(" 3) MOSTRAR TODOS LOS CURSOS");
            Console.WriteLine(" 4) MOSTRAR TODOS LOS ALUMNOS PERTENECIENTES A UN CURSO");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 0) MENÚ PRINCIPAL");
            Console.ResetColor();
            Console.WriteLine();
        }

        //AÑADIR CURSO
        public static void MostrarInterfazAddCurso()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("---------------- AÑADIR CURSO -------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //ELIMINAR CURSO
        public static void MostrarInterfazEliminarCurso()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------- ELIMINAR CURSO ------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //IMPRIMIR CURSOS
        public static void MostrarInterfazImprimirCursos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------- IMPRIMIR CURSOS -----------------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //OBTENER TODOS LOS ALUMNOS PERTENECIENTES A UN CURSO
        public static void MostrarInterfazImprimirCursoAlumnos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------- IMPRIMIR CURSO POR ALUMNOS ------------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }


        //------------------------------- A L U M N O S -------------------------------//


        //MENÚ GESTIÓN DE ALUMNOS
        public static void GestionAlumnos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("----------------- GESTIÓN DE ALUMNOS -----------------");
            Console.WriteLine("------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------------------- ALUMNOS -----------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 1) INTRODUCIR ALUMNO");
            Console.WriteLine(" 2) ELIMINAR ALUMNO");
            Console.WriteLine(" 3) MOSTRAR LISTA DE ALUMNOS");
            Console.WriteLine(" 4) ORDENAR ALFABÉTICAMENTE A LOS ALUMNOS");
            Console.WriteLine(" 5) MOSTRAR DATOS DEL ALUMNO(POR NOMBRE)");
            Console.WriteLine(" 6) MOSTRAR ALUMNOS PERTENECIENTES A UN CURSO");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 0) MENÚ PRINCIPAL");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------- NOTAS ------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 7) AÑADIR NOTAS A UN ALUMNO");
            Console.WriteLine(" 8) ELIMINAR NOTAS DE UN ALUMNO");
            Console.WriteLine(" 9) MOSTRAR ALUMNOS CON NOTA MEDIA IGUAL O MAYOR A 5.");
            Console.WriteLine(" 10) MOSTRAR ALUMNOS CON NOTA MEDIA MENOR QUE 5.");
            Console.ResetColor();
            Console.WriteLine();
        }

        //AÑADIR ALUMNO
        public static void MostrarInterfazAddAlumno()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("---------------- AÑADIR ALUMNO ------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("< RECUERDE QUE ANTES DE CREAR UN NUEVO ALUMNO, ");
            Console.WriteLine("DEBE EXISTIR EL CURSO QUE SE LE VA A ASIGNAR > ");
            Console.ResetColor();
            Console.WriteLine();
        }

        //ELIMINAR ALUMNO
        public static void MostrarEliminarAlumno()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------- ELIMINAR ALUMNO -----------------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //IMPRIMIR LISTA DE ALUMNOS
        public static void MostrarImprimirListaAlumnos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------- IMPRIMIR ALUMNOS ----------------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //ORDENAR ALFABÉTICAMENTE LA LISTA DE LOS ALUMNOS
        public static void MostrarInterfazOrdenarAlumnos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------- ORDENAR ALFABÉTICAMENTE ALUMNOS --------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //OBTENER ALUMNOS POR MEDIO DE SU NOMBRE
        public static void MostrarInterfazNombreAlumno()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------- IMPRIMIR POR NOMBRE DEL ALUMNO ---------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //OBTENER TODOS LOS ALUMNOS PERTENECIENTES A UN CURSO
        public static void MostrarInterfazImprimirAlumnosPorCurso()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------- IMPRIMIR ALUMNOS DE UN CURSO ----------");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }


        //--------------------------------- N O T A S ---------------------------------//


        //AÑADIR NOTAS A UN ALUMNO
        public static void MostrarInterfazAddNotaAlumno()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("------------ AÑADIR NOTAS A UN ALUMNO ----------------");
            Console.WriteLine("------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //ELIMINAR NOTAS DE UN ALUMNO
        public static void MostrarInterfazEliminarNotaAlumno()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("----------- ELIMINAR NOTAS DE UN ALUMNO --------------");
            Console.WriteLine("------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //OBTENER LOS ALUMNOS CON NOTA MEDIA MAYOR O IGUAL A 5
        public static void MostrarInterfazImprimirNotaMediaAprobados()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("------ IMPRIMIR NOTA MEDIA DE ALUMNOS APROBADOS -------");
            Console.WriteLine("-------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //OBTENER LOS ALUMNOS CON NOTA MEDIA MENOR QUE 5
        public static void MostrarInterfazImprimirNotaMediaSuspensos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("----- IMPRIMIR NOTA MEDIA DE ALUMNOS SUSPENDIDOS -----");
            Console.WriteLine("------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }


        //----------------------------- P R O F E S O R E S -----------------------------//


        //MENÚ GESTIÓN DE PROFESORES
        public static void GestionProfesores()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--------------- GESTIÓN DE PROFESORES ----------------");
            Console.WriteLine("------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--------------------- PROFESORES ---------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 1) INTRODUCIR PROFESOR");
            Console.WriteLine(" 2) ELIMINAR PROFESOR");
            Console.WriteLine(" 3) MOSTRAR LISTA DE PROFESORES");
            Console.WriteLine(" 4) ORDENAR ALFABÉTICAMENTE A LOS PROFESORES");
            Console.WriteLine(" 5) MOSTRAR DATOS DE LOS PROFESORES");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 0) MENÚ PRINCIPAL");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------- ASIGNATURAS ---------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 6) AÑADIR ASIGNATURA A UN PROFESOR");
            Console.WriteLine(" 7) ELIMINAR ASIGNATURA A UN PROFESOR");
            Console.WriteLine(" 8) MOSTRAR PROFESORES QUE IMPARTAN UNA ASIGNATURA");
            Console.ResetColor();
        }

        //AÑADIR PROFESOR
        public static void MostrarInterfazAddProfesor()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------- AÑADIR PROFESOR ------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //ELIMINAR PROFESOR
        public static void MostrarInterfazEliminarProfesor()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("---------------- ELIMINAR PROFESOR -----------------");
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //OBTENER LISTA DE PROFESORES
        public static void MostrarinterfazImprimirProfesores()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--------------- IMPRIMIR PROFESORES ----------------");
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //ORDENAR ALFABÉTICAMENTE LA LISTA DE PROFESORES
        public static void MostrarInterfazOrdenarProfesores()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------- ORDENAR LISTA DE PROFESORES ------------");
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //OBTENER PROFESORES POR MEDIO DE SU NOMBRE
        public static void MostrarInterfazImprimirDatosProfesores()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("---------- MOSTRAR DATOS DE LOS PROFESORES ----------");
            Console.WriteLine("-----------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }


        //------------------------- A S I G N A T U R A S ----------------------------//


        //AÑADIR ASIGNATURA A UN PROFESOR
        public static void MostrarInterfazAddAsignaturaProfesor()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------- AÑADIR ASIGNATURA A PROFESOR -----------");
            Console.WriteLine("---------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //ELIMIAR ASIGNATURA A UN PROFESOR
        public static void MostrarinterfazEliminarAsignaturaProfesor()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("--------- ELIMINAR ASIGNATURA A PROFESOR ----------");
            Console.WriteLine("---------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }

        //OBTENER PROFESORES QUE IMPARTEN UNA ASIGNATURA
        public static void MostrarInterfazImprimirProfesorConAsignatura()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("-------- IMPRIMIR PROFESORES POR ASIGNATURA --------");
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }


        //-------------------- F I N A L I Z A R     P R O G R A M A --------------------//


        //CERRAR PROGRAMA
        public static void LanzarGestionDespedida()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------- C E R R A N D O   E L   P R O G R A M A -----------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("GRACIAS POR TODO JUAN FRAN, ESPERO QUE CONSIGAS TODOS TUS PROPÓSITOS... HASTA PRONTO!!!");
            Console.ResetColor();
        }
    }
}


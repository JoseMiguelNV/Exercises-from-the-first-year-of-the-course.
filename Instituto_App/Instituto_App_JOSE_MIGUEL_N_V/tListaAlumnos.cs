using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto_App_JOSE_MIGUEL_N_V
{
    class tListaAlumnos
    {
        List<tAlumno> ListaAlumnos;

        //CONSTRUCTOR ENCARGADO DE INICIALIZAR LA LISTA DE LOS ALUMNOS
        public tListaAlumnos()
        {
            ListaAlumnos = new List<tAlumno>();
        }

        //MÉTODO PARA AÑADIR ALUMNOS GUARDANDO TODOS SUS DATOS EN UNA LISTA.
        public void AddAlumno(tListaCursos ListaCursos)
        {
            tAlumno alumno = new tAlumno();
            Console.Write("Nombre: ");
            alumno.Setnombre(Console.ReadLine());
            Console.Write("DNI: ");
            alumno.SetDNI(Console.ReadLine());
            Console.Write("Teléfono: ");
            alumno.SetTelefono(Console.ReadLine());
            string codigo = ListaCursos.ValidarCurso();
            alumno.SetCodigo_curso(codigo);
            ListaAlumnos.Add(alumno);
        }

        //MÉTODO PARA ELIMINAR ALUMNOS POR SU NOMBRE
        public void EliminarAlumno()
        {
            Console.Write("Introduce el nombre del alumno que deseas eliminar: ");
            string nombre = Console.ReadLine();
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                if (nombre == ListaAlumnos[i].Getnombre())
                {
                    ListaAlumnos.Remove(ListaAlumnos[i]);
                    Console.WriteLine();
                    Console.WriteLine("Alumno eliminado correctamente...");
                    Console.ReadLine();
                }
            }
        }

        //MÉTODO PARA MOSTRAR LA LISTA DE ALUMNOS
        public void ImprimirListaAlumnos()
        {
            Console.Clear();
            int contador = 1;
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Alumno número {0}:", contador);
                Console.ResetColor();
                ListaAlumnos[i].InformacionAlumno();
                Console.WriteLine();
                contador++;
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        //MÉTODO PARA ORDENAR ALUMNOS POR ORDEN ALFABÉTICO
        public void ordenarAlumnos()
        {
            for (int i = 0; i < ListaAlumnos.Count - 1; i++)
            {
                for (int j = i + 1; j < ListaAlumnos.Count; j++)
                {
                    tAlumno aux;
                    string alumno1 = ListaAlumnos[i].Getnombre();
                    string alumno2 = ListaAlumnos[j].Getnombre();
                    if (alumno1.CompareTo(alumno2) == 1)
                    {
                        aux = ListaAlumnos[i];
                        ListaAlumnos[i] = ListaAlumnos[j];
                        ListaAlumnos[j] = aux;
                    }
                }
            }

            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                ListaAlumnos[i].InformacionAlumno();
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        //MÉTODO PARA IMPRIMIR UN ALUMNO ULITIZANDO SU NOMBRE
        public void ImprimirNombreAlumno()
        {
            Console.Write("Introduce el nombre del alumno que deseas obtener de la lista: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                if (nombre == ListaAlumnos[i].Getnombre())
                {
                    ListaAlumnos[i].InformacionAlumno();
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        //MÉTODO PARA MOSTRAR TODOS LOS ALUMNOS PERTENECIENTES A UN CURSO
        public void ImprimirAlumnosPorCurso()
        {
            Console.Write("Introduce el Código para obtener los Alumnos del curso: ");
            string Codigo_curso = Console.ReadLine();
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                if (Codigo_curso == ListaAlumnos[i].GetCodigo_curso())
                {
                    ListaAlumnos[i].InformacionAlumno();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }


        //--------------------------- M É T O D O S   P A R A   L A S   N O T A S -------------------------------//


        //MÉTODO PARA AÑADIR NOTAS A LOS ALUMNOS
        public void AddNotaAlumno()
        {
            Console.Write("Introduce Alumno: ");
            string nombre = Console.ReadLine();
            int contador = 1;          
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (nombre == ListaAlumnos[i].Getnombre())
                    {                      
                        Console.Write("{0}º Trimestre: ", contador);
                        double nota = double.Parse(Console.ReadLine());
                        ListaAlumnos[i].Setnotas(nota);
                        contador++;                     
                    }
                }
            }
        }

        //MÉTODO PARA ELIMINAR NOTAS DE UN ALUMNO 
        public void EliminarNotaAlumno()
        {
            Console.Write("Introduce Alumno: ");
            string nombre = Console.ReadLine();
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                if (nombre == ListaAlumnos[i].Getnombre())
                {
                    ListaAlumnos[i].QuitarNotaAlumno();
                }
            }
            Console.ReadLine();
        }

        //MÉTODO PARA IMPRIMIR LOS ALUMNOS CON NOTA MEDIA APROBADA(MAYOR O IGUAL A 5)
        public void ImprimirNotaMediaAprobados()
        {
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                ListaAlumnos[i].GetNotaMediaAprobados();
            }
            Console.ReadLine();
        }

        //MÉTODO PARA IMPRIMIR LOS ALUMNOS CON NOTA MEDIA SUSPENDIDA(MENOR O IGUAL A 5)
        public void ImprimirNotaMediaSuspensos()
        {
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                ListaAlumnos[i].GetNotaMediaSuspendidos();
            }
            Console.ReadLine();
        }
    }
}

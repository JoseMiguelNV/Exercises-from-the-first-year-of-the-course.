using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto_App_JOSE_MIGUEL_N_V
{
    class tListaProfesores
    {
        List<tProfesor> ListaProfesores;

        //CONSTRUCTOR ENCARGADO DE INICIALIZAR LA LISTA DE PROFESORES
        public tListaProfesores()
        {
            ListaProfesores = new List<tProfesor>();
        }

        //MÉTODO PARA AÑADIR PROFESORES GUARDANDO TODOS SUS DATOS EN UNA LISTA.
        public void AddAProfesor()
        {
            tProfesor profesor = new tProfesor();
            Console.Write("Nombre: ");
            profesor.Setnombre(Console.ReadLine());
            Console.Write("DNI: ");
            profesor.SetDNI(Console.ReadLine());
            Console.Write("Teléfono: ");
            profesor.SetTelefono(Console.ReadLine());
            Console.Write("Codigo del Curso: ");     
            profesor.SetCodigo_curso(Console.ReadLine());   //NO VALÍDO EL CODIGO DEL CURSO PARA LOS PROFESORES COMO SI HE HECHON PARA LOS ALUMNOS, PORQUE ÉSTOS PUEDEN O NO SER TUTORES DE UN CURSO SEGÚN EXPLICA LA PRÁCTICA
            ListaProfesores.Add(profesor);
        }

        //MÉTODO PARA ELIMINAR PROFESORES POR SU NOMBRE
        public void EliminarProfesor()
        {
            Console.Write("Introduce el nombre del Profesor que deseas eliminar: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < ListaProfesores.Count; i++)
            {
                if (nombre == ListaProfesores[i].Getnombre())
                {
                    ListaProfesores.Remove(ListaProfesores[i]);
                    Console.WriteLine("Profesor eliminado correctamente...");
                }
            }
            Console.ReadLine();
        }

        //MÉTODO PARA MOSTRAR LA LISTA DE PROFESORES
        public void ImprimirListaProfesores()
        {
            Console.Clear();
            int contador = 1;
            for (int i = 0; i < ListaProfesores.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Profesor número {0}:", contador);
                Console.ResetColor();
                ListaProfesores[i].InformacionProfesor();
                Console.WriteLine();
                contador++;
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        //MÉTODO PARA ORDENAR PROFESORES POR ORDEN ALFABÉTICO
        public void ordenarListaProfesores()
        {
            for (int i = 0; i < ListaProfesores.Count - 1; i++)
            {
                for (int j = i + 1; j < ListaProfesores.Count; j++)
                {
                    tProfesor aux;
                    string profesor1 = ListaProfesores[i].Getnombre();
                    string profesor2 = ListaProfesores[j].Getnombre();
                    if (profesor1.CompareTo(profesor2) > 0)
                    {
                        aux = ListaProfesores[i];
                        ListaProfesores[i] = ListaProfesores[j];
                        ListaProfesores[j] = aux;
                    }
                }
            }
            for (int i = 0; i < ListaProfesores.Count; i++)
            {
                ListaProfesores[i].InformacionProfesor();
            }
            Console.ReadLine();
        }

        //MÉTODO PARA MOSTRAR DATOS DE PROFESORES ULITIZANDO SU NOMBRE
        public void ImprimirNombreProfesor()
        {
            Console.Write("Introduce el nombre del Profesor que deseas obtener de la lista: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < ListaProfesores.Count; i++)
            {
                if (nombre == ListaProfesores[i].Getnombre())
                {
                    ListaProfesores[i].InformacionProfesor();
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }


        //-------------------- M É T O D O S   P A R A   L A S   A S I G N A T U R A S --------------------//


        //MÉTODO PARA AÑADIR ASIGNATURAS A LOS PROFESORES
        public void AñadirAsignatura()
        {
            Console.Write("Introduce Profesor: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce Asignatura: ");
            string asignatura = Console.ReadLine();
            for (int i = 0; i < ListaProfesores.Count; i++)
            {
                if (nombre == ListaProfesores[i].Getnombre())
                {
                    ListaProfesores[i].SetAsignatura(asignatura);
                }              
            }
            Console.ReadLine();
        }

        //METODO PARA ELIMINAR ASIGNATURAS DEL PROFESOR
        public void EliminarAsignatura()
        {
            Console.Write("Introduce Profesor: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce Asignatura: ");
            string asignatura = Console.ReadLine();
            for (int i = 0; i < ListaProfesores.Count; i++)
            {
                if (nombre == ListaProfesores[i].Getnombre())
                {
                    ListaProfesores[i].QuitarAsignaturaProfesor(asignatura);
                }
            }
            Console.ReadLine();

        }

        //MÉTODO PARA MOSTRAR LOS PROFESORES QUE IMPARTEN UNA ASIGNATURA
        public void MostrarProfesoresPorAsignatura()
        {
            Console.Write("Introduce la Asignatura para obtener los Profesores que la imparten: ");
            string asignatura = Console.ReadLine();
            for (int i = 0; i < ListaProfesores.Count; i++)
            {
                if (ListaProfesores[i].GetAsignatura() == null)
                {
                    continue;
                }
                List<string> asignaturas = ListaProfesores[i].GetAsignatura();
                for (int j = 0; j < asignaturas.Count; j++)
                {
                    if (asignatura == asignaturas[j])
                    {
                        ListaProfesores[i].InformacionProfesor();
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}


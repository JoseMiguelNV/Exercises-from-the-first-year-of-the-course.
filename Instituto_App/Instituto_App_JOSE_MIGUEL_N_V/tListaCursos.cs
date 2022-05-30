using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto_App_JOSE_MIGUEL_N_V
{
    class tListaCursos
    {
        private List<tCurso> ListaCursos;

        //CONSTRUCTOR ENCARGADO DE INICIALIZAR LA LISTA DE LOS CURSOS
        public tListaCursos()
        {
            ListaCursos = new List<tCurso>();
        }

        //MÉTODO PARA AÑADIR UN CURSO
        public void AddCurso()
        {
            tCurso curso = new tCurso();
            Console.Write("Introduce Curso: ");
            curso.SetNombre(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Introduce Código: ");
            curso.SetCodigo(Console.ReadLine());
            ListaCursos.Add(curso);
        }

        //MÉTODO PARA ELIMINAR UN CURSO POR SU CÓDIGO
        public void EliminarCurso()
        {
            Console.Write("Introduce el Código del Curso que desea eliminar: ");
            string codigo = Console.ReadLine();
            for (int i = 0; i < ListaCursos.Count; i++)
            {
                if (codigo == ListaCursos[i].GetCodigo())
                {
                    ListaCursos.Remove(ListaCursos[i]);
                    Console.WriteLine();
                    Console.WriteLine("Curso eliminado correctamente...");
                    break;
                }
            }
            Console.ReadLine();
        }

        //MÉTODO PARA MOSTRAR TODOS LOS CURSOS
        public void imprimirCursos()
        {
            Console.Clear();
            int contador = 1;
            for (int i = 0; i < ListaCursos.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Curso número {0}:", contador);
                Console.ResetColor();
                ListaCursos[i].InformacionCurso();
                Console.WriteLine();
                contador++;
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        //MÉTODO PARA VALIDAR LOS CURSOS
        public string ValidarCurso()
        {
            string codigo;
            do
            {
                Console.Write("Código del curso: ");               
                codigo = Console.ReadLine();
                Console.WriteLine();
                if (EstaEnLaLista(codigo) != true)
                {
                    Console.WriteLine("El código no existe, introduzca un código válido.");
                }
            } while (!EstaEnLaLista(codigo));
            return codigo;
        }

        //MÉTODO AUXILIAR PARA VALIDAR LOS CURSOS
        public bool EstaEnLaLista(string curso)
        {
            for (int i = 0; i < ListaCursos.Count; i++)
            {
                if (curso == ListaCursos[i].GetCodigo())
                {
                    return true;
                }
            }
            return false;
        }
    }
}

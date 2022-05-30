using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto_App_JOSE_MIGUEL_N_V
{
    class tProfesor
    {
        private string nombre;
        private string DNI;
        private string telefono;
        private string codigo_curso;
        private List<string> ListaAsignaturas;


        //---------------------------- C O N S T R U C T O R E S ------------------------------//


        public tProfesor()
        {
            ListaAsignaturas = new List<string>();
        }


        //------------------------- G E T T E R S   Y   S E T T E R S -------------------------//


        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string Getnombre()
        {
            return nombre;
        }

        public void SetDNI(string DNI)
        {
            this.DNI = DNI;
        }

        public string GetDNI()
        {
            return DNI;
        }

        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public string GetTelefono()
        {
            return telefono;
        }

        public void SetCodigo_curso(string codigo_curso)
        {
            this.codigo_curso = codigo_curso;
        }

        public string GetCodigo_curso()
        {
            return codigo_curso;
        }

        //MÉTODO UTILIZADO PARA AÑADIR ASIGNATURAS A LOS PROFESORES
        public void SetAsignatura(string asignatura)
        {
            ListaAsignaturas.Add(asignatura);
            Console.WriteLine();
            Console.WriteLine("Asignatura añadida correctamente.");
        }

        //MÉTODO PARA DEVOLVER LA ASIGNATURA DEL PROFESOR
        public List<string> GetAsignatura()
        {
            return ListaAsignaturas;
        }


        //------------------------------------ M E T O D O S ----------------------------------------//


        //METODO QUE REUNE INFORMACIÓN DEL PROFESOR PARA TRABAJAR DESDE DISTINTAS PARTES DEL PROGRAMA
        public void InformacionProfesor()
        {
            Console.WriteLine();
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("DNI: {0}", DNI);
            Console.WriteLine("Teléfono: {0}", telefono);
            Console.WriteLine("Tutor del Curso con código: {0}", codigo_curso);
            int contador = 1;
            if (ListaAsignaturas.Count > 0)
            {
                for (int i = 0; i < ListaAsignaturas.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Asignatura {0}: {1}", contador, ListaAsignaturas[i]);
                    Console.ResetColor();
                    contador++;
                }
            }
            else if (ListaAsignaturas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El Profesor no dispone de Asignaturas asignadas.");
                Console.ResetColor();
            }
        }

        //MÉTODO PARA ELIMINAR ASIGNATURAS DE UN PROFESOR
        public void QuitarAsignaturaProfesor(string asignatura)
        {
            for(int i = 0; i < ListaAsignaturas.Count; i++)
            {
                if(asignatura == ListaAsignaturas[i])
                {
                    ListaAsignaturas.Remove(asignatura);
                    Console.WriteLine();
                    Console.WriteLine("Asignatura eliminada correctamente.");
                }               
            }
        }
    }
}

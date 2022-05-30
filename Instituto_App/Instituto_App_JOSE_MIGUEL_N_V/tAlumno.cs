using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto_App_JOSE_MIGUEL_N_V
{
    class tAlumno
    {
        private string nombre;
        private string DNI;
        private string telefono;
        private string codigo_curso;
        private List<double> Notas;
        private List<double> ListaNotaMedia;


        //---------------------------- C O N S T R U C T O R E S ------------------------------//


        public tAlumno()
        {
            Notas = new List<double>();
            ListaNotaMedia = new List<double>();
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

        //MÉTODO UTILIZADO PARA AÑADIR NOTAS A LOS ALUMNOS
        public void Setnotas(double nota)
        {   
            Notas.Add(nota);          
        }

        //METODO REALIZADO EN CLASE CON EL PROFESOR PARA OBTENER OBTENER LA NOTA, NO SE USA EN LA APP PERO LO DEJO PARA QUE CADA ATRIBUTO TENGA SU SET Y SU GET
        public double Getnotas(int posicion)
        {
            return Notas[posicion];
        }


        //------------------------------------ M E T O D O S ----------------------------------------//


        //METODO QUE REUNE INFORMACIÓN DEL ALUMNO PARA TRABAJAR DESDE DISTINTAS PARTES DEL PROGRAMA
        public void InformacionAlumno()
        {
            Console.WriteLine();
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("DNI: {0}", DNI);
            Console.WriteLine("Teléfono: {0}", telefono);
            Console.WriteLine("Codigo del Curso: {0}", codigo_curso);
            int contador = 1;             
            if (Notas.Count > 0)
            {
                for (int i = 0; i < Notas.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Notas {0}º Trimestre: {1}", contador, Notas[i]);
                    Console.ResetColor();
                    contador++;
                }
            }
            else if (Notas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El Alumno no dispone de notas.");
                Console.ResetColor();
            }              
        }

        //MÉTODO PARA ELIMINAR NOTAS DE UN ALUMNO
        public void QuitarNotaAlumno()
        {
            if (Notas.Count > 0)
            {
                for (int i = Notas.Count - 1; Notas.Count >= 1; i--)
                {
                    Notas.Remove(Notas[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Notas eliminadas correctamente.");
            }
        }

        //MÉTODO PARA OBTENER LA NOTA MEDIA MAYOR O IGUAL A 5
        public void GetNotaMediaAprobados()
        {
            double media = 0;
            for (int i = 0; i < Notas.Count; i++)
            {
                media += Notas[i];
                ListaNotaMedia.Add(media);
            }
            if((media / 3) >= 5)
            {
                InformacionAlumno();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nota media: {0}", media / 3);
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        //MÉTODO PARA OBTENER LA NOTA MEDIA MENOR QUE 5
        public void GetNotaMediaSuspendidos()
        {
            double media = 0;
            for (int i = 0; i < Notas.Count; i++)
            {
                media += Notas[i];
                ListaNotaMedia.Add(media);
            }
            if ((media / 3) < 5 && (media / 3) > 0)
            {
                InformacionAlumno();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nota media: {0}", media / 3);
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}

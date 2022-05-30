using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto_App_JOSE_MIGUEL_N_V
{
    class tCurso
    {
        private string nombre;
        private string codigo;


        //------------------------ G E T T E R S   Y   S E T T E R S -------------------------//


        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string GetCodigo()
        {
            return codigo;
        }


        //------------------------------------ M E T O D O S ----------------------------------------//

       
        //MÉTODO PARA MANEJAR INFORMACIÓN DE LOS CURSOS
        public void InformacionCurso()
        {
            Console.WriteLine();
            Console.WriteLine("Curso : {0}", nombre);
            Console.WriteLine("Código : {0}", codigo);
            Console.WriteLine();
        }
    }
}

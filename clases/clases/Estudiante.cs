using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    class Estudiante
    {
        public Estudiante() { 
            this.asignaturas = new List<string>();
            this.AsigArray = new string[0];
        }

        private List<string> asignaturas;

        public List<string> Asignaturas
        {
            get { return asignaturas; }
            set { asignaturas = value; }
        }

        private string[] asigArray;

        public string[] AsigArray
        {
            get { return asigArray; }
            set { asigArray = value; }
        }

        public void EntrarAsignaturas()
        {
            Console.WriteLine();
            Console.WriteLine("Entre el nombre de la Asignatura:");
            string asig = Console.ReadLine();

            //adding it to the list
            this.Asignaturas.Add(asig);

            //adding it to the array
            string[] asigs = this.AsigArray;
            Array.Resize(ref asigs, this.AsigArray.Length + 1);
            asigs[asigs.Length - 1] = asig;
            this.AsigArray = asigs;
           
            //ask for next asignatura
            ConsoleKeyInfo cki;
            Console.WriteLine("Otra Asignatura? (S/N):");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.S)
            {
                this.EntrarAsignaturas();
            }
        }

        internal void ListarAsignaturas()
        {
            Console.WriteLine("Usando List of String:");
            foreach (string asig in this.Asignaturas)
            {
                Console.WriteLine(asig);
            }

            Console.WriteLine("Usando Array of String:");
            foreach (string asig in this.AsigArray)
            {
                Console.WriteLine(asig);
            }
            Console.ReadKey();
        }
    }
}

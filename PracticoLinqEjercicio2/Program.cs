using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticoLinqEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>()
            {
                new Alumno("Eva",20,6),
                new Alumno("Ana",22,7),
                new Alumno("Rosa",22,12),
                new Alumno("Ricardo",20,3),
                new Alumno("Felipe",30,6),
                new Alumno("Pepe",32,2),
                new Alumno("Laia",30,9),
                new Alumno("Stephanie",32,1),
            };

            var alumnosAprobadosMayoresTreinta = alumnos.Where(alumno => alumno.Edad > 30 && alumno.Nota >= 6);

            //Forzando la ejecucion con el operador, FirsOrDefault
            var alumnoPorExcelencia = alumnos.Where(alumno => alumno.Nota == alumnos.Max(x => x.Nota)).FirstOrDefault();

            //Como queremos obtener 1 solo registro, podemos usar el operador FirstOrDefault, filtrando con una expresion lambda, sin usar el operador Where

            var alumnoPorExcelenciaSegundaManera = alumnos.FirstOrDefault(alumno => alumno.Nota == alumnos.Max(x => x.Nota));


        }
    }
}

using System;
using System.Linq;

namespace PracticoLinqEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var libros = Libro.Libros();

            Libro.Libros().OrderByDescending(libro => libro.CantidadDeVentas).Take(3);
            Libro.Libros().OrderBy(libro => libro.CantidadDeVentas).Take(3);

            var ventasDeAutores = libros.Join(Autor.Autores(),
                                                libro => libro.IdAutor,
                                                autor => autor.IdAutor,
                                                (libro, autor) => new { NombreAutor = autor.Nombre, CantidadDeVentas = libro.CantidadDeVentas }).ToList();

            var autorConMasVentas = ventasDeAutores.OrderByDescending(ventas => ventas.CantidadDeVentas).FirstOrDefault();

            Console.WriteLine(autorConMasVentas.NombreAutor);

        }
    }
}

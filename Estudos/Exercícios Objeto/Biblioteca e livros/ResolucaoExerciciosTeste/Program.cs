using System;
using System.Globalization;
using System.Runtime.CompilerServices;


namespace ResolucaoExerciciosTeste
{

    class Program
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AddBook(new Livro("Dom Casmurro", "Machado de Assis", 256));
            biblioteca.AddBook(new Livro("1984", "George Orwell", 328));

            biblioteca.ListarLivros();

            Console.WriteLine($"Total de livros na biblioteca: {biblioteca.TotalDeLivros()}");


        }
    }
}
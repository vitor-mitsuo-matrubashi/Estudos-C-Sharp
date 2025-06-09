using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoExerciciosTeste
{

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public Livro(string Titulo, string Autor, int Paginas) 
        {

            if (Paginas <= 0)
            {
                throw new ArgumentException("Número de páginas inválido!");
            }

            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Paginas = Paginas;
        }

        public Livro() 
        {
        }

        public void Descricao() 
        {
            Console.WriteLine($"O livro {Titulo} do autor {Autor} tem {Paginas} páginas.");
        }




    }



}
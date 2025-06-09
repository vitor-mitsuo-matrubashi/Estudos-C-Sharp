using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoExerciciosTeste
{
    internal class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void AddBook(Livro livro)
        {
            livros.Add(livro);
        }

        public void ListarLivros() 
        {
            foreach(var livro in livros)
            {
                livro.Descricao();
            }
        }

        public int TotalDeLivros()
        {
            return livros.Count;
        }

    }
}

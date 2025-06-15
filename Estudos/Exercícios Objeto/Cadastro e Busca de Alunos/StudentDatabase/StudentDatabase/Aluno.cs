using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double NotaFinal;


        public Aluno(string Nome, int Idade, double NotaFinal) 
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.NotaFinal = NotaFinal;
        }

        public Aluno()
        {
        }

        public void Descricao() 
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, NotaFinal: {NotaFinal}");
            
        }

    }
}

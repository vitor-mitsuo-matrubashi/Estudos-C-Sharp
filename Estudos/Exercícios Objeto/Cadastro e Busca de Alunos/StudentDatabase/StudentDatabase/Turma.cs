using System;
using System.Collections.Generic;

namespace StudentDatabase
{
    public class Turma
    {
        private List<Aluno> alunos = new List<Aluno>();

        public void AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public void ListarAlunos()
        {
            foreach (var aluno in alunos)
            {
                aluno.Descricao();
            }
        }

        public void BuscarAlunoPorNome(string nome)
        {
            var alunoEncontrado = alunos.Find(a => a.Nome.ToLower() == nome.ToLower());

            if (alunoEncontrado != null)
            {
                Console.WriteLine("Aluno encontrado:");
                alunoEncontrado.Descricao();
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
    }
}

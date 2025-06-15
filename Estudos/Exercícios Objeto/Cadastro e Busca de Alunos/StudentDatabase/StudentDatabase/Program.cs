using System;
using StudentDatabase;

class Program
{

    static void Main(string[] args)
    {
        Turma turma = new Turma();

        turma.AdicionarAluno(new Aluno("João", 16, 8.5));
        turma.AdicionarAluno(new Aluno("Maria", 17, 9.0));
        turma.AdicionarAluno(new Aluno("Lucas", 15, 7.2));

        Console.WriteLine("=== Alunos cadastrados ===");
        turma.ListarAlunos();
        Console.WriteLine("\nDigite o nome do aluno que deseja buscar:");
        string nomeBusca = Console.ReadLine();

        Console.WriteLine();
        turma.BuscarAlunoPorNome(nomeBusca);

        Console.WriteLine("\nPressione qualquer tecla para sair.");
        Console.ReadKey();

    }
}


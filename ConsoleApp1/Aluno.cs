using System;

namespace ConsoleApp1
{
    internal class Aluno : PessoaFisica
    {
        public string RM = string.Empty;
        public string Curso = string.Empty;

        public void listarAluno()
        {
            listarDados(nome, idade, cpf);
            Console.WriteLine("O portador do RM " + RM + " está matriculado no curso " + Curso);
        }

        public void matriculDisciplina(string rm)
        {
            Console.WriteLine("Aluno " + rm + " matriculado em disciplina!");
        }
    }
}


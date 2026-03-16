using System;

namespace ConsoleApp1
{
    internal class Professor : PessoaFisica
    {
        public string formacao = string.Empty;
        public string cargo = string.Empty;
        public double salario;

        public void listarProfessor()
        {
            listarDados(nome, idade, cpf);
            Console.WriteLine("Formação acadêmica: " + formacao);
            Console.WriteLine("Cargo na instituição: " + cargo);
            Console.WriteLine("Salário: " + salario);
        }

        public void cadastrarDisciplina()
        {
            Console.WriteLine("Disciplina cadastrada com sucesso!");
        }
    }
}

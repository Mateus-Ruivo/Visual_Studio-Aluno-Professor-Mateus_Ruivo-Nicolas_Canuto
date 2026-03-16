using System;

namespace ConsoleApp1
{
    internal class PessoaFisica
    {
        public string nome = string.Empty;
        public int idade;
        public string cpf = string.Empty;

        public void listarDados(string nome, int idade, string cpf)
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("CPF: " + cpf);
        }
    }
}

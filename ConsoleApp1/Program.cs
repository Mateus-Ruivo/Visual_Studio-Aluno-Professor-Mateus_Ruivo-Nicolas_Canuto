
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você é aluno ou professor?");
            string escolaridade = Console.ReadLine();

            if (escolaridade.Equals("professor", StringComparison.OrdinalIgnoreCase))
            {
                Professor prof = new Professor();

                Console.WriteLine("Insira o nome: ");
                prof.nome = Console.ReadLine();

                Console.WriteLine("Insira a idade: ");
                prof.idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o CPF: ");
                prof.cpf = Console.ReadLine();

                Console.WriteLine("Insira a formação acadêmica: ");
                prof.formacao = Console.ReadLine();

                Console.WriteLine("Insira o cargo: ");
                prof.cargo = Console.ReadLine();

                Console.WriteLine("Insira o salário: ");
                prof.salario = Convert.ToDouble(Console.ReadLine());

                int opcao;
                do
                {
                    Console.WriteLine("\n--- MENU PROFESSOR ---");
                    Console.WriteLine("1 - Listar dados");
                    Console.WriteLine("2 - Cadastrar disciplina");
                    Console.WriteLine("0 - Sair");
                    Console.Write("Escolha uma opção: ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            prof.listarProfessor();
                            break;
                        case 2:
                            prof.cadastrarDisciplina();
                            break;
                    }
                } while (opcao != 0);
            }
            else if (escolaridade.Equals("aluno", StringComparison.OrdinalIgnoreCase))
            {
                Aluno aluno = new Aluno();

                Console.WriteLine("Insira o nome: ");
                aluno.nome = Console.ReadLine();

                Console.WriteLine("Insira a idade: ");
                aluno.idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o CPF: ");
                aluno.cpf = Console.ReadLine();

                Console.WriteLine("Insira seu RM: ");
                aluno.RM = Console.ReadLine();

                Console.WriteLine("Insira seu curso: ");
                aluno.Curso = Console.ReadLine();

                int opcao;
                do
                {
                    Console.WriteLine("\n--- MENU ALUNO ---");
                    Console.WriteLine("1 - Listar dados");
                    Console.WriteLine("2 - Matricular disciplina");
                    Console.WriteLine("0 - Sair");
                    Console.Write("Escolha uma opção: ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            aluno.listarAluno();
                            break;
                        case 2:
                            aluno.matriculDisciplina(aluno.RM);
                            break;
                    }
                } while (opcao != 0);
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 3;
        Classes.Pessoa[] pessoas = new Classes.Pessoa[n];

        for (int i = 0; i < pessoas.Length; i++) {
            pessoas[i] = new Classes.Pessoa();
            Console.WriteLine($"Digite o nome da {i + 1}ª pessoa: ");
            pessoas[i].nome = Console.ReadLine()!;
            while (!Validacao.ValidarNome(pessoas[i])){
                Console.WriteLine($"Digite novamente o nome da {i + 1}ª pessoa: ");
                pessoas[i].nome = Console.ReadLine()!;
            }; // Se o nome for inválido, repete até ser válido
            
            Console.WriteLine($"Digite o email da {i + 1}ª pessoa: ");
            pessoas[i].email = Console.ReadLine()!;
            while (!Validacao.ValidarEmail(pessoas[i])){
                Console.WriteLine($"Digite novamente o email da {i + 1}ª pessoa: ");
                pessoas[i].email = Console.ReadLine()!;
            }; // Se o email for inválido, repete até ser válido
            
            Console.WriteLine($"Digite a idade da {i + 1}ª pessoa: ");
            pessoas[i].idade = int.Parse(Console.ReadLine()!);
            while (!Validacao.ValidarIdade(pessoas[i])){
                Console.WriteLine($"Digite novamente a idade da {i + 1}ª pessoa: ");
                pessoas[i].idade = int.Parse(Console.ReadLine()!);
            }; // Se a idade for inválida, repete até ser válido
        }

        Classes.Pessoa[] result = Classes.MaiorMenor(pessoas);
        Classes.Pessoa pessoaMaisNova = result[0];
        Classes.Pessoa pessoaMaisVelha = result[1];

        Console.WriteLine($"\nA pessoa mais nova é {pessoaMaisNova.nome} com {pessoaMaisNova.idade} anos.");
        Console.WriteLine($"A pessoa mais velha é {pessoaMaisVelha.nome} com {pessoaMaisVelha.idade} anos.");
    }
}

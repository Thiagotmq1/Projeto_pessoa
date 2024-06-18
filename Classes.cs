using System.Diagnostics.Contracts;

class Classes
{
    public class Pessoa {
        public string nome;
        public string email;
        public int idade;
    }

    public static Pessoa[] MaiorMenor(Pessoa[] pessoas) {

        int maior = int.MinValue, menor = int.MaxValue;
        Pessoa pessoaMaisNova = null!;
        Pessoa pessoaMaisVelha = null!;

        for (int i = 0; i < pessoas.Length; i++) {
            if (pessoas[i].idade < menor) {
                menor = pessoas[i].idade;
                pessoaMaisNova = pessoas[i];
            }
            if (pessoas[i].idade > maior) {
                maior = pessoas[i].idade;
                pessoaMaisVelha = pessoas[i];
            }
        }

        Pessoa[] result = new Pessoa[2];
        result[0] = pessoaMaisNova; // Menor idade
        result[1] = pessoaMaisVelha; // Maior idade

        return result;
    }
}

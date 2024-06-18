class Validacao
{
    // Valida o nome da pessoa
    public static bool ValidarNome(Classes.Pessoa pessoa)
    {
        // Verifica se o nome é nulo, vazio ou tem menos de dois caracteres
        if (string.IsNullOrWhiteSpace(pessoa.nome) || pessoa.nome.Length < 2)
        {
            Console.WriteLine("Nome inválido: O nome não pode ser vazio ou ter menos de dois caracteres.");
            return false;
        }
        
        // Divide o nome em partes (usando espaço) e verifica se há pelo menos duas partes (nome e sobrenome)
        string[] nomeParts = pessoa.nome.Split(' ');
        if (nomeParts.Length < 2)
        {
            Console.WriteLine("Nome inválido: O nome deve conter pelo menos um sobrenome.");
            return false;
        }

        return true;
    }

    // Valida o email da pessoa
    public static bool ValidarEmail(Classes.Pessoa pessoa)
    {
        // Verifica se o email é nulo, vazio ou não contém '@'
        if (string.IsNullOrWhiteSpace(pessoa.email) || !pessoa.email.Contains("@"))
        {
            Console.WriteLine("Email inválido: O email deve conter '@'.");
            return false;
        }

        // Divide o email em duas partes usando o '@' como separador
        string[] emailParts = pessoa.email.Split('@');
        // Verifica se há exatamente duas partes e se cada parte tem pelo menos três caracteres
        if (emailParts.Length != 2 || emailParts[0].Length < 3 || emailParts[1].Length < 3)
        {
            Console.WriteLine("Email inválido: Deve haver pelo menos três caracteres antes e depois do '@'.");
            return false;
        }

        // Verifica se a parte do domínio (após o '@') contém um ponto e não começa nem termina com um ponto
        if (!emailParts[1].Contains(".") || emailParts[1].StartsWith(".") || emailParts[1].EndsWith("."))
        {
            Console.WriteLine("Email inválido: O domínio deve conter '.' e não deve começar ou terminar com '.'.");
            return false;
        }

        return true;
    }

    // Valida a idade da pessoa
    public static bool ValidarIdade(Classes.Pessoa pessoa)
    {
        // Calcula o ano de nascimento
        int anoAtual = DateTime.Now.Year;
        int anoNascimento = anoAtual - pessoa.idade;

        // Verifica se o ano de nascimento está entre o ano atual e 150 anos atrás
        if (anoNascimento < (anoAtual - 150) || anoNascimento > anoAtual)
        {
            Console.WriteLine("Idade inválida: A pessoa não pode ter mais que 150 anos ou menos que 0 anos.");
            return false;
        }
        return true;
    }
}

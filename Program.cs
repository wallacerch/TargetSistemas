class Program
{
    static void Main(string[] args)
    {
        //SEGUNDA QUESTÃO
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 1;
        while (c < numero)
        {
            c = a + b;
            a = b;
            b = c;
        }

        if (c == numero)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }

        //QUINTA QUESTÃO
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        char[] charArray = palavra.ToCharArray();
        Array.Reverse(charArray);

        string palavraInvertida = new string(charArray);
        Console.WriteLine($"A string invertida é: {palavraInvertida}.");
    }
}
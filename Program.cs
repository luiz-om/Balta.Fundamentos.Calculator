Menu();


static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro Valor");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine($"Segundo Valor");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 + valor2;

    Console.WriteLine($"O resultado da soma é {resultado}");
    // Console.WriteLine($"O resultado da soma é " + (valor1 + valor2));

}

static void Subtracao()
{

    Console.Clear();
    Console.WriteLine($"Primeiro numero");
    float numero1 = float.Parse(Console.ReadLine());

    Console.WriteLine($"Segundo numero");
    float numero2 = float.Parse(Console.ReadLine());


    float resultado = numero1 - numero2;
    Console.WriteLine($"O resultado da soma é {resultado}");
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine($"Primeiro valor");
    float numero1 = float.Parse(Console.ReadLine());

    Console.WriteLine($"Segundo Valor");
    float numero2 = float.Parse(Console.ReadLine());

    float resultado = numero1 / numero2;
    Console.WriteLine($"O resultado da divisão é {resultado}");

}

static void Multiplicao()
{
    Console.Clear();

    Console.WriteLine($"Primeiro Valor");
    float numero1 = float.Parse(Console.ReadLine());

    Console.WriteLine($"Segundo Valor");
    float numero2 = float.Parse(Console.ReadLine());

    float resultato = numero1 * numero2;

    Console.WriteLine($"O resultado da multiplicação é {resultato}");


}

static void Menu()
{
    Console.WriteLine("""
    O que deseja fazer?
    1 - Soma
    2 - Subtracão
    3 - Divisão
    4 - Multiplicação
    5 - Sair
    """);

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Soma();
            break;
        case 2:
            Subtracao();
            break;
        case 3: Divisao(); break;
        case 4: Multiplicao(); break;
        case 5:
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"Opção invalida programa sera fechado.");

            break;

    }
}
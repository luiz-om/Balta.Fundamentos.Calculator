﻿Soma();
Thread.Sleep(2000);
Subtracao();
Thread.Sleep(2000);
Divisao();
Thread.Sleep(2000);
Multiplicao();

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
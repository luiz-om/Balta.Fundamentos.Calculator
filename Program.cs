Console.Clear();

Console.WriteLine("Primeiro Valor");
float valor1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Segundo Valor");
float valor2 = float.Parse(Console.ReadLine());

float resultado = valor1 + valor2;

Console.WriteLine($"O resultado da soma é {resultado}");
Console.WriteLine($"O resultado da soma é " +(valor1+valor2));



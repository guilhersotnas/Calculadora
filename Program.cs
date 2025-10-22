using System;

class Programa
{
    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("-------------------");
        Console.WriteLine("Qual função deseja?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("-------------------");
        Console.Write("Insira o número da função desejada: ");
        int res = int.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Soma()
    {

        Console.Write("Primeiro valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double resultado = v1 + v2;
        Console.WriteLine($"Resultado da soma: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {

        Console.Write("Primeiro valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double resultado = v1 - v2;
        Console.WriteLine($"Resultado da subtração: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {

        Console.Write("Primeiro valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double resultado = v1 / v2;
        Console.WriteLine($"Resultado da divisão: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {

        Console.Write("Primeiro valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double resultado = v1 * v2;
        Console.WriteLine($"Resultado da multiplicação: {resultado}");
        Console.ReadKey();
        Menu();
        // teste alteração
        Console.WriteLine("Teste");
    }
}
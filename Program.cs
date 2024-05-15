using System;
using Microsoft.VisualBasic;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      // var result = Console.WriteLine("Informe a Operação Matemática: (+) (-) (*) (/) ");
      // Soma();
      // Subtract();
      // Multiply();
      // Division();
      Menu();
    }
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("O que deseja fazer? ");
      Console.WriteLine("1- Soma");
      Console.WriteLine("2- Subtração");
      Console.WriteLine("3- Multiplicação");
      Console.WriteLine("4- Divisão");
      Console.WriteLine("5- Sair");

      Console.WriteLine("========");
      Console.WriteLine("Selecione uma opção: ");
      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 1: Soma(); break;
        case 2: Subtract(); break;
        case 3: Multiply(); break;
        case 4: Division(); break;
        case 5: System.Environment.Exit(0); break; // Sair de um aplicação Console.
        default: Menu(); break;
      }

    }

    // Funções
    static void Soma()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());


      Console.WriteLine(" ");

      float result = v1 + v2;
      // Console.WriteLine("O resultado da soma é " + result);
      Console.WriteLine($"O resultado da soma é {result}");
      // Console.WriteLine($"O resultado da soma é {v1 + v2}");
      // Console.WriteLine("O resultado da soma é " + (v1 + v2));
    }
    static void Subtract()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.Clear();
      Console.WriteLine("Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");
      float result = v1 - v2;
      Console.WriteLine($"O resultado de subtração é {result}");

      Console.ReadKey();

    }
    static void Multiply()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");
      float result = v1 * v2;

      Console.WriteLine($"O resultado de Multiplicação é {result}");
      Console.ReadKey();
    }
    static void Division()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");
      float result = v1 / v2;

      Console.WriteLine($"O resultado de Divisão é {result}");
      Console.ReadKey();
    }
  }

}



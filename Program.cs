class MinhaCalculadora
{
  static void Main(string[] args)
  {
   Menu();  
  }

  static void Menu()
  {
    Console.WriteLine("================Calculadora================");
    Console.WriteLine("");
    Console.WriteLine("Selecione uma opção!");
    Console.WriteLine("");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Modulo");
    Console.WriteLine("6 - Sair");

    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
      case 1: Soma(); break;
      case 2: Subtracao(); break;
      case 3: Multiplicacao(); break;
      case 4: Divisao(); break;
      case 5: Modulo(); break;
      case 6: System.Environment.Exit(0); break;
      default: Menu(); break;
    }
  }


  static void Soma()
  {
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 + v2;
    Console.WriteLine($"O valor da soma é: {resultado}");
    Console.ReadKey();
    Menu();
  }

  static void Subtracao()
  {
    Console.WriteLine("Primeiro valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey();Console.ReadKey();
    Menu();
  }

  static void Multiplicacao()
  {
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
    Console.ReadKey();
    Menu();
  }

  static void Divisao()
  {
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 / v2;
    Console.WriteLine("O resultado da divisao é: {resultado}");
    Console.ReadKey();
    Menu();

  }

  static void Modulo()
  {
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado= v1 % v2;
    Console.WriteLine($"O resultado do módulo é: {resultado}");
    Console.ReadKey();
    Menu();
  }

}
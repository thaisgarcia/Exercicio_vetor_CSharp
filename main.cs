using System;

class MainClass
{
  public static void Main(string[]args)
  { 
    //Declaração de variáveis
    double[] prova1 = new double[10];
    double[] prova2 = new double[10];
    double[] media = new double[10];
    int i;
    
    Console.WriteLine("Prova 1:");
    for (i = 0; i < 10; i++) //Laço de repetição da 1ª prova 
    {
      Console.Write("Digite a nota do {0}ª aluno: ", i+1); 
      prova1[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine();

    Console.WriteLine("Prova 2:"); 
    for (i = 0; i < 10; i++) //Laço de repetição da 2ª prova
    {
      Console.Write("Digite a nota do {0}º aluno: ", i+1); 
      prova2[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine();

    for (i = 0; i < 10; i++) //Laço de repetição da média
    {
      media[i]=((prova1[i]+prova2[i])/2); //Cálculo da média
      Console.WriteLine("A média do {0}º aluno: {1}", i+1, media[i]);
    }

    Console.ReadKey();
  }
} 
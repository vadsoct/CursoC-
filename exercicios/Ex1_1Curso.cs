using System;
using System.Globalization;

namespace C_
{
    class Ex1Curso
    {
       public static void Ex1Fixacao()
        {
            Console.WriteLine("digite o nome :");

            string np = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa : ");

            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero Entre com o preço de um produto : ");

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                       

            Console.WriteLine("digite o nome a idade e a altura :");
            string [] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            System.Console.WriteLine(np);
            Console.WriteLine("Você digitou o numero de quartos : " + n1);
            Console.WriteLine("Você digitou o produto de valor : " + n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
          
       }


    }
}
using System;
using System.Globalization;

namespace C_
{
    class Ex7_1POO
    {
       public static void Ex1()
           {
               
               
            Ex7_1POOAulaRetangulo R = new Ex7_1POOAulaRetangulo();
                        
            System.Console.WriteLine("Insira as propriedades do retandulo: ");

            System.Console.WriteLine("insira o Altura : ");            
            R.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     

            System.Console.WriteLine("Insira o Largura : ");
            R.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

                                                    
            System.Console.WriteLine("Dados do retangulo: " + R);

            
            System.Console.WriteLine();
            double area = R.Area();
            System.Console.Write("A área do retangulo: " + area.ToString("F2",CultureInfo.InvariantCulture));

            System.Console.WriteLine();
            double perimetro = R.Perimetro();
            System.Console.Write("O perímetro do retangulo: " + perimetro.ToString("F2",CultureInfo.InvariantCulture));
               
            System.Console.WriteLine();
            double diagonal = R.Diagonal();
            System.Console.Write("A diágonal do retangulo: " + diagonal.ToString("F2",CultureInfo.InvariantCulture));
           

       }
    }
}
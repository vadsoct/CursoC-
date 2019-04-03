using System;
using System.Globalization;

namespace C_
{
    class Ex7Curso
    {
       public static void Ex6Sequencial()
        {

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo ;
            
                                   
            Console.WriteLine("Insira os valores de A, B e C em sequencia dividido por espaço: ");
   
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);
      
           
            triangulo = A*C/2;
            circulo = 3.14159 * C * C;
            trapezio = (A+B)/2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            System.Console.WriteLine("Triangulo :" + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Circulo :" + circulo.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Trapézio :" + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Quadrado :" + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Retangulo :" + retangulo.ToString("F3", CultureInfo.InvariantCulture));


       }


    }
}
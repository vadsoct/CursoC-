using System;
using System.Globalization;

namespace C_
{
    class Ex3Curso
    {
       public static void Ex2Sequencial()
        {

            const double pi = 3.14159;
            double raio = 0;
            double area = 0;


            Console.WriteLine("Insira o valor do raio : ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * (Math.Pow(raio,2));              

            System.Console.WriteLine("A area desse cirulo é : " + area.ToString("F4", CultureInfo.InvariantCulture));
       }


    }
}
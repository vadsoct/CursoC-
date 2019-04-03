using System;
using System.Globalization;

namespace C_
{
    class Ex2Curso
    {
       public static void Ex1Sequencial()
        {

            int resul = 0;

            Console.WriteLine("Insira o primeiro valor da soma : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o primeiro valor da soma : ");
            int n2 = int.Parse(Console.ReadLine());

            resul = n1 + n2;              

            System.Console.WriteLine("O resultado da soma é : " + resul);
       }


    }
}
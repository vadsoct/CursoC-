using System;
using System.Globalization;

namespace C_
{
    class Ex4Curso
    {
       public static void Ex3Sequencial()
        {

            
            double A,B,C,D,Diferenca;
            
            Console.WriteLine("Insira o valor do A : ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do B : ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do C : ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do D : ");
            D = int.Parse(Console.ReadLine());

            Diferenca = (A*B-C*D);              

            System.Console.WriteLine("O Valor da diferença é : " + Diferenca);
       }


    }
}
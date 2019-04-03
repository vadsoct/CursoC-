using System;
using System.Globalization;

namespace C_
{
    class Ex6Curso
    {
       public static void Ex5Sequencial()
        {

            int idPecaA = 0;
            int qPecaA = 0;
            double vlrUniA = 0;   
            int idPecaB = 0;
            int qPecaB = 0;
            double vlrUniB = 0;
            double total = 0;
                                   
            Console.WriteLine("Insira o ID da peça A : ");
            idPecaA = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira quantidade de peças tipo A : ");
            qPecaA = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor das peças tipo A : ");
            vlrUniA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                                   
            Console.WriteLine("Insira o ID da peça B : ");
            idPecaB = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira quantidade de peças tipo B : ");
            qPecaB = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor das peças tipo B : ");
            vlrUniB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            total = (qPecaA * vlrUniA) + (qPecaB * vlrUniB);

            System.Console.WriteLine("Os id dos produtos são " + idPecaA + " " + idPecaB + " e o valor a ser pago será de: " + total.ToString("F2",CultureInfo.InvariantCulture));
       }


    }
}
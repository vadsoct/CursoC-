using System;
using System.Globalization;

namespace C_
{
    class Ex2_2Condicional
       {
       public static void Ex1()
        {

            int num = 0;
            string resultado;
            
            Console.WriteLine("Insira um valor para saber se é par ou impar:");
            num = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if ( num % 2 == 0 ){
                resultado = "par";
            }else{
                resultado = "impar";
            }

            System.Console.WriteLine("Esse numero é " + resultado);
       }


    }
}
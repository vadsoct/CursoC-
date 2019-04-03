using System;
using System.Globalization;

namespace C_
{
    class Ex2_1Condicional
       {
       public static void Ex1()
        {

            int num = 0;
            string resultado;
            
            Console.WriteLine("Insira um valor para saber se é positivo ou negativo:");
            num = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if ( num < 0 ){
                resultado = "negativo";
            }else{
                resultado = "positivo";
            }

            System.Console.WriteLine("Esse numero é " + resultado);
       }


    }
}
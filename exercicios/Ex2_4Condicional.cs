using System;
using System.Globalization;

namespace C_
{
    class Ex2_4Condicional
       {
       public static void Ex1()
        {
            Console.WriteLine("Entre com dois valores de inicio e fim do jogo: ");

            string[] valores = Console.ReadLine().Split(' ');
            int comeco = int.Parse(valores[0]);
            int fim = int.Parse(valores[1]);
            int resultado;
                    

            if ( comeco < fim )
            {
                resultado =  fim  - comeco;    
               
            }else{
                resultado = 24 - comeco + fim;
            }

            System.Console.WriteLine("O jogo durou " + resultado + " horas");
       }


    }
}
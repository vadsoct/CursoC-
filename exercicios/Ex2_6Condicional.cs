using System;
using System.Globalization;

namespace C_
{
    class Ex2_6Condicional
       {
       public static void Ex1()
        {
            Console.WriteLine("Digite um valor: ");

            double valor; 
            string intervalo;         
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);            

            if ( valor >= 0 && valor <= 25  )
            {
                intervalo = "Intervalo [0,25]";
                                                 
            }else if (valor > 25 && valor <= 50){

                intervalo = "Intervalo [25,50]";

            }else if (valor > 50 && valor <= 75){

                intervalo = "Intervalo [50,75]";

            }else if (valor > 75 && valor <= 100){

                intervalo = "Intervalo [75,100]";
            
            }else{

                System.Console.WriteLine("Fora de intervalo");
                intervalo = null;

            }

                    
            System.Console.WriteLine(intervalo);
       }


    }
}
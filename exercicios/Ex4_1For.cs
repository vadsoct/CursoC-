using System;
using System.Globalization;

namespace C_
{
    class Ex4_1For
       {
       public static void Ex1()
        {                     
            System.Console.WriteLine("Digite um valor maior igual a 1 e menor que 1000 para saber a sequencia de numeros impares: ");
            double X = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);                  


            if(X >= 1 && X <= 1000){

          

                for (int i = 1; i <= X ; i++)
                {     
                

                    if ( i % 2 != 0 )
                    {
                        System.Console.WriteLine(i);
                                                                        
                    }
                

                }
            }else{    
                        System.Console.WriteLine("fora de intervalo");
            }

        }
    }
}


            
                    

            
                    
            
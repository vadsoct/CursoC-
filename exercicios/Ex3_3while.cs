using System;
using System.Globalization;

namespace C_
{
    class Ex3_3while
       {
       public static void Ex1()
        {                     
            double X = 0;
            int gasolina = 0, alcool = 0, diesel = 0;
            
                while (X != 4)
            {       

                    System.Console.WriteLine("Entre com o codigo do combustivel: \n 1-Alcool \n 2-Gasolina \n 3-Diesel \n 4-Fim");
                    X = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                                        
                    if ( X == 1 )
                    {
                        alcool++;
                                                 
                    }else if (X == 2){

                        gasolina++;

                    }else if (X == 3){

                        diesel++;

                    }else if (X == 4){

                        System.Console.WriteLine("Muito Obrigado !!");
            
                    }else{
                    
                        System.Console.WriteLine("Opção Invalida");

                }
            }
             System.Console.WriteLine("Alcool: " + alcool+ "\n" + "Gasolina: " + gasolina + "\n" + "Diesel: " + diesel );
        }
    }
}


            
                    

            
                    
            